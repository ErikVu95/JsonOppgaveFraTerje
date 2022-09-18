using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace JsonOppgaveFraTerje
{
    public class SortWorkShopAndApprove
    {
        public string Bedriftsnavn { get; set; }
        public string Adresse { get; set; }
        public string Postnummer { get; set; }
        public int PostnummerToInt { get; set; }
        public string Poststed { get; set; }
        public string Godkjenningstyper { get; set; }
        public int Organisasjonsnummer { get; set; }
        public int Godkjenningsnummer { get; set; }

        public SortWorkShopAndApprove(string bedriftsnavn, string adresse, string postnummer, string poststed, string godkjenningstyper, int organisasjonsnummer, int godkjenningsnummer)
        {
            Bedriftsnavn = bedriftsnavn;
            Adresse = adresse;
            Postnummer = postnummer;
            Poststed = poststed;
            Godkjenningstyper = godkjenningstyper;
            Organisasjonsnummer = organisasjonsnummer;
            Godkjenningsnummer = godkjenningsnummer;
            CheckParse();
        }

        public void CheckParse()
        {
            if (Postnummer != "")
            {
                PostnummerToInt = int.Parse(Postnummer);
            }
        }
    }
}
