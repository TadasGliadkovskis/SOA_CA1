namespace Tadas_Gliadkovskis_CA1
{
    partial class TwitterApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwitterApp));
            this.getRecentTweets = new System.Windows.Forms.Button();
            this.userSearchBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.userLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberOfTweets = new System.Windows.Forms.NumericUpDown();
            this.fruitSearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.publishTweetTextBox = new System.Windows.Forms.TextBox();
            this.tweetTextLabel = new System.Windows.Forms.Label();
            this.publishTweetBtn = new System.Windows.Forms.Button();
            this.characterMax = new System.Windows.Forms.Label();
            this.characterCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTweets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // getRecentTweets
            // 
            this.getRecentTweets.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.getRecentTweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRecentTweets.ForeColor = System.Drawing.Color.Transparent;
            this.getRecentTweets.Location = new System.Drawing.Point(57, 280);
            this.getRecentTweets.Name = "getRecentTweets";
            this.getRecentTweets.Size = new System.Drawing.Size(313, 48);
            this.getRecentTweets.TabIndex = 0;
            this.getRecentTweets.Text = "Retrieve Recent Tweets";
            this.getRecentTweets.UseVisualStyleBackColor = false;
            this.getRecentTweets.Click += new System.EventHandler(this.getRecentTweets_click);
            // 
            // userSearchBox
            // 
            this.userSearchBox.Location = new System.Drawing.Point(195, 142);
            this.userSearchBox.MaxLength = 20;
            this.userSearchBox.Multiline = true;
            this.userSearchBox.Name = "userSearchBox";
            this.userSearchBox.Size = new System.Drawing.Size(175, 42);
            this.userSearchBox.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "twitter_logo.png");
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(53, 152);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(94, 20);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "UserName:";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(53, 224);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(112, 20);
            this.numberLabel.TabIndex = 4;
            this.numberLabel.Text = "No. of Tweets";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfTweets
            // 
            this.numberOfTweets.Location = new System.Drawing.Point(250, 225);
            this.numberOfTweets.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfTweets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfTweets.Name = "numberOfTweets";
            this.numberOfTweets.Size = new System.Drawing.Size(55, 22);
            this.numberOfTweets.TabIndex = 1;
            this.numberOfTweets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fruitSearchBox
            // 
            this.fruitSearchBox.Location = new System.Drawing.Point(195, 142);
            this.fruitSearchBox.Multiline = true;
            this.fruitSearchBox.Name = "fruitSearchBox";
            this.fruitSearchBox.Size = new System.Drawing.Size(175, 42);
            this.fruitSearchBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // publishTweetTextBox
            // 
            this.publishTweetTextBox.Location = new System.Drawing.Point(611, 130);
            this.publishTweetTextBox.MaxLength = 180;
            this.publishTweetTextBox.Multiline = true;
            this.publishTweetTextBox.Name = "publishTweetTextBox";
            this.publishTweetTextBox.Size = new System.Drawing.Size(222, 76);
            this.publishTweetTextBox.TabIndex = 6;
            this.publishTweetTextBox.TextChanged += new System.EventHandler(this.updateCharacterCount);
            // 
            // tweetTextLabel
            // 
            this.tweetTextLabel.AutoSize = true;
            this.tweetTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tweetTextLabel.Location = new System.Drawing.Point(447, 164);
            this.tweetTextLabel.Name = "tweetTextLabel";
            this.tweetTextLabel.Size = new System.Drawing.Size(86, 20);
            this.tweetTextLabel.TabIndex = 7;
            this.tweetTextLabel.Text = "Tweet text";
            // 
            // publishTweetBtn
            // 
            this.publishTweetBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.publishTweetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishTweetBtn.ForeColor = System.Drawing.Color.Transparent;
            this.publishTweetBtn.Location = new System.Drawing.Point(520, 280);
            this.publishTweetBtn.Name = "publishTweetBtn";
            this.publishTweetBtn.Size = new System.Drawing.Size(313, 48);
            this.publishTweetBtn.TabIndex = 8;
            this.publishTweetBtn.Text = "Publish Tweet";
            this.publishTweetBtn.UseVisualStyleBackColor = false;
            this.publishTweetBtn.Click += new System.EventHandler(this.publishTweet);
            // 
            // characterMax
            // 
            this.characterMax.AutoSize = true;
            this.characterMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterMax.Location = new System.Drawing.Point(666, 225);
            this.characterMax.Name = "characterMax";
            this.characterMax.Size = new System.Drawing.Size(46, 20);
            this.characterMax.TabIndex = 9;
            this.characterMax.Text = "/ 180";
            // 
            // characterCount
            // 
            this.characterCount.AutoSize = true;
            this.characterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterCount.Location = new System.Drawing.Point(634, 225);
            this.characterCount.Name = "characterCount";
            this.characterCount.Size = new System.Drawing.Size(36, 20);
            this.characterCount.TabIndex = 10;
            this.characterCount.Text = "180";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Characters Remaining:";
            // 
            // TwitterApp
            // 
            this.ClientSize = new System.Drawing.Size(871, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.characterCount);
            this.Controls.Add(this.characterMax);
            this.Controls.Add(this.publishTweetBtn);
            this.Controls.Add(this.tweetTextLabel);
            this.Controls.Add(this.publishTweetTextBox);
            this.Controls.Add(this.numberOfTweets);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userSearchBox);
            this.Controls.Add(this.getRecentTweets);
            this.Name = "TwitterApp";
            this.Text = "Twitter";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTweets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox userSearchBox;
        private System.Windows.Forms.Button getRecentTweets;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.NumericUpDown numberOfTweets;
        private System.Windows.Forms.TextBox fruitSearchBox;
        private System.Windows.Forms.TextBox publishTweetTextBox;
        private System.Windows.Forms.Label tweetTextLabel;
        private System.Windows.Forms.Button publishTweetBtn;
        private System.Windows.Forms.Label characterMax;
        private System.Windows.Forms.Label characterCount;
        private System.Windows.Forms.Label label2;
    }
}