using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace opp_classes_lists_filing
{
    class Students
    {
        public int studentId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string Dept { get; set; }
        public string MaxSeats { get; set; }

        public static List<Students> list = new List<Students>();

        public void addStudent(Students stdobj)
        {
            list.Add(stdobj);


        }
        public void removeStudent(int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].studentId == id)
                {
                    list.RemoveAt(i);
                }
            }

        }
        public void printAll()
        {
            foreach (Students std in list)
                WriteLine(std);
        }
        public override string ToString()
        {
            return " Student ID: " + this.studentId + " / Student Name: " + this.StudentName + "/Father Name: " + this.FatherName + " / Max Seats " + this.MaxSeats;
            //return string.Join(counter + ": " + list, Environment.NewLine);
        }
        public void loadFile()
        {
            Students obj;
            using (FileStream file = new FileStream(@"D:\StudentRecord.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                StreamReader reader = new StreamReader(file);
                string Totalline = "";
                while ((Totalline = reader.ReadLine()) != null)
                {

                    string[] array = Totalline.Split(",".ToCharArray());
                    obj = new Students()
                    {
                        studentId = Int32.Parse(array[0]),
                        StudentName = array[1],
                        FatherName = array[2],
                        Dept = array[3],
                        MaxSeats = array[4]
                    };
                    //   if(!list.Contains(obj))

                    obj.addStudent(obj);


                    //WriteLine(obj.studentId);

                }
                reader.Close();
            }

        }
        public void savetofile()
        {
            using (FileStream file = new FileStream(@"D:\StudentRecord.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                StreamWriter writer = new StreamWriter(file);
                for (int i = 0; i < list.Count; i++)
                {
                    writer.Write(list[i].studentId + ",");
                    writer.Write(list[i].StudentName + ",");
                    writer.Write(list[i].FatherName + ",");
                    writer.Write(list[i].Dept + ",");
                    writer.WriteLine(list[i].MaxSeats, Environment.NewLine);
                }
                writer.Close();
            }

        }


    }
}
