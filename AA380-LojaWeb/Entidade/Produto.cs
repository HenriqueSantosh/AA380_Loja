using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_loja.Entidade
{
    public class Produto
    {

        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Descricao { get; internal set; }
        public double Preco { get; internal set; }
     
    }
}
