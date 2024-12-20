/*while (true) {
    Main();
    if (Console.ReadLine() == "!") {
        break;
    } else {
        int Fibonaccis_Sequence = 0;
        while (true){
            F.Fibonacci(ref Fibonaccis_Sequence);
            if (Fibonaccis_Sequence == 0) {
                Console.Write(Fibonaccis_Sequence);
            }
            Console.Write(", " + Fibonaccis_Sequence);
    }
} 
Console.Write("Enter the how much of the Fibonacci sequence you want to see: ");
int n = Convert.ToInt32(Console.ReadLine());
n++;
int[] fibonacci_array = new int[n];
fibonacci_array[0] = 0;
fibonacci_array[1] = 1;
for (int i = 0; i < n; i++) {
    F.Fibonacci(fibonacci_array, i, n);
}

void Main() {
    Console.WriteLine("How meny numbers do you need?");
    int amount = Convert.ToInt32(Console.ReadLine());
    if (amount == 2) {
        double[] input = new double[2];
        Console.Write("Enter your first value: ");
        input[0] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your second value: ");
        input[1] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What do you want to do with them?");
        while (true) {
            string type = Convert.ToString(Console.ReadLine());
            if (type == "+") {
                Console.WriteLine(input[0] + " + " + input[1] + " = " + Addition(input[0], input[1]));
                break;
            } else if (type == "-") {
                Console.WriteLine(input[0] + " - " + input[1] + " = " + Subtraction(input[0], input[1])); 
                break;
            } else if (type == "*") {
                Console.WriteLine(input[0] + " * " + input[1] + " = " + Multiplication(input[0], input[1]));
                break;
            } else if (type == "/") {
                Console.WriteLine(input[0] + " / " + input[1] + " = " + Divided(input[0], input[1]));
                break;
            } else {
                Console.WriteLine("input is invalid");
            }
        }
        return;
    } else if (amount == 1) {
        Console.Write("Enter your value: ");
        double input = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What do you want to do with it?");
        while (true) {
            string type = Convert.ToString(Console.ReadLine());
            if (type == "n!") {
                int input_int = Convert.ToInt32(input);
                Console.WriteLine(input + "! = " + Factorial(input_int));
                break;
            } else if(type =="!n") {
                Console.WriteLine("!" + input + " = " + Sub_Factorial(input));
                break;
            } else {
                Console.WriteLine("input is invalid");
            }
        }
    }
}

double Addition(double a, double b) {
    return a+b;
}

double Subtraction(double a, double b) {
    return a-b;
}

double Multiplication(double a, double b) {
    return a*b;
}

double Divided(double a, double b) {
    return a/b;
}

int Factorial(int a) {
    for (int i = a-1; i >= 1; i--) {
        a = a*i;
    }
    return a;
}

double Sub_Factorial(double a){
    double c = 0;
    int a_d = Convert.ToInt32(a);
    Factorial(a_d);
    for (int k = 1; k <= a_d; k++) {
        double k_d = Convert.ToDouble(k);
        double k_F = Convert.ToDouble(Factorial(k));
        double o = -1;
        c = ((Math.Pow((k_d, o))/k_F) + c;
        Console.WriteLine(c);
    }
    return c;
}*/



//Del 2
//uppgift 1:
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text.Unicode;
using ovningsuppgifter_programmering_1;

void uppgift1(){
    int a = 10; 
    Console.WriteLine(a);
}

void uppgift2(){
    string a = "Tore";
    Console.WriteLine("Hej " + a);
}

void uppgift3(){
    Console.WriteLine("Skriv ett nummer");
    int a = 0;
    int b = 0;
    try{
        a = int.Parse(Console.ReadLine());
    }
    catch(Exception e){
        Console.WriteLine(e.Message + "\nFörsök igen: ");
    }
    Console.WriteLine("Skriv ett till nummer");
    try{
        b = int.Parse(Console.ReadLine());
    }
    catch(Exception e){
        Console.WriteLine(e.Message + "\nFörsök igen: ");
    }
    Console.WriteLine("Summan är " + (a + b));
}

void uppgift4(){
    Console.WriteLine("Skriv ett tal");
    int a = int.Parse(Console.ReadLine());
    
    if (a < 0) {
        Console.WriteLine("Det är negativt");
    } else if (a > 0) {
        Console.WriteLine("Det är posetivt");
    } else {
        Console.WriteLine("Det är noll");
    }
}

void uppgift5(){
    Console.WriteLine("Skriv ett tal");
    int a = int.Parse(Console.ReadLine());

    if (a % 2 == 0){
        Console.WriteLine("Det är jämmt");
    } else {
        Console.WriteLine("Det är udda");
    }
}

