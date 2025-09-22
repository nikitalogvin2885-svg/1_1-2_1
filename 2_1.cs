using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //int A = 2, B = 3, C = 6;

            //Console.WriteLine($"а) = {(A % 2 == 0 && B % 2 != 0) || (A % 2 != 0 && B % 2 == 0)}");
            //Console.WriteLine($"б) = {(A % 3 == 0) && (B % 3 == 0) && (C % 3 == 0)}");

            //2
            //int N = 20;
            //Console.WriteLine($"а) = {(N % 4 == 0) || (N % 7 == 0)}");
            //Console.WriteLine($"б) = {(N % 5 == 0) && (N % 10 != 0)}");

            //3
            //int n = 3, m = 4, k = 5, l = 2;
            //Console.WriteLine($"3) = {(n + m > k) || (n > k && m > l)}");

            //4
            //int N = 24;
            //Console.WriteLine($"4) = {((N % 3 != 0) || (N % 9 != 0)) && ((N % 4 != 0) || (N % 5 == 0) || (N % 24 == 0))}");

            //5
            //int k = 1, l = 2, n = 3, m = 4;
            //Console.WriteLine($"5) = {((n <= 2) || (m * m == Math.Pow(l, 4))) && ((n > 1) || (k + l == 0))}");

            //6
            //double D = 75000;
            //Console.WriteLine($"6)Процентная ставка = {((D <= 50000) ? 0.16 : 0.18)}");

            //7
            //int N = 14;
            //Console.WriteLine($"7) = {(N % 2 == 0) && (N % 7 == 0) && (N % 11 != 0) && (N % 13 != 0)}");

            //8
            //int N = 70;
            //Console.WriteLine($"8) = {(N % 3 != 0) && (N % 7 == 0) && (N % 10 == 0)}");

            //9
            //int k = 0, l = 5, n = 2, m = 3;
            //Console.WriteLine($"9) = {((k != 0) || (l > m)) && ((k >= 0) || (2 * l - 3 * n < k * m))}");

            //10
            //int N = 56;
            //Console.WriteLine($"10) = {(N % 3 != 0) && (N % 7 == 0) && ((N % 5 != 0) || (N % 4 != 0)) && ((N % 8 != 0) || (N % 11 == 0))}");
        }
    }
}