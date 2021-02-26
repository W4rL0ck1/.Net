using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macorrati_banco.Model
{
    [Table("Alunos")]
    public class Aluno
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
