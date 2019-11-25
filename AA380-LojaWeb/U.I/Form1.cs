using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_loja.U.I;
using Projeto_loja.LojaWebService;



namespace Projeto_loja.UI
{
    public partial class frmProduto : Form
    {
        IWebService webService;


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

            webService = new WebServiceClient();


            LojaWebService.Produto produto = CreateProduto();
            bool result = webService.SaveOrUpdateProduto(produto);

            if (!result)
                MessageBox.Show("Erro ao salvar.",
                                                  "Cadastro",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Error,
                                                  MessageBoxDefaultButton.Button1);

            webService = new WebServiceClient();
            LoadGrid(webService.GetProdutos());
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
                string action = "Alterar produto";
                SaveOrUpdate(prod, action);

                webService = new WebServiceClient();
                LoadGrid(webService.GetProdutos());
            }

            if (e.ColumnIndex == this.btnGridExcluir.Index && RESULT)
            {
                DataGridViewRow currentRow = this.dgvProduto.Rows[e.RowIndex];
                int id = int.Parse(currentRow.Cells[0].Value.ToString());
                DeleteProduto(id);
            }

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            webService = new WebServiceClient();
            LoadGrid(webService.GetProdutos());
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

        private void DeleteProduto(int id)
        {

            DialogResult resultado = MessageBox.Show(" Os dados serão perdidos. Confirma a Exlusão?",
                "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                webService = new WebServiceClient();
                bool result = webService.DeleteProduto(id);
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

                webService = new WebServiceClient();
                LoadGrid(webService.GetProdutos());
            }
        }
        private void LoadGrid(IList<Produto> produtos)
        {
            webService = new WebServiceClient();
            dgvProduto.DataSource = null;

            if (produtos != null)
            {
                dgvProduto.DataSource = produtos;
            }
        }

        private void SaveOrUpdate(Produto prod, string action)
        {
            frmEditar venda = new frmEditar(prod);
            venda.Text = action;
            venda.ShowDialog();
            webService = new WebServiceClient();
            LoadGrid(webService.GetProdutos());

        }


        #endregion

        private void btnCad_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            string action = "Cadastrar Produto";
            SaveOrUpdate(produto, action);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            FieldsNameAndDescription();
        }

        private void FieldsNameAndDescription()
        {
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            SearchProductByNameDescription(nome, descricao);
        }
        private void SearchProductByNameDescription(string nome, string descricao)
        {
            webService = new WebServiceClient();
            LoadGrid(webService.GetProdutoByNameDESc(nome, descricao));
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            FieldsNameAndDescription();
        }
    }
}
