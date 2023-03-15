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
    public partial class FormAddCategoria : Form
    {
        public FormAddCategoria()
        {
            InitializeComponent();
        }

        //botao confirma cadastro marca
        private void iconConfirmaCadastro_Click(object sender, EventArgs e)
        {
           
                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.insereCategoria(txtTipo.Text);

                if (retorno)
                {
                    MessageBox.Show("Nova Categoria Inserida!");
                    txtTipo.Text = "";
                    txtTipo.Focus();
                    this.Close();
            }
                else
                    MessageBox.Show(conecta.mensagem);


        }//fim add categoria
    }
}
