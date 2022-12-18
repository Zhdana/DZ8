// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
Console.WriteLine("введите m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] firstarray2d = new int [m,n];
int[,] secondarray2d = new int [m,n];
Random random = new Random();
 for( int i=0; i<m; i++)
 {
    for( int j=0; j<n; j++)
    {
    firstarray2d[i,j] = random.Next(-10,10);
       
    }
 }
 for( int i=0; i<m; i++)
 {
    for( int j=0; j<n; j++)
    {
    secondarray2d[i,j] = random.Next(-10,10);
        
    }
 }
 int[,] resultarray = new int[m,n];
 void Сomposition(int[,] firstarray, int[,] secondarray, int[,] resultarray)
{
  for (int i = 0; i < resultarray.GetLength(0); i++)
  {
    for (int j = 0; j < resultarray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstarray.GetLength(1); k++)
      {
        sum += firstarray[i,k] * secondarray[k,j];
      }
      resultarray[i,j] = sum;
    }
  }
}

Сomposition(firstarray2d, secondarray2d, resultarray);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
WriteArray(firstarray2d);
WriteArray(secondarray2d);
Console.WriteLine("Произведение первой и второй матриц:");
WriteArray(resultarray);