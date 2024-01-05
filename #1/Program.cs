
//Date de intrare
Console.Write("a:");
 double a = Convert.ToDouble(Console.ReadLine());
 Console.Write("b:");
 double b = Convert.ToDouble(Console.ReadLine());

 Calcul1(a, b);

static void Calcul1(double a, double b)
{
    // Formula de calcul
    double x = -b / a;
    // Rezolvare
    Console.WriteLine($"Se rezolva ecuatia {a}x + {b} = 0");
    Console.WriteLine($"x = -b / a");
    Console.WriteLine($"x = -{b} / {a}");
    Console.WriteLine($"x: {x}");
}
