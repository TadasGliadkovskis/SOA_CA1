using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Deserializers;

namespace Tadas_Gliadkovskis_CA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://www.fruityvice.com/api/fruit/banana");
            var request = new RestRequest();

            var response = client.Execute(request);

            JsonDeserializer deserializer = new JsonDeserializer();

            MessageBox.Show(response.Content);
        }



        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.BackgroundImage = global::Tadas_Gliadkovskis_CA1.Properties.Resources.dots_image1;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(113, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get all Fruits";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(690, 473);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
