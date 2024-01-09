using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace todo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=master; Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Tasks> Tasks {get; set;}

        
        
    }

    
}