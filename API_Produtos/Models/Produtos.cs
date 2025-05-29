using System.ComponentModel.DataAnnotations;

namespace API_Produtos.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "Nome deve ter entre 3 e 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Range(0.01, 10000,
            ErrorMessage = "Preço deve estar entre R$0,01 e R$10.000,00.")]
        public decimal Preco { get; set; }
    }
}
