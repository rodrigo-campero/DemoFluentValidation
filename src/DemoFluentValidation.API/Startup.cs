using System;
using System.IO;
using System.Reflection;
using DemoFluentValidation.API.Filter;
using DemoFluentValidation.Domain.Validators;
using DemoFluentValidation.IoC;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;

namespace DemoFluentValidation.API
{
    public class Startup
    {
        protected bool IsTest = true;
        public IConfiguration Configuration { get; }
        private Container container = new Container();

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            container = Bootstrap.Register(container);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            if (!IsTest)
            {
                services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    c.IncludeXmlComments(xmlPath);
                    c.AddFluentValidationRules();
                });
            }

            services
                .AddMvc(options =>
                {
                    options.Filters.Add(typeof(ValidationFilter));
                    options.EnableEndpointRouting = false;
                })
                .AddFluentValidation(o =>
                {
                    o.RegisterValidatorsFromAssemblyContaining<CompanyValidator>();
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            services.AddSimpleInjector(container, options =>
            {
                options.AddAspNetCore()
                       .AddControllerActivation();
            });

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSimpleInjector(container);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            if (!IsTest)
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                });
            }

            app.UseMvc();

            container.Verify();
        }
    }
}
