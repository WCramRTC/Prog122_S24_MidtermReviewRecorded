
---
## Variable Names

txtName: A TextBox for entering text (likely a name).

btnAddProgramming: A Button for adding "Programming" to a schedule.

btnDatabase: A Button for adding "Database" to a schedule.

btnFrontEnd: A Button for adding "Front End Web Dev" to a schedule.

rtbDisplaySchedule: A RichTextBox for displaying the current schedule.

rtbPreviousSchedule: A RichTextBox for displaying a previous schedule.

cmbChooseSchedule: A ComboBox for selecting a schedule.

btnFinalizeSchedule: A Button for finalizing the schedule.

---

## Classes

### Course.cs

- **Fields**
    - `_name`: A private string field to store the course name.
    - `_location`: A private string field to store the course location.
- **Constructor**
    - `Course(name: string, location: string)`: Initializes a course with a name and location.
- **Properties**
    - `Name`: Property with getter and setter to access the course name.
    - `Location`: Property with getter and setter to access the course location.
- **Methods**
    - `ToString()`: Overrides the default `ToString()` method to provide a custom representation (Name and Location).
	    Course Name - Course Location
	    `Programming 122 - J310`

### Schedule.cs

- **Fields:**
    - `_studentId`: A private string to store the student ID.
    - `_studentName`: A private string to store the student name.
    - `_courses`: A private list of `Course` objects, indicating a one-to-many relationship (a schedule has multiple courses).
- **Constructor:**
    - `Schedule()`: Initializes a Schedule object, generating a random student ID and creating an empty course list.
- **Properties:**
    - `StudentId`: Read-only property to get the student ID.
    - `StudentName`: Read-only property to get the student name.
    - `Courses`: Read-only property to get the course list.
- **Methods:**
    - `AddCourse(course: Course)`: Adds a course to the schedule.
    - `FormatSchedule()`: Creates a formatted string representation of the schedule.

```
		Student Id: 26358940
		Student Name: Will
		Programming 122 - J310
		Database 1 - J315
		Front End Web Development - J312
		Programming 122 - J310
```

    - `ToString()`: Overrides the default `ToString` method for a custom representation.
    - `Student ID - Student Name`
    - `12345823 - Will`

### ClassProgram.cs

- **Fields**
    
    - `_programmingCourses`: A private list of `Course` objects representing programming courses.
    - `_databaseCourses`: A private list of `Course` objects representing database courses.
    - `_frontEndCourses`: A private list of `Course` objects representing front-end development courses.
- **Constructor**
    
    - `ClassProgram()`: Initializes a new `ClassProgram` object. It populates the course lists with some initial course data.
- **Properties**
    
    - `ProgrammingCourses`: Read-only property to access the list of programming courses.
    - `DatabaseCourses`: Read-only property to access the list of database courses.
    - `FrontEndCourses`: Read-only property to access the list of front-end development courses.

---
## MainWindow.xaml.cs

Here we rig up our functionality to the main window

**Fields**

- **previousSchedules:**
    - **Type:** `List<Schedule>`
    - **Purpose:** Stores a list of completed schedules, likely for historical reference or selection.
- **programs:**
    - **Type:** `ClassProgram`
    - **Purpose:** Provides access to organized course lists (programming, database, front-end).
- **currentSchedule:**
    - **Type:** `Schedule`
    - **Purpose:** Holds the schedule currently being built by the user.

**Methods**

- **MainWindow()**
    
    - **Purpose:** The constructor of the `MainWindow` class. Initializes components, creates a new `currentSchedule`, and binds the `previousSchedules` to the ComboBox.
- **btnAddProgramming_Click(object sender, RoutedEventArgs e)**
    
    - **Purpose:** Event handler for the "Add Programming" button click.
        - Adds the first programming course from `programs.ProgrammingCourses` to the `currentSchedule`.
        - Updates the display (`rtbDisplaySchedule`) with the formatted schedule.
- **btnDatabase_Click(object sender, RoutedEventArgs e)**
    
    - **Purpose:** Event handler for the "Add Database" button click.
        - Adds the first database course from `programs.DatabaseCourses` to the `currentSchedule`.
        - Updates the display (`rtbDisplaySchedule`) with the formatted schedule.
- **btnFrontEnd_Click(object sender, RoutedEventArgs e)**
    
    - **Purpose:** Event handler for the "Add Front End Web Dev" button click.
        - Adds the first front-end course from `programs.FrontEndCourses` to the `currentSchedule`.
        - Updates the display (`rtbDisplaySchedule`) with the formatted schedule.
- **btnFinalizeSchedule_Click(object sender, RoutedEventArgs e)**
    
    - **Purpose:** Event handler for the "Finalize Schedule" button click.
        - Gets the student's name from the `txtName` textbox.
        - If the name is not empty:
            - Assigns the name to the `currentSchedule`.
            - Adds the `currentSchedule` to `previousSchedules`.
            - Updates and refreshes the ComboBox (`cmbChooseSchedule`).
            - Clears the name textbox.
            - Creates a new `currentSchedule`.
        - If the name is empty, shows a "Enter a name" message box.
- cmbChooseSchedule_SelectionChanged

	- **Purpose:** Display .FormattedSchedule for the selectedItem in the ComboBox.

**Events:**

- **btnAddProgramming_Click:** Triggered when the "Add Programming" button is clicked.
- **btnDatabase_Click:** Triggered when the "Add Database" button is clicked.
- **btnFrontEnd_Click:** Triggered when the "Add Front End Web Dev" button is clicked.
- **btnFinalizeSchedule_Click:** Triggered when the "Finalize Schedule" button is clicked.
- **cmbChooseSchedule_SelectionChanged:** Triggers when a new item is selected in the combo box

---
- [ ] Introduce Project
- [ ] Show off functionality
- [ ] Show how to properly setup project to get started
	- [ ] Shell classes
	- [ ] Add comments with functionality
- [ ] Introduce gui and variables names
	- [ ] Get it setup
- [ ] Explain 3 classes
- [ ] Build Shell
- [ ] 