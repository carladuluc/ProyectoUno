using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Presentacion
{
    internal static class Program
    {

        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IConfiguration configuration = new ConfigurationBuilder() 
                .AddJsonFile("appsettings.json")
                .Build();

            
            ServiceCollection Services = new ServiceCollection();
            Services.AddSingleton<IConfiguration>(configuration); //para configuraciones
            //Conección a datos
            Services.AddTransient<ProductoRepository>();
            Services.AddTransient<SuplidorRepository>();
            Services.AddTransient<CategoriaRepository>();
            //Para Formularios (listas)
            Services.AddTransient<Inicio>();
            Services.AddTransient<Productos>(); 
            Services.AddTransient<Suplidores>(); 
            Services.AddTransient<Categorias>(); 
            //CRUD Productos
            Services.AddTransient<CrearProducto>();

            //CRUD Suplidores
            Services.AddTransient<CrearSuplidor>()
                ;
            //CRUD Categorias
            Services.AddTransient<CrearCategoria>();

            Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
           




            var serviceProvider = Services.BuildServiceProvider();



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            var mainForm= serviceProvider.GetService<Inicio>();
            Application.Run(mainForm);
        }
    }
}