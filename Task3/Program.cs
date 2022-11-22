int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
            }
        }
    }

    return matrix3;
}

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

int rowsA = ReadInt("Введите количество строк матрицы 1: ");
int columnsA = ReadInt("Введите количество столбцов матрицы 1: ");
int rowsB = ReadInt("Введите количество строк матрицы 2: ");
int columnsB = ReadInt("Введите количество столбцов матрицы 2: ");
int[,] numbersA = new int[rowsA, columnsA];
int[,] numbersB = new int[rowsB, columnsB];

Fill2DArrayRandomNumbers(numbersA);
Write2DArray(numbersA);
Console.WriteLine();
Fill2DArrayRandomNumbers(numbersB);
Write2DArray(numbersB);
Console.WriteLine();

if (numbersA.GetLength(1) == numbersB.GetLength(0))
{
    Console.WriteLine("Итоговая матрица: ");
    Write2DArray(DivMatrix(numbersA, numbersB));
}
else
{
    Console.WriteLine("Нельзя перемножить матрицы!");
}
