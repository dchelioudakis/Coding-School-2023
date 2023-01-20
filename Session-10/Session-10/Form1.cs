
using SerializeLib;
using UniLib;

namespace Session_10 {
    public partial class Form1 : Form {

        private List<Course> Courses = new List<Course>();
        private List<Student> Students = new List<Student>();
        private List<Professor> Professors = new List<Professor>();
        private List<Grade> Grades = new List<Grade>();
        private List<Schedule> Schedules = new List<Schedule>();

       
        public Form1() {
            InitializeComponent();

            PopulateCourses();
            PopulateStudents();
            PopulateProfessors();
            PopulateGrades();
            PopulateSchedules();

            
            //SerializeInitialData(Students, "students.json");
            //SerializeInitialData(Professors, "professors.json");
            //SerializeInitialData(Grades, "grades.json");
            //SerializeInitialData(Schedules, "schedules.json");
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

            Courses = courses;
            grvCourses.DataSource = courses;

            SaveObject(courses, "courses.json");

        }
        private void PopulateStudents() {

            List<Course> courses = Courses;

            List<Student> students = new List<Student>();

            Student studentOne = new Student() {
                Name = "Dimitris",
                Age = 28,
                RegistrationNumber = 1563,
                Courses = new List<Course> { courses[0] },
            };
            students.Add(studentOne);

            Student studentTwo = new Student() {
                Name = "Stelios",
                Age = 27,
                RegistrationNumber = 1897,
                Courses = new List<Course> { courses[0], courses[1] },
            };
            students.Add(studentTwo);

            Students = students;
            grvStudents.DataSource = students;

            SaveObject(students, "students.json");
        }

        private void PopulateGrades() {

            List<Grade> grades = new List<Grade>();
            List<Student> students = Students;

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

            Grades= grades;
            grvGrades.DataSource = grades;

            SaveObject(grades, "grades.json");
        }


        private void PopulateProfessors() {

            List<Professor> professors = new List<Professor>();
            List<Course> courses = Courses;

            Professor professorOne = new Professor() {
                Name = "Helen",
                Age = 35,
                Rank = "Professor",
                Courses = new List<Course> { courses[0] },
            };
            professors.Add(professorOne);

            Professor professorTwo = new Professor() {
                Name = "Michael",
                Age = 32,
                Rank = "Professor",
                Courses = new List<Course> { courses[1] },
            };
            professors.Add(professorTwo);

            Professors = professors;

            SaveObject(professors, "professors.json");
        }


        private void PopulateSchedules() {

            List<Schedule> schedules = new List<Schedule>();
            List<Course> courses = Courses;
            List<Professor> proffesors = Professors;

            Schedule ScheduleOne = new Schedule() {
                CourseID = courses[0].ID,
                ProfessorID = proffesors[0].ID,
                Calendar = new DateTime(2023,05,08)
            };
            schedules.Add(ScheduleOne);

            Schedule ScheduleTwo = new Schedule() {
                CourseID = courses[1].ID,
                ProfessorID = proffesors[1].ID,
                Calendar = new DateTime(2023, 06, 08)
            };
            schedules.Add(ScheduleTwo);

            Schedules = schedules;
            grvSchedules.DataSource = schedules;

            SaveObject(schedules, "schedules.json");
        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveAll();
        }


        private void SaveObject(object input, string fileName) {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(input, fileName);
        }

        private void SaveAll() {

            SaveObject(Courses, "courses.json");
            SaveObject(Students, "students.json");
            SaveObject(Professors, "professors.json");
            SaveObject(Grades, "grades.json");
            SaveObject(Schedules, "schedules.json");
        }

        //private void LoadAll() {
        //    Serializer serializer = new Serializer();

        //    Courses = serializer.Deserialize<Course>("courses.json");
        //    grvCourses.DataSource = Courses;

        //    Students = serializer.Deserialize<Student>("students.json");
        //    grvCourses.DataSource = Students;

        //    Professors = serializer.Deserialize<Professor>("professors.json");

        //    Grades = serializer.Deserialize<Grade>("grades.json");
        //    grvCourses.DataSource = Grades;



        //    //SaveObject(Courses, "courses.json");
        //    //SaveObject(Students, "students.json");
        //    //SaveObject(Professors, "professors.json");
        //    //SaveObject(Grades, "grades.json");
        //    //SaveObject(Schedules, "schedules.json");
        //}
    }
}