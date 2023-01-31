using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Subject
    {
        public SubjectNames SubjectName { get; private set; }

        public string RoomName { get; private set; }

        public List<string>[] Schedule = new List<string>[5];

        public static string[] weekdays = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        public Subject(int fagKode, string roomName)
        {
            for (int i = 0; i < Schedule.Length; i++)
            {
                Schedule[i] = new List<string>();
            }

            SubjectName = (SubjectNames)fagKode;
            RoomName= roomName;
        }

        public void AddTime(int weekDay, string newTime)
        {
            Schedule[weekDay].Add(newTime);
        }

        public void ShowTimeTable()
        {
            for (int i = 0; i < Schedule.Length; i++)
            {
                if (Schedule[i].Count == 0) continue;

                Console.WriteLine(weekdays[i]);
                foreach (var time in Schedule[i])
                {
                    Console.WriteLine(time);
                }

            }
        }
    }
}
