using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Checkpoint2.Models
{
    public class Jogador
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Nome do Jogador")]
        [Required(ErrorMessage = "Informe o nome")]
        public string? NomeJogador { get; set; }

        [DisplayName("Posição")]
        [Required(ErrorMessage = "Informe sua posição")]
        public Posicao Posicao { get; set; }

        [DisplayName("País")]
        [Required(ErrorMessage = "Informe o País")]
        public string? Nacionalidade { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Informe sua data de nascimento")]
        public DateTime DataNasc { get; set; }

        public Time? Time { get; set; }
    }

    public enum Posicao
    {
        GOL, ZAG, LAT, MEI, ATA
    }
}
