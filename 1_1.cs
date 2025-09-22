using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //bool A = true, B = false, C = false;

            //Console.WriteLine($"a) = {(A || (!A && B)) || C}");
            //Console.WriteLine($"б) = {(!A && A && (B || C))}");
            //Console.WriteLine($"в) = {((A || (B && !C)) && A)}");

            //2
            //bool X = false, Y = true, Z = false;

            //Console.WriteLine($"a) = {(X && !(Z || Y)) || Z}");
            //Console.WriteLine($"б) = {(!X || (X && (Y || Z)))}");
            //Console.WriteLine($"в) = {(X || (Y && !Z))}");

            ////3а
            //int x = 2, y = 1;
            //Console.WriteLine($"а) = {!(x > y && y > 0) && (y > x)}");

            ////3б
            //int x = 2, y = -2;
            //Console.WriteLine($"б) = {(x >= 2) || (Math.Pow(y, 2) != 5)}");

            ////4
            //int A = 6;
            //Console.WriteLine($"4) = {(A % 2 == 0) || (A % 3 == 0)}");

            //5
            //int A = 1, B = 3;
            //Console.WriteLine($"5) = {(A % 2 != 0) && (B % 2 != 0)}");

            //6
            //bool X = false, Y = false, Z = true;

            //Console.WriteLine($"а) = {X || (Y && !Z)}");
            //Console.WriteLine($"б) = {!X && Y}");
            //Console.WriteLine($"в) = {!(X && Z) || Y}");

            //8
            //int x = 1, y = 2;
            //Console.WriteLine($"а) = {(x >= 0) && (y * y == 4)}");

            //int x = 2, y = 1;
            //Console.WriteLine($"б) = {(x * y != 0) || (y > x)}");

            //9
            //int x = 1, y = 2;
            //Console.WriteLine($"а) = {!(x > y && y > 0) || (y > x)}");

            //int x = 2, y = 1;
            //Console.WriteLine($"б) = {(x * y != 0) && (y < x)}");

            ////10
            //bool A = true, B = false, C = true;

            //Console.WriteLine($"а) = {A || !(A && B) || C}");
            //Console.WriteLine($"б) = {!A || C && (B || C)}");
            //Console.WriteLine($"в) = {(A || B && !C) || A}");

            ////11
            //int x = 1; y = 2;

            //Console.WriteLine($"а) = {!(x > y && y > 1) && (y > x)}");
        }
    }
}