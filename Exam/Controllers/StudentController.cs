using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Exam.Models;
using System.IO;
using System.Text;
using System.Configuration;

namespace Exam.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext db = new StudentContext();

        public ActionResult Ranking()
        {
            ViewBag.TopStudents = db.Students.ToList<Student>().OrderByDescending(s => s.Total).Take(5);
            ViewBag.WorthStudents = db.Students.ToList<Student>().OrderBy(s => s.Total).Take(5);
            return View();
        }
        public FileStreamResult CreateFile()
        {
            var students = "";
            foreach (var item in db.Students)
            {
                students += item.FirstName + " " + item.LastName + ", группа: " + item.Group + ", литература: " + item.Value_Literature +
                    ", математика: " + item.Value_Maths + ", физика: " + item.Value_Physics + ", химия: " + item.Value_Chemistry + ", история: " + item.Value_History +
                    ", ОБЩИЙ БАЛЛ: " + item.Total + Environment.NewLine;
            }
            var byteArray = Encoding.UTF8.GetBytes(students);
            var stream = new MemoryStream(byteArray);
            return File(stream, "text/plain", "Список студентов.txt");
        }

        //public void SaveTxt()
        //{
        //    StreamWriter sw = new StreamWriter(Server.MapPath("~/Files/Список студентов.txt"), true);
        //    foreach (var item in db.Students)
        //    {
        //        sw.WriteLine(item.ToString());
        //    }
        //    sw.Close();
        //}
        //public FileResult CreateFile()
        //{
        //    SaveTxt();

        //    string file_path = Server.MapPath("~/Files/Список студентов.txt");
        //    string file_type = "application/txt";
        //    string file_name = "Список студентов.txt";
        //    return File(file_path, file_type, file_name);
        //}
        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,FirstName,LastName,Group,Value_Literature,Value_Maths,Value_Physics,Value_Chemistry,Value_History")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,FirstName,LastName,Group,Value_Literature,Value_Maths,Value_Physics,Value_Chemistry,Value_History")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
