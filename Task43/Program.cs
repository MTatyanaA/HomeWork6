// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;
using static System.Console;

Clear();

Write("Введите b1: ");
int b1 = int.Parse(ReadLine());
Write("Введите k1: ");
int k1 = int.Parse(ReadLine());
Write("Введите b2: ");
int b2 = int.Parse(ReadLine());
Write("Введите k2: ");
int k2 = int.Parse(ReadLine());

pointOfIntersection(b1, k1, b2, k2);

void pointOfIntersection(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;

    if ((k1 * point[0] + b1) == (k2 * point[0] + b2)) {


        Write(" Точка пересечения");
        Write($"[{String.Join(", ", point)}]");
}
else
{
    WriteLine("Здесь нет никакого пересечения.");
}

} 
double ResultX(double a2,double a1, double b1,double b2) // метод поиска результата для оси ОХ
{
    return (a2-a1)/(b1-b2);
}
double ResultY(double a2,double a1, double b1,double b2) // метод поиска результата для оси ОУ
{
    return b2*((a2-a1)/(b1-b2)) +a2;
}
double Input1(string k1) // метод ввода коэффициентов для функции первой прямой
{
    Console.Write($"Введите коэффициенты для функции первой прямой {k1} ");
    return Convert.ToDouble(Console.ReadLine());   
}
double Input2(string k2) // метод ввода коэффициентов для функции второй прямой
{
    Console.Write($"Введите коэффициенты для функции второй прямой {k2} ");
    return Convert.ToDouble(Console.ReadLine()); 
}

