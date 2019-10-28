using System;
using System.Collections.Generic;
using System.Text;

namespace MeetTheTeacher.Logic
{
    /// <summary>
    /// Verwaltung der Lehrer (mit und ohne Detailinfos)
    /// </summary>
    public class Controller
    {
        private readonly List<Teacher> _teachers;
        private readonly Dictionary<string, int> _details;

        /// <summary>
        /// Liste für Sprechstunden und Dictionary für Detailseiten anlegen
        /// </summary>
        public Controller(string[] teacherLines, string[] detailsLines)
        {
            _teachers = new List<Teacher>();
            _details = new Dictionary<string, int>();

            InitDetails(detailsLines);
            InitTeachers(teacherLines);
        }

        public int Count => throw new NotImplementedException();
        public int CountTeachersWithoutDetails => throw new NotImplementedException();
        /// <summary>
        /// Anzahl der Lehrer mit Detailinfos in der Liste
        /// </summary>
        public int CountTeachersWithDetails => throw new NotImplementedException();

        /// <summary>
        /// Aus dem Text der Sprechstundendatei werden alle Lehrersprechstunden 
        /// eingelesen. Dabei wird für Lehrer, die eine Detailseite haben
        /// ein TeacherWithDetails-Objekt und für andere Lehrer ein Teacher-Objekt angelegt.
        /// </summary>
        /// <returns>Anzahl der eingelesenen Lehrer</returns>
        private void InitTeachers(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(";");

                if (IsDetailTeacher(data[0]))
                {
                    int detail;
                    _details.TryGetValue(data[0], out detail);
                    TeacherWithDetail newTeacher = new TeacherWithDetail(
                        data[0],
                        data[1],
                        Convert.ToInt32(data[2]),
                        ConvertToTime(data[3]),
                        ConvertToTime(data[4]),
                        Convert.ToInt32(data[5]),
                        data[6],
                        detail);

                    _teachers.Add(newTeacher);
                }
                else
                {
                    Teacher newTeacher = new Teacher(
                        data[0],
                        data[1],
                        Convert.ToInt32(data[2]),
                        ConvertToTime(data[3]),
                        ConvertToTime(data[4]),
                        Convert.ToInt32(data[5]),
                        data[6]);

                    _teachers.Add(newTeacher);
                }

            }
        }
        /// <summary>
        /// Lehrer, deren Name in der Datei IgnoredTeachers steht werden aus der Liste 
        /// entfernt
        /// </summary>
        public void DeleteIgnoredTeachers(string[] names)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Sucht Lehrer in Lehrerliste nach dem Namen
        /// </summary>
        /// <param name="teacherName"></param>
        /// <returns>Index oder -1, falls nicht gefunden</returns>
        private int FindIndexForTeacher(string teacherName)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Ids der Detailseiten für Lehrer die eine
        /// derartige Seite haben einlesen.
        /// </summary>
        private void InitDetails(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(";");
                _details.Add(data[0], Convert.ToInt32(data[1]));
            }
        }
        /// <summary>
        /// HTML-Tabelle der ganzen Lehrer aufbereiten.
        /// </summary>
        /// <returns>Text für die Html-Tabelle</returns>
        public string GetHtmlTable()
        {
            throw new NotImplementedException();
        }
        private bool IsDetailTeacher(string name)
        {
            return _details.ContainsKey(name);
        }
        private DateTime ConvertToTime(string time)
        {
            throw new NotImplementedException();
        }

    }
}
