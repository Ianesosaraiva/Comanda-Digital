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
    public partial class NovoProduto : Form
    {
        comandaEntities bd = new comandaEntities();
        string mensagem = "";

        public NovoProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();


            try
            {
                produto.produto1 = txtProduto.Text;
                produto.valor = Convert.ToDouble(txtValor.Text);

                bd.Produto.Add(produto);
                bd.SaveChanges();

                mensagem = "Produto adicionado com sucesso";

                txtProduto.Clear();
                txtValor.Clear();
                txtProduto.Focus();

            }
            catch
            {
                if (txtProduto.Text == "" || txtValor.Text == "")
                {
                    mensagem = "Por favor, preencha todos os campos!";
                }
                else if (Convert.ToDouble(txtValor.Text) < 0)
                {
                    mensagem = "Por favor, utilize apenas numeros positivos no campo Preço!";
                }
                else
                {
                    mensagem = "Por favor, preencha todos os campos!";
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
    }
}
