// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void FindPoint(double a1, double b1, double a2, double b2)
{
    //a1*x + b1 = a2*x + b2
    //x = (b2-b1)/(a1-a2)
    if(a1-a2 == 0)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
    double x = (b2-b1)/(a1-a2);
    double y = a1*x + b1;
    Console.WriteLine("Точка пересечения прямых = ("+x+";"+y+")");
    }
}
Console.WriteLine("Введите коэфициент а1 = ");
double a1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите коэфициент b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите коэфициент а2 = ");
double a2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите коэфициент b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

FindPoint(a1, b1, a2, b2);

