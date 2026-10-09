using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //n1

            //int n = int.Parse(Console.ReadLine());
            //int[] X = new int[n];

            //for (int i = 0; i < n; i++)
            //    X[i] = int.Parse(Console.ReadLine());

            //int M = int.Parse(Console.ReadLine());
            //int count = 0;

            //for (int i = 0; i < n; i++)
            //    if (Math.Abs((long)X[i]) > M)
            //        count++;

            //int[] Y = new int[count];
            //int j = 0;

            //for (int i = 0; i < n; i++)
            //    if (Math.Abs((long)X[i]) > M)
            //        Y[j++] = X[i];

            //Console.WriteLine("M = " + M);
            //Console.WriteLine("Массив X: " + string.Join(" ", X));
            //Console.WriteLine("Массив Y: " + string.Join(" ", Y));

            //n2
            //int[] a = new int[15];

            //for (int i = 0; i < 15; i++)
            //    a[i] = int.Parse(Console.ReadLine());

            //int count = 0;
            //int current = 0;
            //int max = 0;

            //for (int i = 0; i < 15; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        count++;
            //        current++;

            //        if (current > max)
            //            max = current;
            //    }
            //    else
            //        current = 0;
            //}

            //Console.WriteLine("Отрицательных чисел: " + count);
            //Console.WriteLine("Максимум подряд: " + max);


            //n3
            //int[] a = new int[15];

            //for (int i = 0; i < 15; i++)
            //    a[i] = int.Parse(Console.ReadLine());

            //int max = a[0];
            //int count = 0;

            //for (int i = 1; i < 15; i++)
            //    if (a[i] > max)
            //        max = a[i];

            //for (int i = 0; i < 15; i++)
            //    if (a[i] == max)
            //        count++;

            //Console.WriteLine("Максимум: " + max);
            //Console.WriteLine("Количество повторений: " + count);

            //n4
            //Console.WriteLine("Введите кол-во повторений: ");
            //int n = int.Parse(Console.ReadLine());
            //int x = int.Parse(Console.ReadLine());
            //int[] prices = new int[n];

            //for (int i = 0; i < n; i++)
            //    prices[i] = int.Parse(Console.ReadLine());

            //int min = int.MaxValue;
            //int max = int.MinValue;

            //for (int i = 0; i < n; i++)
            //{
            //    if (prices[i] < x)
            //        prices[i] = prices[i] * 97 / 100;
            //    else
            //        prices[i] = prices[i] * 95 / 100;

            //    if (prices[i] < min)
            //        min = prices[i];

            //    if (prices[i] > max)
            //        max = prices[i];
            //}

            //Console.WriteLine("Цены: " + string.Join(" ", prices));
            //Console.WriteLine("Минимальная цена: " + min);
            //Console.WriteLine("Максимальная цена: " + max);

            //n5
            //Console.WriteLine("Введите кол-во элементов: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];

            //for (int i = 0; i < n; i++)
            //    a[i] = int.Parse(Console.ReadLine());

            //int max = a[0];

            //for (int i = 1; i < n; i++)
            //    if (a[i] > max)
            //        max = a[i];

            //Console.WriteLine("Максимум: " + max);
            //Console.WriteLine("Обратный порядок:");

            //for (int i = n - 1; i >= 0; i--)
            //    Console.Write(a[i] + " ");


            //n6
            //Console.WriteLine("Введите кол-во элементов: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] D = new int[n];

            //for (int i = 0; i < n; i++)
            //    D[i] = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i < n; i += 2)
            //    sum += D[i];

            //Console.WriteLine("Массив D: " + string.Join(" ", D));
            //Console.WriteLine("Сумма: " + sum);


            //n7
            //Console.WriteLine("Введите кол-во элементов: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];

            //for (int i = 0; i < n; i++)
            //    a[i] = int.Parse(Console.ReadLine());

            //bool found = false;

            //for (int i = 0; i < n; i++)
            //{
            //    bool alreadyPrinted = false;

            //    for (int k = 0; k < i; k++)
            //        if (a[k] == a[i])
            //            alreadyPrinted = true;

            //    if (alreadyPrinted)
            //        continue;

            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (a[i] == a[j])
            //        {
            //            Console.WriteLine(a[i]);
            //            found = true;
            //            break;
            //        }
            //    }
            //}

            //if (!found)
            //    Console.WriteLine("Повторяющихся элементов нет");


            //n8
            //int[,] a = new int[3, 4];
            //int product = 1;
            //bool found = false;

            //for (int i = 0; i < 3; i++)
            //    for (int j = 0; j < 4; j++)
            //        a[i, j] = int.Parse(Console.ReadLine());

            //for (int i = 0; i < 3; i++)
            //    for (int j = 0; j < 4; j++)
            //        if (a[i, j] > 0)
            //        {
            //            product *= a[i, j];
            //            found = true;
            //        }

            //if (found)
            //    Console.WriteLine("Произведение положительных: " + product);
            //else
            //    Console.WriteLine("Положительных элементов нет");

            //for (int i = 0; i < 3; i++)
            //{
            //    int max = a[i, 0];

            //    for (int j = 1; j < 4; j++)
            //        if (a[i, j] > max)
            //            max = a[i, j];

            //    Console.WriteLine("Максимум строки " + (i + 1) + ": " + max);
            //}

            //n9 
            //Console.WriteLine("Введите размеры массива (n на m): ");
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int[,] a = new int[n, m];

            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < m; j++)
            //        a[i, j] = int.Parse(Console.ReadLine());

            //bool found = false;

            //for (int i = 0; i < n; i++)
            //{
            //    if (m < 2)
            //        continue;

            //    int difference = a[i, 1] - a[i, 0];
            //    bool valid = difference < 0;

            //    for (int j = 2; j < m; j++)
            //        if ((long)a[i, j] - a[i, j - 1] != difference)
            //            valid = false;

            //    if (valid)
            //    {
            //        Console.WriteLine("Строка: " + (i + 1));
            //        found = true;
            //    }
            //}

            //if (!found)
            //    Console.WriteLine("Таких строк нет");

            //n10
            //Console.WriteLine("Введите размеры массива (n на m): ");
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int[,] a = new int[n, m];

            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < m; j++)
            //        a[i, j] = int.Parse(Console.ReadLine());

            //bool found = false;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int k = i + 1; k < n; k++)
            //    {
            //        bool equal = true;

            //        for (int j = 0; j < m; j++)
            //            if (a[i, j] != a[k, j])
            //                equal = false;

            //        if (equal)
            //        {
            //            Console.WriteLine(
            //                "Строки " + (i + 1) + " и " + (k + 1));
            //            found = true;
            //        }
            //    }
            //}

            //if (!found)
            //    Console.WriteLine("Одинаковых строк нет");

            //n11
            //Console.WriteLine("Введите размеры массива (n на m): ");
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int[,] a = new int[n, m];

            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < m; j++)
            //        a[i, j] = int.Parse(Console.ReadLine());

            //bool found = false;

            //for (int j = 0; j < m; j++)
            //{
            //    int sum = 0;
            //    int product = 1;

            //    for (int i = 0; i < n; i++)
            //    {
            //        sum += a[i, j];
            //        product *= a[i, j];
            //    }

            //    if (sum > product)
            //    {
            //        Console.WriteLine("Столбец: " + (j + 1));
            //        found = true;
            //    }
            //}

            //if (!found)
            //    Console.WriteLine("Подходящих столбцов нет");

            //n12 
            //Console.WriteLine("Введите размер массива (n на n): ");
            //int n = int.Parse(Console.ReadLine());
            //int[,] a = new int[n, n];

            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < n; j++)
            //        a[i, j] = int.Parse(Console.ReadLine());

            //int sum = 0;
            //int count = 0;

            //for (int i = 0; i < n; i++)
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        sum += a[i, j];
            //        count++;
            //    }

            //if (count > 0)
            //    Console.WriteLine("Среднее: " + (double)sum / count);
            //else
            //    Console.WriteLine("Нет элементов выше диагонали");

            //n13
            //Console.WriteLine("Введите размеры массива (n на m): ");
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int[,] a = new int[n, m];

            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < m; j++)
            //        a[i, j] = int.Parse(Console.ReadLine());

            //bool found = false;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        int minRow = a[i, 0];
            //        int maxRow = a[i, 0];
            //        int minColumn = a[0, j];
            //        int maxColumn = a[0, j];

            //        for (int k = 0; k < m; k++)
            //        {
            //            if (a[i, k] < minRow)
            //                minRow = a[i, k];

            //            if (a[i, k] > maxRow)
            //                maxRow = a[i, k];
            //        }

            //        for (int k = 0; k < n; k++)
            //        {
            //            if (a[k, j] < minColumn)
            //                minColumn = a[k, j];

            //            if (a[k, j] > maxColumn)
            //                maxColumn = a[k, j];
            //        }

            //        if ((a[i, j] == minRow && a[i, j] == maxColumn) ||
            //            (a[i, j] == maxRow && a[i, j] == minColumn))
            //        {
            //            Console.WriteLine(
            //                "Значение: " + a[i, j] +
            //                ", строка: " + (i + 1) +
            //                ", столбец: " + (j + 1));

            //            found = true;
            //        }
            //    }
            //}

            //if (!found)
            //    Console.WriteLine("Седловых точек нет");

            //n14
            //Console.WriteLine("Введите размер массива (n на n): ");
            //int n = int.Parse(Console.ReadLine());
            //int[,] a = new int[n, n];

            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < n; j++)
            //        a[i, j] = int.Parse(Console.ReadLine());

            //int target = 0;

            //for (int j = 0; j < n; j++)
            //    target += a[0, j];

            //bool magic = true;

            //for (int i = 0; i < n; i++)
            //{
            //    int sum = 0;

            //    for (int j = 0; j < n; j++)
            //        sum += a[i, j];

            //    if (sum != target)
            //        magic = false;
            //}

            //for (int j = 0; j < n; j++)
            //{
            //    int sum = 0;

            //    for (int i = 0; i < n; i++)
            //        sum += a[i, j];

            //    if (sum != target)
            //        magic = false;
            //}

            //int diagonal1 = 0;
            //int diagonal2 = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    diagonal1 += a[i, i];
            //    diagonal2 += a[i, n - 1 - i];
            //}

            //if (diagonal1 != target || diagonal2 != target)
            //    magic = false;

            //if (magic)
            //    Console.WriteLine("Магический квадрат");
            //else
            //    Console.WriteLine("Не является магическим квадратом");

            //n15
            //Console.WriteLine("Введите размеры массива (n на m): ");
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int[,] a = new int[n, m];

            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < m; j++)
            //        a[i, j] = int.Parse(Console.ReadLine());

            //int maxRow = 0;
            //int maxColumn = 0;

            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < m; j++)
            //        if (a[i, j] > a[maxRow, maxColumn])
            //        {
            //            maxRow = i;
            //            maxColumn = j;
            //        }

            //for (int j = 0; j < m; j++)
            //{
            //    int temp = a[0, j];
            //    a[0, j] = a[maxRow, j];
            //    a[maxRow, j] = temp;
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    int temp = a[i, 0];
            //    a[i, 0] = a[i, maxColumn];
            //    a[i, maxColumn] = temp;
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //        Console.Write(a[i, j] + "\t");

            //    Console.WriteLine();
            //}

            //n16
            //Console.WriteLine("Введите размеры массива (n на m): ");
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int[,] a = new int[n, m];

            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < m; j++)
            //        a[i, j] = int.Parse(Console.ReadLine());

            //int[] sums = new int[m];

            //for (int j = 0; j < m; j++)
            //{
            //    int sum = 0;
            //    int max = a[0, j];
            //    bool hasEven = false;

            //    for (int i = 0; i < n; i++)
            //    {
            //        if (a[i, j] % 2 == 0)
            //        {
            //            sum += a[i, j];
            //            hasEven = true;
            //        }

            //        if (a[i, j] > max)
            //            max = a[i, j];
            //    }

            //    if (hasEven)
            //        sums[j] = sum;
            //    else
            //        sums[j] = max;
            //}

            //for (int j = 0; j < m - 1; j++)
            //{
            //    for (int k = j + 1; k < m; k++)
            //    {
            //        if (sums[j] < sums[k])
            //        {
            //            int tempSum = sums[j];
            //            sums[j] = sums[k];
            //            sums[k] = tempSum;

            //            for (int i = 0; i < n; i++)
            //            {
            //                int temp = a[i, j];
            //                a[i, j] = a[i, k];
            //                a[i, k] = temp;
            //            }
            //        }
            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //        Console.Write(a[i, j] + "\t");

            //    Console.WriteLine();
            //}

            //Console.WriteLine("Суммы столбцов: " + string.Join(" ", sums));
        }
    }
}
