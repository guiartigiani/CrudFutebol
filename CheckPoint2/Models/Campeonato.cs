using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Checkpoint2.Models
{
    public class Campeonato
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Nome do Campeonato")]
        [Required(ErrorMessage = "Informe o nome do Campeonato")]
        public string? NomeCamp { get; set; }

        [DisplayName("País")]
        [Required(ErrorMessage = "Informe o País")]
        public string? PaisCamp { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Data de Inicio")]
        [Required(ErrorMessage = "Informe sua data de inicio")]
        public DateTime InicioCamp { get; set; }

        public List<Time>? Times { get; set; }
    }
}
