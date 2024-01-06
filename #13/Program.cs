// Determianti cati ani bisecti sunt intre anii y1 si y2.

Console.Write("Introdu un an: ");
int firstYear = Convert.ToInt32(Console.ReadLine());

Console.Write("Introdu un an: ");
int secondYear = Convert.ToInt32(Console.ReadLine());

int[] years = GetYears(firstYear, secondYear);

int cnt = 0;
foreach (int year in years) {
    if (IsBisect(year)) {
        cnt++;
    }
}

Console.WriteLine($"Intre anii [{firstYear}, {secondYear}] sunt {cnt} ani bisecti");

static bool IsBisect(int year)
{
    if (year % 4 != 0) {
        return false;
    }
    else if (year % 100 != 0) {
        return true;
    }
    else if (year % 400 != 0) {
        return false;
    }
    return true;
}

static int[] GetYears(int firstYear, int secondYear)
{
    int largestYear, smallestYear;
    if (firstYear > secondYear) {
        largestYear = firstYear;
        smallestYear = secondYear;
    }
    else {
        largestYear = secondYear;
        smallestYear = firstYear;
    }

    int[] arr = new int[(largestYear - smallestYear) - 1];

    int cnt = smallestYear;
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = cnt + 1;
        cnt++;
    }
    return arr;
}