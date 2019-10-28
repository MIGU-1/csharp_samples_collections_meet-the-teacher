using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MeetTheTeacher.Logic
{
    /// <summary>
    /// Klasse, die einen Detaileintrag mit Link auf dem Namen realisiert.
    /// </summary>
    public class TeacherWithDetail : Teacher
    {
        public int Detail { get; set; }
        public TeacherWithDetail(string name, string day, int unit, DateTime timeFrom, DateTime timeTo, int room, string comment, int detail)
            : base(name, day, unit, timeFrom, timeTo, room, comment)
        {
            Detail = detail;
        }
    }
}
