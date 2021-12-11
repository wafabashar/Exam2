using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Exam2.data
{
    public class Emoloyee_Context:DbContext
    {
        IConfiguration configuration;

        public Emoloyee_Context(IConfiguration _configuration)
        {
            configuration = _configuration;

        }

        public Emoloyee_Context()
        {
            

        }

        public DbSet<Employee> Employee { set; get; }

        public DbSet<Department> Department { set; get; }

        public DbSet<Country> country { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("EmployeeConnectionString"));
            base.OnConfiguring(optionsBuilder);
        }

    }
}
