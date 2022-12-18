//// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива

Console.WriteLine("введите m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int [m,n];
Random random = new Random();
 for( int i=0; i<m; i++)
 {
    for( int j=0; j<n; j++)
    {
    array2d[i,j] = random.Next(-10,10);
    Console.Write(array2d[i,j]+" ");
    }
 }
 Console.WriteLine();

 void SortValue(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
        {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
            if (array[i, z] < array[i, z + 1])
            {
            int temp = array[i, z + 1];
            array[i, z + 1] = array[i, z];
            array[i, z] = temp;
            }
            }
        }
    }
}
SortValue(array2d);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array2d[i,j]);
    }
}
