using Macorrati_banco.Model;
using Macorrati_banco.Model.EF6_Relacionamentos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macorrati_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            CriaAluno();
            Console.WriteLine("Aluno criado com sucesso...");
            Console.WriteLine("Acessando os dados dos Alunos...");
            AlunoDbContext db = new AlunoDbContext();
            var resultado = from aluno in db.Alunos select aluno;
            foreach (var a in resultado)
            {
                Console.WriteLine(a.Nome + " " + a.Idade.ToString());
            }
            Console.ReadKey(true);
        }
        static void CriaAluno()
        {
            Aluno aluno = new Aluno
            {
                Id = 1,
                Idade = 12,
                Nome = "Macoratti"
            };
            AlunoDbContext db = new AlunoDbContext();
            db.Alunos.Add(aluno);
            db.SaveChanges();
        }
    }
}

   