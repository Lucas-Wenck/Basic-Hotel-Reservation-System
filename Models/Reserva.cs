using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    public class Reserva
    {

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes { get; set; }

        public Suite Quarto { get; set; }

        public int DiasReservados { get; set; }

        public void CadastrarHospede(List<Pessoa> hospedes)
        {
            if (hospedes.Count > Quarto.Capacidade)
            {
                throw new Exception("A quantidade de hospedes excede a capacidade da suite");
            }
            else
            {
                Hospedes = hospedes;
            }
        }

        public void CadastrarSuite(Suite quarto)
        {
            Quarto = quarto;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorTotal()
        {
            if (DiasReservados >= 10)
            {
                return DiasReservados * Quarto.ValorDiaria * 0.9m;
            }
            else
            {
                return DiasReservados * Quarto.ValorDiaria;
            }
        }
    }
}
