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
    public partial class ListarProdutos : Form
    {
        comandaEntities bd = new comandaEntities();
        List<Produto> produtos = new List<Produto>();
        
        public ListarProdutos()
        {
            InitializeComponent();

            this.produtos = bd.Produto.ToList();
            dgDados.DataSource = produtos;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.Show();
        }
    }
}
