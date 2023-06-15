internal class Program
{
    static int[] sortArray(int[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = i + 1; j < num.Length; j++)
            {
                if (num[i] > num[j])
                {
                    int temp = num[i];
                    num[i] = num[j];
                    num[j] = temp;
                }
            }
        }
        return num;
    }

    static int searchArray(int[] num, int schNum)
    {
        for (int i = 0; i < num.Length; i++)
        {
            if (schNum == num[i])
            {
                return i;
            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        int[] arr = new int[8] { 4, 7, 3, 5, 1, 10, 90, 8 };
        int[] anArray = sortArray(arr);
        Console.WriteLine("The sorted array is: ");
        for (int i = 0; i < anArray.Length; i++)
        {
            Console.Write(anArray[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Searched array: " + searchArray(arr , 10));
        ////5th place - index in the array

        Console.WriteLine("Sea+rched array: " + searchArray(arr, 20));
        ////-1 - not in the array

    }
}