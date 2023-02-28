using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCrudCodeFast.Models
{
    public class CrudDbContext : DbContext
    {

        public CrudDbContext() : base("DBConnectionStr")
        {
          
        }
        public DbSet<Employee> Employees { get; set; }
    }
}