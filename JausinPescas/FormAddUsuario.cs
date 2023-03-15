using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JausinPescas
{
    public partial class FormAddUsuario : Form
    {
        public FormAddUsuario()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        //botao confima criar conta
        private void iconCriaConta_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            if (txtSenha.Text.Equals(txtConfirmaSenha.Text))
            {
               bool retorno = con.insereUsuario(txtUsuario.Text, txtSenha.Text);
                if (retorno)
                {
                    MessageBox.Show("Novo Usuario Cadastrado!");
                    this.Close();
                    FormLogin form = new FormLogin();
                    form.ShowDialog();
                }
                else
                    MessageBox.Show(con.mensagem);
            }
            else
                MessageBox.Show("Senhas não coincidem!"); //nao cria usuario se as senhas nao forem iguais
        }
    }
}
