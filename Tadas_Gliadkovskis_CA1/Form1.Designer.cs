namespace Tadas_Gliadkovskis_CA1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.getAllButton = new System.Windows.Forms.Button();
            this.fruitSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getAllButton
            // 
            this.getAllButton.BackColor = System.Drawing.Color.LightGreen;
            this.getAllButton.BackgroundImage = global::Tadas_Gliadkovskis_CA1.Properties.Resources.dots_image1;
            this.getAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.getAllButton.Location = new System.Drawing.Point(113, 41);
            this.getAllButton.Name = "getAllButton";
            this.getAllButton.Size = new System.Drawing.Size(275, 48);
            this.getAllButton.TabIndex = 0;
            this.getAllButton.Text = "Get all Fruits";
            this.getAllButton.UseVisualStyleBackColor = false;
            this.getAllButton.Click += new System.EventHandler(this.getAllButton_Click);
            // 
            // fruitSearchBox
            // 
            this.fruitSearchBox.Location = new System.Drawing.Point(169, 175);
            this.fruitSearchBox.Multiline = true;
            this.fruitSearchBox.Name = "fruitSearchBox";
            this.fruitSearchBox.Size = new System.Drawing.Size(175, 42);
            this.fruitSearchBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Yellow;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchButton.Location = new System.Drawing.Point(169, 246);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(175, 28);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Get Fruit Info";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.getSingleFruit);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(690, 473);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.fruitSearchBox);
            this.Controls.Add(this.getAllButton);
            this.Name = "Form1";
            this.Text = "Fruit Nutritional Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox fruitSearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button getAllButton;

    }
}