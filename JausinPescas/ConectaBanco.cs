using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace JausinPescas
{ 
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=lojapesca");
        public String mensagem;

        public DataTable listaCategorias()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("lista_categorias", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_categorias

        public DataTable listaMarcas()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("lista_marcas", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_marcas

        public DataTable listaFornecedores()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("lista_fornecedores", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_fornecedores

        public bool insereProduto(Produto p)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", p.Nome);
            cmd.Parameters.AddWithValue("qntdEstoque", p.QntdEstoque);
            cmd.Parameters.AddWithValue("precoCusto", p.PrecoCusto);
            cmd.Parameters.AddWithValue("precoVenda", p.PrecoVenda);
            cmd.Parameters.AddWithValue("dataInsercao", p.DataInsercao.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("obsProduto", p.ObsProduto);
            cmd.Parameters.AddWithValue("Categoria_codCategoria", p.Categoria_codCategoria1);
            cmd.Parameters.AddWithValue("Marca_codMarca", p.Marca_codMarca1);
            cmd.Parameters.AddWithValue("Fornecedor_codFornecedor", p.Fornecedor_codFornecedor1);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereBanda

        public DataTable listaProdutos()
        {
            MySqlCommand cmd = new MySqlCommand("lista_produtos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_produtos

        public DataTable listaProduto()
        {
            MySqlCommand cmd = new MySqlCommand("lista_produto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_produto unico combobox

        public bool alteraProduto(Produto p, int idproduto)
        {
            MySqlCommand cmd = new MySqlCommand("update_produto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("codProdutos", idproduto );
            cmd.Parameters.AddWithValue("nomeProduto", p.Nome);
            cmd.Parameters.AddWithValue("qntdEstoque", p.QntdEstoque);
            cmd.Parameters.AddWithValue("precoCusto", p.PrecoCusto);
            cmd.Parameters.AddWithValue("precoVenda", p.PrecoVenda);
            cmd.Parameters.AddWithValue("dataInsercao", p.DataInsercao.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("obsProduto", p.ObsProduto);
            cmd.Parameters.AddWithValue("Categoria_codCategoria", p.Categoria_codCategoria1);
            cmd.Parameters.AddWithValue("Marca_codMarca", p.Marca_codMarca1);
            cmd.Parameters.AddWithValue("Fornecedor_codFornecedor", p.Fornecedor_codFornecedor1);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(mensagem = "Erro:" + e.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim update_produto

        public bool deletaProduto(int idProduto)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deleteProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codProdutoR", idProduto);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deleta_Produto

        public bool insereMarca(string nome)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereMarca", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("novaMarca", nome);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insere_marca

        public bool insereCategoria(string nome)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereCategoria", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("novaCat", nome);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insere_categoria

        public bool insereFornecedor(string nome, string cnpj)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereFornecedor", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NovoFornecedor", nome);
            cmd.Parameters.AddWithValue("CNPJ", cnpj);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insere_fornecedor

        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }//fim verifica hash
        public bool insereUsuario(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("insere_usuario", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }//fim insere_usuario

    }
}

