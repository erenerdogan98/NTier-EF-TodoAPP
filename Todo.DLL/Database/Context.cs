using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Entities;

namespace Todo.DLL.Database
{
    public class Context : DbContext
    {
        string Sqlserver = "server = DESKTOP-57R498V\\SQLEXPRESS01;database = TodoApp; integrated security = true;TrustServerCertificate=true;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Sqlserver);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<TodoLibrary> Todos { get; set; }
    }
}
