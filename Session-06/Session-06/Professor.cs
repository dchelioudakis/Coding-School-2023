﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {
    public class Professor : Person{

        public string? Rank { get; set; }
        public Course[] Courses { get; set; }

        public Professor() {

        }
        public Professor(string rank) {
            Rank= rank;
        }
        public Professor(string rank, Course[] courses) {
            Rank = rank;
            Courses = courses;
        }



        public void Teach(Course course, DateTime datetime) {

        }
        public void SetGrade(Guid studentId, Guid courseId, int grade) {

        }
        public void GetName() {

        }


    }
}