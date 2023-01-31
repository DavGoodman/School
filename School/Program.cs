using System;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School PorsgrunnVgs = new School();
            FillInfo(PorsgrunnVgs);

            PorsgrunnVgs.PrintStudendsInSubject(1);
        }

        static void FillInfo(School school)
        {
            

            var student1 = new Student("Fredrik");
            var student2 = new Student("David");
            var student3 = new Student("Marius");
            var student4 = new Student("Robert");
            var student5 = new Student("Simen");

            Subject math = new Subject(0, "101");
            math.AddTime(0, "10:00");
            math.AddTime(0, "13:00");
            math.AddTime(2, "08:00");
            math.AddTime(3, "9:00");

            Subject english = new Subject(1, "102");
            english.AddTime(0, "08:00");
            english.AddTime(1, "10:00");
            english.AddTime(1, "13:00");
            english.AddTime(4, "8:00");


            student1.AddSubjects(math);
            student1.AddSubjects(english);
            student2.AddSubjects(math);
            student3.AddSubjects(english);
            student4.AddSubjects(math);
            student4.AddSubjects(english);
            student5.AddSubjects(math);


            Teacher terje = new Teacher("Terje");
            terje.AddSubjects(math);

            Class class2b = new Class("2B", terje);
            class2b.AddStudent(student1);
            class2b.AddStudent(student2);
            class2b.AddStudent(student3);
            class2b.AddStudent(student4);
            class2b.AddStudent(student5);

            school.AddClass(class2b);
            
        }
    }
}