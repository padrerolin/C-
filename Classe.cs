using System;
using CSharp;
using Interface;
using Enum;
namespace CSharp
{

    class Program
    {


        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Giovanna";
            person.Idade = 22;
            person.Estado = "PB";

            var person2 = new Pessoa();

            person2.Nome = "Julia";
            person2.Idade = 23;
            person2.Estado = "MG";

            var pessoa = (Pessoas)0;

            Pessoas pessoa2 = Pessoas.João;
            Pessoas pessoa3 = (Pessoas)4;

            Animal animal = new Animal();

            animal.Nome = "Buck";
            animal.nomeDono = "Elmano";
            animal.Especie = "Shnauzer";


            Console.WriteLine(pessoa3);



        }



    }
}


