//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyChangerDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExchageRate
    {
        public string Id { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<decimal> BuyRate { get; set; }
        public Nullable<decimal> SellRate { get; set; }
    }
}