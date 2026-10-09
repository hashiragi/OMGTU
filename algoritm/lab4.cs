using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        //n1
        //static bool IsPrime(int n) //// проверка на простое число
        //{
        //    if (n < 2) return false;

        //    for (int i = 2; i * i <= n; i++)
        //        if (n % i == 0) return false;

        //    return true;
        //}

        //static int DigitSum(int n) //// сумма цифр
        //{
        //    n = Math.Abs(n);
        //    int sum = 0;

        //    while (n > 0)
        //    {
        //        sum += n % 10;
        //        n /= 10;
        //    }

        //    return sum;
        //}

        //static bool HasDigit2(int n) //// поиск двойки
        //{
        //    n = Math.Abs(n);

        //    while (n > 0)
        //    {
        //        if (n % 10 == 2) return true;
        //        n /= 10;
        //    }

        //    return false;
        //}

        //static void Main()
        //{
        //    int sum = 0, count = 0;

        //    Console.WriteLine("Введите числа (0 для окончания):");

        //    while (true)
        //    {
        //        int n = int.Parse(Console.ReadLine());

        //        if (n == 0) break;

        //        if (IsPrime(DigitSum(n)))
        //            sum += n;

        //        if (n > 0 && HasDigit2(n))
        //            count++;
        //    }

        //    Console.WriteLine("Сумма чисел: " + sum);
        //    Console.WriteLine("Количество положительных чисел с цифрой 2: " + count);
        //}

        //n2
        //static void Main()
        //{
        //    Console.Write("Введите натуральное число: ");
        //    int n = int.Parse(Console.ReadLine());

        //    int product = 1;

        //    while (n > 0)
        //    {
        //        product *= n % 10;
        //        n /= 10;
        //    }

        //    Console.WriteLine("Произведение цифр: " + product);
        //}

        //n3 

        //static int CountOddDigits(int n) //// считаем нечет цифры
        //{
        //    n = Math.Abs(n);
        //    int count = 0;

        //    while (n > 0)
        //    {
        //        int digit = n % 10;

        //        if (digit % 2 != 0)
        //            count++;

        //        n /= 10;
        //    }

        //    return count;
        //}

        //static void Main()
        //{
        //    int max = int.MinValue;
        //    int position = 0;
        //    int currentPosition = 0;

        //    Console.WriteLine("Введите числа (0 для окончания):");

        //    while (true)
        //    {
        //        int n = int.Parse(Console.ReadLine());

        //        if (n == 0) break;

        //        currentPosition++;

        //        if (n < 0 && CountOddDigits(n) % 2 == 0)
        //        {
        //            if (n > max)
        //            {
        //                max = n;
        //                position = currentPosition;
        //            }
        //        }
        //    }

        //    if (position == 0)
        //        Console.WriteLine("Подходящих чисел нет.");
        //    else
        //    {
        //        Console.WriteLine("Порядковый номер: " + position);
        //        Console.WriteLine("Число: " + max);
        //    }
        //}

        //n4

        //static void Main()
        //{
        //    int count = 0;

        //    Console.WriteLine("Введите неотрицательные числа.");
        //    Console.WriteLine("Отрицательное число завершает ввод.");

        //    double previous = double.Parse(Console.ReadLine());

        //    if (previous < 0)
        //    {
        //        Console.WriteLine("Последовательность пуста.");
        //        return;
        //    }

        //    double current = double.Parse(Console.ReadLine());

        //    if (current < 0)
        //    {
        //        Console.WriteLine("Количество: 0");
        //        return;
        //    }

        //    while (true)
        //    {
        //        double next = double.Parse(Console.ReadLine());

        //        if (next < 0) break;

        //        if (current > previous && current > next)
        //            count++;

        //        previous = current;
        //        current = next;
        //    }

        //    Console.WriteLine("Количество: " + count);
        //}

        //n5
        //static void Main()
        //{
        //    Console.Write("Введите число N: ");
        //    int n = int.Parse(Console.ReadLine());

        //    int count = 0;
        //    int sum = 0;

        //    while (n > 0)
        //    {
        //        int digit = n % 10;

        //        sum += digit;
        //        count++;

        //        n /= 10;
        //    }

        //    Console.WriteLine("Количество цифр: " + count);
        //    Console.WriteLine("Сумма цифр: " + sum);
        //}

        //n6

        //static void Main()
        //{
        //    Console.Write("Введите x: ");
        //    double x = double.Parse(Console.ReadLine());

        //    double eps = 0.00001;
        //    double sum = 1;
        //    double term = 1;
        //    int n = 1;

        //    while (n <= Math.Abs(x) || Math.Abs(term) > eps)
        //    {
        //        term *= x / n;
        //        sum += term;
        //        n++;
        //    }

        //    Console.WriteLine("Результат ряда: " + sum);
        //    Console.WriteLine("Math.Exp(x): " + Math.Exp(x));
        //}

        //n7
        //static void Main()
        //{
        //    Console.Write("Введите x в радианах: ");
        //    double x = double.Parse(Console.ReadLine());

        //    double eps = 0.00001;
        //    double sum = x;
        //    double term = x;
        //    int n = 1;

        //    while (n <= Math.Abs(x) || Math.Abs(term) > eps)
        //    {
        //        term *= -x * x / ((2 * n) * (2 * n + 1));
        //        sum += term;
        //        n++;
        //    }

        //    Console.WriteLine("Результат ряда: " + sum);
        //    Console.WriteLine("Math.Sin(x): " + Math.Sin(x));
        //}

        //n8

        //static void Main()
        //{
        //    Console.Write("Введите x в радианах: ");
        //    double x = double.Parse(Console.ReadLine());

        //    double eps = 0.0001;
        //    double sum = 1;
        //    double term = 1;
        //    int n = 1;

        //    while (n <= Math.Abs(x) || Math.Abs(term) > eps)
        //    {
        //        term *= -x * x / ((2 * n - 1) * (2 * n));
        //        sum += term;
        //        n++;
        //    }

        //    Console.WriteLine("Результат ряда: " + sum);
        //    Console.WriteLine("Math.Cos(x): " + Math.Cos(x));
        //}

        //n9

        //static void Main()
        //{
        //    Console.Write("Введите число: ");
        //    int n = int.Parse(Console.ReadLine());

        //    int product = 1;

        //    while (n > 0)
        //    {
        //        product *= n % 10;
        //        n /= 10;
        //    }

        //    Console.WriteLine("Произведение цифр: " + product);
        //}

        //n10

        //static void Main()
        //{
        //    int max = int.MinValue;
        //    int position = 0;
        //    int currentPosition = 0;

        //    Console.WriteLine("Введите числа (0 для окончания):");

        //    while (true)
        //    {
        //        int n = int.Parse(Console.ReadLine());

        //        if (n == 0) break;

        //        currentPosition++;

        //        if (n < 0 && n > max)
        //        {
        //            max = n;
        //            position = currentPosition;
        //        }
        //    }

        //    if (position == 0)
        //        Console.WriteLine("Отрицательных чисел нет.");
        //    else
        //    {
        //        Console.WriteLine("Порядковый номер: " + position);
        //        Console.WriteLine("Число: " + max);
        //    }
        //}

        //n11

        //static void Main()
        //{
        //    int count = 0;
        //    int previous = 0;
        //    bool first = true;

        //    Console.WriteLine("Введите числа (0 для окончания):");

        //    while (true)
        //    {
        //        int n = int.Parse(Console.ReadLine());

        //        if (n == 0) break;

        //        if (!first && Math.Sign(n) != Math.Sign(previous))
        //            count++;

        //        previous = n;
        //        first = false;
        //    }

        //    Console.WriteLine("Количество изменений знака: " + count);
        //}

        //n12

        //static void Main()
        //{
        //    int a = 1;
        //    int b = 1;
        //    int sum = 0;

        //    while (a <= 1000)
        //    {
        //        sum += a;

        //        int next = a + b;
        //        a = b;
        //        b = next;
        //    }

        //    Console.WriteLine("Сумма чисел Фибоначчи: " + sum);
        //}

        //n13

        static void Main()
        {
            Console.Write("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());

            int original = n;
            int reversed = 0;

            while (n > 0)
            {
                int digit = n % 10;
                reversed = reversed * 10 + digit;
                n /= 10;
            }

            if (original == reversed)
                Console.WriteLine("Число является палиндромом.");
            else
                Console.WriteLine("Число не является палиндромом.");
        }


    }
}
