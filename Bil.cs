using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovningsuppgifter_programmering_1
{
    public class Bil
    {
        /*
        - Egenskaper:
            - `Märke` (string)
            - `Modell` (string)
            - `Årsmodell` (int)
            - `Dagshyra` (double)
            - `ÄrTillgänglig` (bool)
        - Metoder
            - `VisaInfo()`: Skriver ut bilens information, t.ex. "Volvo XC60, Årsmodell: 2020, Dagshyra: 499 kr, Tillgänglig: Ja/Nej".
        */

        private string märke;
        private string modell;
        private int årsmodell;
        private double dagshyra;
        private bool ärTillgänglig;

        public string Märke{
            get{ return märke; }
        }

        public string Modell{
            get{ return modell; }
        }

        public int Årsmodell{
            get{ return årsmodell; }
        }

        public double Dagshyra{
            get{ return dagshyra; }
        }

        public bool ÄrTillgänglig{
            get{ return ärTillgänglig; }
            set{ årsmodell = value; }
        }

        public void VisaInfo(){
            Console.WriteLine(märke + " " + modell + "\n" + "Årsmodell: " + årsmodell + "\n" + "Dagshyra: " + dagshyra + "\n" + "Tillgänglig: " + ärTillgänglig);
        }

        public Bil(string mä, string mo, int å, double d, bool ä){
            märke = mä;
            modell = mo;
            dagshyra = d;
            ärTillgänglig = ä;
        }
    }
}