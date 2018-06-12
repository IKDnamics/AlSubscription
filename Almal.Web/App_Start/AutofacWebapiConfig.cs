
using Autofac;
using Autofac.Core;
using Autofac.Integration.WebApi;
using Autofac.Integration.Mvc;
using Microsoft.Owin.Security;
using Almal.Data;
using Almal.Data.Infrastructure;
using Almal.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Web;
using Almal.Service.SecurityService;
using System.Web.Http;



namespace Almal.Web.App_Start
{
    public class AutofacWebapiConfig
    {
        public static IContainer Container;
        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
           
         
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
       
       
            // EF Context
            builder.RegisterType<Almal.Data.AlmalEntities>()
                   .As<IContext>()
                   .InstancePerRequest();
            builder.RegisterType<ApplicationDbContext>()

                  .InstancePerRequest();
            builder.RegisterAssemblyTypes(Assembly.Load("Almal.Service"))
            .Where(t => t.Name.EndsWith("Service"))

                      .AsImplementedInterfaces()

                      .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(EntityService<>))
                   .As(typeof(IEntityService<>))
                   .InstancePerRequest();

            


            builder.RegisterType<UserManager>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SignInManager>().AsSelf().InstancePerLifetimeScope();
            builder.Register<IAuthenticationManager>(c => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            Container = builder.Build();

            return Container;
        }
    }
}