using System.ComponentModel.DataAnnotations;

namespace GestaoProfissionais.Models
{
    public class Profissional
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string TipoDocumento { get; set; }
        [Required]
        public string NumeroDocumento { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}