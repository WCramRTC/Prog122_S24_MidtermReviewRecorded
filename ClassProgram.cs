using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace Prog122_S24_MidtermReviewRecorded
{
    public class ClassProgram
    {

        // Fields
        List<Course> _programmingCourses; // Declaring our programming courses list
        List<Course> _databaseCourses; // Delcaring our database courses list
        List<Course> _frontEndCourses; // Declaring our front end courses list

        // Constructor
        public ClassProgram()
        {
            // INITIALIZING our programming courses list
            _programmingCourses = new List<Course>();
            // Programming 122 - J310
            // Created a course to add to our ClassProgram list
            Course prog122 = new Course("Programming 122", "J310");
            // Add the course to the _programmingCourses list
            _programmingCourses.Add(prog122); 

            _databaseCourses = new List<Course>();
            // Database 1 - J315
            _databaseCourses.Add(new Course("Database 1", "J315"));


            _frontEndCourses = new List<Course>();
            // Front End Web Development - J312
            _frontEndCourses.Add(new Course("Front End Web Development", "J312"));
        }


        // Properties
        //    - `ProgrammingCourses`: Read-only property to access the list of programming courses.
        //    - `DatabaseCourses`: Read-only property to access the list of database courses.
        //    - `FrontEndCourses`: Read-only property to access the list of front-end development courses.

        public List<Course> ProgrammingCourses
        {
            // Read Only
            get { return _programmingCourses; }
        }
        public List<Course> DatabaseCourses 
        { get => _databaseCourses; }
        public List<Course> FrontEndCourses 
        { get => _frontEndCourses; }
    } // class

} // namespace
