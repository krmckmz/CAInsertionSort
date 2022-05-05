class Program
{

    static void Main(string[] args)
    {
        InsertionSortByWhile(new int[] { 3, 4, 5, 2 });
        Console.ReadLine();
    }

    static void InsertionSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
            for (int j = i + 1; j > 0; j--)
                if (numbers[j] < numbers[j - 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = temp;
                }
    }

    static void InsertionSortByWhile(int[] numbers)
    {
        int j, temp;
        for (int i = 1; i <= numbers.Length - 1; i++)
        {
            temp = numbers[i];
            j = i - 1;
            while (j >= 0 && numbers[j] > temp)
            {
                numbers[j + 1] = numbers[j];
                j--;
            }
            numbers[j + 1] = temp;
        }
    }
}