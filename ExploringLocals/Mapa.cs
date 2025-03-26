using System;
using System.Collections.Generic;
using System.Text;

namespace ExpMys
{
    public class Mapa
    {
        int vida = 0;
        int chanceATK = 0;
        string nome;
        bool perry = true;
        string localE = "Cidade Central";
        string direcao;

        public void explorarLocal()
        {
            Console.WriteLine("Insira um nome de usuário");
            nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Seja Bem Vindo " + nome);

            Random aleatorio = new Random();
            vida = aleatorio.Next(15, 26);

            do
            {
                Console.Clear();
                Console.WriteLine("Você está em " + localE + ".");
                chanceATK = aleatorio.Next(1, 5);

                if (localE == "Deserto Sem Fim" && chanceATK == 3)
                {
                    Console.WriteLine("Você foi atacado por um calango gigante");
                    Console.WriteLine("Você perdeu 6 de vida");
                    vida -= 6;
                    Console.ReadKey();
                }
                else if (localE == "Deserto Sem Fim" && chanceATK != 3)
                {
                    Console.WriteLine("Você não foi atacado");
                    Console.WriteLine("Você achou um castelinho de areia com uma placa escrita: Castelinho do Roger");
                    Console.ReadKey();
                }
                else if (localE == "Minas Esquecidas" && chanceATK == 2)
                {
                    Console.WriteLine("Você não foi atacado");
                    Console.WriteLine("Você achou um diário de um minerador de 1983");
                    Console.ReadKey();
                }
                else if (localE == "Minas Esquecidas" && chanceATK != 2)
                {
                    Console.WriteLine("Você foi atacado por um vampiro");
                    Console.WriteLine("Você perdeu 8 de vida");
                    vida -= 8;
                    Console.ReadKey();
                }
                else if (localE == "Porto" && chanceATK == 1 || localE == "Porto" && chanceATK == 4)
                {
                    Console.WriteLine("Você foi atacado por um velho da lancha");
                    Console.WriteLine("Você recebe 5 de vida");
                    vida -= 5;
                    Console.ReadKey();
                }
                else if (localE == "Porto" && chanceATK != 1 && chanceATK != 4)
                {
                    Console.WriteLine("Você não foi atacado");
                    Console.WriteLine("Você achou uma pequena jóia");
                    Console.ReadKey();
                }
                else if (localE == "Ilha Solitária" && chanceATK == 3 || localE == "Ilha Solitária" && chanceATK == 2)
                {
                    Console.WriteLine("Você foi atacado por um sereiano");
                    Console.WriteLine("Você perdeu 5 de vida");
                    vida -= 5;
                    Console.ReadKey();
                }
                else if (localE == "Ilha Solitária" && chanceATK != 3 && chanceATK != 2)
                {
                    Console.WriteLine("Você não foi atacado");
                    Console.WriteLine("Você achou um pente com fios de cabelos louros");
                    Console.ReadKey();
                }
                else if (localE == "Cidade Na Floresta" && chanceATK == 4)
                {
                    Console.WriteLine("Você foi atacado pelo Saci");
                    Console.WriteLine("Você perdeu 4 de vida");
                    vida -= 4;
                    Console.ReadKey();
                }
                else if (localE == "Cidade Na Floresta" && chanceATK != 4)
                {
                    Console.WriteLine("Você não foi atacado");
                    Console.WriteLine("Você achou uma trilha de pegadas com um pé só");
                    Console.ReadKey();
                }
                else if (localE == "Caverna Na Floresta" && chanceATK == 1 || localE == "Caverna Na Floresta" && chanceATK == 3)
                {
                    Console.WriteLine("Você foi atacado pela Cuca");
                    Console.WriteLine("Você perdeu 6 de vida");
                    vida -= 6;
                    Console.ReadKey();
                }
                else if (localE == "Caverna Na Floresta" && chanceATK != 1 && chanceATK != 3)
                {
                    Console.WriteLine("Você não foi atacado");
                    Console.WriteLine("Você achou um caldeirão com um líquido verde");
                    Console.ReadKey();
                }

                if (vida <= 0)
                {
                    Console.WriteLine("Você morreu");
                    Console.WriteLine("Fim de Jogo");
                    Console.ReadKey();
                    perry = false;
                }
                else if (vida > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Você tem " + vida + " de vida");
                }
                Console.WriteLine("");
                Console.WriteLine("Para onde você quer ir?");
                Console.WriteLine("D - Direita, E - Esquerda, C - Cima, B - Baixo");
                Console.WriteLine("");
                direcao = Console.ReadLine().ToUpper();
                Console.Clear();

                if (localE == "Cidade Central" && direcao == "D")
                {
                    localE = "Porto";
                }
                else if (localE == "Cidade Central" && direcao == "E")
                {
                    localE = "Minas Esquecidas";
                }

                else if (localE == "Cidade Central" && direcao == "C")
                {
                    localE = "Cidade Na Floresta";
                }

                else if (localE == "Cidade Central" && direcao == "B")
                {
                    localE = "Deserto Sem Fim";
                }
                else if (localE == "Porto" && direcao == "D")
                {
                    localE = "Ilha Solitária";
                }
                else if (localE == "Porto" && direcao == "E")
                {
                    localE = "Cidade Central";
                }
                else if (localE == "Porto" && direcao != "D" && direcao != "E")
                {
                    Console.WriteLine("Você não pode ir para esta direção!!!");
                    Console.ReadKey();
                }
                else if (localE == "Ilha Solitária" && direcao == "E")
                {
                    localE = "Porto";
                }
                else if (localE == "Ilha Solitária" && direcao != "E")
                {
                    Console.WriteLine("Você não pode ir para esta direção!!!");
                    Console.ReadKey();
                }
                else if (localE == "Minas Esquecidas" && direcao == "D")
                {
                    localE = "Cidade Central";
                }
                else if (localE == "Minas Esquecidas" && direcao == "C")
                {
                    localE = "Cidade Na Floresta";
                }
                else if (localE == "Minas Esquecidas" && direcao != "D" && direcao != "C")
                {
                    Console.WriteLine("Você não pode ir para esta direção!!!");
                    Console.ReadKey();
                }
                else if (localE == "Cidade Na Floresta" && direcao == "B")
                {
                    localE = "Cidade Central";
                }
                else if (localE == "Cidade Na Floresta" && direcao == "E")
                {
                    localE = "Minas Esquecidas";
                }
                else if (localE == "Cidade Na Floresta" && direcao == "C")
                {
                    localE = "Caverna Na Floresta";
                }
                else if (localE == "Cidade Na Floresta" && direcao == "D" )
                {
                    Console.WriteLine("Você não pode ir para esta direção!!!");
                    Console.ReadKey();
                }
                else if (localE == "Caverna Na Floresta" && direcao == "B")
                {
                    localE = "Cidade Na Floresta";
                }
                else if (localE == "Caverna Na Floresta" && direcao != "B")
                {
                    Console.WriteLine("Você não pode ir para esta direção!!!");
                    Console.ReadKey();
                }
                else if (localE == "Deserto Sem Fim" && direcao == "C")
                {
                    localE = "Cidade Central";
                }
                else if (localE == "Deserto Sem Fim" && direcao != "C")
                {
                    Console.WriteLine("Você não pode ir para esta direção!!!");
                    Console.ReadKey();
                }
                Console.WriteLine("");

            } while (perry == true);
        }
    }
}
