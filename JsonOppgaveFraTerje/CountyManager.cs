using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOppgaveFraTerje
{
    static class CountyManager
    {
        public static List<CountyList> CountyLists = new List<CountyList>();

        static CountyManager()
        {
            CountyLists.Add(new CountyList(1, "Oslo", 0000, 1299));
            CountyLists.Add(new CountyList(2, "Akershus", 1300, 1499));
            CountyLists.Add(new CountyList(2, "Akershus", 1900, 2099));
            CountyLists.Add(new CountyList(3, "Østfold", 1500, 1899));
            CountyLists.Add(new CountyList(4, "Hedmark", 2100, 2599));
            CountyLists.Add(new CountyList(5, "Oppland", 2600, 2999));
            CountyLists.Add(new CountyList(5, "Oppland", 3550, 3599));
            CountyLists.Add(new CountyList(6, "Buskerud", 3000, 3049));
            CountyLists.Add(new CountyList(6, "Buskerud", 3300, 3549));
            CountyLists.Add(new CountyList(7, "Vestfold", 3050, 3299));
            CountyLists.Add(new CountyList(8, "Telemark", 3600, 3999));
            CountyLists.Add(new CountyList(9, "Rogaland", 4000, 4399));
            CountyLists.Add(new CountyList(9, "Rogaland", 5500, 5549));
            CountyLists.Add(new CountyList(10, "Vest-Agder", 4400, 4699));
            CountyLists.Add(new CountyList(11, "Aust-Agder", 4700, 4999));
            CountyLists.Add(new CountyList(12, "Hordaland", 5000, 5499));
            CountyLists.Add(new CountyList(12, "Hordaland", 5550, 5749));
            CountyLists.Add(new CountyList(12, "Hordaland", 5800, 5949));
            CountyLists.Add(new CountyList(13, "Sogn og Fjordane", 5750, 5799));
            CountyLists.Add(new CountyList(13, "Sogn og Fjordane", 5950, 5999));
            CountyLists.Add(new CountyList(13, "Sogn og Fjordane", 6700, 6999));
            CountyLists.Add(new CountyList(14, "Møre og Romsdal", 6000, 6699));
            CountyLists.Add(new CountyList(15, "Sør-Trøndelag", 7000, 7499));
            CountyLists.Add(new CountyList(15, "Sør-Trøndelag", 7700, 7749));
            CountyLists.Add(new CountyList(16, "Nord-Trøndelag", 7500, 7699));
            CountyLists.Add(new CountyList(16, "Nord-Trøndelag", 7750, 7949));
            CountyLists.Add(new CountyList(17, "Nordland", 7950, 8449));
            CountyLists.Add(new CountyList(17, "Nordland", 8500, 8999));
            CountyLists.Add(new CountyList(18, "Troms", 8450, 8499));
            CountyLists.Add(new CountyList(18, "Troms", 9000, 9149));
            CountyLists.Add(new CountyList(18, "Troms", 9200, 9499));
            CountyLists.Add(new CountyList(19, "Finnmark", 9150, 9199));
            CountyLists.Add(new CountyList(19, "Finnmark", 9500, 9999));
        }

        public static void FindCountyByNumber()
        {
            Console.WriteLine("Type a postcode to find the matching County.");
            int postCodeInput;
            postCodeInput = Convert.ToInt32(Console.ReadLine());

            foreach (var number in CountyLists)
            {
                if (postCodeInput >= number.Number1 && postCodeInput <= number.Number2)
                {
                    Console.WriteLine(number.Name);
                    Console.WriteLine();
                }
            }
        }
    }
}

//public static void FindCountyByNumber(List<Garage> list)
//{
//    int postCodeInput;
//    postCodeInput = Convert.ToInt32(Console.ReadLine());

//    foreach (var number in CountyLists)
//    {
//        if (postCodeInput >= number.Number1 && postCodeInput <= number.Number2)
//        {
//            foreach (var info in list)
//            {
//                if (info.PostnummerToInt == postCodeInput)
//                {
//                    info.PrintInfo();
//                }
//            }
//        }
//    }
//}

