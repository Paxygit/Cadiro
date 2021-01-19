using System;
using System.Collections.Generic;
using System.Text;

namespace Cadiro.API
{
    public class Fragments //Wrap all classes to avoid accessibility issues (1/16/21 Dankoter)
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Pay    {
        public int id { get; set; } 
        public int league_id { get; set; } 
        public int pay_currency_id { get; set; } 
        public int get_currency_id { get; set; } 
        public DateTime sample_time_utc { get; set; } 
        public int count { get; set; } 
        public double value { get; set; } 
        public int data_point_count { get; set; } 
        public bool includes_secondary { get; set; } 
        public int listing_count { get; set; } 
    }

    public class Receive    {
        public int id { get; set; } 
        public int league_id { get; set; } 
        public int pay_currency_id { get; set; } 
        public int get_currency_id { get; set; } 
        public DateTime sample_time_utc { get; set; } 
        public int count { get; set; } 
        public double value { get; set; } 
        public int data_point_count { get; set; } 
        public bool includes_secondary { get; set; } 
        public int listing_count { get; set; } 
    }

    public class PaySparkLine    {
        public List<object> data { get; set; } 
        public double totalChange { get; set; } 
    }

    public class ReceiveSparkLine    {
        public List<object> data { get; set; } 
        public double totalChange { get; set; } 
    }

    public class LowConfidencePaySparkLine    {
        public List<object> data { get; set; } 
        public double totalChange { get; set; } 
    }

    public class LowConfidenceReceiveSparkLine    {
        public List<object> data { get; set; } 
        public double totalChange { get; set; } 
    }

    public class Line    {
        public string currencyTypeName { get; set; } 
        public Pay pay { get; set; } 
        public Receive receive { get; set; } 
        public PaySparkLine paySparkLine { get; set; } 
        public ReceiveSparkLine receiveSparkLine { get; set; } 
        public double chaosEquivalent { get; set; } 
        public LowConfidencePaySparkLine lowConfidencePaySparkLine { get; set; } 
        public LowConfidenceReceiveSparkLine lowConfidenceReceiveSparkLine { get; set; } 
        public string detailsId { get; set; } 
    }

    public class CurrencyDetail    {
        public int id { get; set; } 
        public string icon { get; set; } 
        public string name { get; set; } 
        public string tradeId { get; set; } 
    }

    public class Translations    {
    }

    public class Language    {
        public string name { get; set; } 
        public Translations translations { get; set; } 
    }

    public class Root    {
        public List<Line> lines { get; set; } 
        public List<CurrencyDetail> currencyDetails { get; set; } 
        public Language language { get; set; } 
    }


    }
}