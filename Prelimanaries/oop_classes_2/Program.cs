using oop_classes_2.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student std1 = new Student();
                std1.setId(null);
                //------
                //------
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            Console.Read();
        }
    }
}
