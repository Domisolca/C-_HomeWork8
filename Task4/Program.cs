void Fill3DArrayRandomNumbers(int[,,] array)
{
    Random rnd = new Random();
    int number = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                bool flag = true;
                while (flag)
                {
                    number = rnd.Next(1, 100);
                    if (!ExistElement(array, number))
                    {
                        flag = false;
                    }
                }
                array[i, j, k] = number;
            }
        }
    }
}

bool ExistElement(int[,,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == element)
                {
                    return true;
                }
            }
        }
    }

    return false;
}

void Write3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write($"{array[j, k, i]}({j},{k},{i}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int i = ReadInt("Введите первую размерность: ");
int j = ReadInt("Введите вторую размерность: ");
int k = ReadInt("Введите третью размерность: ");
int[,,] numbers = new int[i, j, k];

Fill3DArrayRandomNumbers(numbers);
Write3DArray(numbers);