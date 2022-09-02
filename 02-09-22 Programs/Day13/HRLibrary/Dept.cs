using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Dept
    {
        private int _deptno;

    public int Deptnumber
    {
        get { return _deptno; }
        set { _deptno = value; }
    }

    private string _deptname;

    public string DepartmentName
    {
        get { return _deptname; }
        set { _deptname = value; }
    }
    private string _loc;

    public string Location
    {
        get { return _loc; }
        set { _loc = value; }
    }

        private List<Employee> _emplist;
    public List<Employee> DeptEmployees
    {
        get { return _emplist; }
        set { _emplist = value; }
    }
}
}
