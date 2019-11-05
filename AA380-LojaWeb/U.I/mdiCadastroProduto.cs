using Projeto_loja.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_loja.U.I
{
    public partial class mdiCadastroProduto : Form
    {
        private int childFormNumber = 0;

        public mdiCadastroProduto()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

      
      

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto form = new frmProduto();
            form.MdiParent = this;
            form.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frmvenda = new frmVenda();
            frmvenda.MdiParent = this;
            frmvenda.Show();
        }
    }
}
