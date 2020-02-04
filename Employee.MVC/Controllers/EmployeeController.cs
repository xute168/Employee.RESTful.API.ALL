using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Employee.MVC.Models;
using Employee.MVC.SeviceProxies;


namespace Employee.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        private readonly EmployeeServiceProxy _employeeServiceProxy;
        private readonly EmployeeTaskServiceProxy _employeeTaskServiceProxy;

        public EmployeeController()
        {
            _employeeServiceProxy = new EmployeeServiceProxy();
            _employeeTaskServiceProxy = new EmployeeTaskServiceProxy();
        }

        public async Task<ActionResult> Index()
        {
            return View(await _employeeServiceProxy.GetAll());
        }

        public async Task<ActionResult> Details(int id)
        {
            return View(await _employeeTaskServiceProxy.GetAllByEmployeeId(id));
        }


        [HttpGet]
        public ActionResult Create()
        {
            //return View(await _employeeServiceProxy.Create(newEmployee));
            return View(new Employee.MVC.Models.Employee());
        }

        [HttpPost]
        public async Task<ActionResult> Create(Employee.MVC.Models.Employee newEmployee)
        {
            //return View(await _employeeServiceProxy.Create(newEmployee));
            if (ModelState.IsValid)
            {
                await _employeeServiceProxy.Create(newEmployee);
            }
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Edit(int id)
        {
            return View(await _employeeServiceProxy.GetEmployeeById(id));
            //return Content("id="+id);
        }

        public async Task<ActionResult> Delete(int id)
        {
            string ret = "";
            if (ModelState.IsValid)
            {
                ret = await _employeeServiceProxy.Detele(id);
                if (ret == "Successed")
                {
                    return RedirectToAction("Index");
                }
            }
            if (ret == "BadRequest") ret = "Tasks should be clean out from employee of "+id;
            return Content(ret);

        }

    }
}