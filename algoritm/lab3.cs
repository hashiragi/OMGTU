using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //n1
            //Console.WriteLine("Введите цену: ");
            //double price = double.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} кг = {price * i}");
            //}

            ////n2
            //Console.WriteLine("Введите a: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите b: ");
            //int b = int.Parse(Console.ReadLine());

            //int sum = 0;
            //int count = 0;

            //for (int i = a; i <= b; i++)
            //{
            //    sum += i;
            //    count++;
            //}
            //double avg = sum / count;
            //Console.WriteLine(avg);

            //n3
            //double sum = 0;

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine($"Введите стоимость товара {i}: ");
            //    int price = int.Parse(Console.ReadLine());
            //    sum += price;
            //}
            //double avg = sum / 20;
            //Console.WriteLine($"Средняя стоимость товара: {avg}");

            //n4
            //int cells = 1;

            //for (int i = 3; i <= 24; i += 3)
            //{
            //    cells *= 2;
            //    Console.WriteLine($"Через {i} часов, {cells} клеток");
            //}

            //n5
            //a)
            //double start = 10;

            //for (int day = 2; day <= 10; day++)
            //{
            //    start *= 1.1;
            //    Console.WriteLine($"{day} день: {start} км");
            //}

            //b)
            //double start = 10;
            //double total = 0;
            //for (int day = 1; day <= 7; day++)
            //{
            //    if (day > 1)
            //    {
            //        start *= 1.1;
            //    }
            //    total += start;
            //}
            //Console.WriteLine($"Суммарный путь: {total} км");

            //n6
            //Console.WriteLine("Введите количество чисел: ");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int positive = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    sum += num;

            //    if (num > 0)
            //    {
            //        positive++;
            //    }
            //}
            //Console.WriteLine($"Сумма: {sum}");
            //Console.WriteLine($"Положительных чисел: {positive}");

            //n7
            //double x = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    x += 1.0 / i;
            //}
            //Console.WriteLine(x);

            //n8
            //double z = 1;
            //for (int i = 2; i <= 20; i+=2)
            //{
            //    z *= i;
            //}
            //Console.WriteLine(z);

            //n9
            //Console.WriteLine("Введите число: ");
            //double x = double.Parse(Console.ReadLine());
            //double y = 0;

            //for (int i = 1; i <= 9; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        y += i * i * x;
            //    }
            //    else
            //    {
            //        y -= i * i * x;
            //    }
            //}
            //Console.WriteLine(y);

            //n10
            //Console.WriteLine("Введите число: ");
            //double x = double.Parse(Console.ReadLine());
            //double y = 0;

            //for (int i = 1; i <= 17; i += 2)
            //{
            //    y += x / i;
            //}
            //Console.WriteLine(y);

            //n11
            //Console.WriteLine("Введите число: ");
            //double n = double.Parse(Console.ReadLine());
            //double y = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    y *= i;
            //}
            //Console.WriteLine(y);

            //n12

            //double y = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        y += Math.Pow(3, i);
            //    }
            //    else
            //    {
            //        y -= Math.Pow(3, i);
            //    }
            //}
            //Console.WriteLine(y);

            //n13

            //int n = int.Parse(Console.ReadLine());

            //double[] a = new double[n];

            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //}

            //int count = 0;

            //for (int i = 1; i < n - 1; i++)
            //{
            //    if (a[i] > a[i - 1] && a[i] > a[i + 1])
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //n14
            //int n = int.Parse(Console.ReadLine());

            //int[] a = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}

            //int count = 0;

            //for (int i = 1; i < n; i++)
            //{
            //    if ((a[i - 1] > 0 && a[i] < 0) ||
            //        (a[i - 1] < 0 && a[i] > 0))
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //n15
            //Console.WriteLine("Задайте натуральное число: ");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i < n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        sum += i;
            //    }
            //}

            //if (sum == n)
            //{
            //    Console.WriteLine("Число совершенное");
            //}
            //else
            //{
            //    Console.WriteLine("Число не является совершенным");
            //}
        }
    }
}
