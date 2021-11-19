using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _81_TODOList.Models;

namespace _81_TODOList.Data
{
    public class TODOListContext : DbContext
    {
        public TODOListContext (DbContextOptions<TODOListContext> options)
            : base(options)
        {
        }

        public DbSet<_81_TODOList.Models.Task> Task { get; set; }
    }
}
