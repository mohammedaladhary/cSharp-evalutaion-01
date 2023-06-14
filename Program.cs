internal class Program
{
    static int sortArray(int[] num)
    {
        int temp = 0;
        for (int i = 1; i < num.Length; i++)
        {
            for (int j = 1; j < num.Length -1; j++)
            if (num[j] > num[j + 1])
            {
                temp = num[j + 1];
                    num[j+1] = num[j];
                    num[j] = temp;
            }
        }
        for (int i = 1; i < num.Length; i++)
        {
            return num[i];
        }
        return num.Length;
    }

    static int searchArray(int[] num, int schNum)
    {
        for (int i = 1; i < num.Length; i++)
        {
            if (schNum == num[i])
            {
                return i;
            }
        }
        return -1;
    }

    private static void Main(string[] args)
    {
        int[] arr = new int[8] { 4, 7, 3, 5, 1, 10, 90, 8 };
     
        Console.WriteLine("The sorted array is: " + sortArray(arr));
        //[1,3,4,5,7,8,10,90] sorted array

        Console.WriteLine("Searched array: " + searchArray(arr , 7));
        ////5th place - index in the array

        Console.WriteLine("Searched array: " + searchArray(arr, 20));
        ////-1 - not in the array

    }
}