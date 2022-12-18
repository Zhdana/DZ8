//// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] CreateArray (int x, int y, int z) 
{
    int[,,] array3d = new int[x, y, z];
    Random random = new Random();   
    for (int i = 0; i < array3d.GetLength(0); i++) 
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
                {
                    array3d[i,j,k] = random.Next(10, 100);
                }
        }
    }
    return array3d;
} 


 

int[,,] array3D = CreateArray(2, 2, 2);


void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {

      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( "(" + i + j+ k + ")" + array3D[i,j,k]);
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
WriteArray (array3D);
