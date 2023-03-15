using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;

namespace JausinPescas
{
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }


        void listaProduto()
        {
            ConectaBanco con = new ConectaBanco();
            dgProduto.DataSource = con.listaProdutos();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            listaProduto();
        }

        //botao alterar
        private void iconAltera_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            string cat, mar, forn;
            int linha = dgProduto.CurrentRow.Index;
            p.CodProduto = Convert.ToInt32(dgProduto.Rows[linha].Cells["Codigo"].Value.ToString());
            p.Nome = dgProduto.Rows[linha].Cells["Produto"].Value.ToString();
            p.DataInsercao = Convert.ToDateTime(dgProduto.Rows[linha].Cells["Data de Insercao"].Value.ToString());
            p.PrecoCusto = Convert.ToDecimal(dgProduto.Rows[linha].Cells["Preco de Custo"].Value.ToString());
            p.PrecoVenda = Convert.ToDecimal(dgProduto.Rows[linha].Cells["Preco de Venda"].Value.ToString());
            p.QntdEstoque = Convert.ToInt32(dgProduto.Rows[linha].Cells["Quantidade no Estoque"].Value.ToString());
            cat = dgProduto.Rows[linha].Cells["Categoria"].Value.ToString();
            mar = dgProduto.Rows[linha].Cells["Marca"].Value.ToString();
            forn = dgProduto.Rows[linha].Cells["Fornecedor"].Value.ToString();
            p.ObsProduto = dgProduto.Rows[linha].Cells["Observacoes"].Value.ToString();

            // Valores segundo construtor form alterar: string nome, int qtd, double precoCusto, double precoVenda, DateTime dataValidade, string categoria, string marca, string fornecedor, string obs
            FormAlterar form = new FormAlterar(p.Nome, p.QntdEstoque, p.PrecoCusto, p.PrecoVenda, p.DataInsercao, cat, mar, forn, p.ObsProduto, p.CodProduto);


            //codigos teste abrir segundo alterar dentro do form principal: ainda em desenvolvimento
            //Sistema sis = new Sistema();
            // sis.OpenChildForm(new FormAlterar(p.Nome, p.QntdEstoque, p.PrecoCusto, p.PrecoVenda, p.DataValidade, cat, mar, forn, p.ObsProduto, p.CodProduto));

            // dgProduto.Visible = false;
            // iconAltera.Visible = false;
            // iconRemove.Visible = false;
            //lblTitleListar.Visible = false;

           // form.TopLevel = false;
           // form.FormBorderStyle = FormBorderStyle.None;
           // form.Dock = DockStyle.Fill;
           // panelDesktop2.Controls.Add(form);
           // panelDesktop2.Tag = form;
           // form.BringToFront();

            form.ShowDialog();
            listaProduto();
        }

        //botao remover
        private void iconRemove_Click(object sender, EventArgs e)
        {
            int linha = dgProduto.CurrentRow.Index;
            int idRemover = Convert.ToInt32(dgProduto.Rows[linha].Cells["Código"].Value.ToString());
            DialogResult resp = MessageBox.Show("Confirma exclusão?", "Remover Produto", MessageBoxButtons.OKCancel);

            if (resp == DialogResult.OK)
            {
                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.deletaProduto(idRemover);
                if (retorno)
                    MessageBox.Show("Produto Excluído!");
                else
                    MessageBox.Show("Erro", conecta.mensagem);
                listaProduto();
            }//fim if ok
            else
                MessageBox.Show("Operação Cancelada!");
        }

        //filtro por nome do produto
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgProduto.DataSource as DataTable).DefaultView.RowFilter = String.Format("Produto like'{0}%'", txtBusca.Text);
        }
    }
}
