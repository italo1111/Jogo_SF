using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_SF
{
    internal class Program
    {
        static void Main(string[] args)
        {
               Jogo jogo = new Jogo();


                jogo.DistribuirCartas();


                Console.WriteLine("Cartas do Jogador 1:");
                foreach (var carta in jogo.cartasJogador1)
                {
                    carta.ExibirInformacoes();
                }

                Console.WriteLine("\nCartas do Jogador 2:");
                foreach (var carta in jogo.cartasJogador2)
                {
                    carta.ExibirInformacoes();
                }

                while (jogo.cartasJogador1.Count > 0 && jogo.cartasJogador2.Count > 0)
                {
                    Console.WriteLine("\nEscolha uma carta para jogar (1 a 4): ");
                    int cartaEscolhidaJogador1 = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("\nEscolha um atributo para comparar (km/h, rpm, hp): ");
                    string atributoEscolhido = Console.ReadLine().ToLower();

                    jogo.JogarRodada(cartaEscolhidaJogador1, atributoEscolhido);

                    jogo.VerificarVitoria();
                }
        }
    }
}

