using Microsoft.EntityFrameworkCore;
using System;

using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace File_upload.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options):base(options) { 


        }
        public DbSet<EmployeeModel> Employees_File{ get; set; }
    }
}
