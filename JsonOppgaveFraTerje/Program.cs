using System.Text.Json;
using Newtonsoft.Json;

namespace JsonOppgaveFraTerje
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "csvjson.json";
            string jsonFile = File.ReadAllText(fileName);
            var garage = JsonConvert.DeserializeObject<List<Garage>>(jsonFile);

            CountyManager.FindCountyByNumber();
            GarageManager.RangePrintInfo(garage);

        }

        public static void MenuPrint()
        {
            Console.WriteLine("Choose a County to see the mechanics in your area.");
            int listNumber = 1;
            for (int i = 0; i < CountyManager.CountyLists.Count; i++)
            {
                if (CountyManager.CountyLists[i].IdNumber == listNumber)
                {
                    Console.WriteLine($"{listNumber}. " + CountyManager.CountyLists[i].Name);
                    listNumber++;
                }
            }
        }

        public static void LisencePrint()
        {
            Console.WriteLine("Choose one or multiple licenses");
            int listNumber = 1;
            for (int i = 0; i < GarageManager.Licenses.Count; i++)
            {
                Console.WriteLine($"{listNumber}. " + GarageManager.Licenses[i].Name);
                listNumber++;
            }
        }
    }
}