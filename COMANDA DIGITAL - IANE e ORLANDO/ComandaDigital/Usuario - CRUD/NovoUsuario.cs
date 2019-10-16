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
    public partial class NovoUsuario : Form
    {
        comandaEntities bd = new comandaEntities();
        string mensagem = "";

        public NovoUsuario()
        {
            InitializeComponent();
            var acessos = bd.Acesso.ToList();

            foreach (var item in acessos)
            {
                comboAcessos.Items.Add(item.descricao);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa();

            try
            {
                if (txtNome.Text != "")
                {
                    if (txtSenha.Text == txtConfirmarSenha.Text)
                    {
                        if (comboAcessos.Text == "Administrador")
                        {
                            pessoa.idAcesso = 1;
                        }
                        else
                        {
                            pessoa.idAcesso = 2;
                        }

                        pessoa.nome = txtNome.Text;
                        pessoa.cpf = txtCpf.Text;
                        pessoa.telefone = maskTelefone.Text;
                        pessoa.endereco = txtEndereco.Text;
                        pessoa.cidade = txtCidade.Text;
                        pessoa.senha = txtSenha.Text;

                        bd.Pessoa.Add(pessoa);

                        bd.SaveChanges();

                        mensagem = "Pessoa adicionada com sucesso!";

                        txtConfirmarSenha.Clear();
                        txtCpf.Clear();
                        txtNome.Clear();
                        txtSenha.Clear();
                        maskTelefone.Clear();
                        txtCidade.Clear();
                        txtEndereco.Clear();
                        comboAcessos.Items.Clear();
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
                mensagem = "Por favor, preencha todos os campos!";
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.Show();
        }
    }
}
