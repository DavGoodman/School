using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Class
    {
        public Teacher ClassTeacher;
        public List<Student> Students = new List<Student>();
        public string ClassName { get; private set; }

        public Class(string className, Teacher classTecher)
        {
            ClassTeacher= classTecher;
            ClassName = className;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void ShowStudentList() 
        {
            foreach(var student in Students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
