using Newtonsoft.Json;
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
        Converter converter;
        public Form1()
        {
            InitializeComponent();
            Console.Read();
            converter = new Converter();

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            converter.Сurrency = Сurrency.GetСurrency(url.Text);
            List<СurrencyCountry> сurrencyCountries = new List<СurrencyCountry>{
                converter.Сurrency.Valute.Aud,
                converter.Сurrency.Valute.Azn,
                converter.Сurrency.Valute.Gbp,
                converter.Сurrency.Valute.Amd,
                converter.Сurrency.Valute.Byn,
                converter.Сurrency.Valute.Bgn,
                converter.Сurrency.Valute.Brl,
                converter.Сurrency.Valute.Huf,
                converter.Сurrency.Valute.Hkd,
                converter.Сurrency.Valute.Usd,
                converter.Сurrency.Valute.Eur,
                converter.Сurrency.Valute.Kzt,
                converter.Сurrency.Valute.Cad,
                converter.Сurrency.Valute.Cny,
                converter.Сurrency.Valute.Try,
                converter.Сurrency.Valute.Uah
            };

            foreach(var i in сurrencyCountries)
            {
                listFromTo.Items.Add(i.Name);
                listInTo.Items.Add(i.Name);
            }
            

        }
    }
}
