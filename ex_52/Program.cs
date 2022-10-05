// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] massive = new int[4, 4];

Array(massive);
Print(massive);

Console.Write("Среднее арифметическое значение: ");


double sum = 0;

for (int j = 0; j < massive.GetLength(1); j++)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        sum += massive[i, j];
    }
    double avg = sum / massive.GetLength(1);
    Console.WriteLine(Math.Round(avg, 1) + " ");
    sum = 0;
}