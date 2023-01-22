
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
        }

        private void PopulateCourses() {

            List<Course> courses = new List<Course>();

            Course courseOne = new Course() {
                ID = Guid.NewGuid(),
                Code = "CRS1",
                Subject = "Algebra",
            };
            courses.Add(courseOne);

            Course courseTwo = new Course() {
                ID = Guid.NewGuid(),
                Code = "CRS2",
                Subject = "Physics",
            };
            courses.Add(courseTwo);

            Courses = courses;
            grvCourses.DataSource = courses;
        }
        private void PopulateStudents() {

            List<Course> courses = Courses;

            List<Student> students = new List<Student>();

            Student studentOne = new Student() {
                ID = Guid.NewGuid(),
                Name = "Dimitris",
                Age = 28,
                RegistrationNumber = 1563,
                Courses = new List<Course> { courses[0] },
            };
            students.Add(studentOne);

            Student studentTwo = new Student() {
                ID = Guid.NewGuid(),
                Name = "Stelios",
                Age = 27,
                RegistrationNumber = 1897,
                Courses = new List<Course> { courses[0], courses[1] },
            };
            students.Add(studentTwo);

            Students = students;
            grvStudents.DataSource = students;
        }

        private void PopulateGrades() {

            List<Grade> grades = new List<Grade>();
            List<Student> students = Students;

            Grade GradeOne = new Grade() {
                ID = Guid.NewGuid(),
                StudentID = students[0].ID,
                CourseID = students[0].Courses[0].ID,
                GradeVal = 9
            };
            grades.Add(GradeOne);

            Grade GradeTwo = new Grade() {
                ID = Guid.NewGuid(),
                StudentID = students[1].ID,
                CourseID = students[1].Courses[1].ID,
                GradeVal = 8
            };
            grades.Add(GradeTwo);

            Grades= grades;
            grvGrades.DataSource = grades;
        }


        private void PopulateProfessors() {

            List<Professor> professors = new List<Professor>();
            List<Course> courses = Courses;

            Professor professorOne = new Professor() {
                ID = Guid.NewGuid(),
                Name = "Helen",
                Age = 35,
                Rank = "Professor",
                Courses = new List<Course> { courses[0] },
            };
            professors.Add(professorOne);

            Professor professorTwo = new Professor() {
                ID = Guid.NewGuid(),
                Name = "Michael",
                Age = 32,
                Rank = "Professor",
                Courses = new List<Course> { courses[1] },
            };
            professors.Add(professorTwo);

            Professors = professors;
        }


        private void PopulateSchedules() {

            List<Schedule> schedules = new List<Schedule>();
            List<Course> courses = Courses;
            List<Professor> proffesors = Professors;

            Schedule ScheduleOne = new Schedule() {
                ID = Guid.NewGuid(),
                CourseID = courses[0].ID,
                ProfessorID = proffesors[0].ID,
                Calendar = new DateTime(2023,05,08)
            };
            schedules.Add(ScheduleOne);

            Schedule ScheduleTwo = new Schedule() {
                ID = Guid.NewGuid(),
                CourseID = courses[1].ID,
                ProfessorID = proffesors[1].ID,
                Calendar = new DateTime(2023, 06, 08)
            };
            schedules.Add(ScheduleTwo);

            Schedules = schedules;
            grvSchedules.DataSource = schedules;

        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveAll();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            try {
                LoadFromJsonFiles();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
            UpdateDataGrids();
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

        private void LoadFromJsonFiles() {
            Serializer serializer = new Serializer();

            Courses = serializer.Deserialize<List<Course>>("courses.json");
            Students = serializer.Deserialize<List<Student>>("students.json");
            Professors = serializer.Deserialize<List<Professor>>("professors.json");
            Grades = serializer.Deserialize<List<Grade>>("grades.json");
            Schedules = serializer.Deserialize<List<Schedule>>("schedules.json");
        }

        private void UpdateDataGrids() {
            grvCourses.DataSource = Courses;
            grvStudents.DataSource = Students;
            grvGrades.DataSource = Grades;
            grvSchedules.DataSource = Schedules;
        }

    }
}