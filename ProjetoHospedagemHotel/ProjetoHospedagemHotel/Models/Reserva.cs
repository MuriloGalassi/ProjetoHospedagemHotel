using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospedagemHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; private set; }
        public Suite SuiteReservada { get; private set; }
        public int DiasReservados { get; private set; }

        public Reserva(int diasReservados)
        {
            Hospedes = new List<Pessoa>();
            DiasReservados = diasReservados;
        }

        public void CadastrarHospede(Pessoa hospede)
        {
            Hospedes.Add(hospede);
        }

        public void CadastrarSuite(Suite suite)
        {
            SuiteReservada = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (SuiteReservada == null)
                throw new Exception("Nenhuma suíte cadastrada para esta reserva.");

            decimal valorTotal = DiasReservados * SuiteReservada.ValorDiaria;


            if (DiasReservados >= 10)
            {
                valorTotal *= 0.9m;
            }

            return valorTotal;
        }

        public override string ToString()
        {
            return $"Suíte: {SuiteReservada}\nDias Reservados: {DiasReservados}\nHóspedes:\n{string.Join("\n", Hospedes)}";
        }
    }
}
