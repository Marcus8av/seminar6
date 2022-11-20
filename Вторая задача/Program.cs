/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

System.Console.WriteLine("Введите значение к1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение к2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
    
double X (double k1, double b1, double k2, double b2)
{
double x = 0;
x = (b2 - b1) / (k1 - k2);
return x;
}

double Y (double k1, double b1)
{
double y = 0;
y = X(k1, b1, k2, b2) * k1 + b1;
return y;
}

System.Console.WriteLine($"Точка пересечения двух прямых = ({X(k1, b1, k2, b2)}; {Y(k1, b1)})");



