using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_loja.Entidade
{
    public class NotaFiscal
    {
        public int Id { get; set; }

        public DateTime DataNota { get; set; }

        public float ValorTotal { get; set; }
        public IList<Produto> Produtos { get; set; }
    }
}
