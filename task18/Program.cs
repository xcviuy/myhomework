// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int[,] array = new int[m, n];
array = changeArray(array);
double[,] arrayDouble = new double[m, n];
PrintArray(array);

Console.Write();
for (int i = 0; i < n; i++)
{
  int arithmeticNumbers = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticNumbers += array[j, i];
  }
  arithmeticNumbers = Math.Round(arithmeticNumbers / m, 1);
  Console.WriteLine($"столбца № {i+1} {arithmeticNumbers}");
}

int[,] changeArray (double[,] array)
{
  int[,] array = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return array;
}

void PrintArray(double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
       Console.Write(array[i, j] + " ");
      }
      Console.WriteLine();
  }
}

 