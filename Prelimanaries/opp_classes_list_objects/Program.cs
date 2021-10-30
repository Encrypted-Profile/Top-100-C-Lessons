using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace opp_classes_list_objects
{
    class Program
    {
        enum dept
        {
            BSCS,BSCE,BSSE
        }
        enum maxSeats : int
        {
            BSCS=50,
            BSCE=100, 
            BSSE=300
        }
        static void Main(string[] args)
        {
            //load from file to list
            Students obj=null;
            while(true)
            {
                WriteLine("Enter Sudent ID");
                int id = Int32.Parse(ReadLine());
                if (id == 0)
                    break;
                WriteLine("Enter Sudent Name");
                string name=ReadLine();
                WriteLine("Enter Sudent Father Name");
                string father=ReadLine();

                obj = new Students()
                {
                    studentId = id,
                    FatherName = father,
                    StudentName = name,
                    Dept=dept.BSCS.ToString(),
                    MaxSeats=maxSeats.BSCS.ToString("D")
                };

                obj.addStudent(obj);

            }
            Students objx = new Students();
            objx.printAll();

            Read();
        }
    }
}
