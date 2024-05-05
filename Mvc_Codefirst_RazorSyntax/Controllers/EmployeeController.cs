using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Codefirst_RazorSyntax.Models;

namespace Mvc_Codefirst_RazorSyntax.Controllers
{
   
    public class EmployeeController : Controller
    {
        DatabaseContext _Db = new DatabaseContext();
        public ActionResult AddEmployee(int id=0)
        {
            ViewBag.ctr = _Db.tblcountries.ToList();
            ViewBag.pp = "Save";
            tblEmployee obj = new tblEmployee();
            if (id > 0)
            {
                var data = (from a in _Db.tblEmployees where a.empid==id select a).ToList();
                
                obj.empid = data[0].empid;
                obj.name = data[0].name;
                obj.city = data[0].city;
                obj.salary = data[0].salary;
                obj.country = data[0].country;
                obj.state = data[0].state;
                ViewBag.pp = "Update";
            }
            ViewBag.stt= (from a in _Db.tblstates where a.cid == obj.country select a).ToList();
            return View(obj);
        }


        public ActionResult DeleteEmployee(int id=0)
        {
            var data = _Db.tblEmployees.Find(id);
            _Db.tblEmployees.Remove(data);
            _Db.SaveChanges();
            return RedirectToAction("ShowEmployee");
        }
        public ActionResult ShowEmployee()
        {
            var data = (from a in _Db.tblEmployees 
                        join b in _Db.tblcountries on a.country equals b.cid
                        join c in _Db.tblstates on a.state equals c.sid
                        select new tblEmployee1 {empid=a.empid,name=a.name,city=a.city,salary=a.salary,country=b.cname,state=c.sname } ).ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult AddEmployee(tblEmployee _emp)
        {
            if (_emp.empid > 0)
            {
                _Db.Entry(_emp).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                _Db.tblEmployees.Add(_emp);
            }
           
            _Db.SaveChanges();
            return RedirectToAction("ShowEmployee");
        }

        public JsonResult StateGet(int A)
        {
            var data = (from a in _Db.tblstates where a.cid==A select a).ToList();
            return Json(data,JsonRequestBehavior.AllowGet);
        }
    }
}