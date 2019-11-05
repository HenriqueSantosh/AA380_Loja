using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_loja.Entidade;

namespace Projeto_loja.Interface
{
    interface IProdutoDAO 
    {
        bool Save(Produto p);
        bool Update(Produto p);
        bool Delete(int id);
        IList<Produto> GetProdutos();

    }
}
