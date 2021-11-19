using IRunes.App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRunes.App.Data
{
    class IRunesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=IRunesApp_DB;Integrated Security=True;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

        DbSet<Album> Albums { get; set; }
    }
}
