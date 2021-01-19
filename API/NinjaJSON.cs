using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Cadiro
{
    public class NinjaJSON
    {
        private static string baseUrl = @"https://poe.ninja/api/data/";
        
        private static string leagueUrl = @"?league=";
        private static string typeUrl = @"&type=";

        public static string GetUrl(string input, string league) 
        {
            return "temp";
        }

        public static string GetType(string input)
        {
            string type = string.Empty;
            switch (input)
            {
                case "Currency":
                    type = "currency";
                    break;

                case "Fragment":
                    type = "currency";
                    break;

                default:
                    type = "item";
                    break;
            }
            return type;
        }

        public static async Task<string> GetJSON()
        {
            //this would be item here
            //string fullUrl = baseUrl + "GetDivinationCardsOverview" + leagueUrl + "Ritual";
            string fullUrl = @"https://poe.ninja/api/data/itemoverview?league=Ritual&type=DivinationCard";
        var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(fullUrl);
            string result = await response.Content.ReadAsStringAsync();
        return result;
        }




    }
}
