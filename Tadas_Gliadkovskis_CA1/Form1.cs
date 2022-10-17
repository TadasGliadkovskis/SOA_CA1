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

        private void getAllButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://www.fruityvice.com/api/fruit/banana");
            var request = new RestRequest();

            var response = client.Execute(request);

            JsonDeserializer deserializer = new JsonDeserializer();

            MessageBox.Show(response.Content);
        }


    }
}
