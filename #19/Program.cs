// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 

Console.Write("Da-mi un numar e: ");
int e = Convert.ToInt32(Console.ReadLine());
int[] arr = IntToArr(e);

if (DoesRepeat(arr)) {
    Console.WriteLine($"Numarul {e} este format din doua cifre care se pot repeta!");
}
else {
    Console.WriteLine($"Numarul {e} nu este format din doua cifre care se pot repeta!");
}

static int Digits(int n)
{
    int digits = n < 0 ? 2 : 1;
    while ((n /= 10) != 0) ++digits;
    return digits;
}

static int[] IntToArr(int n)
{
    int[] arr = new int[Digits(n - 1)];
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        arr[i] = n % 10;
        n /= 10;
    }
    return arr;
}

static bool DoesRepeat(int[] arr)
{
    int n = arr.Length;

    switch (n) {
        case < 2: // daca numarul este decat o cifra, atunci nu respecta cerinta
            return false;
        case 2: // daca numarul este format din 2 cifre, inevitabil respecta cerinta
            return true;
        case >= 3: // daca este format din 3 sau mai multe cifre, se stabilesc primele 2 cifre diferite. dupa care se verifica daca exista mai mult de 2 cifre  diferite.
            int firstNum = arr[0];
            int secondNum = 0;
            for (int i = 1; i < n; i++) {
                if (arr[i] != firstNum) {
                    secondNum = arr[i];
                    break;
                }
            }
            
            for (int i = 0; i < n; i++) {
                if (arr[i] != firstNum && arr[i] != secondNum) {
                    return false;
                }
            }
            return true;
    }    
}
