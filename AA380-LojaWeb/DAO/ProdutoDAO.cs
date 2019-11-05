using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_loja.Interface;
using Projeto_loja.Entidade;

namespace Projeto_loja.DAO
{
    public class ProdutoDAO : IProdutoDAO, IDisposable
    {
        private ProjectDbContext contexto;
        public ProdutoDAO()
        {
            contexto = new ProjectDbContext();
        }
        public bool Delete(int ID)
        {
            try
            {
                Produto produto = contexto.Produtos.Find(ID);
                contexto.Remove(produto);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

       
        public bool Save(Produto produto)
        {
            try
            {
                contexto.Produtos.Add(produto);
                contexto.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                throw ex;
                return false;
            }
        }

        public bool Update(Produto produto)
        {
            try
            {
                contexto.Produtos.Update(produto);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

        public IList<Produto> GetProdutos()
        {
            try
            {

                return contexto.Produtos.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
           
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
