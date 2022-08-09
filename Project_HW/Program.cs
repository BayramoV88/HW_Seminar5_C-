void Zadacha34()
{
    int size = 10;
    int[] array = new int[size];

    FillArray(array, 100, 1000);
    PrintArray(array);
    FindEvenNums(array);
}

void Zadacha36()
{
    int size = 10;
    int[] array = new int[size];

    FillArray(array);
    PrintArray(array);
    FindSumOddNums(array);
}

void FillArray(int[] array, int startNum = -20, int finishNum = 20)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(startNum, finishNum);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FindEvenNums(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum++;
    }   
    Console.WriteLine($"количество четных чисел массива равно {sum}");
}

void FindSumOddNums(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");
}


//Zadacha34();
Zadacha36();