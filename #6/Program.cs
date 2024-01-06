// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
Console.Write("a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b:");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("c:");
int c = Convert.ToInt32(Console.ReadLine());

if (IsTriangle(a, b, c)) {
    Console.WriteLine($"{a}, {b}, {c} pot fi laturile unui triunghi");
}
else {
    Console.WriteLine($"{a}, {b}, {c} nu pot fi laturile unui triunghi");

}

static bool IsTriangle(int a, int b, int c)
{
    if (a + b > c || a + c > b || c + b > a)
    {
        return true;
    }
    return false;
}