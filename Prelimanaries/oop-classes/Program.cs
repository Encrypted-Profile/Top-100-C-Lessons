using oop_classes.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student(); //callls parameterless constructor
            Student std2 = new Student(
                                        10,
                                        "Ali"
                                        ,"Hassan"
                                        ,"He is a good boy");

            Student std3 = new Student()
            {
                studentId = 20,
                studentName = "Hussain",
                studentFather = "Jawad",
                note = "he is bad boy"
            };  //calls parameterless constructor


            Console.WriteLine(std3);
            Console.Read();

        }
    }
}
