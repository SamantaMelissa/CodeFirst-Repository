using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Alunos.EfCore.Domain
{
    public class EscolaAluno
    {

        [Key]
        public Guid Id { get; set; }
        
        public Guid IdEscola { get; set; }
        [ForeignKey("IdEscola")]
        public Escola Escola { get; set; }

        public Guid IdAluno { get; set; }
        [ForeignKey("IdAluno")]
        public Aluno Aluno { get; set; }

        public EscolaAluno()
        {
            Id = Guid.NewGuid();
        }
    }
}
