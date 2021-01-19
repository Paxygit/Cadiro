using System;
using System.Collections.Generic;
using System.Text;

namespace Cadiro.API
{
    public class HelmetEnchants //Wrap all classes to avoid accessibility issues (1/16/21 Dankoter)
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Sparkline    {
        public List<object> data { get; set; } 
        public double totalChange { get; set; } 
    }

    public class LowConfidenceSparkline    {
        public List<object> data { get; set; } 
        public double totalChange { get; set; } 
    }

    public class TradeInfo    {
        public string mod { get; set; } 
        public int min { get; set; } 
        public int max { get; set; } 
    }

    public class Line    {
        public int id { get; set; } 
        public string name { get; set; } 
        public string icon { get; set; } 
        public int mapTier { get; set; } 
        public int levelRequired { get; set; } 
        public object baseType { get; set; } 
        public int stackSize { get; set; } 
        public string variant { get; set; } 
        public object prophecyText { get; set; } 
        public object artFilename { get; set; } 
        public int links { get; set; } 
        public int itemClass { get; set; } 
        public Sparkline sparkline { get; set; } 
        public LowConfidenceSparkline lowConfidenceSparkline { get; set; } 
        public List<object> implicitModifiers { get; set; } 
        public List<object> explicitModifiers { get; set; } 
        public object flavourText { get; set; } 
        public bool corrupted { get; set; } 
        public int gemLevel { get; set; } 
        public int gemQuality { get; set; } 
        public string itemType { get; set; } 
        public double chaosValue { get; set; } 
        public double exaltedValue { get; set; } 
        public int count { get; set; } 
        public string detailsId { get; set; } 
        public TradeInfo tradeInfo { get; set; } 
        public object mapRegion { get; set; } 
        public int listingCount { get; set; } 
    }

    public class Translations    {
    }

    public class Language    {
        public string name { get; set; } 
        public Translations translations { get; set; } 
    }

    public class Root    {
        public List<Line> lines { get; set; } 
        public Language language { get; set; } 
    }


    }
}