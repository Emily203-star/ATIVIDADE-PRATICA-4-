using Estacionamento.Enumeradores;

namespace Estacionamento.Modelos
{
    public abstract class Veiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public TipoVeiculo Tipo { get; set; }

        public abstract decimal CalcularValor(int horas);
    }
}