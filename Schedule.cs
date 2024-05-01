using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Documents;
using System.Windows.Input;
using System.Xml.Linq;

namespace Prog122_S24_MidtermReviewRecorded
{
    public class Schedule
    {
        // Fields
        string _studentId;
        string _studentName;
        List<Course> _courses;


        // Constructor
        public Schedule()
        {
            // Generate a random student ID Number
            // 100000000 - 1000000000
            Random rand = new Random();
            _studentId = rand.Next(100000000, 1000000000).ToString();

            // Initialize our Course List
            _courses = new List<Course>();
        }


        // Properties
        public string StudentId
        {
            get { return _studentId; }
        }
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }
        public List<Course> Courses
        {
            get { return _courses; }
        }

        // Methods
        //    - `AddCourse(course: Course)`: Adds a course to the schedule.
        public void AddCourse(Course course)
        {
            _courses.Add(course);
        } // AddCourse

        public string FormatSchedule()
        {
            string formatString = "";
            formatString += $"Student Id: {_studentId}\n";
            formatString += $"Student Name: {_studentName}\n";
            formatString += $"\n";
            for (int i = 0; i < _courses.Count; i++)
            {
                formatString += _courses[i].ToString() + "\n";
            }

            return formatString;
        }


        //    - `ToString()`: Overrides the default `ToString` method for a custom representation.
        public override string ToString()
        {
            //`12345823 - Will`
            return $"{_studentId} - {_studentName}";
        }


    } // class

} // namespace
