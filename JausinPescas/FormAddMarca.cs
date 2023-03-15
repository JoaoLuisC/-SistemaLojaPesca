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
    public partial class FormAddMarca : Form
    {
        public FormAddMarca()
        {
            InitializeComponent();
        }

        //botao confirma cadastro marca
        private void iconConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereMarca(txtNomeMarca.Text);

            if (retorno)
            {
                MessageBox.Show("Nova Marca Inserido!");
                txtNomeMarca.Text = "";
                txtNomeMarca.Focus();
                this.Close();
            }
            else
                MessageBox.Show(conecta.mensagem);

        }//fim add marca
    }
    }

