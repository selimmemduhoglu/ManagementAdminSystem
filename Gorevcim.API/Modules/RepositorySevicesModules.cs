using Gorevcim.Repository.UnitOfWork;
using FluentValidation;
using Module = Autofac.Module;
using Autofac.Extensions.DependencyInjection;
using Gorevcim.Core;
using Gorevcim.API.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Gorevcim.Core.Repositories;
using Gorevcim.Core.Services;
using Gorevcim.Core.UnitOfWork;
using Gorevcim.Repository.Repositories;
using Gorevcim.Service.Mappings;
using Gorevcim.Service.Services;
using Autofac;

namespace Gorevcim.API.Modules
{
    public class RepositorySevicesModules : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductsRepository>();

            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();

            builder.RegisterType<UnitOfWork>().As<IGenericUnitOfWork>();

            var repository = Assembly.GetAssembly(typeof(AppContext));
            var service = Assembly.GetAssembly(typeof(MapProfiles));
            var api = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope(); ;
            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();



        }








    }
}

