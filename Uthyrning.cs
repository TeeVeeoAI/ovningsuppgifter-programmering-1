using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovningsuppgifter_programmering_1
{
    public class Uthyrning
    {
        /*
        - Egenskaper:
            - `Bil` (Bil-objekt)
            - `Kund` (Kund-objekt)
            - `AntalDagar` (int)
            - `TotalKostnad` (double, beräknas automatiskt vid skapandet)
        - Metoder:
            - `VisaUthyrningsInfo()`: Skriver ut information om uthyrningen, t.ex. "Bil: Volvo XC60, Kund: Anna Andersson, Antal dagar: 3, Total kostnad: 1497 kr."
        */

        private Bil bil;
        private Kund kund;
        private int antalDagar;
        private double totalKostnad;

        public void VisaUthyrningsInfo(){
            Console.WriteLine("Bil: " + bil.Märke + " " + bil.Modell + "\nKund: " + kund.Namn + "\nAntal dagar: " + antalDagar + "\nTotal kostnad" + totalKostnad + " kr.");
        }
        

        public Uthyrning(Bil b, Kund k, int a){
            kund = k;
            bil = b;
            antalDagar = a;
            totalKostnad = b.Dagshyra * a;
        }
    }
}