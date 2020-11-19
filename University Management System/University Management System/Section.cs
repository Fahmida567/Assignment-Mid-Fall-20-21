﻿using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Section
    {
        private string secName;

        public string SecName
        {
            get { return secName; }
            set { secName = value; }
        }

       
        private Faculty[] faculties;

        private int facultyCount;

        public int FacultyCount
        {
            get { return facultyCount; }
            set { facultyCount = value; }
        }


        public Section()
        {
            secName = "xxxx";
            faculties = new Faculty[1000];
        }
        public Section(string name, string id)
        {
            this.secName = name;
            faculties = new Faculty[1000];
            facultyCount = 0;
        }
        public void AddFaculty(Faculty fac)
        {   if (facultyCount < 1000)
                faculties[facultyCount++] =fac;
            else
                Console.WriteLine("faculty is full");
        }
        public void ShowInfo1()
        {
            Console.WriteLine(" Section  is:" + secName);
           

        }
       

    }

}

