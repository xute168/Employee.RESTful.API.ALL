using System;
using Xunit;
using Employee.MVC.Controllers;

namespace EmployeeMVCTest
{
    public class EmployeeTest
    {
        [Fact]
        public async void ReturnTest1()
        {
            var emp = new EmployeeController();
            //var result = await emp.Index();
        }
    }
}
