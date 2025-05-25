using Xunit;
using Moq;
using StudentAPI.Models;
using StudentAPI.Services;
using StudentAPI.Controllers;
using System.Collections.Generic;

namespace StudentAPI.Tests.Controllers.StudentController
{
    public class StudentControllerWithMoqTests
    {
        [Fact]
        public void GetAll_ReturnsAllEstudiantes_FromMockedService()
        {
            // Arrange
            var mockService = new Mock<IStudentService>();
            mockService.Setup(s => s.GetAll()).Returns(new List<Student>
            {
                new Student { CI = 1, Nombre = "Frank", Nota = 70 },
                new Student { CI = 2, Nombre = "Monserrat", Nota = 40 }
            });

            var controller = new StudentAPI.Controllers.StudentController(mockService.Object);

            // Act
            var result = controller.GetAll();

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("Frank", result[0].Nombre);
            Assert.Equal("Monserrat", result[1].Nombre);
        }

        [Fact]
        public void GetById_ReturnsCorrectEstudiante_FromMock()
        {
            // Arrange
            var mockService = new Mock<IStudentService>();
            var estudiante = new Student { CI = 10, Nombre = "Sonia", Nota = 95 };

            mockService.Setup(s => s.GetById(10)).Returns(estudiante);

            var controller = new StudentAPI.Controllers.StudentController(mockService.Object);

            // Act
            var result = controller.GetById(10);

            // Assert
            Assert.Equal("Sonia", result.Nombre);
            Assert.Equal(95, result.Nota);
        }

        [Fact]
        public void HasApproved_ReturnsTrue_WhenNotaIsSufficient()
        {
            // Arrange
            var estudiante = new Student { CI = 1, Nombre = "Carlos", Nota = 60 };
            var mockService = new Mock<IStudentService>();
            mockService.Setup(s => s.HasApproved(estudiante)).Returns(true);

            var result = mockService.Object.HasApproved(estudiante);

            // Assert
            Assert.True(result);
            mockService.Verify(s => s.HasApproved(estudiante), Times.Once); // se llamó al método 1 vez
        }
    }
}