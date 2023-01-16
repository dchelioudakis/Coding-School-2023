using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {
    public class University : Institute {
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] Schedules { get; set; }

        public University() {

        }
        public University(Student[] students) {
            Students = students;
        }
        public University(Student[] students, Course[] courses) {
            Students = students;
            Courses = courses;
        }
        public University(Student[] students, Course[] courses, Grade[] grades) {
            Students = students;
            Courses = courses;
            Grades = grades;
        }
        public University(Student[] students, Course[] courses, Grade[] grades, Schedule[] schedules) {
            Students = students;
            Courses = courses;
            Grades = grades;
            Schedules = schedules;
        }
    
        public void getStudents() {

        }
        public void GetCourses() {

        }
        public void GetGrades() {

        }
        public void SetSchedule(Guid courseId, Guid professorId, DateTime datetime) {

        }
    }
}
