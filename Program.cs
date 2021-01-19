using System;
using Cadiro.API;
using Newtonsoft.Json;
namespace Cadiro
{
    class Program
    {
        static void Main(string[] args)
        {
             Root divinationCard = JsonConvert.DeserializeObject<Root>(NinjaJSON.GetJSON().Result);
            //Console.WriteLine(NinjaJSON.GetJSON().Result.ToString());
            for (int i = 0; i < divinationCard.lines.Count; i++)
                Console.WriteLine(divinationCard.lines[i].name + " costs " + divinationCard.lines[i].chaosValue.ToString() + "c.");
        }
    }
}
