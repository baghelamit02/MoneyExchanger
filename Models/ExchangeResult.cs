using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ExchangeResult
    {
        public string Message { get; set; }
        public string CurrencyConvertedTo { get; set; }
        public string CurrencyConvertedFrom { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal SuggestedExchangeRate { get; set; }
    }
}
