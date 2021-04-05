using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyChangerDAL;
using Common;

namespace MoneyChangerBC
{
    public class ExchangeBC
    {
        public ExchangeResult SellCurrecy(decimal customerAmount , string currencyType )
        {
            MoneyExchangeData data = new MoneyExchangeData();
            var getMoneyExchangeRate = data.GetMoneyExchange(currencyType.ToString());
            var getMoneyExchangeRateList = data.GetMoneyExchangeList();
            ExchangeResult result = new ExchangeResult();

            if (getMoneyExchangeRate != null)
            {
                if (customerAmount == 0)
                {
                    result.Message = Constants.ExchangeZeroAmountMessage;
                    return result;
                }

                if (getMoneyExchangeRate.SellRate == 0)
                {
                    result.Message = Constants.ExchangeSellAmountZeroMessage;
                    return result;
                }

                result.Message = Constants.ExchangeSuccessMessage;
                result.ExchangeRate = Convert.ToDecimal(customerAmount * getMoneyExchangeRate.BuyRate);
                result.SuggestedExchangeRate = Math.Round(result.ExchangeRate, 0);
                result.CurrencyConvertedTo = CurrencyType.SGD.ToString();
                result.CurrencyConvertedFrom = currencyType.ToString();
            }
            else
            {
                result.Message = Constants.ExchangeDoNotConvertMessage;
            }
            return result;
        }

        public ExchangeResult BuyCurrecy(decimal customerAmount, string currencyType)
        {
            MoneyExchangeData data = new MoneyExchangeData();
            var getMoneyExchangeRate = data.GetMoneyExchange(currencyType.ToString());           

            ExchangeResult result = new ExchangeResult();
            if (getMoneyExchangeRate != null)
            {
                if (customerAmount == 0)
                {
                    result.Message = Constants.ExchangeZeroAmountMessage;
                    return result;
                }

                if(getMoneyExchangeRate.SellRate == 0)
                {
                    result.Message = Constants.ExchangeSellAmountZeroMessage;
                    return result;
                }

                result.Message = Constants.ExchangeSuccessMessage;
                result.ExchangeRate = Math.Round(Convert.ToDecimal(customerAmount * (1 / getMoneyExchangeRate.SellRate)), 4);
                result.SuggestedExchangeRate = Math.Round(result.ExchangeRate, 0);
                result.CurrencyConvertedFrom = CurrencyType.SGD.ToString();
                result.CurrencyConvertedTo = currencyType.ToString();                
            }
            else
            {
                result.Message = Constants.ExchangeDoNotBuyConvertMessage;
            }
            return result;

        }
    }
}
