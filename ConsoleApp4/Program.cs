using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Первая задача

            int[] A = new int[5];
            double[,] B = new double[3, 4];
            Random r = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    B[i, j] = r.NextDouble() * 100;
            Console.WriteLine($"Entry {A.Length} number");
            for (int i = 0; i < A.Length; i++)
                A[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Array a ");
            for (int i = 0; i < A.Length; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine("\n");
            Console.WriteLine("Array B");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                    Console.Write("{0:F2} ", B[i, j]);
                Console.WriteLine();
            }
            double min = A[0], max = 0;
            double sum = 0, multi = 1;
            double sum_pA = 0, sum_upB = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (min > A[i])
                    min = A[i];
                if (max < A[i])
                    max = A[i];
                sum += A[i];
                multi *= A[i];
                if (A[i] % 2 == 0)
                    sum_pA += A[i];
            }
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (min > B[i, j])
                        min = B[i, j];
                    if (max < B[i, j])
                        max = B[i, j];
                    sum += B[i, j];
                    multi *= B[i, j];
                    if (j % 2 != 0)
                        sum_upB += B[i, j];
                }
            Console.WriteLine();
            Console.WriteLine("Минимум  = {0:F2}, Максимум = {1:F2}, Сумма = {2:F2}\n Произведение  = {3:F2}, Четное_A = {4}, Четное_B = {5:F2}", min, max, sum, multi, sum_pA, sum_upB);
            #endregion

            #region Вторая задача 

            int[,] arr2 = new int[5, 5];
            int sum_2 = 0;
            int iMin = 0, iMax = 0;
            int jMin = 0, jMax = 0;
            int min_2 = arr2[0, 0];
            int max_2 = arr2[0, 0];
            bool count = false;
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = r.Next(-100, 100);
                    Console.Write("{0,4}", arr2[i, j]);
                    if (arr2[i, j] < min_2)
                    {
                        min_2 = arr2[i, j];
                        iMin = i;
                        jMin = j;
                    }
                    if (arr2[i, j] > max_2)
                    {
                        max_2 = arr2[i, j];
                        iMax = i;
                        jMax = j;
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if ((i == iMax && j == jMax) || (i == iMin && j == jMin))
                    {
                        if (count)
                        {
                            count = false;
                            continue;
                        }
                        else
                        {
                            count = true;
                            continue;
                        }
                    }
                    if (count)
                    {
                        sum_2 += arr2[i, j];
                    }
                }
            }
            Console.WriteLine("Minimum {0}", min);
            Console.WriteLine("Maximum {0}", max);
            Console.WriteLine("Summa  {0}", sum_2);
            #endregion

            #region Третья задача


            Console.WriteLine("Entry text ");
            string text = Console.ReadLine();
            char[] buf = new char[256];
            Console.WriteLine("Entry meaning ");
            int crypt = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < text.Length; i++)
            {
                buf[i] = text[i];
                buf[i] += Convert.ToChar(crypt);
            }
            Console.Write("encrypted view ");
            Console.WriteLine(buf);
            for (int i = 0; i < text.Length; i++)
                buf[i] -= Convert.ToChar(crypt);
            Console.Write($"decoded view  ");
            Console.WriteLine(buf);
            #endregion

            #region Четвертая задача

            int[,] arr_1 = new int[3, 3];
            int[,] arr_2 = new int[3, 3];
            for (int i = 0; i < arr_1.GetLength(0); i++)
                for (int j = 0; j < arr_1.GetLength(1); j++)
                {
                    arr_1[i, j] = r.Next(1, 20);
                    arr_2[i, j] = r.Next(1, 20);
                }
            Console.WriteLine("Array A");
            for (int i = 0; i < arr_1.GetLength(0); i++)
            {
                for (int j = 0; j < arr_1.GetLength(1); j++)
                    Console.Write("{0} ", arr_1[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("\nArray B");
            for (int i = 0; i < arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < arr_2.GetLength(1); j++)
                    Console.Write("{0} ", arr_2[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("Choose what you need to do :\n1 -Multiplying a Matrix by a Number \n2 - Matrix addition\n3 - Product of matrices");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {
                Console.Write("Entry number ");
                int c_multi = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < arr_1.GetLength(0); i++)
                    for (int j = 0; j < arr_1.GetLength(1); j++)
                        arr_1[i, j] *= c_multi;
                for (int i = 0; i < arr_2.GetLength(0); i++)
                    for (int j = 0; j < arr_2.GetLength(1); j++)
                        arr_2[i, j] *= c_multi;
                Console.WriteLine("Result ");
                Console.WriteLine("Array A");
                for (int i = 0; i < arr_1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr_1.GetLength(1); j++)
                        Console.Write("{0} ", arr_1[i, j]);
                    Console.WriteLine();
                }
                Console.WriteLine("\nArray B");
                for (int i = 0; i < arr_2.GetLength(0); i++)
                {
                    for (int j = 0; j < arr_2.GetLength(1); j++)
                        Console.Write("{0} ", arr_2[i, j]);
                    Console.WriteLine();
                }
            }
            else if (type == 2)
            {
                int[,] arr_res = new int[3, 3];
                for (int i = 0; i < arr_1.GetLength(0); i++)
                    for (int j = 0; j < arr_1.GetLength(1); j++)
                        arr_res[i, j] = arr_1[i, j] + arr_2[i, j];
                Console.WriteLine("Result: ");
                for (int i = 0; i < arr_res.GetLength(0); i++)
                {
                    for (int j = 0; j < arr_res.GetLength(1); j++)
                        Console.Write("{0} ", arr_res[i, j]);
                    Console.WriteLine();
                }
            }
            else if (type == 3)
            {
                int[,] arr_res = new int[3, 3];
                for (int i = 0; i < arr_1.GetLength(0); i++)
                    for (int j = 0; j < arr_1.GetLength(1); j++)
                        for (int k = 0; k < arr_1.GetLength(0); k++)
                            arr_res[i, j] += arr_1[i, k] * arr_2[k, j];
                Console.WriteLine("Result  ");
                for (int i = 0; i < arr_res.GetLength(0); i++)
                {
                    for (int j = 0; j < arr_res.GetLength(1); j++)
                        Console.Write("{0} ", arr_res[i, j]);
                    Console.WriteLine();
                }
            }
            #endregion
        }
    }
}