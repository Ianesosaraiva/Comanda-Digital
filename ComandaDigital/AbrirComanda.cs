using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandaDigital
{
    public partial class Abrir_Comanda : Form
    {
        comandaEntities bd = new comandaEntities();
        int numeroComanda;
        string mensagem;

        int first;

        GenericPrincipal MyPrincipal = Thread.CurrentPrincipal as GenericPrincipal;

        public Abrir_Comanda(int idPessoa)
        {
            InitializeComponent();

            var usuarioLogado = bd.Pessoa.FirstOrDefault(x => x.idPessoa == idPessoa);

            if (usuarioLogado.Acesso.descricao == "Administrador")
            {
                toolStrip1.Visible = false;
            }
            else
            {
                btnVoltar.Visible = false;
                laLogadoNome.Text = usuarioLogado.nome;
            }
        }

        private void Abrir()
        {

        }

        private void BtnAbrirComanda_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtNumero.Text) > 0)
                {
                    numeroComanda = Convert.ToInt32(txtNumero.Text);

                    var comanda = bd.Comanda.FirstOrDefault(x => x.Pedido.numeroComanda == numeroComanda && x.Pedido.flgEncerramento != 1);

                    Pedidos pedidoView = new Pedidos(false, Convert.ToInt32(txtNumero.Text));

                    if (comanda != null)
                    {
                        pedidoView = new Pedidos(true, Convert.ToInt32(txtNumero.Text));
                    }

                    this.Hide();

                    pedidoView.Show();
                }
                else
                {
                    MessageBox.Show("A comanda é composta apenas por numeros positivos!");
                    txtNumero.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Digite o numero da comanda no campo acima!");
                txtNumero.Focus();
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.Show();
        }
    }
}
