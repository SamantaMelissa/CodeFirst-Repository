using Alunos.EfCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alunos.EfCore.Interfaces
{
    interface IEscolaRepository
    {
        List<Escola> Listar();
        Escola BuscarPorId(Guid id);
        List<Escola> BuscarPorNome(string nome);
        void Adicionar(Escola escola);
        void Editar(Escola escola);
        void Remover(Guid id);
    }
}
