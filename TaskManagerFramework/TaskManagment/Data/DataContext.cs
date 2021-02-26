using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using TaskManager.Models;

namespace TaskManager.Data
{

    public class DataContext : DbContext
    {
        public DataContext() : base("name=ConexaoSQLServerEntityDemo")
        { }
        public DbSet<Task> Task { get; set; }
        public DbSet<CheckoutProcess> CheckOutProcess { get; set; }        
        public DbSet<Department> Department { get; set; }    
        public DbSet<User> User { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}
