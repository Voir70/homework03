/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */



int x1 = ReadInt("Введите координату X первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");


double sum1 = Math.Pow((x2 - x1), 2);
double sum2 = Math.Pow((y2 - y1), 2);
double sum3 = Math.Pow((z2 - z1), 2);

double length = Math.Sqrt(sum1 + sum2 + sum3);
Console.WriteLine($"Длинна отрезка {length}");


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 