using Microsoft.Practices.Unity;
using PolicyHost.Entity;
using PolicyValidate.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyRepository.IoC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IDatabaseContext, DatabaseContext>(new PerResolveLifetimeManager());
            container.RegisterType<IValidate<Policy>, ValidatePolicy>(new PerResolveLifetimeManager());
        }
    }
}
