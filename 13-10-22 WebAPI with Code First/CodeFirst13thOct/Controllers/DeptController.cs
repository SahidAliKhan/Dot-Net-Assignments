using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using Helper;
using CodeFirst13thOct.Models;

namespace CodeFirst13thOct.Controllers
{
    public class DeptController : ApiController
    {
        // GET: api/Dept
        deptmethods ms = null;
        public DeptController()
        {
            ms = new deptmethods();
        }
        List<Dept> s = new List<Dept>();
        public IEnumerable<Dept> Get()
        {
            List<Department> c = ms.Showalldepts();
            foreach (var item in c)
            {
                Dept v = new Dept();
                v.deptno = item.deptno;
                v.deptname = item.deptname;
                v.location = item.location;
                s.Add(v);
            }
            return s;

        }

        // GET: api/Dept/5
        public Dept Get(int id)
        {
            Dept r = new Dept();
            Department p = new Department();
            p = ms.finddept(id);

            r.deptno = Convert.ToInt32(p.deptno);
            r.deptname = p.deptname.ToString();
            r.location = p.location.ToString();
            return r;

        }

        // POST: api/Dept
        public HttpResponseMessage Post([FromBody] Dept value)
        {
            Department p = new Department();
            p.deptname = value.deptname;
            p.location = value.location;
            p.deptno = value.deptno;
            bool k = ms.Adddept(p);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }

        // PUT: api/Dept/5
        public HttpResponseMessage Put(int id, [FromBody] Dept value)
        {
            Department s = new Department();
            s.deptname = value.deptname;
            s.deptno = value.deptno;
            s.location = value.location;
            bool k = ms.updatedept(id, s);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }

        // DELETE: api/Dept/5
        public HttpResponseMessage Delete(int id)
        {
            bool k = ms.Removedept(id);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }
    }
}