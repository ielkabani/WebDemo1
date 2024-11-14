using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDemo1.Data;
using WebDemo1.Models;

namespace WebDemo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly WebDemo1Context _context;

        public StudentsController(WebDemo1Context context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public IActionResult GetStudents()
        {
            var studentList = _context.Student.ToList();
            return Ok(studentList);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            Student student = _context.Student.Find(id);
            if (student == null)
                return NotFound();
            return Ok(student);
        }
    }
}
