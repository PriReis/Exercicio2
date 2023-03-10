//Exercicio 2
//a)Desenvolvam um programa que armazene uma lista de convidados utilizando um array

using System;
using System.Collections.Generic;
public class Exerc2A
{
    public static void Main()
    {
        string[] convidados = new string[6];

        convidados[0] = "João Gabriel";
        convidados[1] = "Agnes";
        convidados[2] = "Priscila Valentin";
        convidados[3] = "Caue";
        convidados[4] = "Evandro";
        convidados[5] = "Camila";

        Console.WriteLine("O número de convidados é igual a " + convidados.Length);

    }
}