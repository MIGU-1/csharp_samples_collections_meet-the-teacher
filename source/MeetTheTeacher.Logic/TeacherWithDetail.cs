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
        public TeacherWithDetail(string name, string day, string unit, string time, string room, string comment, int detail)
            : base(name, day, unit, time, room, comment)
        {
            Detail = detail;
        }
        public override string GetHtmlForName()
        {
            return $"<a href=\"?id={Detail}\">{base.GetHtmlForName()}</a>";
        }
    }
}
