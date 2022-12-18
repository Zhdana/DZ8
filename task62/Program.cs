//// // Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array2d = new int[4, 4];

int value = 1;
int i = 0;
int j = 0;

while (value <= array2d.GetLength(0) * array2d.GetLength(1))
{
  array2d[i, j] = value;
  value++;
  if (i <= j + 1 && i + j < array2d.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array2d.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array2d.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(array2d);

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

