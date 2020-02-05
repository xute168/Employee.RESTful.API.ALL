using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Employee.RESTful.API.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Employee.RESTful.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EmployeeContext>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            services.AddAutoMapper();
            //Swagger - Enable this line and the related lines in Configure method to enable swagger UI
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo {
                        Title = "ERP API",
                        Version = "v1",
                        Description = "Through this API you can access employees and their tasts",
                        Contact = new Microsoft.OpenApi.Models.OpenApiContact
                        {
                            Email = "xute_168@hotmail.com",
                            Name = "Michael Xu",
                            Url = new Uri("http://www.google.com")
                        }
                    }                    
                    );
                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name }.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);
                options.IncludeXmlComments(xmlCommentsFullPath);
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            { app.UseHsts(); }
            // Enable middleware to serve generated Swagger as a JSON endpoint
            app.UseHttpsRedirection();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "ERP API V1");
                options.RoutePrefix = "";
                options.EnableDeepLinking();
                options.DisplayOperationId();
               
            });
            app.UseStaticFiles();
            // Enable middleware to serve swagger-ui assets (HTML, JS, CSS etc.)

            app.UseMvc();
          

           
        }
    }
}
