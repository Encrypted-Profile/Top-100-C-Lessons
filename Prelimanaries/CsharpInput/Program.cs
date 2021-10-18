using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parsing from string to integer
            //Int32.parse();
            //double.parse();
            //float.parse();


            //Input Integer

            //Console.WriteLine("Enter First Number: ");
            //int val1 =Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number: ");
            //int val2 = Int32.Parse(Console.ReadLine());
            //int result = val1 + val2;
            //Console.WriteLine("The sum is {0}",result);


            //Character input

            //Console.WriteLine("Enter a character: ");
            //char ch = (char)Console.Read();
            //Console.WriteLine("The character is {0}",ch);


            //String input

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Your name is {0}",name);

            Console.ReadKey();
        }
    }
}
