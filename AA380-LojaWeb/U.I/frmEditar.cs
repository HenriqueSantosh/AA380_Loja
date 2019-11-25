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


namespace Projeto_loja.U.I
{
    public partial class frmEditar : Form
    { 
        IWebService service;
        Produto produto;
        public frmEditar(Produto _produto)
        {
             this.produto = _produto;
             
            InitializeComponent();
        }

        #region Eventos 
        private void frmEditar_Load(object sender, EventArgs e)
        {
            LoadObject(produto);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
             if (ValidarCampos())
              {
                  MessageBox.Show("Todos os Campos Devem Ser Preenchidos");
                  return;
              }

            service = new WebServiceClient();
            Produto prod = CreateProduto(produto);
            bool result = service.SaveOrUpdateProduto(prod);
            if (!result)
            {
                MessageBox.Show("Erro ao Alterar");
                return;
            }

            MessageBox.Show("Produto Alterado com sucesso !!");
        }

        #endregion

        #region Metodos
          private void LoadObject(Produto produto)
           {
               txtNome.Text = produto.Nome;
               txtDescricao.Text = produto.Descricao;
               txtPreco.Text =  Convert.ToString(produto.Preco);
           }

           private Produto CreateProduto(Produto produto)
           {
               produto.Nome = txtNome.Text.ToString();
               produto.Descricao = txtDescricao.Text.ToString();
               produto.Preco = Convert.ToDouble(txtPreco.Text.ToString());
               return produto;
           }
           private bool ValidarCampos()
           {
               bool result = string.IsNullOrEmpty(txtDescricao.Text.ToString()) ||
                              string.IsNullOrEmpty(txtNome.Text.ToString()) ||
                              string.IsNullOrEmpty(txtPreco.Text.ToString());
               return result;
           }
       
        #endregion
    }
}

