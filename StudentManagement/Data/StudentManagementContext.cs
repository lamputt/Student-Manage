using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentManagement.Data
{
    public class StudentManagementContext : DbContext
    {
        public StudentManagementContext (DbContextOptions<StudentManagementContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManagement.Models.Departments> Departments { get; set; } = default!;
        public DbSet<StudentManagement.Models.Courses> Courses { get; set; } = default!;
        public DbSet<StudentManagement.Models.Roles> Roles { get; set; } = default!;
    }
}
