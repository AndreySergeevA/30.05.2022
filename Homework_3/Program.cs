/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetDemension(string message)
{
Console.WriteLine(message);
int demension = int.Parse(Console.ReadLine());
return demension;
}

int[,] GetMatrix(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 10) Console.Write($" {array[i, j]}  ");
            else Console.Write($"  {array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

double[] GetArithmeticMean(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            result[j] = sum / array.GetLength(1);
        }
    }
    return result;
}

void PrintArray(double[] array)
{
    Console.WriteLine("------------------------");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

int row = GetDemension("Введите длину для первого разряда матрицы:");
int col = GetDemension("Введите длину для второго разряда матрицы:");
int min = GetDemension("Введите минимальное значение чисел:");
int max = GetDemension("Введите максимальное значение чисел:");

int[,] matrix = GetMatrix(row, col, min, max);
PrintMatrix(matrix);
double[] arithmeticMean = GetArithmeticMean(matrix);
PrintArray(arithmeticMean);