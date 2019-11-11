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
using Loja_Web_services.Entidade.Entidade;


namespace Projeto_loja.UI
{
    public partial class frmProduto : Form
    {
        ServiceReference1.IService1 service;


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

            service = new ServiceReference1.Service1Client();

            ServiceReference1.Produto produto = CreateProduto();
             bool result = service.SaveProduto(produto);
           
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

                 ServiceReference1.Produto prod = new ServiceReference1.Produto();
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

             private ServiceReference1.Produto CreateProduto()
             {
                 ServiceReference1.Produto produto = new ServiceReference1.Produto();
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
                        service = new ServiceReference1.Service1Client();
                        bool result = service.DeleteProduto(id);
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
            service = new ServiceReference1.Service1Client();
            dgvProduto.DataSource = null;
            IList<ServiceReference1.Produto> List = service.GetProdutos();
            if (List.Count > 0)
            {
                dgvProduto.DataSource = List;
            }
        }

             private void Update(ServiceReference1.Produto prod)
             {
                 frmEditar venda = new frmEditar(prod);
                 venda.ShowDialog();
                 LoadGrid();

             }

             
            #endregion
        }
    }
