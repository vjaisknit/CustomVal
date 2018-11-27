using CustomVal.CustValidation;
using CustomVal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomVal.Controllers
{
    public class EmployeeController : Controller
    {
        DatabaseContext _db = new DatabaseContext();
        // GET: Employee

        public ActionResult RegisterEmployee()
        {
            var dataForPageLoad = new EmployeeDTO
            {
                SkillList=_db.SkillMsts.ToList()
            };
            return View(dataForPageLoad);
        }
        [HttpPost]
        public ActionResult RegisterEmployee(EmployeeDTO employee)
        {
           if( !ModelState.IsValid)
            {
                var dataForVal = new EmployeeDTO
                {
                    employeeMst = employee.employeeMst,
                    SkillList = _db.SkillMsts.ToList()
                };
                return View(dataForVal);
            }
           
           
            return Redirect("RegisterEmployee");
        }
    }
}