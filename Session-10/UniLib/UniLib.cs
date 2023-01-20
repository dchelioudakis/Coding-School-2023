using System.Diagnostics;

namespace UniLib {
    public class Institute {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int? YearsInService { get; set; }

        public Institute() { 
            ID = Guid.NewGuid();
        }

        public void GetName() {

        }
        public void SetName(string name) {

        }
    }
    public class University : Institute {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourse { get; set; }

        public University() {
            ID = Guid.NewGuid();
        }

        public void GetStudents() {

        }
        public void GetCourses() {

        }
        public void GetGrades() {

        }
        public void SetSchedule(int courseId, int professorId, DateTime datetime) {

        }
    }
    public class Schedule {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Calendar { get; set; }

        public Schedule() {
            ID = new Guid();
        }
    }
    public class Course {
        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }

        public Course() { 
            ID = new Guid();
        }
    }
    public class Person {

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }


        public Person() {
            ID = new Guid();
        }

        public void Getname() {

        }
        public void SetName(string name) {

        }
    }
    public class Professor : Person {

        public string? Rank { get; set; }
        public List<Course> Courses { get; set; }

        public Professor() {
        
        }
       
        public void Teach(Course course, DateTime datetime) {

        }
        public void SetGrade(int studentId, int courseId, int grade) {

        }
        public void GetName() {

        }
    }
    public class Grade {

        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int? GradeVal { get; set; }

        public Grade() {
            ID = new Guid();
        }
    }
    public class Student : Person {

        public int RegistrationNumber { get; set; }
        public List<Course> Courses { get; set; }

        public Student() {
        }

        public void Attend(Course course, DateTime datetime) {
        }
        public void WriteExam(Course course, DateTime datetime) {

        }
    }

}