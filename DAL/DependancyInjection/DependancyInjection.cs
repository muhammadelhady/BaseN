using DAL.DatabaseContext;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DependancyInjection
{
    public static class DependencyInjection
    {
        public static void DAL_DI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<DataContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefualtConnection"), m => m.MigrationsAssembly("DAL"));
            });
            services.AddDbContextPool<RemedyContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("ARSystemConnection"), m => m.MigrationsAssembly("DAL"));
            });

            
        
          
        }
    }
}
