using Xunit;
using StudentAPI.Models;
using StudentAPI.Services;
using StudentAPI.Tests.Controllers.StudentController;

namespace EstudentAPI.Tests.Services
{
    public class StudentServiceTests
    {
        [Fact]
        public void HasApproved_NotaMayorIgual51_ReturnsTrue()
        {
            // Arrange
            var estudiante = new Student { CI = 1, Nombre = "Ruddy", Nota = 70 };
            var service = new StudentService();

            // Act
            var resultado = service.HasApproved(estudiante);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void HasApproved_NotaMenor51_ReturnsFalse()
        {
            // Arrange
            var estudiante = new Student { CI = 2, Nombre = "Maria", Nota = 45 };
            var service = new StudentService();

            // Act
            var resultado = service.HasApproved(estudiante);

            // Assert
            Assert.False(resultado);
        }
    }
}