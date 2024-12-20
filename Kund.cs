using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovningsuppgifter_programmering_1
{
    public class Kund
    {
        /*
        - Egenskaper:
            - `Namn` (string)
            - `Telefonnummer` (string)
        - Metoder:
            - `VisaKundInfo()`: Skriver ut kundens namn och telefonnummer.
        */

        private string namn;
        private string telefonnummer;

        public string Namn{
            get{ return namn; }
        }
        public string Telefonnummer{
            get{ return telefonnummer; }
        }

        public void VisaKundInfo(){
            Console.WriteLine("Namn: " + namn + "Telefonnumer" + telefonnummer);
        }

        public Kund(string n, string t){
            namn = n;
            telefonnummer = t;
        }
    }
}