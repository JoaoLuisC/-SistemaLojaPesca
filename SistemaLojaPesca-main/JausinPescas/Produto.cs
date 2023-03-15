using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JausinPescas
{
    internal class Produto
    {
        string nome, obsProduto;
        int qntdEstoque, Categoria_codCategoria, Marca_codMarca, Fornecedor_codFornecedor;
        decimal precoCusto, precoVenda;
        DateTime dataInsercao;

        int codProduto;

        public string Nome { get => nome; set => nome = value; }
        public string ObsProduto { get => obsProduto; set => obsProduto = value; }
        public int QntdEstoque { get => qntdEstoque; set => qntdEstoque = value; }
        public int Categoria_codCategoria1 { get => Categoria_codCategoria; set => Categoria_codCategoria = value; }
        public int Marca_codMarca1 { get => Marca_codMarca; set => Marca_codMarca = value; }
        public int Fornecedor_codFornecedor1 { get => Fornecedor_codFornecedor; set => Fornecedor_codFornecedor = value; }
        public int CodProduto { get => codProduto; set => codProduto = value; }
        public decimal PrecoCusto { get => precoCusto; set => precoCusto = value; }
        public decimal PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public DateTime DataInsercao { get => dataInsercao; set => dataInsercao = value; }
    }
}
