// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 

Console.Write("Da-mi un numar e: ");
int e = Convert.ToInt32(Console.ReadLine());
int[] arr = IntToArr(e);

if (DoesRepeat(arr))
{
    Console.WriteLine($"Numarul {e} este format din doua cifre care se repeta!");
}
else
{
    Console.WriteLine($"Numarul {e} nu este format din doua cifre care se repeta!");
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

// TODO de facut functia asta sa fucntioneze
static bool DoesRepeat(int[] arr)
{
    int n = arr.Length;
    bool repeat = true;
    int firstElement = arr[0];
    int secondElement = 0;

    switch (n) {
        case < 2:
            return false;
        case 2:
            return true;
        case 3:
            for (int i = 0; i < 2; i++) {
                if (arr[i] == arr[i + 1]) {
                    return true;
                }
            }
            return false;
         case > 3:
            int cnt = 0;
            for (int i = 0; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    if (arr[i] != arr[j]) {
                        cnt++;
                    }
                    if (cnt > 2) {
                        return false;
                    }
                }
                
            }    
            return true;
        }

    }
        // 1 1 1 1 2
    
    // for (int i = 0; i < n; i++) {
    //     if (arr[i] != arr[0]) {
    //         secondElement = arr[i];
    //     }
    // }
    // if (n > 3) {
    //     // for (int i = 0; i < n; i++) {
    //     //     if (arr[i] != firstElement && arr[i] != secondElement) {
    //     //         return false;
    //     //     }
    //     // }
    // }
    // return repeat;
