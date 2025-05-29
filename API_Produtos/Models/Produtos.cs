using System.ComponentModel.DataAnnotations;

namespace API_Produtos.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; } = string.Empty;

        [Range(0.01, 10000, ErrorMessage = "O preço deve estar entre 0.01 e 10000.")]
        public decimal Preco { get; set; }
    }
}
