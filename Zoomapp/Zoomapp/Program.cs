using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to print the result of the specified operations. Go to the editor
//Test data:

//    -1 + 4 * 6
//    ( 35+ 5 ) % 7
//    14 + -4 * 6 / 11
//    2 + 15 / 6 * 1 - 7 % 2 

//Expected Output:
//23
//5
//12
//3

namespace Zoomapp
{
    class Program
    {
        static void Main(string[] args){

            int a;
            int b;
            int c;
            int d;

            a = -1 + 4 * 6;
            b = (35 + 5) % 7;
            c = 14 + -4 * 6 / 11;
            d = 2 + 15 / 6 * 1 - 7 % 2;

            //Console.WriteLine("PLease enter a number");

            //b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} {b} {c} {d}");

            Console.ReadLine();

        }
    }
}
