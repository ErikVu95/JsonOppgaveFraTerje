using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOppgaveFraTerje
{
    public class Lisence
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public string LisenceType { get; set; }

        public Lisence(string name, int idNumber, string lisenceType)
        {
            Name = name;
            IdNumber = idNumber;
            LisenceType = lisenceType;
        }
    }
}
