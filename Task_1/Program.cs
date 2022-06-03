// Разворот массива

void PrintArray(int[]arr)
{
foreach(int item in arr)
{
Console.Write(item + " ");
}
}


int [] arr = new int [4]{1,2,3,4};

PrintArray(arr);
Console.WriteLine();
Console.WriteLine("==========================");

int[] result = arr.Reverse().ToArray();
PrintArray(result);
