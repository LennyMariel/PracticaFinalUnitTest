using StudentAPI.Services;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using System.Collections.Generic;


namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: /Estudent
        [HttpGet]
        public List<Student> GetAll()
        {
            return _studentService.GetAll();
        }

        // GET: /Estudent/{ci}
        [HttpGet("{ci}")]
        public Student GetById(int ci)
        {
            var estudiante = _studentService.GetById(ci);
            if (estudiante == null) return null;
            return estudiante;
            /*var estudiante = _studentService.GetById(ci);
            estudiante.Nombre = "Nombre Estándar"; // ← ⚠ Esto sobreescribe lo que Moq devuelve
            return estudiante;*/
        }

        // POST: /Estudent
        [HttpPost]
        public Student Create(Student estudiante)
        {
            return _studentService.Create(estudiante);
        }

        // PUT: /Estudent/{ci}
        [HttpPut("{ci}")]
        public Student Update(int ci, Student updatedEstudiante)
        {
            return _studentService.Update(ci, updatedEstudiante);
        }

        // DELETE: /Estudent/{ci}
        [HttpDelete("{ci}")]
        public Student Delete(int ci)
        {
            return _studentService.Delete(ci);
        }
    }
}