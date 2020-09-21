using Alunos.EfCore.Domain;
using Alunos.EfCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alunos.EfCore.Repository
{
    public class EscolaRepository : IEscolaRepository
    {
        private readonly EscolaAlunoContext ctx;
        public EscolaRepository()
        {
            ctx = new EscolaAlunoContext();
        }

        /// <summary>
        /// Adiciona uma nova escola
        /// </summary>
        /// <param name="produto">Objeto do tipo Escola</param>
        public void Adicionar(Escola escola)
        {
            try 
            { 
            ctx.Escolas.Add(escola);
            //Salvando o objeto 
            ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Busca uma escola pelo seu Id
        /// </summary>
        /// <param name="id">Id de Escola</param>
        /// <returns>Lista de escolas</returns>
        public Escola BuscarPorId(Guid id)
        {
            try
            {
                return ctx.Escolas.Find(id);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Escola >BuscarPorNome(string nome)
        {
            try
            {
                return ctx.Escolas.Where(c => c.Nome.Contains(nome)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Editar(Escola escola)
        {
            try
            {
                //Buscar produto pelo id
                Escola EscolaTemp = BuscarPorId(escola.Id);

                //Verifica se produto existe
                //Caso não existe gera uma exception
                if (EscolaTemp == null)
                    throw new Exception("Escola não encontrada");

                //Caso exista altera sua propriedades
                EscolaTemp.Nome = escola.Nome;
               

                //Altera Produto no contexto
                ctx.Escolas.Update(EscolaTemp);
                //Salva o contexto
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Lista as escolas
        /// </summary>
        /// <returns>retorna uma lista de novas escolas</returns>
        public List<Escola> Listar()
        {
            try
            {
                return ctx.Escolas.ToList();
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
              Escola escolaTemp = BuscarPorId(id);

                //Remove o produto do dbSet
                ctx.Escolas.Remove(escolaTemp);
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
