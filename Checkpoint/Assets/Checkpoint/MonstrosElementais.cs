using UnityEditor.Experimental.GraphView;
using UnityEngine;
    //Amanda Campos Corrêa
    //RM569609
public class MonstrosElementais : MonoBehaviour
{
    [Header("Escolha um monstro elemental pelo seu número correspondente: 1 = Fogo; 2 = Água; 3 = Pedra:")]
    [SerializeField] private int escolhaJogador;
    private int escolhaComputador;
    private int pontosJogador;
    private int pontosComputador;
    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (pontosJogador < 3 || pontosComputador < 3)
            {
                escolhaComputador = Random.Range(1, 4);

                //Escolhas do jogador
                if (escolhaJogador == 1)
                {
                    print("Escolha do jogador: " + escolhaJogador + ": Fogo");
                }
                if (escolhaJogador == 2)
                {
                    print("Escolha do jogador: " + escolhaJogador + ": Água");
                }
                if (escolhaJogador == 3)
                {
                    print("Escolha do jogador: " + escolhaJogador + ": Pedra");
                }

                //Escolhas do computador
                if (escolhaComputador == 1)
                {
                    print("Escolha do computador: " + escolhaComputador + ": Fogo");
                }
                if (escolhaComputador == 2)
                {
                    print("Escolha do computador: " + escolhaComputador + ": Água");
                }
                if (escolhaComputador == 3)
                {
                    print("Escolha do computador: " + escolhaComputador + ": Pedra");
                }

                //Fogo vence Pedra

                if (escolhaJogador == 1 && escolhaComputador == 3)
                {
                    print("Fogo vence Pedra! Jogador pontuou.");
                    pontosJogador++;
                }
                if (escolhaJogador == 3 && escolhaComputador == 1)
                {
                    print("Fogo vence Pedra! Computador pontuou.");
                    pontosComputador++;
                }

                //Pedra vence Água

                if (escolhaJogador == 3 && escolhaComputador == 2)
                {
                    print("Pedra vence Água! Jogador pontuou.");
                    pontosJogador++;
                }
                if (escolhaJogador == 2 && escolhaComputador == 3)
                {
                    print("Pedra vence Água! Computador pontuou.");
                    pontosComputador++;
                }

                //Água vence fogo

                if (escolhaJogador == 2 && escolhaComputador == 1)
                {
                    print("Água vence Fogo! Jogador pontuou.");
                    pontosJogador++;
                }
                if (escolhaJogador == 1 && escolhaComputador == 2)
                {
                    print("Água vence Fogo! Computador pontuou.");
                    pontosComputador++;
                }

                //Empate
                if (escolhaJogador == escolhaComputador)
                {
                    print("Empate!");
                }

                //Pontuação
                print("Pontuação do jogador: " + pontosJogador);
                print("Pontuação do computador: " + pontosComputador);

                //Vencedor
                if (pontosJogador == 3)
                {
                    print("O jogador é o vencedor!");
                }
                else if (pontosComputador == 3)
                {
                    print("O computador é o vencedor!");
                }
                print("_______________________________________________________________");
            }
            else
            {
                print("O jogo foi finalizado.");
            }
        }
    }
}