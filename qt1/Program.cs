/*-------------------------------------------------------------------
Questão 1: Sistema de Cura de Personagem
• Contextualização: Em um jogo de RPG, o jogador pode usar poções de cura para 
recuperar a vida do seu personagem durante a batalha. A quantidade de vida 
recuperada depende do tipo de poção, do nível do personagem e da quantidade de 
poções usadas.
• Comando: Crie um programa que receba o tipo de poção (Pequena, Média, Grande), o 
nível do personagem e a quantidade de poções usadas. Crie uma função que calcule a 
quantidade de vida recuperada com base nos seguintes critérios:
• Poção Pequena: 10 pontos de vida por poção.
• Poção Média: 20 pontos de vida por poção.
• Poção Grande: 30 pontos de vida por poção.
• Adicione 5 pontos adicionais para cada nível do personagem acima de 5.
• Exiba o total de vida recuperadaicial, 
classe, e raça do personagem e exiba esses dados no console.
@Lista: 04
@Autor: Ana Vitória
@Data: 08/09/2024
---------------------------------------------------------------------*/

using System;
using System.Numerics;

class Program
{
static void Main()
    {
     Console.Clear();

        string? ty;
        int level, q;

     Console.WriteLine("escreva o tipo de poção (pequena, media ou grande): ");
     ty = Console.ReadLine();

     Console.WriteLine("escreva o nível do jogador: ");
        int.TryParse(Console.ReadLine(), out level);

     Console.WriteLine("escreva a quantidade de poções que deseja tomar?: ");
        int.TryParse(Console.ReadLine(), out q);

        int total = Some(level, q, ty);
     Console.ReadLine();

     Console.WriteLine("a sua pontuação de vida é: " + total);


     Console.WriteLine("\nPressione ENTER para fechar.");
     Console.ReadLine();
    }
        static int Some(int n, int q, string ty)
    {
        int n1 = 0;
        int total = 0;
        if (n > 5)
        {
            n = n1 = 5;
        }

        if (ty == "pequena")
        {
            total = (10 + n1) * q;
        }

        if (ty == "media")
        {
            total = (20 + n1) * q;
        }

        if (ty == "grande")
        {
            total = (30 + n1) * q;
        }
        return total;


    }


}
