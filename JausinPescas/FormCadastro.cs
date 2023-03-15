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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
           
            listaCategorias();
            listaMarcas();
            listaFornecedores();
            
        }

        void limpaCampos()
        {
            txtNomeProduto.Text = "";
            txtDataInsercao.Text = "";
            txtPrecoCusto.Text = "";
            txtQtdEstoque.Text = "";
            txtPrecoVenda.Text = "";
            cbCategoria.Text = "";
            cbFornecedor.Text = "";
            cbMarca.Text = "";
            rtxtObsProduto.Text = "";
            txtNomeProduto.Focus();
        }

        //botao confima cadastro
        private void iconConfirmaCadastro_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txtNomeProduto.Text;
            p.QntdEstoque = Convert.ToInt32(txtQtdEstoque.Text);
            p.PrecoCusto = Convert.ToDecimal(txtPrecoCusto.Text);
            p.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text);

            if (txtDataInsercao.Text.Equals("") == true)
                {
                DateTime anula = new DateTime();
                p.DataInsercao = anula;
               }
            else
                p.DataInsercao = Convert.ToDateTime(txtDataInsercao.Text);
            
            p.Categoria_codCategoria1 = Convert.ToInt32(cbCategoria.SelectedValue.ToString());
            p.Marca_codMarca1 = Convert.ToInt32(cbMarca.SelectedValue.ToString());
            p.Fornecedor_codFornecedor1 = Convert.ToInt32(cbFornecedor.SelectedValue.ToString());
            p.ObsProduto = rtxtObsProduto.Text;

            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereProduto(p);
            if (retorno)
            {
                limpaCampos();
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            else
                lblmsgerro.Text = conecta.mensagem;


        }
        void listaCategorias()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCategorias();
            cbCategoria.DataSource = tabelaDados;
            cbCategoria.DisplayMember = "Tipo";
            cbCategoria.ValueMember = "codCategoria";

            lblmsgerro.Text = con.mensagem;
            cbCategoria.Text = "";
 
        }

        void listaMarcas()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaMarcas();
            cbMarca.DataSource = tabelaDados;
            cbMarca.DisplayMember = "nomeMarca";
            cbMarca.ValueMember = "codMarca";

            lblmsgerro.Text = con.mensagem;
            cbMarca.Text = "";
        }

        void listaFornecedores()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaFornecedores();
            cbFornecedor.DataSource = tabelaDados;
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "codFornecedor";

            lblmsgerro.Text = con.mensagem;
            cbFornecedor.Text = "";
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            cbCategoria.Text = "";
            cbMarca.Text = " ";
            cbFornecedor.Text = " ";
        }

        //add fornecedor
        private void iconAddFornecedor_Click(object sender, EventArgs e)
        {
            FormAddFornecedor form = new FormAddFornecedor();
            form.ShowDialog();
            listaFornecedores();
        }

        //add categoria
        private void iconAddCategoria_Click(object sender, EventArgs e)
        {
            FormAddCategoria form = new FormAddCategoria();
            form.ShowDialog();
            listaCategorias();
        }

        //add marca
        private void iconAddMarca_Click(object sender, EventArgs e)
        {
            FormAddMarca form= new FormAddMarca();
            form.ShowDialog();
            listaMarcas();
        }
    }
}
