using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CustomArrayClass_indexers_T
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var data = new Data<int>();
            data[0] = 10;
            data[1] = 20;
            data[2] = 30;
            data[3] = 40;

            foreach (var item in data.list)
            {
                WriteLine(item);
            }

            var names = new Data<string>();
            names[0] ="Ali";
            names[1] ="Ali 2";
            names[2] ="Ali  4";
            names[3] ="Ali  5";

            foreach (var item in names.list)
            {
                WriteLine(item);
            }

            Read();
        }
    }
}
