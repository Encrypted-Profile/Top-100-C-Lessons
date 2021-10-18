using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelimanaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Types

            // int , char , float ,double string, bool
            int a, b, c, d;
            a = 10;
            b = 20;
            c = 30;
            d = 40;

            Console.WriteLine("The value of a is ",a);
            Console.WriteLine($"The value of a is {a}");  // string interpolation
            Console.WriteLine("The value of a is {0} and b is {1}",a,b);



            //float pi = 3.1416;  // it generates error
            float pi = 3.1416f;
            float pi2 = (float)3.1416f;

            double pai = 3.1415;


            char ch = 'A';
            string tense = "A brown quick fox jumps over the lazy dog";


            bool flag = false;
            flag = true;
            Console.WriteLine(flag);



            //Console.Write("Hello World");
            //Console.Write("Hello World");
            //Console.Write("Hello World");
            //Console.Write("Hello World");
            //Console.Write("Hello World");


            Console.ReadKey();
        }
    }
}
