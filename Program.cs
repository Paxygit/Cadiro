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
            Debug();
        }

        private static void Debug()
        {
            //string item, league;
            //Console.WriteLine("Item: ");
            //item = Console.ReadLine();
            //Console.WriteLine("\nLeague: ");
            //league = Console.ReadLine();
            string item = "Prophecy";
            string league = "Ritual";
            Prophecy.Root Prophecys = JsonConvert.DeserializeObject<Prophecy.Root>(NinjaJSON.GetJSON(item, league).Result);
            for (int i = 0; i < Prophecys.lines.Count; i++)
                Console.WriteLine(Prophecys.lines[i].name + " costs " + Prophecys.lines[i].chaosValue.ToString() + "c.");
            Console.WriteLine("\n\n");
            //Debug();
        }
    }
}
