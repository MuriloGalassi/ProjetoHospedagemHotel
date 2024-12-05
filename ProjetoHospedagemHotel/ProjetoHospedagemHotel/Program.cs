using ProjetoHospedagemHotel.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Hospedagem de Hotel ===");


        Console.WriteLine("\nCadastrando uma Suíte...");
        Suite suiteLuxo = new Suite("Luxo", 4, 300m);


        Console.WriteLine("\nCriando uma Reserva...");
        Console.Write("Informe o número de dias reservados: ");
        int diasReservados = int.Parse(Console.ReadLine());
        Reserva reserva = new Reserva(diasReservados);


        Console.WriteLine("\nCadastrando Hóspedes...");
        for (int i = 0; i < suiteLuxo.Capacidade; i++)
        {
            Console.Write($"Digite o nome do hóspede {i + 1}: ");
            string nome = Console.ReadLine();
            Console.Write($"Digite o documento do hóspede {i + 1}: ");
            string documento = Console.ReadLine();
            reserva.CadastrarHospede(new Pessoa(nome, documento));

            Console.Write("Adicionar mais hóspedes? (S/N): ");
            string opcao = Console.ReadLine().ToUpper();
            if (opcao != "S") break;
        }


        reserva.CadastrarSuite(suiteLuxo);


        Console.WriteLine("\n=== Informações da Reserva ===");
        Console.WriteLine(reserva);


        decimal valorTotal = reserva.CalcularValorDiaria();
        Console.WriteLine($"\nValor Total com desconto (se aplicável): {valorTotal:C}");

        Console.WriteLine("\nReserva concluída com sucesso!");
    }
}