while(true) {
    Main();
    if (Console.ReadLine() == "!") {
        break;
    } else {
        
    }
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
            if (type == "!") {
                int input_int = Convert.ToInt32(input);
                Console.WriteLine(input + "! = " + Factorial(input_int));
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