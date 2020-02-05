using System.Collections.Generic;
using System.Threading.Tasks;
using Employee.MVC.Models;

namespace Employee.MVC.SeviceProxies
{
    public interface IEmployeeServiceProxy
    {
        Task<Models.Employee> Create(Models.Employee newEmployee);
        Task<string> Detele(int id);
        Task<List<Models.Employee>> GetAll();
        Task<Models.Employee> GetEmployeeById(int id);
    }
}