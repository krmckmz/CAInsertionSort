class Program
{

    static void Main(string[] args)
    {
        InsertionSort(new int[] { 7, 4, 5, 2 });
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

    //static void InsertionSortByWhile(int[] numbers)
    //{
    //    int inner = default(int);

    //    for (int i = 1; i <= numbers.Length; i++)
    //    {
    //        int temp = numbers[i];
    //        inner = i;

    //        while (inner > 0 && numbers[inner - 1] >= temp)
    //        {
    //            numbers[inner] = numbers[inner - 1];
    //            inner--;
    //        }

    //        numbers[i] = temp;
    //    }
    //}
}