using Xunit;
using StudentAPI.Controllers;
using StudentAPI.Models;
using StudentAPI.Services;          
using StudentAPI.Tests.Stubs;

namespace StudentAPI.Tests.Controllers.EstudentController
{
    public class StudentGetMethodsTests
    {
        [Fact]
        public void GetAll_ReturnsAllEstudiantes()
        {
            // Arrange
            var controller = new StudentAPI.Controllers.StudentController(new StudentServiceStub());

            // Act
            var result = controller.GetAll();

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("Ruddy", result[0].Nombre);
            Assert.Equal("Maria", result[1].Nombre);
        }

        [Fact]
        public void GetById_ExistingCI_ReturnsCorrectStudent()
        {
            // Arrange
            var controller = new StudentAPI.Controllers.StudentController(new StudentServiceStub());

            // Act
            var result = controller.GetById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.CI);
            Assert.Equal("Ruddy", result.Nombre);
            Assert.Equal(75, result.Nota);
        }

        [Fact]
        public void GetById_NonExistingCI_ReturnsNullOrDefault()
        {
            // Arrange
            var controller = new StudentAPI.Controllers.StudentController(new StudentServiceStub());

            // Act
            var result = controller.GetById(99); // no existe

            // Assert
            Assert.Null(result); // esto depende de tu implementación del stub
        }
    }
}