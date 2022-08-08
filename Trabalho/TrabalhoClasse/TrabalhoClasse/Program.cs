using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoClasse
{
    internal class Program
    {
        static void Main(string[] args) {
            const int TAM = 15;
            Pessoa[] p = new Pessoa[TAM];
            int c = 0;
            UnobservedTaskExceptionEventArgs op = 0;
            do {
                op = menu();
                switch (op) {
                    case 1: p[c++] = cadastrarPessoa(); break;
                    case 2: ListarPessoas(p, c); break;
                    case 3: exibirMediaPesoIdeal(p, "MASCULINO", c); break;
                    case 4: exibirmediaPesoIdeal(p, "FEMININO", c); break;
                    case 0: break;

                    default: Console.WriteLine("Opção Inválida."); break;
                }
                Console.SetCursorPosition(50, 20);
                Console.Write("Tecle Algo para continuar!");
                Console.Read