// Determinati daca n se divide cu k, unde n si k sunt date de intrare.
Console.Write("n:");
double n = Convert.ToDouble(Console.ReadLine());
Console.Write("k:");
double k = Convert.ToDouble(Console.ReadLine());
double calcul = k / n;

if (calcul % 1 == 0)
{
    Console.WriteLine("n se divide cu k");
}
else 
{
    Console.WriteLine("n nu se divide cu k");
}