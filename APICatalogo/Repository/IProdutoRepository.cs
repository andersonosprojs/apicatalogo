using ApiCatalogo.Pagination;
using APICatalogo.Models;
using APICatalogo.Pagination;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCatalogo.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<PagedList<Produto>> GetProdutos(ProdutosParameters produtosParameters);

        Task<IEnumerable<Produto>> GetProdutosPorPreco();
    }
}
