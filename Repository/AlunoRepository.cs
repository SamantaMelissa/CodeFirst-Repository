using Alunos.EfCore.Domain;
using Alunos.EfCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alunos.EfCore.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly EscolaAlunoContext ctx;
        public AlunoRepository()
        {
            ctx = new EscolaAlunoContext();
        }
        public void Adicionar(Aluno aluno)
        {
            
            try
            {
                ctx.Entry(aluno).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Aluno BuscarPorId(Guid id)
        {
            try
            {
                //return _ctx.Produtos.FirstOrDefault(c => c.Id == id); top 1
                return ctx.Alunos.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Aluno> BuscarPorNome(string nome)
        {
            try
            {
                return ctx.Alunos.Where(c => c.Nome.Contains(nome)).ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public void Editar(Aluno aluno)
        {
            //Buscar produto pelo id
            Aluno AlunoTemp = BuscarPorId(aluno.Id);

            //Verifica se produto existe
            //Caso não existe gera uma exception
            if (AlunoTemp == null)
                throw new Exception("Aluno não encontrado");

            //Caso exista altera sua propriedades
            AlunoTemp.Nome = aluno.Nome;
            AlunoTemp.DataNasc = aluno.DataNasc;

            //Altera Produto no contexto
            ctx.Alunos.Update(AlunoTemp);
            //Salva o contexto
            ctx.SaveChanges();
        }

        public List<Aluno> Listar()
        {
            try
            {
                return ctx.Alunos.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remover(Guid id)
        {
            try
            {
                //Buscar produto pelo id
               Aluno alunoTemp = BuscarPorId(id);

                //Remove o produto do dbSet
               ctx.Alunos.Remove(alunoTemp);
                //Salva as alteráções do contexto
              ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                //TODO : Incluir erro na tabela de Log
                throw new Exception(ex.Message);
            }
        }
    }
    
}
