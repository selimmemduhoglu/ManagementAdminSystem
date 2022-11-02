using Gorevcim.Repository.AppDbContexts.AppDbContext;
using Gorevcim.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Gorevcim.Core.Repositories;
using Gorevcim.Core.UnitOfWork;
using Gorevcim.Repository.UnitOfWork;
using Gorevcim.Core;
using System.Net.Sockets;
using Gorevcim.Service.Services;
using Gorevcim.Service.Mappings;
using Gorevcim.Core.DTOs;
using FluentValidation;
using FluentValidation.AspNetCore;
using Gorevcim.Service.Validation;
using Gorevcim.API.Filters;
using Microsoft.AspNetCore.Mvc;
using Gorevcim.API.Middlewares;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using Gorevcim.API.Modules;


var builder = WebApplication.CreateBuilder(args);


builder.Host.UseServiceProviderFactory(new AutoServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepositoryServicesmodule()));

builder.Services.AddControllers(options => options.Filters.Add(new ValidateFilterAttribute())).AddFluentValidation(x => x.registerValidatorsFromAssemblyContaining<ProductDtoValidator>());
builder.Services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(NotFoundFilter<>));
builder.Services.AddAutoMapper(typeof(MapProfiles));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//Bizim yazdýðýmýz kýsým

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});
// Ýsme göre deðil  tipe göre çekiyoruz.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}





app.UseHttpsRedirection();

app.UseCustomException();

app.UseAuthorization();

app.MapControllers();

app.Run();
