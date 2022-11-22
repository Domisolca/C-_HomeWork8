void Fill2DArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void Write2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] SumArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        sumArray[i] = sum;
    }

    return sumArray;
}

int MinIndex(int[] array)
{
    int minIndex = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minIndex])
        {
            minIndex = i;
        }
    }

    return minIndex;
}

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
int[] sumNumbers = new int[rows];

Fill2DArrayRandomNumbers(numbers);
Write2DArray(numbers);
sumNumbers = SumArray(numbers);
int minIndex = MinIndex(sumNumbers);
Console.WriteLine("Минимальная сумма элементов в строке номер: " + (minIndex+1));