using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Department
    {
        private string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
       
        private int numberOfCourse;

        public int NumberOfCourse
        {
            get { return numberOfCourse; }
            set { numberOfCourse = value; }
        }

        private string departmentId;

        public string DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
        private Faculty[] faculties;

        private int facultyCount;

        public int FacultyCount
        {
            get { return facultyCount; }
            set { facultyCount = value; }
        }
        private Course[] courses;
        private int courseCount;

        public int CourseCount
        {
            get { return courseCount; }
            set { courseCount = value; }
        }



        public Department()
        {
            faculties = new Faculty[1000];
            courses = new Course[50];
           
        }

        public Department(string name, string id)
        {
            this.departmentName = name;
            this.departmentId = id;
            faculties = new Faculty[1000];
            courses = new Course[50];
            courseCount = 0;


        }
       
        public void AddCourse(Course crses)
        {
            courses[courseCount++] = crses;
        }
        public void ShowInfo3()
        {
            Console.WriteLine(" Deprtment Name is:" + departmentName);
            Console.WriteLine(" Department Id is " + departmentId);
            Console.WriteLine("Total Course:" + numberOfCourse);

        }


    }
}

