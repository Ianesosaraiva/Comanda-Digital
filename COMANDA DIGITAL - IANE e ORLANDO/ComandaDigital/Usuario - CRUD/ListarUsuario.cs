using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandaDigital.Usuario___CRUD
{
    public partial class ListarUsuario : Form
    {
        comandaEntities bd = new comandaEntities();

        public ListarUsuario()
        {
            InitializeComponent();
            var pessoas = bd.Pessoa.ToList();

            dgDados.DataSource = pessoas;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.Show();
        }
    }
}
