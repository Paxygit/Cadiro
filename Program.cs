using System;
using Cadiro.API;
using Newtonsoft.Json;
namespace Cadiro
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string item, league;
            item = Console.ReadLine();
            league = Console.ReadLine();
            DivinationCard.Root divinationCard = JsonConvert.DeserializeObject<DivinationCard.Root>(NinjaJSON.GetJSON(item, league).Result);
            for (int i = 0; i < divinationCard.lines.Count; i++)
                Console.WriteLine(divinationCard.lines[i].name + " costs " + divinationCard.lines[i].chaosValue.ToString() + "c.");
        }
    }
}
