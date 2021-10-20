using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes_2.App_Code
{
    class Student
    {
        //Encapsulation  (public, private, protected)
        private int studentId;
        private string studentName;
        private string studentFather;
        private string note;

        //Accessors
        public int getId()
        {
            return this.studentId;
        }
        //Mutators
        public void setId(int? id)
        {
            if(id==null)
            {
                throw new Exception("Id can not be null");
            }
            else
                this.studentId =(int)id;
        }

    }
}
