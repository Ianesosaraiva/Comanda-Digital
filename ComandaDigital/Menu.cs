using ComandaDigital.Produtos___CRUD;
using ComandaDigital.Usuario___CRUD;
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
    public partial class Menu : Form
    {

        GenericPrincipal MyPrincipal = Thread.CurrentPrincipal as GenericPrincipal;

        public Menu()
        {
            InitializeComponent();

            GenericIdentity MyIdentity = (GenericIdentity)MyPrincipal.Identity;
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            NovoUsuario novoUsuario = new NovoUsuario();

            this.Hide();
            novoUsuario.Show();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            NovoProduto produto = new NovoProduto();

            this.Hide();
            produto.Show();
        }

        private void btnListarProdutos_Click(object sender, EventArgs e)
        {
            ListarProdutos listar = new ListarProdutos();
            this.Hide();
            listar.Show();
        }

        private void btnAddProduto_Click_1(object sender, EventArgs e)
        {
            NovoProduto novoProduto = new NovoProduto();

            this.Hide();
            novoProduto.Show();
        }

        private void btnListarProdutos_Click_1(object sender, EventArgs e)
        {
            ListarProdutos listarProdutos = new ListarProdutos();

            this.Hide();
            listarProdutos.Show();
        }

        private void btnEditarProdutos_Click(object sender, EventArgs e)
        {
            EditarProduto editarProduto = new EditarProduto();

            this.Hide();
            editarProduto.Show();
        }

        private void btnRemovarProdutos_Click(object sender, EventArgs e)
        {
            RemoverProduto removerProduto = new RemoverProduto();

            this.Hide();
            removerProduto.Show();
        }

        private void btnListarUsuario_Click(object sender, EventArgs e)
        {
            ListarUsuario listarUsuario = new ListarUsuario();

            this.Hide();
            listarUsuario.Show();


        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            EditarUsuario editarUsuario = new EditarUsuario();

            this.Hide();
            editarUsuario.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.Show();
        }

        private void btnAddNComanda_Click_1(object sender, EventArgs e)
        {
            Abrir_Comanda abrir_Comanda = new Abrir_Comanda(Convert.ToInt32(MyPrincipal.Identity.Name));

            this.Hide();
            abrir_Comanda.Show();
        }
    }
}
