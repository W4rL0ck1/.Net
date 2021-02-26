using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Macorrati_banco.Model
{

    namespace EF6_Relacionamentos.Model
    {
        public class AlunoDbContext : DbContext
        {
            public AlunoDbContext() : base("name=ConexaoSQLServerEscolaDemo") { }

            public DbSet<Aluno> Alunos { get; set; }
        }
    }
}
