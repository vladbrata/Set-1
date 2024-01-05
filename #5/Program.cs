// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.
Random random = new Random();
int num = random.Next(1, 1000);
Console.WriteLine($"Se da numarul {num}");

Console.Write("Introdu un numar k: ");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintResult(num, k));

static string PrintResult(int num, int k)
{
    int[] arr = NumToArr(num);
    if (k > Digits(num)) {
        return "Numarul este prea scurt!";
    }
    else {
        return $"A {k} cifra din numarul (de la dreapta la stanga) {num} este {arr[k - 1]}";
    }
}

static int[] NumToArr(int num)
{
    int[] arr = new int[Digits(num)];
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = num % 10;
        num = num / 10;
    }
    return arr;
}

static int Digits(int n)
{
    int digits = n < 0 ? 2 : 1;
    while ((n /= 10) != 0) ++digits;
    return digits;
}