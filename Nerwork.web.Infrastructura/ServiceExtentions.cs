using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Nerwork.web.Infrastructura.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerwork.web.Infrastructura
{
    public static class ServiceExtentions
    {
       // public static int AppDdContext { get; private set; }

        public static void AddDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext <AppDbContext> (opt =>
            {
                opt.UseSqlServer (connectionString);
                opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
               
        }
    }
}
