using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using Newtonsoft.Json;

namespace WindowsFormsApp3
{
    public partial class BeginForm : Form
    {
        public BeginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListForm nextForm = new ListForm();

            const string URL = "https://salty-ravine-09555.herokuapp.com/list_all";

            using (WebClient client = new WebClient())
            {
                string s = client.DownloadString(URL);
                Console.WriteLine("{0}", s);

                ResultObject obj = JsonConvert.DeserializeObject<ResultObject>(s);

                //obj.ForEach((x) => Console.WriteLine("Movie is {0}", x));

                int x = 0;

                foreach (string value in obj.result)
                {
                    Console.WriteLine(value);
                    Button btn = new Button();
                    btn.Text = value.ToString();
                    btn.ForeColor = System.Drawing.Color.Black; ;
                    btn.BackColor = System.Drawing.Color.LightSkyBlue;
                    btn.Size = new System.Drawing.Size(128, 128);
                    btn.Click += new EventHandler(btn_Click);
                    btn.Name = string.Format("butDynamic{0}", x);

                    nextForm.movieList.Controls.Add(btn);

                    x++;
                }

            }

            this.Hide();

            Console.WriteLine("---------------------------------------\n\n");
            nextForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void btn_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;

            Console.WriteLine(s);

            ViewForm vf = new ViewForm();

            vf.movieName.Text = s;

            string url2 = "https://salty-ravine-09555.herokuapp.com/get_similar/" + s;

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url2);

                ResultObject obj = JsonConvert.DeserializeObject<ResultObject>(json);

                int x = 0;

                foreach (string value in obj.result)
                {
                    Console.WriteLine(value);
                    Button btn = new Button();
                    btn.Text = value.ToString();
                    btn.ForeColor = System.Drawing.Color.Black; ;
                    btn.BackColor = System.Drawing.Color.LightSkyBlue;
                    btn.Size = new System.Drawing.Size(128, 128);
                    btn.Click += new EventHandler(btn_Click);
                    btn.Name = string.Format("butDynamic{0}", x);

                    vf.movieList.Controls.Add(btn);

                    x++;
                }

            }

            vf.Show();
        }

    }

    public class Movies
    {
        //public string index { get; set; }
        public string name { get; set; }
        //public string message { get; set; }
    }
    public class ResultObject
    {
        public List<string> result { get; set; }
        
    }
}
