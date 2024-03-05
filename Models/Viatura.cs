using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcViatura.Models
{
    public class Viatura
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Cor { get; set; }
        public int Cilindrada { get; set; }
        public int Ano { get; set; }
        [Display(Name = "Mês")]
        public int Mes { get; set; }
        public string? Tipo { get; set; }
        [Display(Name = "Preço")]
        public int Preco { get; set; }
        [Display(Name = "Forma de Pagamento")]
        public string? ForPgto { get; set; }


    }
}
