using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MeetTheTeacher.Logic
{
    /// <summary>
    /// Verwaltet einen Eintrag in der Sprechstundentabelle
    /// Basisklasse für TeacherWithDetail
    /// </summary>
    public class Teacher : IComparable
    {
        public string Name { get; set; }
        public string Day { get; set; }
        public string Unit { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public string Room { get; set; }
        public string Comment { get; set; }

        public Teacher(string name, string day, string unit, string time, string room, string comment)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (day == null)
                throw new ArgumentNullException(nameof(day));
            if (time == null)
                throw new ArgumentNullException(nameof(time));
            if (comment == null)
                throw new ArgumentNullException(nameof(comment));

            Name = name;
            Day = day;
            Unit = unit;
            TimeFrom = ConvertToTime(1, time);
            TimeTo = ConvertToTime(2, time);
            Room = room;
            Comment = comment;
        }
        private DateTime ConvertToTime(int code, string time)
        {
            DateTime returnTime = new DateTime();
            time = time.Trim(' ', 'h');
            string[] times = time.Split("-");

            if (times.Length == 2)
            {
                string[] timeOfDay;

                if (code == 1)
                {
                    timeOfDay = times[0].Trim(' ').Split(":");
                }
                else
                {
                    timeOfDay = times[1].Trim(' ').Split(":");
                }

                int hrs;
                int min;
                bool hrsOk = Int32.TryParse(timeOfDay[0], out hrs);
                bool minOk = Int32.TryParse(timeOfDay[1], out min);

                if (hrsOk && minOk)
                    returnTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hrs, min, 0);
            }

            return returnTime;
        }
        public virtual string GetHtmlForName()
        {
            return Name;
        }
        public int CompareTo(object obj)
        {
            Teacher otherT = obj as Teacher;

            if (otherT == null)
                throw new ArgumentNullException(nameof(obj));

            return otherT.Name.CompareTo(this.Name) * -1;
        }
    }
}
