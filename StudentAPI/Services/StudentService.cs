using StudentAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentAPI.Services
{
    public class StudentService : IStudentService
    {
        private List<Student> _estudiantes;

        public StudentService()
        {
            _estudiantes = new List<Student>();
        }

        public List<Student> GetAll()
        {
            return _estudiantes;
        }

        public Student GetById(int ci)
        {
            var estudiante = _estudiantes.FirstOrDefault(e => e.CI == ci);
            if (estudiante == null)
            {
                estudiante = new Student
                {
                    CI = -1,
                    Nombre = "No Encontrado",
                    Nota = 0
                };
            }
            return estudiante;
        }

        public Student Create(Student estudiante)
        {
            estudiante.CI = _estudiantes.Count > 0 ? _estudiantes.Max(e => e.CI) + 1 : 1;
            _estudiantes.Add(estudiante);
            return estudiante;
        }

        public Student Update(int ci, Student updatedEstudiante)
        {
            var estudiante = _estudiantes.FirstOrDefault(e => e.CI == ci);
            if (estudiante != null)
            {
                estudiante.Nombre = updatedEstudiante.Nombre;
                estudiante.Nota = updatedEstudiante.Nota;
            }
            return estudiante;
        }

        public Student Delete(int ci)
        {
            var estudiante = _estudiantes.FirstOrDefault(e => e.CI == ci);
            if (estudiante != null)
            {
                _estudiantes.Remove(estudiante);
            }
            return estudiante;
        }

        public bool HasApproved(Student estudiante)
        {
            return estudiante.Nota >= 51;
        }
    }
}