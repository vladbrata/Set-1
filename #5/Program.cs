// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.

int num = 1467;
int[] arr = NumToArr(num);

Console.Write("Introdu un numar k: ");
int k = Convert.ToInt32(Console.ReadLine());

PrintResult(num, k);


static string PrintResult(int num, int k)
{
    if (k > Digits(num)) {
        return "Numarul este prea scurt!";
    }
    else {
        return $"A {k} cifra din numarul {num} este {arr[k]}";
    }
}

static int[] NumToArr(int num)
{
    int[] arr = new int[Digits(num)];
    for (int i = arr.Length - 1; i >= 0; i--) {
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