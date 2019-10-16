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
    public partial class Login : Form
    {
        comandaEntities bd = new comandaEntities();

        public Login()
        { 
            InitializeComponent();
        }

        public void autenticacao(int User)
        {
            GenericIdentity MyIdentity = new GenericIdentity(Convert.ToString(User));
            GenericPrincipal MyPrincipal = new GenericPrincipal(MyIdentity, null);
            Thread.CurrentPrincipal = MyPrincipal;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            var usuarios = bd.Pessoa.FirstOrDefault(x => x.cpf == txtUser.Text && x.senha == txtPassword.Text);

            if (usuarios != null)
            {
                autenticacao(usuarios.idPessoa);

                if (usuarios.Acesso.descricao == "Administrador")
                {
                    Menu menu = new Menu();

                    this.Hide();
                    menu.Show();
                }
                else
                {
                    Abrir_Comanda comanda = new Abrir_Comanda(usuarios.idPessoa);

                    this.Hide();
                    comanda.Show();
                }

            }
            else
            {
                MessageBox.Show("Login ou senha inválidos", "Ocorreu um erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnEntrar_Click(sender, e);
            }
        }

        public void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
