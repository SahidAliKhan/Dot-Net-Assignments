using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPS
{
    public interface IExtensionManager
    {
        bool CheckExtension(string FileName);
    }
    public class ExtensionManager : IExtensionManager
    {
        public bool CheckExtension(string FileName)
        {
            //Some complex business logic might goes here. May be DB operation or file system handling  
            return false;
        }
    }

    public class StubExtensionManager : IExtensionManager
    {
        public bool CheckExtension(string FileName)
        {
            return true;
        }
    }

    public class FileChecker
    {
        IExtensionManager objmanager = null;
        //Default constructor  
        public FileChecker()
        {
            objmanager = new ExtensionManager();
        }
        //parameterized constructor  
        public FileChecker(IExtensionManager tmpManager)
        {
            objmanager = tmpManager;
        }

        public Boolean CheckFile(String FileName)
        {
            return objmanager.CheckExtension(FileName);
        }
    }
}
