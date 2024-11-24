using System.ComponentModel.DataAnnotations;

namespace GestaoProfissionais.Models
{
    public class Especialidade
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string TipoDocumento { get; set; }
    }
}