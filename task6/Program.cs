// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int result = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(result);
if (result > 99)
{
    Console.WriteLine(str[2]); // 0, 1, 2-(3)
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}