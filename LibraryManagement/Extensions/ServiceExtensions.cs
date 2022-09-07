using LibraryManagement.BusinessRepository.Contracts;
using LibraryManagement.BusinessRepository.Implemented;
using LibraryManagement.DataContext;
using LibraryManagement.DataRepository.Contracts;
using LibraryManagement.DataRepository.Implemented;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<AppDataContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("connectDB")));
    
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICategoryData, CategoryData>();
            services.AddScoped<ICatgeoryBusiness, CategoryBusiness>();
            services.AddScoped<IBookData, BookData>();
            services.AddScoped<IBookBusiness, BookBusiness>();
            services.AddScoped<IStudentData, StudentData>();
            services.AddScoped<IStudentBusiness, StudentBusiness>();
        }
    }
}
