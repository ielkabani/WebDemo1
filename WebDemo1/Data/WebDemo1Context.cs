using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebDemo1.Models;

namespace WebDemo1.Data
{
    public class WebDemo1Context : DbContext
    {
        public WebDemo1Context (DbContextOptions<WebDemo1Context> options)
            : base(options)
        {
        }

        public DbSet<WebDemo1.Models.Student> Student { get; set; } = default!;
        public DbSet<WebDemo1.Models.Course> Course { get; set; } = default!;
    }
}
