using Microsoft.EntityFrameworkCore;
using StudentWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebApi.AppDbContext
{
    public class StudentDbContext : DbContext
    {
        
        public StudentDbContext(DbContextOptions<StudentDbContext> builder)
            : base (builder)
        {
           
        }
        public DbSet<Student> Students { get; set; }
    }
}
