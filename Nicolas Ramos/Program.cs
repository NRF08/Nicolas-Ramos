using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicolas_Ramos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string email;
            string endereço;
            string bairro;
            string cidade;
            int telefone;
            int idade;

            Console.WriteLine("Bem-vindo!");
            Console.WriteLine("Escreva seu nome completo:");
        nome: Console.ReadLine();

            Console.WriteLine("Escreva seu email:");
        email: Console.ReadLine();

            Console.WriteLine("Escreva sua idade:");
        idade: Console.ReadLine();

            Console.WriteLine("Escreva seu endereço:");
        endereço: Console.ReadLine();

            Console.WriteLine("Escreva seu bairro:");
        bairro: Console.ReadLine();

            Console.WriteLine("Escreva sua cidade:");
        cidade: Console.ReadLine();

            Console.WriteLine("Escreva seu telefone:");
        telefone: Console.ReadLine();

            Console.ReadKey();
        }
    }
}
