using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandaDigital.Produtos___CRUD
{
    public partial class RemoverProduto : Form
    {
        comandaEntities bd = new comandaEntities();
        string mensagem = "";
        Produto produtos = new Produto();

        public RemoverProduto()
        {
            InitializeComponent();
            tsPesquisa.Focus();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProduto.Text != "")
                {
                    var resultado = MessageBox.Show("Deseja realmente removar esse produto?", "Tem Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        var produto = bd.Produto.FirstOrDefault(x => x.idProduto == this.produtos.idProduto);
                        bd.Produto.Remove(produto);
                        bd.SaveChanges();
                        mensagem = "Produto remolvido com sucesso!";

                        tsPesquisa.Clear();
                        txtProduto.Clear();
                        txtValor.Clear();
                    }
                }
                else
                {
                    mensagem = "Por favor, procure por um produto cadastrado no campo Buscar logo acima!";
                }
               
            }
            catch
            {
                if (txtProduto.Text == null)
                {
                    mensagem = "Digite um produto cadastrado!";
                }
            }
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtos = bd.Produto.FirstOrDefault(x => x.produto1 == tsPesquisa.Text);

                txtProduto.Text = produtos.produto1;
                txtValor.Text = Convert.ToString(produtos.valor);
            }
            catch
            {
                if (tsPesquisa.Text == "")
                {
                    mensagem = "Pesquise pelo nome do produto no campo pesquisa!";
                    tsPesquisa.Focus();
                }
                else if (txtProduto.Text != null)
                {
                    mensagem = "Digite um produto cadastrado!";
                }
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
