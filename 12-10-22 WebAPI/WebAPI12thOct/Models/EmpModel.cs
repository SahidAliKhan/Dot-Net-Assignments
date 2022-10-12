using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI12thOct.Models
{
    public class EmpModel
    {
        private int _empid;

        public int EmployeeID
        {
            get { return _empid; }
            set { _empid = value; }
        }

        private string _lname;
        public string LastName
        {
            //20
            get { return _lname; }
            set { _lname = value; }
        }
        private string _fname;
        public string FirstName
        {
            get { return _fname; }
            set
            {
                if ((value.Length > 10) || (string.IsNullOrEmpty(value)))
                {
                    throw new Exception("First Name too long.. it shud not exceed 10 chars");
                }
                else
                {
                    _fname = value;
                }
            }
        }
        private string _title;
        public string Title
        {
            //30
            get { return _title; }
            set { _title = value; }
        }

        private DateTime _birthdate;

        public DateTime BirthDate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
    }
}