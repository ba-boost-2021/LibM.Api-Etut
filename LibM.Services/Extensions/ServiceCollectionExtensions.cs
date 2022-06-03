using LibM.Services.Abstractions;
using LibM.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
