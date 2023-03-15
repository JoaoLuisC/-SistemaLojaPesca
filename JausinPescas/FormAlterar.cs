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
    public partial class FormAlterar : Form
    {
        public FormAlterar()
        {
            InitializeComponent();
            listaCategorias();
            listaFornecedores();
            listaMarcas();

            //desativa campos se produto a ser alterado nao estiver selecionado previamente
            txtAltNomeProduto.Enabled= false;
            txtAltQtdEstoque.Enabled= false;
            txtAltPrecoCusto.Enabled= false;
            txtAltPrecoVenda.Enabled= false;   
            txtAltDataInsercao.Enabled= false;
            cbAltCategoria.Enabled= false;
            cbAltFornecedor.Enabled= false;
            cbAltMarca.Enabled= false; 
            rtxtAltObsProduto.Enabled= false;
            iconConfirmaAlteracao.Enabled= false;
        }

        int idAltera = 0;
        public FormAlterar(string nome, int qtd, decimal precoCusto, decimal precoVenda, DateTime dataInsercao, string categoria, string marca, string fornecedor, string obs, int idAlterar)
        {
            InitializeComponent();
            txtAltNomeProduto.Text = nome;
            txtAltQtdEstoque.Text = Convert.ToString(qtd);
            txtAltPrecoCusto.Text = Convert.ToString(precoCusto);
            txtAltPrecoVenda.Text = Convert.ToString(precoVenda);
            txtAltDataInsercao.Text = Convert.ToString(dataInsercao);
            cbAltCategoria.Text = categoria;
            cbAltMarca.Text = marca;
            cbAltFornecedor.Text = fornecedor;
            rtxtAltObsProduto.Text = obs;

            idAltera = idAlterar;

            listaCategorias();
            listaFornecedores();
            listaMarcas();
        }

        void listaCategorias()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCategorias();
            cbAltCategoria.DataSource = tabelaDados;
            cbAltCategoria.DisplayMember = "Tipo";
            cbAltCategoria.ValueMember = "codCategoria";

            lblmsgerro.Text = con.mensagem;

        }

        void listaMarcas()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaMarcas();
            cbAltMarca.DataSource = tabelaDados;
            cbAltMarca.DisplayMember = "nomeMarca";
            cbAltMarca.ValueMember = "codMarca";

            lblmsgerro.Text = con.mensagem;
        }

        void listaFornecedores()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaFornecedores();
            cbAltFornecedor.DataSource = tabelaDados;
            cbAltFornecedor.DisplayMember = "nome";
            cbAltFornecedor.ValueMember = "codFornecedor";

            lblmsgerro.Text = con.mensagem;
        }

        private void FormAlterar_Load(object sender, EventArgs e)
        {
            if (idAltera == 0)
            {
                cbAltCategoria.Text = "";
                cbAltMarca.Text = " ";
                cbAltFornecedor.Text = " ";

                MessageBox.Show("Selecione um produto na aba 'Listar'", "Produto Não Selecionado");
            }
        }

        //botao confirma alteracao
        private void iconConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txtAltNomeProduto.Text;
            p.QntdEstoque = Convert.ToInt32(txtAltQtdEstoque.Text);
            p.DataInsercao = Convert.ToDateTime(txtAltDataInsercao.Text);
            p.PrecoCusto = Convert.ToDecimal(txtAltPrecoCusto.Text);
            p.PrecoVenda = Convert.ToDecimal(txtAltPrecoVenda.Text);
            p.ObsProduto = rtxtAltObsProduto.Text;
            p.Categoria_codCategoria1 = Convert.ToInt32(cbAltCategoria.SelectedValue.ToString());
            p.Marca_codMarca1 = Convert.ToInt32(cbAltMarca.SelectedValue.ToString());
            p.Fornecedor_codFornecedor1 = Convert.ToInt32(cbAltFornecedor.SelectedValue.ToString());

            //envia dados pro update no banco
            ConectaBanco con = new ConectaBanco();
            bool retorno = con.alteraProduto(p, idAltera);

            if (retorno)
            {
                MessageBox.Show("Dados alterados com sucesso!");
                this.Close();

                
            }
            else
                lblmsgerro.Text = con.mensagem;
        }
    }
    }

