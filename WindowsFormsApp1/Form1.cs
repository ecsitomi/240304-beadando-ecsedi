using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Xml;
//using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string apiUrl = "https://retoolapi.dev/Kc6xuH/data";
        HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_nev.Clear();
            textBox_fizetes.Clear();
            textBox_pozicio.Clear();
            listBox1.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonValasz = await response.Content.ReadAsStringAsync();
                    //var elemek = System.Text.Json.JsonSerializer.Deserialize<List<Elem>>(jsonValasz);
                    var elemek = Ember.FromJson(jsonValasz);

                    //listBox1.DataSource = elemek;
                    foreach (Ember elem in elemek)
                    {
                        listBox1.Items.Add(elem);
                    }
                    listBox1.DisplayMember = "Kiiratas";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Ember elem = (Ember) listBox1.SelectedItem;
                textBox_id.Text = elem.id.ToString();
                textBox_nev.Text = elem.name.ToString();
                textBox_fizetes.Text = elem.salary.ToString();
                textBox_pozicio.Text = elem.position.ToString();
            }
        }

        private void button_frissit_Click(object sender, EventArgs e)
        {
            Form1_Load(sender,e);
        }

        private async void button_uj_Click(object sender, EventArgs e)
        {
            try
            {

                Ember elem = new Ember();
                elem.name = textBox_nev.Text;
                elem.salary = int.Parse(textBox_fizetes.Text);
                elem.position = textBox_pozicio.Text;

                //itt kértem segítséget a chatgpt-től
                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };

                var json = System.Text.Json.JsonSerializer.Serialize(elem);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(apiUrl, data);
                if (response.IsSuccessStatusCode)
                {
                    Form1_Load(sender, e);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private async void button_modosit_Click(object sender, EventArgs e)
        {
            try
            {

                Ember elem = (Ember)listBox1.SelectedItem;
                elem.id = int.Parse((textBox_id.Text));
                elem.name = textBox_nev.Text;
                elem.salary = int.Parse(textBox_fizetes.Text);
                elem.position = textBox_pozicio.Text;
                var json = JsonConvert.SerializeObject(elem);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(apiUrl + "/" + elem.id, data);
                if (response.IsSuccessStatusCode)
                {
                    Form1_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_torol_Click(object sender, EventArgs e)
        {
            Ember elem = (Ember)listBox1.SelectedItem;
            var response = client.DeleteAsync(apiUrl + "/" + elem.id).Result; 
            if (response.IsSuccessStatusCode)
            {
                Form1_Load(sender, e);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Ember elem = (Ember)listBox1.SelectedItem;
            textBox_id.Text = elem.id.ToString();
            textBox_nev.Text = elem.name.ToString();
            textBox_fizetes.Text = elem.salary.ToString();
            textBox_pozicio.Text = elem.position.ToString();
        }
    }
}
