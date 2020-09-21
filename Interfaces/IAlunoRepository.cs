using Alunos.EfCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alunos.EfCore.Interfaces
{
    interface IAlunoRepository
    {
        List<Aluno> Listar();
        Aluno BuscarPorId(Guid id);
       List<Aluno> BuscarPorNome(string nome);
        void Adicionar(Aluno aluno);
        void Editar(Aluno aluno);
        void Remover(Guid id);






    }
}
