// Afisati toti divizorii numarului n.
Console.Write("Da-mi un numar n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nDivizorii numarului {n} sunt: ");
GetDivizori(n);

static void GetDivizori(int n)
{
    for (int i = 1; i <= n; i++) {
       if (n == 0) {
           throw new ArgumentException("Invalid!");
       }
       else if (n == 1) {
           throw new ArgumentException("Invalid");
       }
       if (n % i == 0) {
            Console.Write(i + " ");
        }
    }
}