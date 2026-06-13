using System;

namespace Estacionamento.Modelos
{
    public class Ticket
    {
        public int Id { get; set; }
        public string PlacaVeiculo { get; set; }
        public DateTime HorarioEntrada { get; set; }
        public DateTime? HorarioSaida { get; set; }
        public string Vaga { get; set; }
        public decimal ValorTotal { get; set; }
        public int StatusTicket { get; set; } // 0 = Aberto, 1 = Pago

        public Ticket() { }

        public Ticket(string placaVeiculo, string vaga)
        {
            PlacaVeiculo = placaVeiculo;
            HorarioEntrada = DateTime.Now;
            Vaga = vaga;
            StatusTicket = 0;
            ValorTotal = 0.00m;
        }

        public void CalcularCobranca(Veiculo veiculo)
        {
            if (!HorarioSaida.HasValue)
                HorarioSaida = DateTime.Now;

            TimeSpan permanencia = HorarioSaida.Value - HorarioEntrada;
            double totalMinutos = permanencia.TotalMinutes;

            // Regra: Até 15 minutos -> tolerância (grátis)
            if (totalMinutos <= 15)
            {
                ValorTotal = 0.00m;
                return;
            }

            // Regra: Frações acima de 30 minutos contam como nova hora completa
            double horasCalculadas = Math.Floor(totalMinutos / 60);
            double minutosRestantes = totalMinutos % 60;

            if (minutosRestantes > 30)
            {
                horasCalculadas += 1;
            }
            else if (minutosRestantes > 0)
            {
                horasCalculadas += 0.5; // Meia hora se for até 30 minutos
            }

            if (horasCalculadas < 1 && totalMinutos > 15)
            {
                horasCalculadas = 1; // Mínimo de 1 hora cobrada se passar da tolerância
            }

            ValorTotal = veiculo.CalcularValor((int)Math.Ceiling(horasCalculadas));
            if (horasCalculadas < 1 && totalMinutos > 15)
            { 
            }

            ValorTotal = veiculo.CalcularValor(
                (int)Math.Ceiling(horasCalculadas)
            );
        }
    }
}