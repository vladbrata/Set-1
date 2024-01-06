// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

Random num = new Random();
int a = num.Next(1, 9);
int b = num.Next(1, 9);
int c = num.Next(1, 9);
int d = num.Next(1, 9);
int e = num.Next(1, 9);
Console.WriteLine("Numerele inainte de sortare");
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
for (int i = 0; i < 100; i++)
{
    if (a > b) {
        SwapNums(ref a, ref b);
    }
    if (b > c) {
        SwapNums(ref b, ref c);
    }
    if (c > d) {
        SwapNums(ref c, ref d);
    }
    if (d > e) {
        SwapNums(ref d, ref e);
    }
    if (a < b && b < c && c < d && d < e) {
        break;
    }
}
Console.WriteLine("\nNumerele dupa sortare");
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);

static void SwapNums(ref int a, ref int b)
{
    int swap1 = a;
    a = b;
    b = swap1;
}