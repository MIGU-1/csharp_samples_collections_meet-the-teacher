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
    public class Teacher
    {
        public string Name { get; set; }
        public string Day { get; set; }
        public int Unit { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public int Room { get; set; }
        public string Comment { get; set; }

        public Teacher(string name, string day, int unit, DateTime timeFrom, DateTime timeTo, int room, string comment)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (day == null)
                throw new ArgumentNullException(nameof(day));
            if (timeFrom == null)
                throw new ArgumentNullException(nameof(timeFrom));
            if (timeTo == null)
                throw new ArgumentNullException(nameof(timeTo));
            if (comment == null)
                throw new ArgumentNullException(nameof(comment));

            Name = name;
            Day = day;
            Unit = unit;
            TimeFrom = timeFrom;
            TimeTo = timeTo;
            Room = room;
            Comment = comment;
        }
    }
}
