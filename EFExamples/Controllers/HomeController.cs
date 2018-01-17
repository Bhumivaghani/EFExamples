using EFExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EFExamples.Controllers
{
    public class HomeController : Controller
    {
        EFContext stud = new EFContext();

        public ViewResult Index()
        {
            
            return View(stud.students);
        }

        public ViewResult Insert(int id)
        {
           
            Student student = stud.students.FirstOrDefault(x => x.id == id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Insert(Student student)
        {
           
            if (student.id == 0)
            {
                stud.students.Add(student);
            }
            else
            {
                Student dbEntry = stud.students.Find(student.id);
                if (dbEntry != null)
                {
                    dbEntry.name = student.name;
                    dbEntry.address = student.address;
                    dbEntry.age = student.age;
                }
            }
            stud.SaveChanges();

           
            return RedirectToAction("Index");
        }

        
        public ActionResult Create()
        {
            return View("Insert",new Student());
        }

        public ActionResult Delete(int id)
        {
            
            Student dbEntry = stud.students.Find(id);
            if (dbEntry != null)
            {
                stud.students.Remove(dbEntry);
                stud.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}