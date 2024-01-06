// Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
Console.Write("Da-mi un numar a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("\nDa-mi un numar b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("\nDa-mi un numar n: ");
int n = 2;


int cnt = 0;
for (int numar = a; numar <= b; numar++) {
    if (numar % n == 0) cnt++;
}

Console.WriteLine($"\nNumarul de numere divizibile cu {n} din intervalul [{a}, {b}] sunt {cnt}");