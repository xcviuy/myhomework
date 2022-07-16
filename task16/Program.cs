// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введи число М (количество чисел): ");
int count = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[count];

void InputNumbers(int count)
{
for (int i = 0; i < count; i++)
  {
    Console.Write("Введите " + (i+1) + " число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] massiveNumbers)
{
  int sum = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) sum += 1; 
  }
  return sum;
}

InputNumbers(count);

Console.WriteLine("Всего чисел больше 0: " + Comparison(massiveNumbers));

