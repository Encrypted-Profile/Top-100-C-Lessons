using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace opp_classes_list_objects
{
    class Students
    {
        public int studentId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string Dept { get; set; }
        public string MaxSeats { get; set; }

        public static List<Students> list = new List<Students>();

        public void addStudent(Students obj)
        {
            list.Add(obj);
        }
        public void removeStudent(int index)
        {
            list.RemoveAt(index);
        }
        public void printAll()
        {
            foreach(Students std in list)
                WriteLine(std);
        }
        public override string ToString()
        {
            return " Student ID: "+this.studentId+" / Student Name: "+this.FatherName+" / Max Seats "+this.MaxSeats;
            //return string.Join(counter + ": " + list, Environment.NewLine);
        }
    }
}
