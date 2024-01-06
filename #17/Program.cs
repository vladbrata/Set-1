// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.

Console.WriteLine("Da-mi doua numere: ");
Console.Write("a: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Cel mai mare divizor comun al numerelor este: " + GetCmdc(num1, num2));
Console.WriteLine("Cel mai mic multiplu comun al numerelor este: " + GetCmmmc(num1, num2));

static int GetCmdc(int num1, int num2)
{
    int cmdc = 0;

    while (num1 != num2)
    {
        if (num1 > num2)
            num1 -= num2;
        else
            num2 -= num1;

        if (num1 == num2)
            cmdc = num1;
    }
    return cmdc;
}

static int GetCmmmc(int num1, int num2)
{
    int cmmc = (num1 * num2) / GetCmdc(num1, num2);

    return cmmc;
}