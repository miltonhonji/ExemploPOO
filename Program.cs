using System.Diagnostics.Contracts;
using ExemploPOO.Models;

Aluno a1 = new Aluno();

a1.Nome = "Milton";
a1.Idade = 37;
a1.Email = "teste@teste.com";
a1.Nota = 10;

a1.Apresentar();

Professor p1 = new Professor();

p1.Nome = "Nome Professor";
p1.Idade = 50;
p1.Salario = 1000;

p1.Apresentar();

























//ContaCorrente c1 = new ContaCorrente(123,1000);

//c1.ExibirSaldo();
//c1.Sacar(5000);
//c1.ExibirSaldo();

// Pessoa p1 = new Pessoa();

// p1.Nome = "Milton";
// p1.Idade = 37;

// p1.Apresentar();