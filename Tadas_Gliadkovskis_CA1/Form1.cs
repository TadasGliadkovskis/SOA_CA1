using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Extensions;

namespace Tadas_Gliadkovskis_CA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getSingleFruit(object sender, EventArgs e)
        {
            string url = "https://www.fruityvice.com/api/fruit/";
            string theText = fruitSearchBox.Text;
            url += theText;
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.Execute(request);
            MessageBox.Show(response.Content);
        }

        private void getAllButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://www.fruityvice.com/api/fruit/1");
            var request = new RestRequest();

            var response = client.Execute(request);

            JsonDeserializer deserializer = new JsonDeserializer();

            MessageBox.Show(response.Content);

            var temp = new RootObject();

            temp = deserializer.Deserialize<RootObject>(response);

            var fruits = temp;

//https://stackoverflow.com/questions/37649238/how-to-put-multiple-values-of-list-in-a-messagebox
            foreach (Nutritions n in fruits.nutritions)
            {
                
                MessageBox.Show(n.ToString(), "Fruit Nutritional Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*
            MessageBox.Show(deserializer.Deserialize<Nutritions>(fruits.nutritions), "Carbs", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            
        }
       /* public class Info
        {
            public string genus { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public string family { get; set; }
            public string order { get; set; }
            public Nutrition nutrition { get; set; }
        }
       */
        public class Nutritions
        {
            public string carbohydrates { get; set; }
            public string protein { get; set; }
            public string fat { get; set; }
            public string calories { get; set; }
            public string sugar { get; set; }

            public override string ToString()
            {
                StringBuilder ObjectString = new StringBuilder();
                ObjectString.AppendLine("Carbohydrates: "+this.carbohydrates);
                ObjectString.AppendLine("Protein: "+this.protein);
                ObjectString.AppendLine("Fat: "+this.fat);
                ObjectString.AppendLine("Calories: "+this.calories);
                ObjectString.AppendLine("Sugar: "+this.sugar);
                return ObjectString.ToString();
            }
        }
        public class Info
        {
            
        }

        /*

        public class Fruit
        {
            public List<Info> info { get; set; }
        }*/

        public class RootObject
        {
            public string genus { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public string family { get; set; }
            public string order { get; set; }

            public List<Nutritions> nutritions { get; set; }
        }

        


        /*
         * {
              "genus": "Musa",
              "name": "Banana",
              "id": 1,
              "family": "Musaceae",
              "order": "Zingiberales",
              "nutritions": 
              {
                "carbohydrates": 22,
                "protein": 1,
                "fat": 0.2,
                "calories": 96,
                "sugar": 17.2
              }
            }
         */

    }
}
