// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
Console.Write("a:");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b:");
double b = Convert.ToDouble(Console.ReadLine());

double result = Result(a ,b);

Console.WriteLine(PrintResult(result));

static double Result(double a, double b)
{
    if (a == 0) {
        Console.WriteLine("Rezultatul nu are solutii reale.");
        return 0.1;
    }
    
    return -b / a;
}
static string PrintResult(double result)
{
    string output = "x = " + result;
    if (result == 0.1) {
        return "Rezultatul nu are solutii reale.";
    }
    else {
        return "x = " + result;
    }
}
