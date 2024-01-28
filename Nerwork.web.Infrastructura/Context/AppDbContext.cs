using Microsoft.EntityFrameworkCore;
using Nerwork.web.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerwork.web.Infrastructura.Context
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions options)  : base(options) { }
        public DbSet<Category> Categories { get; set; }
    }
}
