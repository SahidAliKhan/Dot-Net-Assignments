using Microsoft.Ajax.Utilities;
using MVC6thOctPS2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6thOctPS2.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        static List<MemberModel> MemberList = new List<MemberModel>();
        static MemberController()
        {
            MemberList.Add(new MemberModel { Memberid = 1, MemberName = "Sahid" });
            MemberList.Add(new MemberModel { Memberid = 2, MemberName = "David" });
            MemberList.Add(new MemberModel { Memberid = 3, MemberName = "Amir" });
            MemberList.Add(new MemberModel { Memberid = 4, MemberName = "Ramesh" });
        }
        public ActionResult Index()
        {
            return View(MemberList);
        }
        public ActionResult EditMember(int id)
        {
            MemberModel foundData = MemberList.Find(Member => Member.Memberid == id);
            return RedirectToAction("EditMemberDetails", new { id = foundData.Memberid });
        }
        public ActionResult EditMemberDetails(int id)
        {
            MemberModel foundData = MemberList.Find(Member => Member.Memberid == id);
            return View(foundData);
        }
        [HttpPost]
        public ActionResult EditMemberDetails(int id, MemberModel m)
        {
            MemberModel foundData = MemberList.Find(Member => Member.Memberid == id);
            MemberList.Remove(foundData);
            MemberList.Add(m);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            MemberModel foundData = MemberList.Find(Member => Member.Memberid == id);
            return View(foundData);
        }
        public ActionResult Delete(int id)
        {
            MemberModel foundData = MemberList.Find(Member => Member.Memberid == id);
            return View(foundData);
        }

        [HttpPost]
        public ActionResult Delete(int id, MemberModel cust)
        {
            MemberModel foundData = MemberList.Find(Member => Member.Memberid == id);
            MemberList.Remove(foundData);
            return View(foundData);
        }
        public ActionResult AddMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMember(MemberModel model)
        {
            MemberList.Add(model);
            return RedirectToAction("Index");
        }

    }
}