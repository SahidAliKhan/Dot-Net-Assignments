using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class BookCategory
    {
		//catid,catname and description

		private int _catid;
		public int CatID
		{
			get { return _catid; }
			set { _catid = value; }
		}
		private string _catname;

		public string CatName
        {
			get { return _catname; }
			set { _catname = value; }
		}

		private string _desc;
		public string Description
        {
			get { return _desc; }
			set { _desc = value; }
		}
        public BookCategory() { }
        public BookCategory(int cid, string cname, string desc)
        {

        }
    }
}