void uppgift6(){
    Console.WriteLine("Skriv ditt namn för att se om du kan köra bil.");
    int ålder = int.Parse(Console.ReadLine());

    if (ålder >= 18){
        Console.WriteLine("Ja");
    } else {
        Console.WriteLine("Nej");
    }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

void uppgift17(){
    //in går klasser Bil, Kund, Uthyrning
    List<Bil> bilar = new List<Bil>();
    List<Kund> kunder = new List<Kund>();
    List<Uthyrning> uthyrningar = new List<Uthyrning>();

    while (true){
        Console.WriteLine(  "Vad vill du göra? \n"+
                            "1. Lägg till ny bil. \n"+
                            "2. Se tillgängliga bilar. \n"+
                            "3. Lägg till ny kund. \n" +
                            "4. Hyr bil \n");
        string input = Console.ReadLine();

        if ( input == "Lägg till ny bil" || input == "Ny bil" || input == "1") {
            bilar.Add(NyBil());
        } else if (input == "Se bilar" || input == "2") {
            SeBilar(bilar);
        } else if (input == "Lägg till ny kund" || input == "Ny kund" || input == "3") {
            kunder.Add(NyKund());
        } else if (input == "Hyr bil" || input == "4") {
            uthyrningar.Add(HyrBil(bilar, kunder));
        }
    }
}

Bil NyBil(){
    string märke;
    string modell;
    int årsmodell;
    double dagshyra;

    Console.WriteLine("\nMärke? ");
    while (true) {
        try {
            märke = Console.ReadLine();
            break;
        }
        catch (Exception e) {
            Console.WriteLine("Försök igen");
        }
    }

    Console.WriteLine("\nModell? ");
    while (true) {
        try {
            modell = Console.ReadLine();
            break;
        }
        catch (Exception e) {
            Console.WriteLine("Försök igen");
        }
    }

    Console.WriteLine("\nårsmodell? ");
    while (true) {
        try {
            årsmodell = int.Parse(Console.ReadLine());
            break;
        }
        catch (Exception e) {
            Console.WriteLine("Försök igen");
        }
    }

    Console.WriteLine("\ndagshyra? ");
    while (true) {
        try {
            dagshyra = double.Parse(Console.ReadLine());
            break;
        }
        catch (Exception e) {
            Console.WriteLine("Försök igen");
        }
    }

    return new Bil(märke, modell, årsmodell, dagshyra);
}

Kund NyKund(){
    string namn;
    string telefonnummer;

    Console.WriteLine("\nNamn?");
    while (true) {
        try{
            namn = Console.ReadLine();
            break;
        }
        catch(Exception e){
            Console.WriteLine("Försök igen");
        }   
    }

    Console.WriteLine("\nTelefonnummer?");
    while (true) {
        try {
            telefonnummer = Console.ReadLine();
            break;
        } 
        catch(Exception e){
            Console.WriteLine("Försök igen");
        }
    }

    return new Kund(namn, telefonnummer);
}

void SeBilar(List<Bil> bilar) {

    foreach (Bil bil in bilar){
        
        if (bil.ÄrTillgänglig == true){

            Console.WriteLine("/////////////////////////////////////////////////////////////////////////\n");
            bil.VisaInfo();

        }
    }
    Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////");
}

Uthyrning HyrBil(List<Bil> bilar, List<Kund> kunder){
    Bil bil;
    Kund kund;
    int antalDagar;
    int i;

    Console.WriteLine("\nVilken kund är du?\n\n");
    int p;

    i = 1;
    foreach(Kund k in kunder){
        Console.Write(i + ". ");
        k.VisaKundInfo();
        i++;
    }

    Console.WriteLine("Vilket nummer?");
    while(true){
        try {
            p = int.Parse(Console.ReadLine());
            if (p > kunder.Count){
                throw new Exception();
            }
            kund = kunder[p-1];
            break;
        }
        catch(Exception e){
            Console.WriteLine("Försök igen.");
        }
    }

    Console.WriteLine("\nVilken bil?\n\n");
    int bill;

    i = 1;
    foreach(Bil b in bilar){
        Console.Write(i + ". ");
        b.VisaInfo();
        i++;
    }

    Console.WriteLine("\nVilket nummer?");
    while (true){
        try {
            bill = int.Parse(Console.ReadLine());
            if (bill > kunder.Count){
                throw new Exception();
            }
            bil = bilar[bill-1];
            break;
        }
        catch (Exception e){
            Console.WriteLine("Försök igen.");
        }
    }

    Console.WriteLine("\nHur många dagar?");
    while (true){
        try{
            antalDagar = int.Parse(Console.ReadLine());
            break;
        }
        catch (Exception e){
            Console.WriteLine("Försök igen.");
        }
    }
    
    bil.ÄrTillgänglig = false;

    return new Uthyrning(bil, kund, antalDagar);
}

uppgift17();