using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentsMVC_Assignment3.Models;

namespace StudentsMVC_Assignment3.Data
{
    public class StudentsMVC_Assignment3Context : DbContext
    {
        public StudentsMVC_Assignment3Context (DbContextOptions<StudentsMVC_Assignment3Context> options)
            : base(options)
        {
        }

        public DbSet<StudentsMVC_Assignment3.Models.Students> Students { get; set; } = default!;
    }
}
