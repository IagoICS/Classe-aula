using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da pessoa:"); string n = Console.ReadLine();
            Console.WriteLine("Digite a idade de {0}:"); int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura de {0}:"); double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a letra correspondente ao sexo(F/M):"); char s = char.Parse(Console.ReadLine());


            Pessoa pessoa = new Pessoa(n, i, a, s );

            Console.WriteLine("\n\n*** Dados da Pessoas ***\n");
            Console.WriteLine(pessoa.ToString());

            Console.WriteLine(" Peso Ideal: {0}",pessoa.calcularPesoIdeal());

            Console.ReadKey();
        }
    }
}
