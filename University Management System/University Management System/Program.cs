using System;

namespace University_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course("CSE", "98736638");
            Section s = new Section("A", "7654499");
            Faculty f = new Faculty("Farzana", "15-875-08");
           
            c.AddFaculty(f);
            c.ShowFacultyDetails();
            c.AddSection(s);
            c.ShowSectionDetails();
            f.AddSection(s);



        }
    }
}
