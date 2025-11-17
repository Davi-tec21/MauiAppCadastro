namespace MauiAppCadastro.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; } = new DateTime(2025, 1, 1);  
        public DateTime DataTermino { get; set; } = new DateTime(2025, 1, 1);
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        public TimeSpan Duracao => DataTermino - DataInicio;

        public double CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}