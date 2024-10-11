public class F(){
    public static void Fibonacci(int[] a, int i, int n) {
    if (i == 0) {
        Console.Write(a[i] + ", ");
    } else if (i == 1){
        Console.Write(a[i]);
    } else {
        a[i] = a[i-1] + a[i-2];   
        if (i < n) {
            Console.Write(", " + a[i]);
        } else {
            Console.Write(a[i]);
        }
    }
    }
}