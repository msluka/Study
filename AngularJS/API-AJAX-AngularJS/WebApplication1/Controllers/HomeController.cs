using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class HomeController : ApiController
    {
        List<Student> Students = new List<Student>
        {
            new Student {Id = 1, Name = "David", Age = 18, Location = "London"},
            new Student {Id = 2, Name = "Alex", Age = 20, Location = "New Yourk"}, 
            new Student {Id = 3, Name = "Sara", Age = 19, Location = "Paris"}
        };


        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return Students;
        }

        [HttpGet]
        public IHttpActionResult GetStudent(int Id)
        {
            var student = (from s in Students where s.Id == Id select s).Single();
            if (student == null)

                return NotFound();

            return Ok(student);
        }
        
    }
}
