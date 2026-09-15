using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* n1
            Console.WriteLine("Введите кол-во секунд: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int h = k / 3600;
            int m = (k % 3600) / 60;
            int s = k % 60;
            Console.WriteLine("Итого: {0} часов, {1} минут, {2} секунд", h, m, s); 
            */
            /* n2
            Console.WriteLine("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите h: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double s = (a + b) / 2 * h;
            Console.WriteLine("Площадь трапеции: {0}", s);
            double v = Math.PI * h * (a * a + a * b + b * b) / 3;
            Console.WriteLine("Объем усеченного конуса: {0}", v);
            */
            /* n3
            Console.WriteLine("Введите R: ");
            double R = Convert.ToDouble(Console.ReadLine());
            double v = (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
            Console.WriteLine("Объем шара: {0}", v);
            double s = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Площадь круга: {0}", s);
            double q = v / s;
            Console.WriteLine("Соотношение между ними: {0}", q);
            */
            /* n4
            Console.WriteLine("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double m = (1.0 / 2.0) * Math.Sqrt(2 * Math.Pow(a, 2) + 2 * Math.Pow(b, 2) - Math.Pow(c, 2));
            Console.WriteLine("Длина медианы треугольника: {0}", m);
            */
            /* n5
            Console.WriteLine("Введите r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите l: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите h: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double s = Math.PI * r * (r + l);
            Console.WriteLine("Площадь поверхности конуса: {0}", s);
            double v = (1.0 / 3.0) * Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine("Объем конуса: {0}", v);
            */
            /* n6
            Console.WriteLine("Введите r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double v = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            double s = 4.0 * Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Объем шара: {0}", v);
            Console.WriteLine("Площадь поверхности: {0}", s);
            */
            /* n7
            Console.WriteLine("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double range = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Расстояние между точками: {0}", range);
            */
            /* n8
            Console.WriteLine("Введите первое число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double max = Math.Max(x, y);
            Console.WriteLine("Максимальное число: {0}", max);
            */
            /* n9
            Console.WriteLine("Переменная x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Переменная y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double change1 = (x - x) + y;
            double change2 = (y - y) + x;
            Console.WriteLine("Переменная x: {0} \nПеременная y: {1}\nПеременная x после смены значений: {2} \nПеременная y после смены значений: {3}", x, y, change1, change2);
            */
            /* n10
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            double avg = (x + y + z) / 3;
            Console.WriteLine("Среднее арифмитическое трех чисел: {0:F2}", avg);
            */
            /* n11
            Console.WriteLine("Введите стоимость товара x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость товара y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость товара z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            double discount = (x + y + z) * 0.13;
            Console.WriteLine("Общая сумма скидки: {0:f1}", discount);
            */
            /* n12
            Console.WriteLine("Введите трехзначное число x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int a = x / 100;
            int b = x / 10 % 10;
            int c = x % 10;
            int d = a + b + c;
            Console.WriteLine("Сумма трех чисел: {0}", d);
            */
            /* n13
            Console.WriteLine("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b, 2));
            Console.WriteLine("Гипотенуза: {0:f5}", c);
            */
        }
    }
}
