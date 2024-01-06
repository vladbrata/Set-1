// Afisati in ordine inversa cifrele unui numar n. 
Console.Write("Da-mi un numar n: ");
int n = Convert.ToInt32(Console.ReadLine());
int reverseInt = ReverseInt(n);

Console.Write($"\nNumarul inversat este: {reverseInt}");

static int ReverseInt(int num)
{
    int result = 0;
    while (num > 0) {
        result = result * 10 + num % 10;
        num /= 10;
    }
    return result;
}