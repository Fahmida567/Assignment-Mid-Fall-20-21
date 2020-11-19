using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Course
    {
        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        private string courseId;

        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        private Faculty[] faculties;

        private int facultyCount;

        public int FacultyCount
        {
            get { return facultyCount; }
            set { facultyCount = value; }
        }
        private Section[] sections;

        private int sectionCount;

        public int SectionCount
        {
            get { return sectionCount; }
            set { sectionCount = value; }
        }

        public Course()
        {
            faculties = new Faculty[1000];
            sections = new Section[50];
        }
        public Course(string name, string id)
        {
            this.courseName = name;
            this.CourseId = id;
            faculties = new Faculty[1000];
            sections = new Section[50];
            sectionCount = 0;
            facultyCount = 0;

        }
        public void AddSection(Section sec)
        {   if (sectionCount < 50)
                sections[sectionCount++] = sec;
            else
                Console.WriteLine("Section is full");
        }
        public void AddFaculty(Faculty fac)
        {
            if (facultyCount < 1000)
                faculties[facultyCount++] = fac;
            else
                Console.WriteLine("Faculty is full");
        }
        public void ShowSectionDetails()
        {
            for (int i = 0; i < sectionCount; i++)
                sections[i].ShowInfo1();

        }
        public void ShowFacultyDetails()
        {
            for (int i = 0; i < facultyCount; i++)
                faculties[i].ShowInfo2();

        }
        public void ShowInfo3()
        {
            Console.WriteLine(" Course Name is:" + courseName);
            Console.WriteLine(" Course Id is " + courseId);

        }


    }
}
