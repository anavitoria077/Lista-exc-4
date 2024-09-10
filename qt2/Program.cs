﻿/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação de Missões
• Contextualização: Em um jogo de aventuras, o jogador ganha pontos ao completar 
missões. A pontuação é calculada com base na dificuldade da missão, na quantidade 
de inimigos derrotados e no tempo gasto para completar.
• Comando: Crie um programa que receba a dificuldade da missão (Fácil, Média, Difícil), 
o número de inimigos derrotados e o tempo gasto (em minutos). Crie uma função para 
calcular a pontuação da missão usando os seguintes critérios:
• Fácil: 5 pontos por inimigo, sem penalidade de tempo.
• Média: 10 pontos por inimigo, -2 pontos por minuto acima de 10 minutos.
• Difícil: 15 pontos por inimigo, -5 pontos por minuto acima de 15 minutos.
• Exiba a pontuação final do jogador.
@Lista: 04
@Autor: Ana Vitóiria
@Data: 08/09/2024
---------------------------------------------------------------------*/

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Clear();

        string? nivelD;
        int numeroIni, tempoG;

        Console.WriteLine("escreva o nível de dificuldade (facil, media ou dificil): ");
        nivelD = Console.ReadLine();

        Console.WriteLine("escreva o número de inimigos: ");
        int.TryParse(Console.ReadLine(), out numeroIni);

        Console.WriteLine("escreva o tempo gasto: ");
        int.TryParse(Console.ReadLine(), out tempoG);

        int total = Some(numeroIni, tempoG, nivelD);

        Console.WriteLine("a sua pontuação de vida é: " + total);

        Console.WriteLine("\nPressione ENTER para fechar.");
        Console.ReadLine();
    }
    static int Some(int numeroIni, int tempoG, string nivelD)
    {
        //int penaliza1 = 0;
        int penaliza2 = 0;
        int total = 0;

        if (nivelD == "facil")
        {
            total = (5 * numeroIni);
        }

        if (nivelD == "media")
        {
            int tempoT = (tempoG - 10) * 2;

            total = (10 * numeroIni) - tempoT;
        }
        if (nivelD == "dificil")
        {
            int tempoT = (tempoG - 15) * 5;

            total = (15 * numeroIni) - tempoT;
        }
        return total;


    }


}