/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/ //                                                  0  1  2  3
Console.WriteLine("введите коэффициэнты через пробел: b1 k1 b2 k2");
double[] mas = Console.ReadLine().Split().Select(double.Parse).ToArray();
double x=0, y=0;
if (mas[1]==mas[3]) Console.WriteLine("прямые параллельны т.к k1=k2");
else 
{
    x=(mas[0]-mas[2])/(mas[3]-mas[1]);
    y=mas[1]*x+mas[0];
    Console.WriteLine($"координаты точки пересечения ({x}, {y})");
}
