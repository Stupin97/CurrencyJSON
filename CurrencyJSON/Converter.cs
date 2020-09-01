using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyJSON
{
    public class Converter
    {
        public Сurrency Сurrency { get; set; }
        public Converter() { }

        public decimal Calculations(decimal str, decimal from, decimal @in)
        {
            return str * from / @in;
        }
    }
}
