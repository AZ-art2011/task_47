// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

Console.WriteLine("Укажите число строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в массиве");
int n = Convert.ToInt32(Console.ReadLine());

float[,] matrix = new float[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        float rand = new Random().Next(-100, 100);
        float rnd = rand / 10;
        matrix[i, j] = rnd;
    }
    
    // Console.WriteLine(rnd);
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    
    Console.WriteLine(" ");
}
