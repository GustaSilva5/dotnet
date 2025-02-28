using System;
class Variaveis
{
    public static void VariaveisNaruto()
    {
        //Variaveis 
        string ninja = "Naruto";
        string vila = "Konoha";
        string sensei = "Kakashi";
        int idade = 17;
        bool hokage = false;
        char rank = 'S';

        Console.WriteLine("Ninja : " + ninja);
        Console.WriteLine("Vila : " + vila);
        Console.WriteLine("Rank : " + rank);
        Console.WriteLine("idade : " + idade);
        Console.WriteLine("Sensei : " + sensei);
        Console.WriteLine("Hokage : " + hokage);

        var Nomeninja = "Itachi";
        Console.WriteLine("Nome do ninja : " + Nomeninja);
        Nomeninja = "Sasuke";
        Console.WriteLine("Nome do ninja : " + Nomeninja);
    }
}

// 🔥 Agora chamamos o método
Variaveis.VariaveisNaruto();