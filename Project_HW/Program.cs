void Zadacha34()
{
    int size = 10;
    int[] array = new int[size];

    FillArray(array, 100, 1000);
    PrintArray(array);
    FindNums(array);
}

void FillArray(int[] array, int startNum, int finishNum)
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

void FindNums(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum++;
    }   
    Console.WriteLine($"количество четных чисел массива равно {sum}");
}



Zadacha34();