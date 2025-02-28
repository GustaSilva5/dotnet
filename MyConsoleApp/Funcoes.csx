using System;
class Funcoes
{
    public static void FuncoesNaruto()
    {
        string Ninja = "Naruto";
        string Jutsu = "Rasengan";
        atacar (Ninja, Jutsu);
    }

    static void atacar(string ninja, string jutsu)
    {
        Console.WriteLine(ninja + " atacou com " + jutsu);
    }

}

Funcoes.FuncoesNaruto()