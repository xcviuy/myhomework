﻿// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53 

int x1 = InputInt("Введите X1: ");
int y1 = InputInt("Введите Y1: ");
int z1 = InputInt("Введите Z1: ");

int x2 = InputInt("Введите X2: ");
int y2 = InputInt("Введите Y2: ");
int z2 = InputInt("Введите Z2: ");


int distanceX = x1 - x2;
int distanceY = y1 - y2;
int distanceZ = z1 - z2;

double distance = Math.Sqrt(Quadro(distanceX) + Quadro(distanceY) + Quadro(distanceZ));
Console.WriteLine(distance);

int InputInt(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}

int Quadro(int number)
{
return number * number;
} 

