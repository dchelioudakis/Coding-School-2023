﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {
    public class University : Institute {
        public Student[]? Students { get; set; }
        public Course[]? Courses { get; set; }
        public Grade[]? Grades { get; set; }
        public Schedule[]? ScheduledCourse { get; set; }

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
            ScheduledCourse = schedules;
        }
        public University(Guid id, string name, Student[] students, Course[] courses, Grade[] grades, Schedule[] schedules) : base(id, name) {
            Students = students;
            Courses = courses;
            Grades = grades;
            ScheduledCourse = schedules;
        }


        public void getStudents() {

        }
        public void GetCourses() {

        }
        public void GetGrades() {

        }
        public void SetSchedule(int courseId, int professorId, DateTime datetime) {

        }
    }
}
