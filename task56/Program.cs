// // Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов. 

Console.WriteLine("введите m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int [m,n];
Random random = new Random();
if (m!=n)
Console.WriteLine("Массив не прямоугольный");
else
{
 for( int i=0; i<m; i++)
 {
    for( int j=0; j<n; j++)
    {
    array2d[i,j] = random.Next(-10,10);
    Console.Write(array2d[i,j]+" ");
    }
 }
}
 Console.WriteLine();

void NumberLine(int[,] array)
{
    int minLine = 0;
    int minSumLine = 0;
    int sumLine = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minLine += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumLine += array[i, j];
        if (sumLine < minLine)
        {
            minLine = sumLine;
            minSumLine = i;
        }
        sumLine = 0;
    }
    Console.Write($"{minSumLine + 1} строка");
}
NumberLine(array2d);