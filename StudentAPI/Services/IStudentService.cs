//using EstudentAPI.Models;
using StudentAPI.Models;
using System.Collections.Generic;

namespace StudentAPI.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int ci);
        Student Create(Student estudiante);
        Student Update(int ci, Student updatedEstudiante);
        Student Delete(int ci);

        bool HasApproved(Student estudiante); // Método clave para Unit Testing
    }
}