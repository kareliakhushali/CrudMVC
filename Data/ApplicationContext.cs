using CrudMVC.Models.ImageImplementation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMVC.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Laptop> Laptops { get; set;  }
    }

}
