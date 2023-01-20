using UniLib;

namespace Session_10 {
    public partial class Form1 : Form {

        private BindingSource BsCourses = new BindingSource();
        private BindingSource BsStudents = new BindingSource();
        private BindingSource BsGrades = new BindingSource();
        private BindingSource BsSheduledCourses = new BindingSource();
        public Form1() {
            InitializeComponent();
        }

        private void PopulateCourses() {

            List<Course> courses = new List<Course>();

            Course courseOne = new Course() {
                Code = "CRS1",
                Subject = "Algebra",
            };
            courses.Add(courseOne);

            Course courseTwo = new Course() {
                Code = "CRS2",
                Subject = "Physics",
            };
            courses.Add(courseTwo);


            BsCourses.DataSource = courses;

        }
        private void PopulateStudents() {

            List<Course> courses = (List<Course>)BsCourses.DataSource;

            List<Student> students = new List<Student>();

            Student studentOne = new Student() {
                Name = "Dimitris",
                Age = 28,
                RegistrationNumber = 1563,
                Courses = { courses[0] },
            };
            students.Add(studentOne);

            Student studentTwo = new Student() {
                Name = "Stelios",
                Age = 27,
                RegistrationNumber = 1897,
                Courses = { courses[0], courses[1] },
            };
            students.Add(studentTwo);


            BsStudents.DataSource = students;
        }

        private void PopulateGrades() {

            List<Grade> grades = new List<Grade>();
            //List<Course> courses = (List<Course>)BsCourses.DataSource;
            List<Student> students = (List<Student>)BsStudents.DataSource;

            Grade GradeOne = new Grade() {
                StudentID = students[0].ID,
                CourseID = students[0].Courses[0].ID,
                GradeVal = 9
            };
            grades.Add(GradeOne);

            Grade GradeTwo = new Grade() {
                StudentID = students[1].ID,
                CourseID = students[1].Courses[1].ID,
                GradeVal = 8
            };
            grades.Add(GradeTwo);


            BsGrades.DataSource = grades;
        }


    }
}