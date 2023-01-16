using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {
    public class Student : Person {
        
        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; }

        public Student() {
        }
        public Student(int registrationNumber) {
            RegistrationNumber = registrationNumber;
        }
        public Student(int registrationNumber, Course[] courses) {
            RegistrationNumber = registrationNumber;
            Courses = courses;
        }
        public Student(Guid id, string name, int age, int registrationNumber, Course[] courses) : base(id, name, age){
            RegistrationNumber = registrationNumber;
            Courses = courses;
        }

        public void Attend(Course course, DateTime datetime) {
        }
        public void WriteExam(Course course, DateTime datetime) {

        }
    }
}
