using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //array initializations
            int[] list = new int[10];

            list[0] = 100;
            list[1] = 200;
            list[2] = 300;

            //foreach (var item in list)
            //{
            //    WriteLine(item);
            //}

            for (int i = 0; i < list.Length; i++)
            {
                WriteLine(list[i]);
            }


            int[] data;
            data = new int[20];

            int[] datum = new int[] { 10,20,30,40,50};

            string[] countries = new string[] { "Pakistan","India","Iran","Malysia","Indonesia","Turkey"};

            string[] countries2 = { "Pakistan", "India","Iran","Malysia","Indonesia","Turkey"};


            Read();

        }
    }
}
