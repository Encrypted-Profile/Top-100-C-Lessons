using oop_classes_3.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.__set("Id", "10");
            std.__set("Name", "Hussain");
            Console.WriteLine(std.getName());
            Console.Read();
        }
    }
}