using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoAppEntityLayer.Entities;

namespace ToDoAppDataLayer
{
    public class MyContext:DbContext
    {
        public MyContext()
        {

        }

        public virtual DbSet<ToDo> ToDoTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("localConnection");
            optionsBuilder.UseSqlServer("Server=HELIN-PC\\SQLEXPRESS;Database=ToDoAppDB;Trusted_Connection=True;TrustServerCertificate=True");
            //base.OnConfiguring(optionsBuilder);
        }

    }
}
