// Detreminati daca un an y este an bisect.
Console.WriteLine("Cate zile are anul?");
Console.WriteLine("Daca are 365 de zile, apasati 1, iar daca are 366, apasati 2");
int y = Convert.ToInt32(Console.ReadLine());

if (y == 1)
{
    Console.WriteLine("Anul nu este bisect!");
}
else {
    Console.WriteLine("Anul este bisect!");
}    