using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CustomArrayClass_indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            data[0] = 10;
            data[1] = 20;
            data[2] = 30;
            data[3] = 40;

            foreach (var item in data.list)
            {
                WriteLine(item);
            }

            Read();
        }
    }
}
