using DemoFluentValidation.Domain.Interfaces;
using DemoFluentValidation.Domain.Services;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFluentValidation.IoC
{
    public class Bootstrap
    {
        public static Container Register(Container container)
        {

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<ICompanyService, CompanyService>(Lifestyle.Scoped);
            return container;
        }
    }
}
