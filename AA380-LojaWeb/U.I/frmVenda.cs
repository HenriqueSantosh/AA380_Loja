using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_loja.LojaWebService;

namespace Projeto_loja
{
    public partial class frmVenda : Form
    {
        NotaFiscal notaFiscal = new NotaFiscal();
        IWebService service;
        Produto produto = new Produto();
        Produto prod;

        public frmVenda()
        {
            InitializeComponent();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCod.Text);
            GetProduct(id);
        }

        private void GetProduct(int id)
        {
            prod = new Produto();
            service = new WebServiceClient();
            prod = service.GetProdutoByID(id);
            produto = prod;
            ClearFields();
            if (prod == null)
            {
                MessageBox.Show("produto não encontrado");
                return;
            }

            txtNome.Text = prod.Nome;
            txtDescricao.Text = prod.Descricao;
            txtPreco.Text = prod.Preco.ToString();

        }

        private void ClearFields()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
        }

        private void SumSubTotal(int quant, Double preco)
        {
            //txtSubTotal.text = 
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddProdut();
        }

        private void AddProdut()
        {
            if (ValidateFilds())
                return;

            service = new WebServiceClient();
            notaFiscal = service.AddGridProduct(produto, notaFiscal);
            SumTotalPrice();
            LoadGrid();
            ClearFields();
        }

        private void SumTotalPrice()
        {
            txtValortotal.Text = service.SumPrice(notaFiscal).ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateFilds()
        {
            bool result = String.IsNullOrEmpty(txtDescricao.Text.ToString()) ||
                                String.IsNullOrEmpty(txtCod.Text.ToString()) ||
                               String.IsNullOrEmpty(txtNome.Text.ToString()) ||
                          String.IsNullOrEmpty(txtDescricao.Text.ToString()) ||
                          String.IsNullOrEmpty(txtPreco.Text.ToString());
            return result;
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {


            LoadGrid();
        }

        private void LoadGrid()
        {
            dvgVendas.DataSource = null;
            if (notaFiscal.Produtos != null)
            {

                dvgVendas.DataSource = (from p in notaFiscal.Produtos
                                        select new Produto
                                        {
                                            Id = p.Produto.Id,
                                            Nome = p.Produto.Nome,
                                            Descricao = p.Produto.Descricao,
                                            Preco = p.Produto.Preco
                                        }).ToList();
            }
        }

        private void dvgVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool RESULT = dvgVendas.DataSource != null && e.RowIndex >= 0;

                if (e.ColumnIndex == this.btnExcluir.Index && RESULT)
                {
                    DataGridViewRow currentRow = this.dvgVendas.Rows[e.RowIndex];
                    int id = int.Parse(currentRow.Cells[0].Value.ToString());
                    RemoveProduct(id);
                    SumTotalPrice();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void RemoveProduct(int id)
        {
            service = new WebServiceClient();
            notaFiscal = service.RemoveProduct(id, notaFiscal);
            LoadGrid();
        }
    }
}
