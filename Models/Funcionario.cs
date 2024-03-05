using System.ComponentModel.DataAnnotations;

namespace MvcViatura.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Morada { get; set; }
        public string? Email { get; set; }
        public int Telefone { get; set; }
        public string? Nib { get; set; }
        public int Contribuinte { get; set; }


    }
}
