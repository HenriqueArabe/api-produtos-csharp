using System.Collections.Generic;
using System.Linq;
using API_Produtos.Models;

namespace API_Produtos.Data
{
    public static class ProdutoRepository
    {
        private static List<Produto> produtos = new()
        {
            new Produto { Id = 1, Nome = "Teclado", Preco = 150.00m },
            new Produto { Id = 2, Nome = "Mouse", Preco = 80.00m }
        };

        public static List<Produto> GetAll() => produtos;

        public static Produto? Get(int id) => produtos.FirstOrDefault(p => p.Id == id);

        public static void Add(Produto produto) => produtos.Add(produto);

        public static void Update(Produto produto)
        {
            var index = produtos.FindIndex(p => p.Id == produto.Id);
            if (index != -1)
                produtos[index] = produto;
        }

        public static void Delete(int id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
                produtos.Remove(produto);
        }
    }
}
