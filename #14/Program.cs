// Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
Console.Write("Da-mi un numar n: ");
int num = Convert.ToInt32(Console.ReadLine());

string result = PrintPalindrome(num);
Console.WriteLine(result);

static int ReverseInt(int num)
{
    int result = 0;

    while (num > 0) {
        result = result * 10 + num % 10;
        num /= 10;
    }
    return result;
}

static bool IsPalindrome(int num)
{
    int reverseNum = ReverseInt(num);

    if (reverseNum == num)
    {
        return true;
    }
    
    return false;
}

static string PrintPalindrome(int num)
{
    int reverseNum = ReverseInt(num);
    bool isPalindrome = IsPalindrome(num);

    if (isPalindrome) {
    return $"{num} este un Palindrom";
    }
    else {
    return $"{num} nu este un Palindrom";
    }
}