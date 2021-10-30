using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace opp_classes_lists_filing
{
     class Program
    {
        enum dept
        {
            BSCS, BSCE, BSSE
        }
        enum maxSeats : int
        {
            BSCS = 50,
            BSCE = 100,
            BSSE = 300
        }
        static void Main(string[] args)
        {
            int choice;
            Students obj = new Students();
            obj.loadFile();
            while (true)
            {
                Clear();
                WriteLine("If you want to add student press 1");
                WriteLine("If you want to remove student press 2");
                WriteLine("If you want to print all the record press 3");
                WriteLine("If you want to exit press 4");
                choice = Int32.Parse(ReadLine());
                if (choice == 1)
                {
                    Clear();
                    while (true)
                    {
                        WriteLine("Enter Sudent ID");
                        int id = Int32.Parse(ReadLine());
                        if (id == 0)
                            break;
                        WriteLine("Enter Sudent Nmae");
                        string name = ReadLine();
                        WriteLine("Enter Sudent Father Name");
                        string father = ReadLine();
                        obj = new Students()
                        {
                            studentId = id,
                            FatherName = father,
                            StudentName = name,
                            Dept = dept.BSCS.ToString(),
                            MaxSeats = maxSeats.BSCS.ToString("D")
                        };

                        obj.addStudent(obj);
                    }
                   
                    
                }
                if(choice==2)
                {
                    Clear();

                    WriteLine("Enter the id of the student you want to remove: ");
                    int a = Int32.Parse(ReadLine());
                    obj.removeStudent(a);
                }
                if (choice==3)
                {
                    
                    Clear();

                    obj.printAll();
                    
                }
                if (choice==4)
                {
                    Clear();

                    WriteLine("Do you want to save?(y/n)");
                    string ch = ReadLine();
                    if(ch=="y" ||  ch=="Y")
                    {
                        obj.savetofile();
                        
                    }
                    break;
                }
                ReadLine();
            }
            Read();
        }
    }
}

