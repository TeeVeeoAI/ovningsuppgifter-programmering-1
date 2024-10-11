public class F(){
    public static void Fibonacci(ref int a, ref int i) {
        int b;
        int c;
        if (i == 0) {
            a = 1;
            c = 1;
            b = 0;
        } else if (i == 1) {
            int temp = a;
            a = b + c;
            b = temp;
            i++;
        } else if (i == 2) {
            int temp = a;
            a = b + c;
            c = temp;
            i--; 
        }
    }
}