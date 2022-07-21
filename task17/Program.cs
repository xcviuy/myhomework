Console.Write("Введите m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows, columns];

FillArray(array);
PrintArray(array);

Console.WriteLine();

void FillArray(double[,] array)
{
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void PrintArray(double[,] array){
for (int i = 0; i < rows; i++)
  {
      for (int j = 0; j < columns; j++)
      {
        double numbers = Math.Round(array[i, j], 1);
        Console.Write(numbers + " ");
      }
      Console.WriteLine();
  }
}
