using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyJSON
{
    public class Сurrency
    {
        public DateTime Date { get; set; }
        public Valute Valute { get; set; }
    }

    //К сожалению такой JSON file
    public class Valute
    {
        public СurrencyCountry Aud { get; set; }
        public СurrencyCountry Azn { get; set; }
        public СurrencyCountry Gbp { get; set; }
        public СurrencyCountry Amd { get; set; }
        public СurrencyCountry Byn { get; set; }
        public СurrencyCountry Bgn { get; set; }
        public СurrencyCountry Brl { get; set; }
        public СurrencyCountry Huf { get; set; }
        public СurrencyCountry Hkd { get; set; }
        public СurrencyCountry Usd { get; set; }
        public СurrencyCountry Eur { get; set; }
        public СurrencyCountry Kzt { get; set; }
        public СurrencyCountry Cad { get; set; }
        public СurrencyCountry Cny { get; set; }
        public СurrencyCountry Try { get; set; }
        public СurrencyCountry Uah { get; set; }
    }

    public class СurrencyCountry
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal Previous { get; set; }
    }

    public class AUD : СurrencyCountry {}
    public class AZN : СurrencyCountry { }
    public class GBP : СurrencyCountry { }
    public class AMD : СurrencyCountry { }
    public class BYN : СurrencyCountry { }
    public class BGN : СurrencyCountry { }
    public class BRL : СurrencyCountry { }
    public class HUF : СurrencyCountry { }
    public class HKD : СurrencyCountry { }
    public class USD : СurrencyCountry { }
    public class EUR : СurrencyCountry { }
    public class KZT : СurrencyCountry { }
    public class CAD : СurrencyCountry { }
    public class CNY : СurrencyCountry { }
    public class TRY : СurrencyCountry { }
    public class UAH : СurrencyCountry { }

}
