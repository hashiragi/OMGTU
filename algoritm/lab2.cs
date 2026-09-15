using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //n1
            //Console.WriteLine("Введите число x: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число y: ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число z: ");
            //int z = int.Parse(Console.ReadLine());

            //if (x >= 1 && x <= 3) Console.WriteLine($"{x}");
            //if (y >= 1 && y <= 3) Console.WriteLine($"{y}");
            //if (z >= 1 && z <= 3) Console.WriteLine($"{z}");

            //n2
            //Console.WriteLine("Введите число x: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число y: ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число z: ");
            //int z = int.Parse(Console.ReadLine());
            //int min = Math.Min((Math.Min(x, y)), z);
            //Console.WriteLine($"Минимальное число {min}");

            //n3
            //Console.WriteLine("Введите год: ");
            //int y = int.Parse(Console.ReadLine());
            //if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
            //{
            //    Console.WriteLine("366 дней");
            //}
            //else Console.WriteLine("365 дней");

            //n4
            //Console.WriteLine("Введите стоимость покупки: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x >= 500 && x <= 999)
            //{
            //    double a = x * 0.03;
            //    Console.WriteLine($"Стоимость покупки, с учетом скидки: {a}. Скидка 500+ рублей.");
            //}
            //else if (x >= 1000)
            //{
            //    double b = x * 0.05;
            //    Console.WriteLine($"Стоимость покупки, с учетом скидки: {b}. Скидка 1000+ рублей.");
            //}


            //n5
            //Console.WriteLine("Введите число месяца: ");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Январь");
            //        break;
            //    case 2:
            //        Console.WriteLine("Февраль");
            //        break;
            //    case 3:
            //        Console.WriteLine("Март");
            //        break;
            //    case 4:
            //        Console.WriteLine("Апрель");
            //        break;
            //    case 5:
            //        Console.WriteLine("Май");
            //        break;
            //    case 6:
            //        Console.WriteLine("Июнь");
            //        break;
            //    case 7:
            //        Console.WriteLine("Июль");
            //        break;
            //    case 8:
            //        Console.WriteLine("Август");
            //        break;
            //    case 9:
            //        Console.WriteLine("Сентябрь");
            //        break;
            //    case 10:
            //        Console.WriteLine("Октябрь");
            //        break;
            //    case 11:
            //        Console.WriteLine("Ноябрь");
            //        break;
            //    case 12:
            //        Console.WriteLine("Декабрь");
            //        break;
            //    default: 
            //        Console.WriteLine("Такого месяца нет");
            //        break;
            //}



            //n6
            //Console.WriteLine("Введите первое число: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число: ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите третье число: ");
            //int z = int.Parse(Console.ReadLine());

            //int count = 0;

            //if (x > 0)
            //{
            //    count++;
            //}
            //if (y > 0)
            //{
            //    count++;
            //}
            //if (z > 0)
            //{
            //    count++;
            //}
            //Console.WriteLine($"Кол-во положительных чисел: {count}");


            //n7
            //Console.WriteLine("Введите первое число: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число: ");
            //int y = int.Parse(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("Первый квадрант");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("Второй квадрант");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("Третий квадрант");
            //}
            //else { Console.WriteLine("Четвёртый квадрант"); }

            //n8
            //Console.WriteLine("Введите цифру:");
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 0: 
            //        Console.WriteLine("Ноль");
            //        break;
            //    case 1:
            //        Console.WriteLine("Один");
            //        break;
            //    case 2:
            //        Console.WriteLine("Два");
            //        break;
            //    case 3:
            //        Console.WriteLine("Три");
            //        break;
            //    case 4:
            //        Console.WriteLine("Четыре");
            //        break;
            //    case 5:
            //        Console.WriteLine("Пять");
            //        break;
            //    case 6:
            //        Console.WriteLine("Шесть");
            //        break;
            //    case 7:
            //        Console.WriteLine("Семь");
            //        break;
            //    case 8:
            //        Console.WriteLine("Восемь");
            //        break;
            //    case 9:
            //        Console.WriteLine("Девять");
            //        break;
            //}


            //n9
            //Console.WriteLine("Введите число от 1 до 30: ");
            //int k = int.Parse(Console.ReadLine());
            //if (k >= 1 && k <= 30)
            //{
            //    int day = k % 7;
            //    switch (day) 
            //        {
            //        case 1:
            //            Console.WriteLine("Понедельник");
            //            break;
            //        case 2:
            //            Console.WriteLine("Вторник");
            //            break;
            //        case 3:
            //            Console.WriteLine("Среда");
            //            break;
            //        case 4:
            //            Console.WriteLine("Четверг");
            //            break;
            //        case 5:
            //            Console.WriteLine("Пятница");
            //            break;
            //        case 6:
            //            Console.WriteLine("Суббота");
            //            break;
            //        case 7:
            //            Console.WriteLine("Воскресенье");
            //            break;
            //    }
            //}
            //else { Console.WriteLine("Неверное число"); }

            //n10
            //Console.WriteLine("Введите номер фигуры: ");
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1:
            //        Console.WriteLine("Введите радиус круга: ");
            //        double r1 = Convert.ToDouble(Console.ReadLine());
            //        double S = Math.PI * r1 * r1;
            //        Console.WriteLine($"Площадь круга: {S}");
            //        break;
            //    case 2:
            //        Console.WriteLine("Введите радиус шара: ");
            //        double r2 = Convert.ToDouble(Console.ReadLine());
            //        double V = (4.0 / 3.0) * Math.PI * r2 * r2 * r2;
            //        Console.WriteLine($"Объем шара: {V}");
            //        break;
            //    case 3:
            //        Console.WriteLine("Введите радиус цилиндра: ");
            //        double r3 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Введите высоту цилиндра: ");
            //        double h = Convert.ToDouble(Console.ReadLine());
            //        double Vc = Math.PI * r3 * r3 * h;
            //        Console.WriteLine($"Объем цилиндра: {Vc}");
            //        break;
            //    case 4:
            //        Console.WriteLine("Введите радиус сферы: ");
            //        double r4 = Convert.ToDouble(Console.ReadLine());
            //        double Ss = 4 * Math.PI * r4 * r4;
            //        Console.WriteLine($"Площадь поверхности сферы: {Ss}");
            //        break;
            //    default:
            //        Console.WriteLine("Такой фигуры нет");
            //        break;
            //}

            //n11
            //Console.WriteLine("Введите номер фигуры (1-3): ");
            //int N = Convert.ToInt32(Console.ReadLine());

            //switch (N)
            //{
            //    case 1:
            //        Console.WriteLine("Введите длину прямоугольника: ");
            //        double a = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Введите ширину прямоугольника: ");
            //        double b = Convert.ToDouble(Console.ReadLine());
            //        double S = a * b;
            //        Console.WriteLine($"Площадь прямоугольника: {S}");
            //        break;
            //    case 2:
            //        Console.WriteLine("Введите основание параллелограмма: ");
            //        double a2 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Введите высоту параллелограмма: ");
            //        double h2 = Convert.ToDouble(Console.ReadLine());
            //        double S2 = a2 * h2;
            //        Console.WriteLine($"Площадь параллелограмма: {S2}");
            //        break;
            //    case 3:
            //        Console.WriteLine("Введите первое основание трапеции: ");
            //        double a3 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Введите второе основание трапеции: ");
            //        double b3 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Введите высоту трапеции: ");
            //        double h3 = Convert.ToDouble(Console.ReadLine());
            //        double S3 = 0.5 * (a3 + b3) * h3;
            //        Console.WriteLine($"Площадь трапеции: {S3}");
            //        break;
            //    default:
            //        Console.WriteLine("Такой фигуры нет");
            //        break;
            //}


            //n12

            //Console.WriteLine("Введите число: ");
            //int n = int.Parse(Console.ReadLine());
            //int a = n % 5;
            //switch (a)
            //{
            //    case 0:
            //        Console.WriteLine("ноль");
            //        break;
            //    case 1:
            //        Console.WriteLine("один");
            //        break;
            //    case 2:
            //        Console.WriteLine("два");
            //        break;
            //    case 3:
            //        Console.WriteLine("Три");
            //        break;
            //    case 4:
            //        Console.WriteLine("четыре");
            //        break;
            //}

            //n13
            //double expr1 = 2 * Math.Pow(10 + Math.Pow(10, 1.0 / 10) + 2 * Math.Pow(10, -3),1.0 / 10);
            //double expr2 = Math.PI / 12 + Math.Asin(Math.Sqrt(3) / 2);
            //double func;
            //if (1 / expr1 > expr2)
            //{
            //    func = Math.Acos((expr1 - expr2) /(1 + expr1 * Math.Sin(expr2)));
            //}
            //else
            //{
            //    func = Math.Sin(expr2) / (expr1 * Math.Sqrt(expr1)) + Math.Exp(Math.Pow(expr1, 2) - 1);
            //}
            //Console.WriteLine($"expr1 = {expr1}");
            //Console.WriteLine($"expr2 = {expr2}");
            //Console.WriteLine($"func = {func}");

            //n14
            //Console.WriteLine("Вычисление функции");
            //double p = Math.Exp(Math.Pow(Math.Sin(2.0 / 3.0), 3)) + Math.Log(Math.Atan(2.0 / 3.0));
            //double q = 7.5 * Math.Pow(Math.Pow(2.8, 1.0 / 3.0),-8) - Math.Log10(1.6 * Math.Pow(1.2, 1.0 / 3.0));
            //double u;
            //double f;
            //if (Math.Pow(p, 2) > q)
            //{
            //    u = Math.Pow(Math.Pow(p, 2) - q,1.0 / 5.0);
            //    f = Math.Sin(Math.Pow(p, 2));
            //}
            //else
            //{
            //    u = 2 * Math.Asin(Math.Pow(p, 2) / q);
            //    f = Math.Sin(q);
            //}
            //Console.WriteLine($"p = {p}");
            //Console.WriteLine($"q = {q}");
            //Console.WriteLine($"u = {u}");
            //Console.WriteLine($"f = {f}");

            //n15
            //Console.WriteLine("Введите x: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите y: ");
            //double y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите z: ");
            //double z = Convert.ToDouble(Console.ReadLine());
            //double u = Math.Cos(
            //    Math.Abs(x + Math.Pow(Math.Abs(y), 1.0 / 3.0))) + Math.Sin(z - Math.Pow(x, 10) / (1 + Math.Pow(y, 2) + Math.Pow(z, 2))
            //);
            //double v = Math.Exp(-Math.Pow(x, 2)) + Math.Pow(Math.Abs(x + y + z), 1.0 / 7.0) + Math.Exp(y);
            //double t;
            //if (Math.Pow(u, 2) + Math.Pow(v, 2) >= 5)
            //{
            //    t = Math.Log(v, 2) + Math.Pow(u, 2) + Math.Pow(5, 1.0 / 5.0);
            //}
            //else
            //{
            //    t = Math.Log(v) + Math.Pow(u, 2.0 / 3.0) + Math.Sin(Math.Sqrt(5));
            //}
            //Console.WriteLine($"u = {u}");
            //Console.WriteLine($"v = {v}");
            //Console.WriteLine($"t = {t}");

            //n16
            //Console.WriteLine("Введите x: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите y: ");
            //double y = Convert.ToDouble(Console.ReadLine());
            //double f;
            //if (Math.Abs(x) >= Math.Abs(y))
            //{
            //    f = Math.Log(Math.Abs(x + y)) / (Math.Log(Math.Abs(x)) + Math.Log(Math.Abs(y))) - Math.Sin(Math.Pow(Math.Pow(x, 8) + Math.Pow(y, 4),1.0 / 5.0));
            //}
            //else
            //{
            //    f = Math.Asin(Math.Abs(x) / Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) + Math.Exp(Math.Cos(Math.Sqrt(Math.Abs(x + y))));
            //}
            //double u;
            //double sum = Math.Pow(x, 8) + Math.Pow(y, 8);
            //double value = Math.Abs(x - y / sum);
            //if (sum >= 12)
            //{
            //    u = Math.Sin(value);
            //}
            //else
            //{
            //    u = Math.Cos(value);
            //}
            //Console.WriteLine($"f = {f:F4}");
            //Console.WriteLine($"u = {u:F4}");
        }
    }
}
