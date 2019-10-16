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
    public partial class EditarUsuario : Form
    {
        comandaEntities bd = new comandaEntities();
        Pessoa pessoa = new Pessoa();
        string mensagem = "";

        public EditarUsuario()
        {
            InitializeComponent();

            tsPesquisa.Focus();

            var produtos = bd.Produto.ToList();

            foreach (var item in produtos)
            {
                comboAcessos.Items.Add(item);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                this.pessoa = bd.Pessoa.FirstOrDefault(x => x.cpf == tsPesquisa.Text);

                txtNome.Text = pessoa.nome;
                txtCpf.Text = pessoa.cpf;
                txtCidade.Text = pessoa.cidade;
                txtEndereco.Text = pessoa.endereco;
                maskTelefone.Text = pessoa.telefone;
                txtSenha.Text = pessoa.senha;
                txtConfirmarSenha.Text = pessoa.senha;

                if (pessoa.idAcesso == 1)
                {
                    comboAcessos.Text = "Administrador";
                }
                else
                {
                    comboAcessos.Text = "Funcionario";
                }

                tsPesquisa.Clear();
                txtConfirmarSenha.Enabled = true;
                txtCpf.Enabled = true;
                txtNome.Enabled = true;
                txtSenha.Enabled = true;
                txtCidade.Enabled = true;
                txtEndereco.Enabled = true;
                maskTelefone.Enabled = true;
            }
            catch
            {
                mensagem = "Pesquise pelo CPF do usuario no campo pesquisa!";
                tsPesquisa.Focus();

                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text != "")
                {
                    if (txtSenha.Text == txtConfirmarSenha.Text)
                    {
                        pessoa.nome = txtNome.Text;
                        pessoa.cpf = txtCpf.Text;
                        pessoa.telefone = maskTelefone.Text;
                        pessoa.endereco = txtEndereco.Text;
                        pessoa.cidade = txtCidade.Text;

                        if(txtSenha.Text != "")
                        {
                            pessoa.senha = txtSenha.Text;
                        }

                        if (comboAcessos.Text == "Administrador")
                        {
                            pessoa.idAcesso = 1;
                        }
                        else
                        {
                            pessoa.idAcesso = 2;
                        }

                        bd.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();

                        mensagem = "Pessoa editada com sucesso!";

                        tsPesquisa.Clear();
                        txtConfirmarSenha.Clear();
                        txtCpf.Clear();
                        txtNome.Clear();
                        txtSenha.Clear();
                        txtCidade.Clear();
                        txtEndereco.Clear();
                        maskTelefone.Clear();

                        tsPesquisa.Focus();
                    }
                    else
                    {
                        mensagem = "Senhas divergentes";
                        txtConfirmarSenha.Focus();
                    }
                }
                else
                {
                    mensagem = "Erro! campos vazios";
                }
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                if (txtNome.Text == null)
                {
                    mensagem = "Procure por uma pessoa cadastrada!";
                }
                else
                {
                    mensagem = "Por favor, preencha todos os campos!";
                }

                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
