using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using MVC.DAL;
using MVC.Models;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        //IList<Student> studentList = new List <Student> {
        //    new Student() { StudentId = 1, StudentName = "John", Age = 18, isNewlyEnrolled = true, Password = "New", Gender = Gender.Male} ,
        //    new Student() { StudentId = 2, StudentName = "Steve",  Age = 21, isNewlyEnrolled = false, Password = "Old", Gender = Gender.Male} ,
        //    new Student() { StudentId = 3, StudentName = "Bill",  Age = 25, isNewlyEnrolled = false, Password = "Old", Gender = Gender.Male} ,
        //    new Student() { StudentId = 4, StudentName = "Anna" , Age = 20, isNewlyEnrolled = true, Password = "New", Gender = Gender.Female} ,
        //    new Student() { StudentId = 5, StudentName = "Ron" , Age = 31, isNewlyEnrolled = false, Password = "Old", Gender = Gender.Male} ,
        //    new Student() { StudentId = 4, StudentName = "Chris" , Age = 17, isNewlyEnrolled = true, Password = "New", Gender = Gender.Male} ,
        //    new Student() { StudentId = 4, StudentName = "Elena" , Age = 19, isNewlyEnrolled = true, Password = "New", Gender = Gender.Female}
        //};
        
        
        // GET: Student
        public ActionResult Index()
        {
            
            //return View(studentList);
            var db = new MVCContext();
            var allStudents = db.Students.ToList();

            //using (var db = new MVCContext())
            //{
                //var customer = new Student()
                //{
                //    StudentName = "Johne"
                //};

                //db.Students.Add(customer);
                //db.SaveChanges();
            //}

            return View(allStudents);
            
        }

        public ActionResult Edit(int Id)
        {
            var db = new MVCContext();
            var std = db.Students.Where(s => s.StudentId == Id).FirstOrDefault();
              
            return View(std);
        }
        
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            var db = new MVCContext();

            if (ModelState.IsValid)
            {
                db.Entry(std).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(std);
        }

    }
}