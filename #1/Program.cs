// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
Console.Write("a:");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b:");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Se rezolva ecuatia {a}x + {b} = 0");
Console.WriteLine($"x = -b / a");
Console.WriteLine($"x = -{b} / {a}");
Console.WriteLine("x = " + Result(a, b));

static double Result(double a, double b)
{
    double x = -b / a;
    return x;
}
