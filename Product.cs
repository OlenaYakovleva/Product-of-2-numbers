using System;
internal class Program {
    static int myProd(int s, int f){
 if (s > f) 
 {
    int temp = s;
    s=f;
    f=temp;
 }

 int res = 1;
 for (int i = s; i <= f; i++)
 res *= i;
 return res;
    }

static void Main(){
    Console.Write ("Type start number: ");
    int s = Convert.ToInt32(Console.ReadLine());

    Console.Write ("Type end number: ");
    int f = Convert.ToInt32(Console.ReadLine());

    int result = myProd(s, f);
    Console.WriteLine($"Product of numbers from {s} to {f} is {result}");
}

}