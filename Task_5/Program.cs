/*
задан двумерный массив. найти сумму элементов, расположенных на главной диагонали
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
int firstDemension = GetDemension("Введите размер первого разряда: ");
int secondDemention = GetDemension("Введите размер второго разряда: ");
int [,] array = InitMatrix(firstDemension, secondDemention);
PrintArray(array);
Console.WriteLine();
int sum = GetSumDiagonal(array);
Console.WriteLine(sum);


int GetSumDiagonal(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + arr[i,j];
                Console.WriteLine(arr[i,j]);
            }
        }
        
    }  
    return sum;  
}

int GetDemension(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}


int [,] InitMatrix(int firstDemension, int secondDemension)
{
    int [,] matrix = new int[firstDemension, secondDemension];
    Random rnd = new Random();
    for(int i = 0; i < firstDemension; i++)
        {
            for(int j = 0; j < secondDemension; j++)
                matrix[i, j] = rnd.Next(1,20);
        }

    return matrix;
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}  ");
        }
        System.Console.WriteLine();
    }    
}

