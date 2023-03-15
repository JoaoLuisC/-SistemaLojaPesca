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
    public partial class FormRemover : Form
    {
        public FormRemover()
        {
            InitializeComponent();
        }

        //botao cofirmar remover
        private void iconConfirmaRemover_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma exclusão?", "Remover Produto", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.deletaProduto(Convert.ToInt32(cbProdutos.SelectedValue));
                if (retorno)
                    MessageBox.Show("Produto Excluído!");
                else
                    MessageBox.Show("Erro", conecta.mensagem);
                listaProdutos();
            }//fim if ok
            else
                MessageBox.Show("Operação Cancelada!");
        }

        void listaProdutos()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaProduto();
            cbProdutos.DataSource = tabelaDados;
            cbProdutos.DisplayMember = "nomeProduto";
            cbProdutos.ValueMember = "codProduto";

            lblmsgerro.Text = con.mensagem;
        }

        private void FormRemover_Load(object sender, EventArgs e)
        {
            listaProdutos();
            cbProdutos.Text = "";
        }
    }
}
