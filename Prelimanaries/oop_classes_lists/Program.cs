using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace oop_classes_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<string> names = new List<string>();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);
            list.Add(70);

            names.Add("Ali");
            names.Add("Abbass");
            names.Add("Mahira");
            names.Add("Jumma");


            foreach (int val in list)
            {
                WriteLine(val);
            }


            foreach (string val in names)
            {
                WriteLine(val);
            }

            Read();
        }
    }
}
