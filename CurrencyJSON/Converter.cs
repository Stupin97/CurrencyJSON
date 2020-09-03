using System;

namespace CurrencyJSON
{
    public class Converter
    {
        public Сurrency Сurrency { get; set; }
        public Converter() { }

        public decimal Calculations(decimal str, decimal from, decimal @in)
        {
            return Math.Round(str * from / @in, 3);
        }
    }
}
