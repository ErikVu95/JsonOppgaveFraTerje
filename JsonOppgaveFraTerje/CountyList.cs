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

        public CountyList(int idnumber, string name, int number1, int number2)
        {
            IdNumber = idnumber;
            Name = name;
            Number1 = number1;
            Number2 = number2;
        }
    }
}
