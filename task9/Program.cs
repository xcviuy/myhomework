// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int n = InputInt("Введите число: ");
int min = 1;
while(min <= n)
{
int result = Quadro(min);
Console.Write(result + " ");
min++;
}

int InputInt(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}

int Quadro(int number)
{
return number * number * number;
}

