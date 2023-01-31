using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Teacher
    {
        public string Name { get; }
        public List<Subject> Subjects = new List<Subject>();
        public Teacher(string name)
        {
            Name = name;
        }

        public void AddSubjects(Subject subject)
        {
            Subjects.Add(subject);
        }

        public void ShowSubjectTimeTables()
        {
            foreach (var subject in Subjects)
            {
                Console.WriteLine(subject.SubjectName);
                subject.ShowTimeTable();
                Console.WriteLine();
            }
        }
    }
}
