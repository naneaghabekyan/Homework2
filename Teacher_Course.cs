/*
 2. Ստեղծել Teacher և Course
○ Teacher-ը դասավանդում է Course (aggregation)
*/
using System;

namespace Teacher_Course
{
    public class Course
    {
        public string Name { get;private set; }
        public Course(string name)
        {
            Name = name;
        }
    }
    public class Teacher
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        private Course course;
        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void AddCourse(Course course)
        {
            this.course = course;
        }
        public void AboutTeacher()
        {
            Console.WriteLine($"{FirstName} {LastName} teaches {course.Name}");
        }
    }
}
