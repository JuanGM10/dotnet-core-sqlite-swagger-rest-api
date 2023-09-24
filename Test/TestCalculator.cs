using Backend.Controllers;
using Backend.Models;
using Backend.Repository;
using Backend.Request;
using Backend.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Reflection.Metadata;
using Xunit;
using Xunit.Sdk;

namespace BackEnd.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Suma()
        {
            var request = new CalculatorRequest() { Number1 = 12, Number2 = 4 };
            var repositoryMock = new Mock<ICalculatorRepository>();
            var s = repositoryMock
                .Setup(r => r.Suma(request))
                .Returns(new ResponseApi() { Code = 200, Message = "Success", Result = 16 });

            var controller = new CalculatorController(repositoryMock.Object);

            // Act
            var blog = controller.Suma(request);

            // Assert
            repositoryMock.Verify(r => r.Suma(request));
            Assert.Equal(200, blog.Code);
        }

        [Fact]
        public void Multiplicacion()
        {
            var request = new CalculatorRequest() { Number1 = 5, Number2 = 4 };
            var repositoryMock = new Mock<ICalculatorRepository>();
            var s = repositoryMock
                .Setup(r => r.Suma(request))
                .Returns(new ResponseApi() { Code = 200, Message = "Success", Result = 16 });

            var controller = new CalculatorController(repositoryMock.Object);

            // Act
            var blog = controller.Suma(request);

            // Assert
            repositoryMock.Verify(r => r.Suma(request));
            Assert.Equal(200, blog.Code);
        }
    }
}
