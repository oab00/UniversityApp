using System.Web.Http;
using System.Collections.Generic;
using System.Linq;
using University.Models;

namespace University.Controllers
{
    public class StudentsController : ApiController
    {
        Student[] students = new Student[]
        {
            new Student { ID = 0, Name = "John Smith", Grade = 80 },
            new Student { ID = 1, Name = "Jane Roe", Grade = 90 },
            new Student { ID = 2, Name = "John Doe", Grade = 70 }
        };

        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        public IHttpActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault((s) => s.ID == id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

    }
}