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
    public partial class Cupom : Form
    {
        DataTable Tabela;
        DataRow Linha;

        int contador = 0;

        List<Produto> Pedidos;

        comandaEntities bd = new comandaEntities();


        GenericPrincipal MyPrincipal = Thread.CurrentPrincipal as GenericPrincipal;

        public Cupom(int numeroComanda, int idPessoa, double total,
            double dinheiro, double troco, List<Produto> tabelaPedidos)

        {
            Pedidos = tabelaPedidos;

            InitializeComponent();
            tabela();

            laComandaN.Text = Convert.ToString(numeroComanda);
            laData.Text = Convert.ToString(DateTime.Now);
            laFuncionario.Text = Convert.ToString(idPessoa);

            laTotalItens.Text = Convert.ToString(contador);
            laTotal.Text += Convert.ToString(total);
            laPago.Text += Convert.ToString(dinheiro);
            laTroco.Text += Convert.ToString(troco);


            GenericIdentity MyIdentity = (GenericIdentity)MyPrincipal.Identity;
        }

        private void tabela()
        {
            Tabela = new DataTable();

            // Adiciona os nomes e tipos das colunas
            Tabela.Columns.Add("PRODUTO", typeof(string));
            Tabela.Columns.Add("QUANTIDADE", typeof(decimal));
            Tabela.Columns.Add("PREÇO", typeof(decimal));
            Tabela.Columns.Add("TOTAL", typeof(decimal));

            foreach (var item in Pedidos)
            {
                Linha = Tabela.NewRow();

                Linha[0] = item.produto1;
                Linha[1] = item.quantidade;
                Linha[2] = item.valor;
                Linha[3] = item.valor * item.quantidade;

                Tabela.Rows.Add(Linha);
                contador++;
            }

            dgDados.DataSource = Tabela;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Abrir_Comanda abrir = new Abrir_Comanda(Convert.ToInt32(MyPrincipal.Identity.Name));

            this.Close();
            abrir.Show();
        }
    }
}
