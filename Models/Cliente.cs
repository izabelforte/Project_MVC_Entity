using System.ComponentModel.DataAnnotations;

namespace MvcViatura.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Morada { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DtNasc { get; set; }
        public string? Email { get; set; }
        public int Telefone { get; set; }
        
    }
}
