using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.Read();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            string url = "https://www.cbr-xml-daily.ru/daily_json.js";
            string json;
            using (WebClient webclient = new WebClient())
            {
                json = webclient.DownloadString(url);
            }
        }
    }
}
