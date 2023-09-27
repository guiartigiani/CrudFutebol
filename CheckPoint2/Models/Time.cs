using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Checkpoint2.Models
{
    public class Time
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Nome do Time")]
        [Required(ErrorMessage = "Informe o nome do Time")]
        public string NomeTime { get; set; }

        [DisplayName("País")]
        [Required(ErrorMessage = "Informe o País")]
        public string Pais { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Data de Inauguração")]
        [Required(ErrorMessage = "Informe sua data de inauguração")]
        public DateTime DataInicio { get; set; }

        public List<Jogador> Jogadores { get; set; }
    }
}
