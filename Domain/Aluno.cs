using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alunos.EfCore.Domain
{
    public class Aluno
    {
        [Key]
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNasc { get; set; }

        [Required]
        public int Quantidade { get; set; }


        public Aluno()
        {
            Id = Guid.NewGuid();
        }
    }
}
