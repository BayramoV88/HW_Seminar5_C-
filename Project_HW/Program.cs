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

void Zadacha38()
{
    int size = 6;
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble() * 100;
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i], 2) + ("  "));
    }
    Console.WriteLine();
    Result(array);
}

void FillArray(int[] array, int startNum = -30, int finishNum = 30)
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
        if (i % 2 == 1) sum = sum + array[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");
}

void Result(double[] array)
{
    double maxN = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxN) maxN = array[i];
    }
    Console.WriteLine("Максимальный элемент массива " + (Math.Round(maxN, 2)));

    double minN = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minN) minN = array[i];
    }
    Console.WriteLine("Минимальный элемент массива " + (Math.Round(minN, 2)));

    double result = 0;
    result = maxN - minN;

    Console.WriteLine("Разница между максимальным и минимальным элементом " + (Math.Round(result, 2)));
}


//Zadacha34();
//Zadacha36();
Zadacha38();