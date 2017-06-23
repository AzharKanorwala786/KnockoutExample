using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppDemo.EntityDataModel;
using AppDemo.Models;
using System.Web.Mvc;

namespace AppDemo.Controllers
{
    public class StudentMvcController : Controller
    {
        //static readonly StudentRepository repository = new StudentRepository();
        // GET: StudentMvc
        public ActionResult Students()
        {
            return View();
        }

        // GET: StudentMvc/Details/5
        public JsonResult GetAll()
        {
            return Json(StudentRepository.GetStudents(), JsonRequestBehavior.AllowGet);
        }

        // GET: StudentMvc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentMvc/Create
        [HttpPost]
        public ActionResult Create(Student student)
        { 
          StudentRepository.InsertStudent(student);
          return Json(student, JsonRequestBehavior.AllowGet);
        }

        // GET: StudentMvc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentMvc/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Student student)
        {
            StudentRepository.DeleteStudent(id);
            return Json(new { Status = true }, JsonRequestBehavior.AllowGet);
        }
    }
}
