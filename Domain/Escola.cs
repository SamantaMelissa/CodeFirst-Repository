using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alunos.EfCore.Domain
{
    public class Escola
    {
        [Key]
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public Escola()
        {
            Id = Guid.NewGuid();
        }
    }
}
