using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>()
            {
                new Course {CourseId = 201, Name = "Physics of Sound", Students = new List<Student>() {
                    new Student() {StudentId = 111, Name = "Darryl Raspberry"},
                    new Student() {StudentId = 222, Name = "Bob McKenzie" }}},
                new Course {CourseId = 102, Name = "Introduction to Denouement", Students = new List<Student>() {
                    new Student() {StudentId = 333, Name = "Dudley Dowrong"},
                    new Student() {StudentId = 444, Name = "Roy Orbitson" }}},
                new Course {CourseId = 451, Name = "Fahrenheit in spite of Celsius", Students = new List<Student>() {
                    new Student() {StudentId = 555, Name ="Jamie Blenderson"},
                    new Student() {StudentId = 666, Name = "Marlow Brandon"}}}
            };

            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("{0} - {1}<br/>", course.Name, course.CourseId);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("{0} <br/>", student.Name); 
                }

            }
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */ 


        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            Course course1 = new Course() {CourseId = 505, Name = "Cooking in a Vacuum" };
            Course course2 = new Course() {CourseId = 410, Name = "Doctorate Level Study Hall" };
            Course course3 = new Course() {CourseId = 720, Name = "The Circle of Circle" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {777, new Student {StudentId = 777, Name = "Tardie Errande", Courses = new List<Course>{course1, course3}}},
                {888, new Student {StudentId = 888, Name = "Moxie Abologna", Courses = new List<Course> {course2, course3}}},
                {999, new Student {StudentId = 999, Name = "Socrates Playdoh", Courses = new List<Course> {course3, course1}}}
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("Student: {0} - {1}<br/>", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;Course:{0} {1}<br/>", course.CourseId, course.Name);
                }

            }

            /*
            * Create a Dictionary of Students (add three example Students
            * ... make up the details).  Use the StudentId as the 
            * key.  Each student must be enrolled in two Courses.  Use
            * Object and Collection Initializers.  Then, iterate through
            * each student and print out to the web page each Student's
            * info and the Courses the Student is enrolled in.
            */
        }


        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = "Archimedes Centipedes";
            student.StudentId = 1000;
            student.Enrollments = new List<Enrollment>()
            {
                new Enrollment {Grade = 90, Course = new Course {CourseId = 1, Name ="Introduction to Denouement 102" }},
                new Enrollment {Grade = 85, Course = new Course {CourseId = 2, Name ="Fahrenheit in Spite of Celsius 451" }}
            };

            resultLabel.Text += String.Format("Student: {0} - {1}<br/>", student.StudentId, student.Name);
            foreach (var enrollment in student.Enrollments)
            {
                resultLabel.Text += String.Format("Enrolled in: {0} - Grade: {1}%<br/>", enrollment.Course.Name, enrollment.Grade);
            }
        }

            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */  
    }
}