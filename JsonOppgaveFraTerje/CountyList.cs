using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOppgaveFraTerje
{
    public class CountyList
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        //public int Number3 { get; set; }
        //public int Number4 { get; set; }
        //public int Number5 { get; set; }
        //public int Number6 { get; set; }

        public CountyList(int idnumber, string name, int number1, int number2)
        {
            IdNumber = idnumber;
            Name = name;
            Number1 = number1;
            Number2 = number2;
        }

        //public CountyList(int idnumber, string name, int number1, int number2, int number3, int number4)
        //{
        //    IdNumber = idnumber;
        //    Name = name;
        //    Number1 = number1;
        //    Number2 = number2;
        //    Number3 = number3;
        //    Number4 = number4;
        //}

        //public CountyList(int idnumber, string name, int number1, int number2, int number3, int number4, int number5, int number6)
        //{
        //    IdNumber = idnumber;
        //    Name = name;
        //    Number1 = number1;
        //    Number2 = number2;
        //    Number3 = number3;
        //    Number4 = number4;
        //    Number5 = number5;
        //    Number6 = number6;
        //}


    }
}
