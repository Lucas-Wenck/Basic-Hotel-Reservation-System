using SistemaHospedagem.Models;

List<Pessoa> hospedes = [];

Pessoa p1 = new(nome: "Hóspede 1");
Pessoa p2 = new(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

Reserva reserva = new(diasReservados: 11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospede(hospedes);

Console.WriteLine($"Numero de hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"O valor total deu: {reserva.CalcularValorTotal()}");
