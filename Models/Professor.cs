using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade}, sou um professor e ganho {Salario}");
        }
    }
}
