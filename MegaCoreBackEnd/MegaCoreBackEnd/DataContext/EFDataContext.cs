using MegaCoreBackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCoreBackEnd.DataContext
{
    public class EFDataContext : DbContext
    {
        public DbSet<Trbpkb> Trbpkb { get; set; }

        public DbSet<Msstoragelocation> Msstoragelocation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=.; initial catalog=Dummy;persist security info=True;user id=sa;password=123456;");
        }
    }
}
