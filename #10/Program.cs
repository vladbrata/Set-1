// Test de primalitate: determinati daca un numar n este prim.

Console.Write("Introdu un numar n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintIsPrime(n));

static bool IsPrime(int n)
{
    if (n < 2) {
        return false;
    }
    else {
        for (int d = 2; d * d <= n; d++)
        {
            if (n % d == 0)
            {
                return false;
            }
        }
    }
    return true;
}
static string PrintIsPrime(int n)
{
    bool isPrime = IsPrime(n);

    if (!isPrime) {
        return $"{n} nu este numar prim";
    }
    
    return $"{n} este numar prim";
}