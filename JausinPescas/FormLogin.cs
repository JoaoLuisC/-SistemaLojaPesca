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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            //tirar borda api
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            txtUsuario.Focus();
        }


        //botao exit
        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //botao confimar login
        private void iconConfirmaLogin_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            if (con.verifica(txtUsuario.Text, txtSenha.Text) == true)
            {
                Sistema sis = new Sistema();
                this.Hide();
                sis.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Usuário ou senha incorreto(s)!" + con.mensagem);
        }

        //botao criar conta
        private void iconCriaConta_Click(object sender, EventArgs e)
        {
            FormAddUsuario form = new FormAddUsuario();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
