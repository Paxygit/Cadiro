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
        private static readonly string baseUrl = @"https://poe.ninja/api/data/";
        private static readonly string leagueUrl = @"?league=";
        private static readonly string typeUrl = @"&type=";

        private static string GetUrl(string input, string league) =>
             baseUrl + GetType(input).ToLower() + "overview" + leagueUrl + league + typeUrl + input; // formats query to JSON url for http client later

        private static string GetType(string input) 
        {
            string type = string.Empty;
            switch (input)
            {
                case "Currency":
                    type = "Currency";
                    break;

                case "Fragment":
                    type = "Currency";
                    break;

                default:
                    type = "Item";
                    break;
            }
            return type;
        } // Simple switch for determining if query is an item or currency for link purposes

        public static async Task<string> GetJSON(string input, string league)
        {
        var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(GetUrl(input, league));
            string result = await response.Content.ReadAsStringAsync();
        return result;
        } // Asyncronously retrieves data from JSON link, 




    }
}
