using System.Text.Json;
using Newtonsoft.Json;

namespace JsonOppgaveFraTerje
{
    class Program
    {
        static List<CountyList> CountyLists = new List<CountyList>();
        static void Main(string[] args)
        {
            string fileName = "csvjson.json";
            string jsonFile = File.ReadAllText(fileName);
            var sortWorkShopAndApprove = JsonConvert.DeserializeObject<List<SortWorkShopAndApprove>>(jsonFile);
            CountyNumberListAdd();
            MenuPrint();
            PrintInfo(sortWorkShopAndApprove);

        }

        static void MenuPrint()
        {
            Console.WriteLine("Choose a County to see the mechanics in your area.");
            int listNumber = 1;
            for (int i = 0; i < CountyLists.Count; i++)
            {
                Console.WriteLine($"{listNumber}. " + CountyLists[i].Name);
                listNumber++;
            }
        }

        static void PrintInfo(List<SortWorkShopAndApprove> list)
        {//Contains? for å sortere etter godkjenninger. Fylke som er lagt til flere ganger printes ut. Finne en god løsning på det.
            int userInputCounty = Convert.ToInt32(Console.ReadLine());

            foreach (var info in CountyLists)
            {
                if (userInputCounty == info.IdNumber)
                {
                    foreach (var shops in list)
                    {
                        if (shops.PostnummerToInt >= info.Number1 && shops.PostnummerToInt <= info.Number2)
                        {
                            Console.WriteLine(shops.Bedriftsnavn);
                            Console.WriteLine(shops.Adresse);
                            Console.WriteLine(shops.Postnummer);
                            Console.WriteLine(shops.Godkjenningstyper);
                            Console.WriteLine(shops.Organisasjonsnummer);
                            Console.WriteLine(shops.Godkjenningsnummer);
                            Console.WriteLine();
                        }
                    }
                }
            }

        }

        static void CountyNumberListAdd()
        {
            CountyLists.Add(new CountyList(1, "Oslo", 0000, 1299));
            CountyLists.Add(new CountyList(2,"Akershus", 1300, 1499));
            CountyLists.Add(new CountyList(3, "Østfold", 1500, 1899));
            CountyLists.Add(new CountyList(4,"Akershus", 1900, 2099));
            CountyLists.Add(new CountyList(5,"Hedmark", 2100, 2599));
            CountyLists.Add(new CountyList(6, "Oppland", 2600, 2999));
            CountyLists.Add(new CountyList(6, "Oppland", 3550, 3599));
            CountyLists.Add(new CountyList(7, "Buskerud", 3000, 3049));
            CountyLists.Add(new CountyList(7, "Buskerud", 3300, 3549));
            CountyLists.Add(new CountyList(8, "Vestfold", 3050, 3299));
            CountyLists.Add(new CountyList(9, "Telemark", 3600, 3999));
            CountyLists.Add(new CountyList(10, "Rogaland", 4000, 4399));
            CountyLists.Add(new CountyList(11, "Vest-Agder", 4400, 4699));
            CountyLists.Add(new CountyList(12, "Aust-Agder", 4700, 4999));
            CountyLists.Add(new CountyList(13, "Hordaland", 5000, 5499));
            CountyLists.Add(new CountyList(13, "Hordaland", 5550, 5749));
            CountyLists.Add(new CountyList(13, "Hordaland", 5800, 5949));
            CountyLists.Add(new CountyList(14, "Rogaland", 5500,5549));
            CountyLists.Add(new CountyList(15, "Sogn og Fjordane", 5750, 5799));
            CountyLists.Add(new CountyList(15, "Sogn og Fjordane", 5950, 5999));
            CountyLists.Add(new CountyList(15, "Sogn og Fjordane", 6700, 6999));
            CountyLists.Add(new CountyList(16, "Møre og Romsdal", 6000, 6699));
            CountyLists.Add(new CountyList(17, "Sør-Trøndelag", 7000, 7499));
            CountyLists.Add(new CountyList(17, "Sør-Trøndelag", 7700, 7749));
            CountyLists.Add(new CountyList(18, "Nord-Trøndelag", 7500, 7699));
            CountyLists.Add(new CountyList(18, "Nord-Trøndelag", 7750, 7949));
            CountyLists.Add(new CountyList(19, "Nordland", 7950, 8449));
            CountyLists.Add(new CountyList(19, "Nordland", 8500, 8999));
            CountyLists.Add(new CountyList(20, "Troms", 9000, 9149));
            CountyLists.Add(new CountyList(20, "Troms", 9200, 9499));
            CountyLists.Add(new CountyList(21, "Finnmark", 9150, 9199));
            CountyLists.Add(new CountyList(21, "Finnmark", 9500, 9999));
        }
    }
}

//    Console.WriteLine(info.Bedriftsnavn);
//    Console.WriteLine(info.Adresse);
//    Console.WriteLine(info.Postnummer);
//    Console.WriteLine(info.Godkjenningstyper);
//    Console.WriteLine(info.Organisasjonsnummer);
//    Console.WriteLine(info.Godkjenningsnummer);
//    Console.WriteLine();