using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_BAL
{
    public class BLL
    {
		private int _bookno;

		public int Book_No
		{
			get { return _bookno; }
			set { _bookno = value; }
		}
		private string _bname;

		public string Book_Name
		{
			get { return _bname; }
			set { _bname = value; }
		}

		private string _author;

		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}

		private int _cost;

		public int Cost
		{
			get { return _cost; }
			set { _cost = value; }
		}

		private string _category;

		public string Category
		{
			get { return _category; }
			set { _category = value; }
		}

		public class MemberBLL
		{
			private int  _memberid;

			public int Member_ID
			{
				get { return _memberid; }
				set { _memberid = value; }
			}
			private string _membername;

			public string Member_Name
			{
				get { return _membername; }
				set { _membername = value; }
			}

		}

		public class UserBLL
		{
			private string _userid;

			public string User_ID
			{
				get { return _userid; }
				set { _userid = value; }
			}
			private string _password;

			public string Password
			{
				get { return _password; }
				set { _password = value; }
			}
		}

        public class Issue
        {
            public int Lib_Issue_Id { get; set; }
            public int Book_No { get; set; }


            private int _memberid;

            public int Member_Id
            {
                get { return _memberid; }
                set
                {
                    if (value > 0 && value < 7)
                    {
                        _memberid = value;

                    }
                    else
                    {
                        Console.WriteLine("Invalid Member Id");
                    }
                }
            }


            public DateTime Issue_Date { get; set; }



            private DateTime _Return_Date;

            public DateTime Return_Date
            {
                get { return _Return_Date; }
                set { _Return_Date = value; }

            }
            public string Comments { get; set; }
        }
    }
}
