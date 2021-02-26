using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlunosCursos.Models;

namespace TesteAlunosCursos.DataContext
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("name=ConexaoSQLServerSchoolDemo")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
