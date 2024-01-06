// (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare

Console.WriteLine("Introdu doua numere");

Console.Write("a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b:");
int b = Convert.ToInt32(Console.ReadLine());

SwapNums(a, b);
Console.WriteLine("Numerele dupa inversare");
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");

static void SwapNums(int a, int b)
{
    a = a + b;
    b = a - b;
    a = a - b;
}