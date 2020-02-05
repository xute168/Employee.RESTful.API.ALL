using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using Employee.Core.Models;

namespace Employee.Core.SeviceProxies
{
    public class EmployeeServiceProxy
    {
        // GET: Employee
        private readonly string Baseurl = "http://localhost:1253/";

        public async Task<List<Employee.Core.Models.Employee>> GetAll()
        {
            List<Employee.Core.Models.Employee> EmpInfo = new List<Employee.Core.Models.Employee>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Employees");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    EmpInfo = JsonConvert.DeserializeObject<List<Employee.Core.Models.Employee>>(EmpResponse);

                }
                //returning the employee list to view  
                return EmpInfo;
            }
            //return View();
        }

        public async Task<Employee.Core.Models.Employee> GetEmployeeById(int id)
        {
            Employee.Core.Models.Employee EmpInfo = new Employee.Core.Models.Employee();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Employees/"+id);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    EmpInfo = JsonConvert.DeserializeObject<Employee.Core.Models.Employee>(EmpResponse);

                }
                //returning the employee list to view  
                return EmpInfo;
            }
            //return View();
        }

        public async Task<Employee.Core.Models.Employee> Create(Employee.Core.Models.Employee newEmployee)
        {
            Employee.Core.Models.Employee EmpInfo = new Employee.Core.Models.Employee();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.PostAsJsonAsync<Employee.Core.Models.Employee>("api/Employees", newEmployee);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    EmpInfo = JsonConvert.DeserializeObject<Employee.Core.Models.Employee>(EmpResponse);

                }
                //returning the employee list to view  
                return EmpInfo;
            }
            //return View();
        }

        public async Task<string> Detele(int id)
        {
            string ret = "";

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.DeleteAsync("api/Employees/"+id);
                
                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    ret = "Successed";
                }
                else
                {
                    ret = Res.StatusCode.ToString();
                }
                
            }
            return ret;
        }

    }
}