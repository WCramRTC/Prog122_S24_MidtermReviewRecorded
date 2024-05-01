using Prog122_S24_MidtermReviewRecorded;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_S24_MidtermReviewRecorded
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //**Fields * *
        List<Schedule> previousSchedules = new List<Schedule>();
        ClassProgram programs = new ClassProgram();
        Schedule currentSchedule;

        // We need to add information to the combo box to display
        // We can use the .ItemsSource property to assign a list
        // That list will be displayed to the combobox
        public MainWindow()
        {
            InitializeComponent(); // Keep InitilaizeComponent at the top

            // Initialize our currentSchedule object
            currentSchedule = new Schedule();

            // Assign previousSchedules to our combo box
            cmbChooseSchedule.ItemsSource = previousSchedules;

        } // MainWindow()

        private void btnAddProgramming_Click(object sender, RoutedEventArgs e)
        {
            // Get the required class from our ClassProgram instance
            // Using our index to get the first item from our list of programming classes
            // Accessing the instance of our ClassProgram, called programs
            // Accessing the ProgrammingCourses LIST - .ProgrammingCourses
            // Accessing the first item in the list - index 0
            Course progClass = programs.ProgrammingCourses[0];

            // Assign the class to our currentSchedule instance
            currentSchedule.AddCourse(progClass);

            // Refresh the rtbDisplaySchedule
            rtbDisplaySchedule.Text = currentSchedule.FormatSchedule();
            
        }

        private void btnDatabase_Click(object sender, RoutedEventArgs e)
        {
            Course databaseCourse = programs.DatabaseCourses[0];
            currentSchedule.AddCourse(databaseCourse);
            rtbDisplaySchedule.Text = currentSchedule.FormatSchedule();
        }


        private void btnFrontEnd_Click(object sender, RoutedEventArgs e)
        {
            Course frontEndCourse = programs.FrontEndCourses[0];
            currentSchedule.AddCourse(frontEndCourse);
            rtbDisplaySchedule.Text = currentSchedule.FormatSchedule();
        }

        private void btnFinalizeSchedule_Click(object sender, RoutedEventArgs e)
        {

            // Check to make sure the user has entered in a student name
            // If they have, "process" the schedule
            string userName = txtName.Text;
            bool isNotEmpty = userName.Length != 0;

            if(isNotEmpty)
            {
                // Run code to process
                // Add users name to current schedule
                currentSchedule.StudentName = userName;

                // Add current Schedule to our list of previous schedules
                previousSchedules.Add(currentSchedule);

                // Create a NEW scheduel for current schedule
                currentSchedule = new Schedule();

                // Clear the txtbox for name
                txtName.Text = "";

                // Clear the rich text box rtbDisplaySchedule
                rtbDisplaySchedule.Text = "";

                // Updates the combo box to show new items from attached list
                cmbChooseSchedule.Items.Refresh();

            }
            else
            {
                // Show message box, "Enter a name"
                MessageBox.Show("Enter a name");
            }


            // If not, prompt user with message box to enter a name

        }


        //- cmbChooseSchedule_SelectionChanged
        //	- **Purpose:**Display.FormattedSchedule for the selectedItem in the ComboBox.
        private void cmbChooseSchedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Grab the selected ITEM
            // Tell the computer it is a schedule
            Schedule selectedSchedule = cmbChooseSchedule.SelectedItem as Schedule;
            rtbPreviousSchedule.Text = selectedSchedule.FormatSchedule();

            // Assign the formattedSchedule to the rtbPreviousSchedules
        }
    } // class

} // namespace


//**Methods**









