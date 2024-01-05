// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.
Console.Write("a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c:");
int c = Convert.ToInt32(Console.ReadLine());

Result(a, b, c);

static void Result(int a, int b, int c)
{
    double delta = Math.Pow(b, 2) - 4 * a * c;
    double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
    if (x1 % 1 == 0 && x2 % 1 == 0)
    {
        Console.WriteLine($"Se rezolva ecuatia: {a}x^2 + {b}x + {c} = 0\n");
        Console.WriteLine($"Delta = b^2 - 4 * a * c");
        Console.WriteLine($"Delta = {b}^2 - 4 * {a} * {c}");
        Console.WriteLine($"Delta = {delta}\n");
        Console.WriteLine($"x1 = (-b + √delta) / 2 * a");
        Console.WriteLine($"x1 = (-{b} + √{delta}) / 2 * {a}");
        Console.WriteLine($"x1 = {x1}\n");
        Console.WriteLine($"x2 = (-b - √delta) / 2 * a");
        Console.WriteLine($"x1 = (-{b} - √{delta}) / 2 * {a}");
        Console.WriteLine($"x1 = {x2}\n");
        Console.WriteLine($"x1: {x1}\tx2: {x2}");
    }
    else
    {
        Console.WriteLine("Problema nu are solutii reale!");
    }
}