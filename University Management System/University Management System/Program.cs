using System;

namespace University_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course("CSE", "98736638");
            Faculty f = new Faculty("Farzana", "15-8750-08");
            Faculty f1 = new Faculty("Farzana", "15-8750-08");
            Section s1 = new Section("A","B");
            Faculty f2 = new Faculty("Orin", "15-8895-08");
            Section s2 = new Section("b","c");
            Faculty f3 = new Faculty("Rozia", "15-8850-08");
            Section s3 = new Section("c","D");


            c.AddFaculty(f1,f2,f3);
            c.ShowFacultyDetails();
            c.AddSection(s1,s2,s3);
            c.ShowSectionDetails();

        }
    }
}
