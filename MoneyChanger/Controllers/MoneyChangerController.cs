using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MoneyChangerBC;
using Common;
using Models;
using Newtonsoft.Json;

namespace MoneyChanger.Controllers
{
    public class MoneyChangerController :  ApiController
    {
        // GET: MoneyChanger
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/MoneyChanger/SellCurrency")]
        
        public ExchangeResult SellCurrency(decimal customerAmount, string currenyType)
        {
            ExchangeBC bc = new ExchangeBC();
            var result = bc.SellCurrecy(customerAmount, currenyType);
            return result;
        }

        // GET: MoneyChanger
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/MoneyChanger/BuyCurrency")]
        public ExchangeResult BuyCurrency(decimal customerAmount, string currenyType)
        {
            ExchangeBC bc = new ExchangeBC();
            var result = bc.BuyCurrecy(customerAmount, currenyType);
            return result;
        }
    }
}