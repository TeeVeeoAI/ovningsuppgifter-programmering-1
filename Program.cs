using System.Runtime.InteropServices;

Main();

void Main() {
    double[] input = new double[2];
    Console.Write("Enter your first value: ");
    input[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter your second value: ");
    input[1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What do you want to do with them?");
    char type = Convert.ToChar(Console.ReadLine());
    while (true) {
        if (type == '+') {
            Console.WriteLine(input[0] + " + " + input[1] + " = " + Addition(input[0], input[1]));
            break;
        } else if (type == '-') {
            Console.WriteLine(input[0] + " - " + input[1] + " = " + Subtraction(input[0], input[1])); 
            break;
        } else if (type == '*') {
            Console.WriteLine(input[0] + " * " + input[1] + " = " + Multiplication(input[0], input[1]));
            break;
        } else if (type == '/') {
            Console.WriteLine(input[0] + " / " + input[1] + " = " + Divided(input[0], input[1]));
            break;
        } else {
            Console.WriteLine("input is invalid");
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
