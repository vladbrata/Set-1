// Se dau 3 numere. Sa se afiseze in ordine crescatoare.

Random rnd = new Random();
int firstNum = rnd.Next(-10, 10);
int secondNum = rnd.Next(-10, 10);
int thirdNum = rnd.Next(-10, 10);
int[] nums = {firstNum, secondNum, thirdNum};

Console.Write("Numerele inainte sa fie sortate sunt: "); 
foreach (int num in nums) {
    Console.Write(num + " ");
}

Console.Write("\nNumerele dupa ce au fost sortate sunt: "); 
int[] sortedNums = BubbleSort(nums);
foreach (int num in sortedNums) {
    Console.Write(num + " ");
}


static int[] BubbleSort(int[] arr)
{
    int i, j, temp;
    bool swapped;

    for (i = 0; i < arr.Length - 1; i++) {
        swapped = false;
        for (j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                swapped = true;
            }
        }
        
        if (swapped == false) {
            break;
        }
    }

    return arr;
}