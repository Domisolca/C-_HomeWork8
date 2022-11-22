void BubbleSort(int[,] mas)
{
    int temp;
    for (int row = 0; row < mas.GetLength(0); row++)
    {
        for (int i = 0; i < mas.GetLength(1); i++)
        {
            for (int j = i + 1; j < mas.GetLength(1); j++)
            {
                if (mas[row, i] < mas[row, j])
                {
                    temp = mas[row, i];
                    mas[row, i] = mas[row, j];
                    mas[row, j] = temp;
                }
            }
        }
    }
}


void Fill2DArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
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

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];

Fill2DArrayRandomNumbers(numbers);
Write2DArray(numbers);
Console.WriteLine();
BubbleSort(numbers);
Console.WriteLine("Массив после сортировки: ");
Write2DArray(numbers);