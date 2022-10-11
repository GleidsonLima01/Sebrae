using HashidsNet;
//using Api.Filtros;
//using Api.Filtros.Swagger;
using Application;
//using Application.Servicos.Automapper;
//using Domain.Extension;
//using Infrastructure;
//using Infrastructure.AcessoRepositorio;
//using Infrastructure.Migrations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Application.Servicos;
using Infra2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();

//builder.Services.AddHttpContextAccessor();
//builder.Services.AddControllers();

//builder.Services.AddEndpointsApiExplorer();
////builder.Services.AddSwaggerGen(option =>
////{
////    option.OperationFilter<HashidsOperationFilter>();
////    option.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Sebrae API", Version = "1.0" });
////    option.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
////    {
////        Name = "Authorization",
////        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
////        Scheme = "Bearer",
////        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
////        Description = "JWT Authorization header utilizando o Bearer scheme. Example: \"Authorization: Bearer {token}\""
////    });
////    option.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
////    {
////        {
////            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
////            {
////                Reference = new Microsoft.OpenApi.Models.OpenApiReference
////                {
////                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
////                    Id = "Bearer"
////                }
////            },
////            System.Array.Empty<string>()
////        }
////    });
////});

////builder.Services.AddInfrastructure(builder.Configuration);
//builder.Services.AddApplication(builder.Configuration);

////builder.Services.AddMvc(options => options.Filters.Add(typeof(FiltroDasExceptions)));

//builder.Services.AddScoped(provider => new AutoMapper.MapperConfiguration(cfg =>
//{
//    cfg.AddProfile(new AutoMapperConfiguracao(provider.GetService<IHashids>()));
//}).CreateMapper());

//builder.Services.AddHealthChecks().AddDbContextCheck<Context>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
