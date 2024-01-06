// (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
Console.WriteLine("Introdu doua numere");

Console.Write("a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b:");
int b = Convert.ToInt32(Console.ReadLine());

SwapNumbers(ref a, ref b);
Console.WriteLine("Numerele dupa inversare");
Console.WriteLine($"a: {a}");
Console.WriteLine($"b: {b}");

static void SwapNumbers(ref int a, ref int b)
{    int swap1 = a;
    a = b;
    b = swap1;
}