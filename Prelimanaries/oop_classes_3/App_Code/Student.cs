using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes_3.App_Code
{
    class Student
    {
        //Encapsulation  (public, private, protected)
        private int studentId;
        private string studentName;
        private string studentFather;
        private string note;

        //Mutators
        public void __set(string name,string value)
        {
            Student program = new Student();
            var parameterTypes = new Type[] { typeof(int) };
            string function = "set" + name;
            MethodInfo[] mi = typeof(Student).GetMethods();
            foreach(MethodInfo methods in mi)
            {
                if(methods.Name==function)
                {
                    methods.Invoke(program, new Object[] { value });
                }
            }
        }
        public void setId(string id)
        {
            this.studentId =Int32.Parse(id);
            Console.WriteLine(this.studentId);
        }
        public void setName(string name)
        {
            this.studentName = name;
            Console.WriteLine(this.studentName);
        }
        public string getName()
        {
            return this.studentName;
        }
        public override string ToString()
        {
            return this.studentId+" "+ this.studentName;
        }

    }
}
