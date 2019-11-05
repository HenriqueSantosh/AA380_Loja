using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_loja.Entidade;
using Projeto_loja.BLL;
using Projeto_loja.U.I;

namespace Projeto_loja.UI
{
    public partial class frmProduto : Form
    {
        private ProdutoBLL produtoBll;
        public frmProduto()
        {
            InitializeComponent();
        }
        #region Eventos |
        private void mntCadastar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.",
                                                  "Cadastro",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Exclamation,
                                                  MessageBoxDefaultButton.Button1);
                return;
            }

            produtoBll = new ProdutoBLL();
            Produto produto = CreateProduto();
            bool result = produtoBll.Save(produto);
            if (!result)
                MessageBox.Show("Erro ao salvar.",
                                                  "Cadastro",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Error,
                                                  MessageBoxDefaultButton.Button1);

            LoadGrid();
            MessageBox.Show("Cadastrado com sucesso.",
                                                  "Cadastro",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Information,
                                                  MessageBoxDefaultButton.Button1);

        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool RESULT = dgvProduto.DataSource != null && e.RowIndex >= 0;

            if (e.ColumnIndex == this.btnGridEditar.Index && RESULT)
            {
                DataGridViewRow currentRow = this.dgvProduto.Rows[e.RowIndex];

                Produto prod = new Produto();
                prod.Id = int.Parse(currentRow.Cells[0].Value.ToString());
                prod.Nome = currentRow.Cells[1].Value.ToString();
                prod.Descricao = currentRow.Cells[2].Value.ToString();
                prod.Preco = Convert.ToDouble(currentRow.Cells[3].Value.ToString());
                Update(prod);
                LoadGrid();
            }

            if(e.ColumnIndex == this.btnGridExcluir.Index && RESULT)
            {
                DataGridViewRow currentRow = this.dgvProduto.Rows[e.RowIndex];
                int id = int.Parse(currentRow.Cells[0].Value.ToString());
                DeleteProduto(id);
            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        #endregion

        #region Metodos
        private bool ValidarCampos()
        {
            bool result = string.IsNullOrEmpty(txtDescricao.Text.ToString()) ||
                           string.IsNullOrEmpty(txtNome.Text.ToString()) ||
                           string.IsNullOrEmpty(txtPreco.Text.ToString());
            return result;
        }

        private Produto CreateProduto()
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text.ToString();
            produto.Descricao = txtDescricao.Text.ToString();
            produto.Preco = Double.Parse(txtPreco.Text.ToString());

            return produto;
        }

        private void  DeleteProduto(int id)
        {
           
            DialogResult resultado = MessageBox.Show(" Os dados serão perdidos. Confirma a Exlusão?",
                "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                produtoBll = new ProdutoBLL();
                bool result = produtoBll.Delete(id);
                if (!result)
                {
                    MessageBox.Show("Erro ao excluir os dados.",
                                                  "Excluir",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Error,
                                                  MessageBoxDefaultButton.Button1);
                    return;
                }
                MessageBox.Show("Dados Excluidos.",
                                                 "Excluir",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information,
                                                 MessageBoxDefaultButton.Button1);
                LoadGrid();
            }
        }
        private void LoadGrid()
        {
            produtoBll = new ProdutoBLL();
            dgvProduto.DataSource = null;
            if (produtoBll.GetProdutos().Count > 0)
            {
                dgvProduto.DataSource = produtoBll.GetProdutos();
            }
        }

        private void Update(Produto prod)
        {
            frmEditar venda = new frmEditar(prod);
            venda.ShowDialog();
            LoadGrid();
           
        }
        #endregion


    }
}
