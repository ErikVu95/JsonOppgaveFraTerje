using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOppgaveFraTerje
{

    static class GarageManager
    {
        //  static List<Garage> Lisences = new List<Garage>();
        public static List<Lisence> Licenses = new List<Lisence>();

        static GarageManager()
        {
            Licenses.Add(new Lisence("Alkolåsverksted", 1, "ALKOLASVERKSTED"));
            Licenses.Add(new Lisence("Bilelektro-/drivstoffanleggverksted", 2, "BILELEKTRODRIVSTOFFANLEGG"));
            Licenses.Add(new Lisence("Bilbremseverksted", 3, "BILBREMSE"));
            Licenses.Add(new Lisence("Bildieselverksted", 4, "BILDIESEL"));
            Licenses.Add(new Lisence("Arbeid på bilglass", 5, "BILGLASS"));
            Licenses.Add(new Lisence("Bilskadeverksted", 6, "BILSKADE"));
            Licenses.Add(new Lisence("Bilverksted 01 - kjøretøy ≤ 3500kg unntatt MC, moped og traktor", 7, "BILVERKSTED01"));
            Licenses.Add(new Lisence("Bilverksted 01 - kjøretøy ≤ 7500kg m/hydr brems unntatt MC, moped og traktor", 8, "BILVERKSTED01B"));
            Licenses.Add(new Lisence("Bilverksted 02 - kjøretøy > 3500kg og ≤ 7500kg unntatt MC, moped og traktor", 9, "BILVERKSTED02"));
            Licenses.Add(new Lisence("Bilverksted 03 - kjøretøy > 7500 kg unntatt MC, moped og traktor", 10, "BILVERKSTED03"));
            Licenses.Add(new Lisence("Bilverksted - alle typer kjøretøy", 11, "BILVERKSTEDALLE"));
            Licenses.Add(new Lisence("Arbeid på eksosanlegg", 12, "EKSOSANLEGG"));
            Licenses.Add(new Lisence("Arbeid på fartsskriver", 13, "FARTSSKRIVER"));
            Licenses.Add(new Lisence("Arbeid på gassdriftsanlegg", 14, "GASSDRIFTANLEGG"));
            Licenses.Add(new Lisence("Arbeid på lette tilhengeres påløpsbremseanlegg", 15, "HENGERESPALOPSBREMSEANLEGG"));
            Licenses.Add(new Lisence("Arbeid på hjul", 16, "HJUL"));
            Licenses.Add(new Lisence("Hjulutrustningsverksted", 17, "HJULUTRUSTNING"));
            Licenses.Add(new Lisence("Kontrollorgan 01 - EU-kontroll av kjøretøy ≤ 3500kg", 18, "KONTROLLORGAN01"));
            Licenses.Add(new Lisence("Kontrollorgan 01 - EU-kontroll av kjøretøy ≤ 7500kg m/hydr brems", 19, "KONTROLLORGAN01B"));
            Licenses.Add(new Lisence("Kontrollorgan 02 - EU-kontroll av kjøretøy ≤ 7500kg", 20, "KONTROLLORGAN02"));
            Licenses.Add(new Lisence("Kontrollorgan 03 - EU-kontroll av kjøretøy > 7500kg", 21, "KONTROLLORGAN03"));
            Licenses.Add(new Lisence("Kontrollorgan 04 - EU-kontroll av alle kjøretøy", 22, "KONTROLLORGAN04"));
            Licenses.Add(new Lisence("Arbeid på lysutstyr", 23, "LYSUTSTYR"));
            Licenses.Add(new Lisence("Motorsykkel- og mopedverksted", 24, "MOTORSYKKELOGMOPED"));
            Licenses.Add(new Lisence("Påbyggerverksted", 25, "PABYGGER"));
            Licenses.Add(new Lisence("Skadeverksted 01", 26, "SKADEVERKSTED01"));
            Licenses.Add(new Lisence("Skadeverksted 02", 27, "SKADEVERKSTED02"));
            Licenses.Add(new Lisence("Traktorverksted", 28, "TRAKTOR"));
        }

        public static void RangePrintInfo(List<Garage> garages)
        {
            Program.MenuPrint();
            int userInputCounty = Convert.ToInt32(Console.ReadLine());
            Program.LisencePrint();
            int userInputLisence = Convert.ToInt32(Console.ReadLine());
            FilterCounties(garages, userInputCounty, userInputLisence, Licenses);
          //  FilterLisences(garages, Licenses, userInputLisence);

        }

        static void FilterCounties(List<Garage> list, int userInputCounty, int userInputLisence, List<Lisence> lisences)
        {
            foreach (var info in CountyManager.CountyLists)
            {
                if (userInputCounty == info.IdNumber)
                {
                    foreach (var shops in list)
                    {
                        if (shops.PostnummerToInt >= info.Number1 && shops.PostnummerToInt <= info.Number2)
                        {
                            foreach (var lisence in lisences)
                            {
                                if (lisence.IdNumber == userInputLisence)
                                {
                                    if (shops.Godkjenningstyper.Contains(lisence.LisenceType))
                                    {
                                        shops.PrintInfo();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        //static void FilterLisences(List<Garage> list, List<Lisence> lisences, int input, int input2)
        //{
        //    foreach (var lisence in lisences)
        //    {
        //        if (lisence.IdNumber == input)
        //        {
        //            foreach (var print in list)
        //            {
        //                print.PrintInfo();
        //            }
        //        }
        //    }
        //}

        

        //public static void FilterLisences(List<Garage> list)
        //{
        //    var userInputLisence = Console.ReadLine();
        //    foreach (var lisence in Licenses)
        //    {
        //       // if (lisence.IdNumber.Contains(userInputLisence))
        //        {
        //            foreach (var garagelist in list)
        //            {
        //                garagelist.PrintInfo();
        //            }
        //        }
        //    }
        //}

    }
}
