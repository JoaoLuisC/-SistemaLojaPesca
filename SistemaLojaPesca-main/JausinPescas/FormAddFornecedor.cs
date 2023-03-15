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
    public partial class FormAddFornecedor : Form
    {
        public FormAddFornecedor()
        {
            InitializeComponent();
        }

        //botao confirma cadastro fornecedor
        private void iconConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereFornecedor(txtNomeFornecedor.Text, txtCnpj.Text);

            if (retorno)
            {
                MessageBox.Show("Novo Fornecedor Inserido!");
                txtNomeFornecedor.Text = "";
                txtCnpj.Text = "";
                txtNomeFornecedor.Focus();
                this.Close();
            }
            else
                MessageBox.Show(conecta.mensagem);


        }//fim add categoria
    }
    }

