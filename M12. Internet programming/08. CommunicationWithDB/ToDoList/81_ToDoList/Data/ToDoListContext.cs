using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _81_ToDoList.Models;

namespace _81_ToDoList.Data
{
    public class ToDoListContext : DbContext
    {
        public ToDoListContext (DbContextOptions<ToDoListContext> options)
            : base(options)
        {
        }

        public DbSet<_81_ToDoList.Models.Task> Task { get; set; }
    }
}
