using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Input;
using System.Windows;
using System.Xml.Linq;

namespace Prog122_S24_MidtermReviewRecorded
{
    public class Course
    {

        // Fields
        string _name; // Course Name
        string _location; // Course Location - Room Number


        // Constructor
        public Course(string name, string location)
        {
            _name = name;
            _location = location;
        }


        // Properties
        public string Name
        {
            // Getters and setters
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }


        // Methods
        public override string ToString()
        {
            return $"{_name} - {_location}";
        }

    } // class

} // namespace
