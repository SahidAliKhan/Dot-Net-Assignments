using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _id;

        public int RollNo
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _class;

        public int Class
        {
            get { return _class; }
            set { _class = value; }
        }
        private string _sec;

        public string Section
        {
            get { return _sec; }
            set { _sec = value; }
        }
        public void AcceptStudent(string n, int id, int c, string s)
        {
            n = Name;
            id = RollNo;
            c = Class;
            s = Section;
        }
    }
}
