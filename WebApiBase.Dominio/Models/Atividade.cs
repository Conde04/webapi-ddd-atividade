using WebApiBase.Infraestrutura.CrossCutting.Enumeradores;

namespace WebApiBase.Dominio.Models
{
    public class Atividade : BaseEntity
    {
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime? DataConclusao { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public Categoria Categoria { get; set; }
        public Status Status { get; set; }
    }
}