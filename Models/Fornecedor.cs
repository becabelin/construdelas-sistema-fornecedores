using System.ComponentModel.DataAnnotations;

namespace MVC_Completo.Models
{
    public class Fornecedor
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(15)]
        public string Telefone_contato { get; set; }

        [Required]
        [MaxLength(18)]
        public string Cnpj { get; set; }

        [Required]
        [MaxLength(100)]
        public string Endereco { get; set; }
    }
}
