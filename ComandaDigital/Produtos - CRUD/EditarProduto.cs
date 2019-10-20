using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandaDigital
{
    public partial class EditarProduto : Form
    {
        comandaEntities bd = new comandaEntities();
        Produto produto = new Produto();
        string mensagem = "";

        public EditarProduto()
        {
            InitializeComponent();
            tsPesquisa.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                produto.produto1 = txtProduto.Text;
                produto.valor = Convert.ToDouble(txtValor.Text);

                bd.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();


                mensagem = "Produto editado com sucesso!";

                txtProduto.Clear();
                txtValor.Clear();
                tsPesquisa.Clear();
                tsPesquisa.Focus();
            }
            catch
            {
                if (txtProduto.Text == null)
                {
                    mensagem = "Digite um produto cadastrado!";
                }
                else
                {
                    mensagem = "Por favor, utilize apenas numeros positivos no campo Preço!";
                }
            }
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                this.produto = bd.Produto.FirstOrDefault(x => x.produto1 == tsPesquisa.Text);

                txtProduto.Text = produto.produto1;
                txtValor.Text = Convert.ToString(produto.valor);

                txtProduto.Enabled = true;
                txtValor.Enabled = true;
            }
            catch
            {
                if(tsPesquisa.Text == null)
                {
                    mensagem = "Pesquise pelo nome do produto no campo pesquisa!";
                    tsPesquisa.Focus();
                }
                else if (txtProduto.Text != null)
                {
                    mensagem = "Digite um produto cadastrado!";
                }
                MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.Show();
        }
    }
}
