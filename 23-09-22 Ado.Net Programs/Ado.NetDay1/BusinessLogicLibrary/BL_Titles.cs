using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary
{
    public class BL_Titles
    {
        //Business logic--- Validations

        private string _titleid;
        public string Title_id
        {
            get
            {
                return _titleid;
            }
            set
            {

                if ((String.IsNullOrEmpty(value)) || (value.Length > 6))
                {
                    throw new Exception("title id not valid");

                }
                else
                {
                    _titleid = value;
                }
            }
        }



        private string _titlename;

        public string TitleName
        {
            get { return _titlename; }
            set
            {
                if ((value.Length > 80) || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Not valid Title.... Please check");
                }
                else
                {
                    _titlename = value;
                }

            }
        }



        private string _pubid;

        public string PubId
        {
            get { return _pubid; }
            set
            {
                if (value.Length > 4)
                {
                    throw new Exception("Length of pubid cannot be more than 4 chars/numbers");
                }
                else
                {
                    _pubid = value;
                }

            }
        }


    }
}
