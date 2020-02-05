using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using Employee.MVC.SeviceProxies;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

[assembly: OwinStartup(typeof(Employee.MVC.Startup))]

namespace Employee.MVC
{
    public class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
        //    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        //}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IEmployeeServiceProxy, EmployeeServiceProxy>();
        }
    }
}
