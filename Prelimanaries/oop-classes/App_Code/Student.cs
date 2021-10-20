using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes.App_Code
{
    class Student
    {
        //Encapsulation  (public, private, protected)
        public int studentId;
        public string studentName;
        public string studentFather;
        public string note;

        public Student(){}

        public Student(int id, string name, string father, string note)
        {
            this.studentId = id;
            this.studentName = name;
            this.studentFather = father;
            this.note = note;
        }

        public override string ToString()
        {
            return "ID: "+this.studentId+" Name: "+this.studentName+" Father Name: "+this.studentFather+Environment.NewLine+"Note: "+this.note;
        }
    }
}
