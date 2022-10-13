using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Helper
{
    public class deptmethods
    {
        MyContext context = null;
        public deptmethods()
        {
            context = new MyContext();

        }
        public bool Adddept(Department p)
        {
            try
            {
                context.Departments.Add(p);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Removedept(int id)
        {
            try
            {

                List<Department> s = context.Departments.ToList();
                Department r = s.Find(pr => pr.deptno == id);

                context.Departments.Remove(r);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Department finddept(int id)
        {
            List<Department> s = context.Departments.ToList();
            Department r = s.Find(pr => pr.deptno == id);
            return r;
        }
        public List<Department> Showalldepts()
        {
            return context.Departments.ToList();
        }
        public bool updatedept(int id, Department p)
        {
            try
            {

                List<Department> s = context.Departments.ToList();
                Department k = s.Find(pr => pr.deptno == id);

                k.deptno = p.deptno;
                k.deptname = p.deptname;
                k.location = p.location;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;


            }
        }
    }
}
