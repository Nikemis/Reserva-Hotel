﻿using System.Text;
using Reserva_Hotel.Models;

Console.OutputEncoding = Encoding.UTF8;


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);


Suite suite = new Suite(tiposuite: "Premium", capacidade: 2, valordiaria: 30);

Reserva reserva = new Reserva(diasReservados: 5);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);



Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");