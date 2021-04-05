using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChangerDAL
{
    public class MoneyExchangeData
    {
        public ExchageRate GetMoneyExchange(string currencyType)
        {
            using (MoneyChangerEntities entities = new MoneyChangerEntities())
            {
                var moneyExchangeList = entities.ExchageRates.Where(a=>a.CurrencyCode == currencyType).FirstOrDefault();
                return moneyExchangeList;
            }
        }

        public List<ExchageRate> GetMoneyExchangeList()
        {
            using (MoneyChangerEntities entities = new MoneyChangerEntities())
            {
                var moneyExchangeList = entities.ExchageRates.ToList();
                return moneyExchangeList;
            }
        }
    }
}
