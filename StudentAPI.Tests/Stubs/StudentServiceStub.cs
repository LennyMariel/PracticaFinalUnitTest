using StudentAPI.Models;
using StudentAPI.Services;

namespace StudentAPI.Tests.Stubs
{
    public class StudentServiceStub : IStudentService
    {
        private List<Student> _estudiantes;

        public StudentServiceStub()
        {
            _estudiantes = new List<Student>
            {
                new Student { CI = 1, Nombre = "Ruddy", Nota = 75 },
                new Student { CI = 2, Nombre = "Maria", Nota = 40 }
            };
        }

        public List<Student> GetAll()
        {
            return _estudiantes;
        }

        public Student GetById(int ci)
        {
            return _estudiantes.FirstOrDefault(e => e.CI == ci)!;
        }

        public Student Create(Student estudiante)
        {
            estudiante.CI = _estudiantes.Max(e => e.CI) + 1;
            return estudiante;
        }

        public Student Update(int ci, Student updatedEstudiante)
        {
            return updatedEstudiante;
        }

        public Student Delete(int ci)
        {
            return _estudiantes.FirstOrDefault(e => e.CI == ci)!;
        }

        public bool HasApproved(Student estudiante)
        {
            return estudiante.Nota >= 51;
        }
    }
}