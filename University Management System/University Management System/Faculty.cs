using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Faculty
    {
        private string facName;

        public string FacName
        {
            get { return facName; }
            set { facName = value; }
        }
        private string facId;

        public string FacId
        {
            get { return facId; }
            set { facId = value; }
        }
        private Section[]sections;

        private int sectionCount;

        public int SectionCount
        {
            get { return sectionCount; }
            set { sectionCount = value; }
        }

        public Faculty()
        {
            facName = "xxxx";
            facId = "234567888";
            sections = new Section[50];


        }
        public Faculty(string name, string id)
        {
            this.facName = name;
            this.facId = id;
            sections = new Section[50];
            sectionCount = 0;

        }
        public void AddSection( Section sec)
        {
            if (sectionCount < 50)
                sections[sectionCount++] = sec;
            else
                Console.WriteLine("Section is full");
        }
        public void ShowSectionDetails()
        {
            for (int i = 0; i < sectionCount; i++)
                sections[i].ShowInfo1();

        }
       
        public void ShowInfo2()
        {
            Console.WriteLine(" Faculty Name is:" + facName);
            Console.WriteLine(" Faculty Id is " + facId);

        }
    }
}
