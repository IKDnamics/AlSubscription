using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac .Integration.SignalR;
using Autofac.Integration.WebApi;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNet.SignalR;
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
//using TasktyCRM.Web.Hubs;
using Almal.Web.Infrastructure.Security;
using AutofacDependencyResolver = Autofac.Integration.Mvc.AutofacDependencyResolver;
using RegistrationExtensions = Autofac.Integration.SignalR.RegistrationExtensions;
using Almal.Service.SecurityService;
using Microsoft.AspNet.SignalR;



namespace Almal.Web.App_Start
{
    public class AutofacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<TasktyCRM.Data.TasktyCRM>().AsSelf().InstancePerLifetimeScope();

            //builder.RegisterType<UserManager>().AsSelf().InstancePerLifetimeScope();
            //builder.RegisterType<RoleManager>().AsSelf().InstancePerLifetimeScope();
            //builder.RegisterType<SignInManager>().AsSelf().InstancePerLifetimeScope();
            ////builder.RegisterType<ClaimedActionsProvider>().AsSelf().InstancePerLifetimeScope();

            // EF Context
            var context = new Almal.Data.AlmalEntities();
            builder.RegisterType<Almal.Data.AlmalEntities>()

                   .InstancePerRequest();
            builder.RegisterType<ApplicationDbContext>()

                   .InstancePerRequest();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UserManager>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<RoleManager>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClaimedActionsProvider>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SignInManager>().AsSelf().InstancePerLifetimeScope();
            
            builder.Register<IAuthenticationManager>(c => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            builder.Register(c => new UserStore<ApplicationUser>(c.Resolve<Almal.Data.AlmalEntities>())).AsImplementedInterfaces().InstancePerRequest();
            builder.Register(c => new RoleStore<ApplicationRole>(c.Resolve<Almal.Data.AlmalEntities>())).AsImplementedInterfaces().InstancePerRequest();
         
            
           

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


            GlobalHost.DependencyResolver = new Autofac.Integration.SignalR.AutofacDependencyResolver(container);



        }

    }
}