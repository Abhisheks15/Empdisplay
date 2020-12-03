using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebAppGTExer01.Models;

namespace WebAppGTExer01.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            List<Emp> listEmp = new List<Emp>
            {
                new Emp{EId=1,EName="Abhishek",EDesig="Developer",EDOJ=DateTime.Parse("12/12/2016") },
                 new Emp{EId=2,EName="Kavya",EDesig="HR",EDOJ=DateTime.Parse("03/02/2015") },
                  new Emp{EId=3,EName="Sameer",EDesig="Developer",EDOJ=DateTime.Parse("06/06/2020") },
                   new Emp{EId=4,EName="Rohan",EDesig="Tester",EDOJ=DateTime.Parse("10/01/2017") },
                    new Emp{EId=5,EName="Vikas",EDesig="Manager",EDOJ=DateTime.Parse("11/12/2016") },
                     new Emp{EId=6,EName="Ruhee",EDesig="HR",EDOJ=DateTime.Parse("12/05/2018")}
            };
            return View(listEmp);
        }

        // GET: Emp/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emp/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emp/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
