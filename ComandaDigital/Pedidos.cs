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
    public partial class Pedidos : Form
    {
        bool pedidoFeito = false;
        bool abriuComanda = false;
        int numeroComanda;
        double total;
        double dinheiro;
        double troco;
        string mensagem;
        string produtoMensagem;

        comandaEntities bd = new comandaEntities();

        List<Produto> produtos = new List<Produto>();
        List<Produto> produtosPedido = new List<Produto>();

        GenericPrincipal MyPrincipal = Thread.CurrentPrincipal as GenericPrincipal;

        public Pedidos(bool comandaTrue, int numero)
        {
            InitializeComponent();

            numeroComanda = numero;
            if (comandaTrue == true)
            {
                var pedido = bd.Pedido.Where(x => x.numeroComanda == numeroComanda && x.flgEncerramento != 1);

                pedidoFeito = true;

                foreach (var item in pedido)
                {
                    this.produtosPedido.Add(item.Produto);
                    total += Convert.ToDouble(item.Produto.valor) * item.quantidade;
                }
                atualizaListaProduto(true);
                laTotal.Text = "R$: " + total;
            }

            this.produtos = bd.Produto.ToList();

            foreach (var item in this.produtos)
            {
                listBox1.Items.Add(item.produto1);
            }


            GenericIdentity MyIdentity = (GenericIdentity)MyPrincipal.Identity;
            
        }
        
        private void addListaProdutos(Produto produto)
        {
            var prod = this.produtosPedido.FirstOrDefault(x => x.produto1 == produto.produto1);

            if (prod == null)
            {
                produto.quantidade = 1;
                this.produtosPedido.Add(produto);
                total += Convert.ToDouble(produto.valor);
                laTotal.Text = "R$: " + total;
            }
            else
            {
                this.produtosPedido.Remove(produto);
                if (produto.quantidade != 0)
                {
                    produto.quantidade++;
                    this.produtosPedido.Add(produto);
                    total += Convert.ToDouble(produto.valor);
                    laTotal.Text = "R$: " + total;
                }
            }

            atualizaListaProduto(true);
        }

        private void menosItemProduto(Produto produto)
        {
            this.produtosPedido.Remove(produto);
            if (produto.quantidade != 1)
            {
                produto.quantidade--;
                this.produtosPedido.Add(produto);
                total -= Convert.ToDouble(produto.valor);
                laTotal.Text = "R$: " + total;
            }
            else
            {
                total -= Convert.ToDouble(produto.valor);
                laTotal.Text = "R$: " + total;
            }

            atualizaListaProduto(false);
        }

        private void atualizaListaProduto(bool index)
        {
            if (index)
            {
                listBox2.Items.Clear();
                foreach (var item in this.produtosPedido)
                {
                    produtoMensagem = item.produto1 + " - " + item.quantidade + " Total: R$" + item.quantidade * item.valor;
                    listBox2.Items.Add(produtoMensagem);
                    abriuComanda = true;
                }
            }
            else
            {
                listBox2.Items.Clear();
                foreach (var item in this.produtosPedido)
                {
                    produtoMensagem = item.produto1 + " - " + item.quantidade + "Total: R$" + item.quantidade * item.valor;
                    listBox2.Items.Add(produtoMensagem);
                }
            }

        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            try
            {
                var index = listBox1.Items.IndexOf(listBox1.SelectedItem);

                var produto = produtos[index];

                addListaProdutos(produto);
            }
            catch
            {
                MessageBox.Show("Por favor, selecionar item!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                var index = listBox1.Items.IndexOf(listBox1.SelectedItem);

                var produto = produtos[index];

                menosItemProduto(produto);
            }
            catch
            {
                MessageBox.Show("Por favor, selecionar item!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fecharComanda()
        {
            foreach (var item in this.produtosPedido)
            {
                var pedido = bd.Pedido.FirstOrDefault(x => x.idPedido == x.idPedido && x.Produto.produto1 == item.produto1 &&
                                                           x.numeroComanda == numeroComanda && x.flgEncerramento != 1);

                pedido.flgEncerramento = 1;

                bd.Entry(pedido).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
        }

        private void salvarComanda(bool fechar)
        {
            Pedido pedido = new Pedido();
            Comanda comanda = new Comanda();

            var pedidos = bd.Pedido.ToList();

            foreach (var item in this.produtosPedido)
            {
                pedido = bd.Pedido.FirstOrDefault(x => x.idPedido == x.idPedido && x.Produto.produto1 == item.produto1 &&
                                                        x.numeroComanda == numeroComanda && x.flgEncerramento != 1);


                if (pedido == null)
                {
                    pedido = new Pedido();

                    pedido.idProduto = item.idProduto;
                    pedido.quantidade = Convert.ToInt32(item.quantidade);
                    pedido.numeroComanda = numeroComanda;

                    bd.Pedido.Add(pedido);
                }
                else
                {
                    pedido.idProduto = item.idProduto;
                    pedido.quantidade = Convert.ToInt32(item.quantidade);
                    pedido.numeroComanda = numeroComanda;

                    bd.Entry(pedido).State = System.Data.Entity.EntityState.Modified;
                }

                bd.SaveChanges();
            }

            //Salvar Comanda Começa Aqui
            comanda = bd.Comanda.FirstOrDefault(x => x.Pedido.numeroComanda == numeroComanda && x.Pedido.flgEncerramento != 1);
            

            if (comanda == null)
            {
                comanda = new Comanda();

                comanda.idPessoa = Convert.ToInt32(MyPrincipal.Identity.Name);
                comanda.data = DateTime.Now;
                comanda.total = total;

                comanda.idPedido = pedido.idPedido;

                bd.Comanda.Add(comanda);
            }
            else
            {
                comanda.idPessoa = Convert.ToInt32(MyPrincipal.Identity.Name);
                comanda.data = DateTime.Now;
                comanda.total = total;

                bd.Entry(comanda).State = System.Data.Entity.EntityState.Modified;
            }

            bd.SaveChanges();

            if (fechar)
            {
                fecharComanda();

                Cupom cupom = new Cupom(numeroComanda, comanda.idPessoa, total, dinheiro, troco, this.produtosPedido);

                cupom.Show();
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            bool flg = false;
            if (pedidoFeito)
            {
                try
                {
                    if (Convert.ToDouble(txtDinheiro.Text) > 0 && total <= Convert.ToDouble(txtDinheiro.Text))
                    {
                        dinheiro = Convert.ToDouble(txtDinheiro.Text);

                        troco = dinheiro - total;
                        flg = true;
                    }
                    else
                    {
                        this.mensagem = "Por favor, insira um valor positivo e dinheiro suficiente para quitar a conta!";
                        MessageBox.Show(mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    this.mensagem = "Por favor, digite o valor que o cliente está utilizando para pagar a conta no campo Dinheiro!";

                    MessageBox.Show(mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (flg == true)
                {
                    var resultado = MessageBox.Show("Deseja realmente encerrar essa conta?", "Tem certeza?", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        salvarComanda(true);
                        
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Desculpa, você não pode finalizar a comanda sem que o cliente tenha recebido" +
                    " o produto! Utilize o botão FAZER PEDIDO para que o produuto seja enviado para o preparo!", 
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (pedidoFeito)
            {
                Abrir_Comanda abrir = new Abrir_Comanda(Convert.ToInt32(MyPrincipal.Identity.Name));

                this.Hide();
                abrir.Show();
            }
            else
            {
                var resultado = MessageBox.Show("Deseja sair sem salvar a comanda?\n\nSe não antes voltar prescione o botão FAZER PEDIDO",
                    "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); ;
                if (resultado == DialogResult.Yes)
                {
                    Abrir_Comanda abrir = new Abrir_Comanda(Convert.ToInt32(MyPrincipal.Identity.Name));

                    this.Hide();
                    abrir.Show();
                }
            }
        }
        

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                dinheiro = Convert.ToDouble(txtDinheiro.Text);

                troco = dinheiro - total;

                mensagem = "Total a Paga: R$ " + total + "\nTroco: R$ " + troco;
            }
            catch
            {
                if (txtDinheiro.Text == "")
                {
                    mensagem = "Por favor, insira o valor que o cliente utiliza-ra para pagar a conta!";
                    txtDinheiro.Focus();
                }
                else
                {
                    mensagem = "Por favor, insira um valor positivo e dinheiro suficiente para quitar a conta!";
                }

            }

            MessageBox.Show(mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            if (abriuComanda)
            {
                salvarComanda(false);
                pedidoFeito = true;
                MessageBox.Show("Pedido realizado com sucesso!", "TUDO CERTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhum pedido foi adicionado na comanda", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
