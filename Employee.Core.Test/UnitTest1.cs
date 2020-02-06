using Moq;
using System;
using Xunit;
using Employee.Core.SeviceProxies;
using Employee.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Employee.Core.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Core.Test
{
    public class EmployeeControllerTest
    {
        [Fact]
        public void Test1()
        {
            var MockEmployeeServiceProxy = new Mock<IEmployeeServiceProxy>();
            MockEmployeeServiceProxy.Setup(w => w.GetAll()).Returns(Task.FromResult(new List<Models.Employee> {
                new Models.Employee{ EmployeeId=1,
                    FirstName ="aa",
                    LastName ="bb",
                    HireDate =new DateTime(2020,2,5)}
            }));

            var emp = new EmployeeController(MockEmployeeServiceProxy.Object);

            var result = emp.Index();
            var viewresult = Assert.IsType<ViewResult>(result.Result);
            var model = Assert.IsAssignableFrom<List<Models.Employee>>(viewresult.ViewData.Model);
            Assert.Contains("aa", model[0].FirstName);
            Assert.Contains("bb", model[0].LastName);
            Assert.Contains("02/05/2020", model[0].HireDate.ToString("MM/dd/yyyy"));
        }
    }
}
