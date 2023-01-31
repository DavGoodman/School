using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class School
    {
        public List<Subject> Subjects { get; private set; }
        public List<Class> Classes { get; private set; }

        public School()
        {
            Subjects = new List<Subject>(); 
            Classes = new List<Class>();
        }

        public void AddClass(Class cls)
        {
            Classes.Add(cls);
        }  
        
        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }


        public void PrintStudendsInSubject(int fagKode)
        {
            var subjectName = (SubjectNames)fagKode;
            Console.WriteLine("Students in " + subjectName);

            //var list =Classes
            //    .Select(c => c.Students
            //        .Select(student => student.Subjects
            //            .Where(sub => sub.SubjectName == subjectName)));



            foreach (var _class in Classes)
            {
                foreach (var student in _class.Students)
                {
                    foreach (var subject in student.Subjects)
                    {
                        if (subjectName == subject.SubjectName)
                        {
                            Console.WriteLine(student.Name);
                        }
                    }
                }
            }
        }
    }
}
