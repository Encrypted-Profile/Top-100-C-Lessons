using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Array2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] list = new int[3,2];
            list[0,0] = 10;
            list[0,1] = 20;
            list[1,0] = 30;
            list[1,1] = 40;
            list[2,0] = 50;
            list[2,1] = 60;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Write(list[i,j]);
                }
                WriteLine();
            }


            Read();
        }
    }
}
