using System;
using System.Collections.Generic;
using System.Threading;

public class Tela
{
    private string titulo;
    private List<string> opcoes;

    public Tela(string titulo, List<string> opcoes)
    {
        this.titulo = titulo;
        this.opcoes = opcoes;
    }

    public void Mostrar()
    {
        Console.Title = titulo.ToUpper();
        Console.CursorVisible = false;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Clear();

        EfeitoConfeteRapido(); // 👈 Adiciona o efeito antes da arte aparecer

        MostrarTelaCentralizada();
        Console.SetCursorPosition(0, Console.WindowHeight - 2);
        Console.ResetColor();
    }

    // 🎉 EFEITO DE CONFETE RÁPIDO (leve e centralizado)
    private void EfeitoConfeteRapido()
    {
        Random random = new Random();
        int largura = Console.WindowWidth;
        int altura = Console.WindowHeight;
        char[] simbolos = { '*', '+', '.', 'o', '@', '#', };

        DateTime inicio = DateTime.Now;
        TimeSpan duracao = TimeSpan.FromMilliseconds(3000);
        while (DateTime.Now - inicio < duracao)
        {
            int x = random.Next(0, largura);
            int y = random.Next(0, altura);
            ConsoleColor cor = (ConsoleColor)random.Next(1, 16);
            char simbolo = simbolos[random.Next(simbolos.Length)];

            Console.ForegroundColor = cor;
            Console.SetCursorPosition(x, y);
            Console.Write(simbolo);

            Thread.Sleep(4); // velocidade do efeito
        }

        Console.Clear(); // limpa o confete antes de mostrar tua arte
    }

    private void MostrarTelaCentralizada()
    {
        string arte = @"
::────────────────────────────────────────────────────────────────────────────::
::                            BEM VINDOS AO                                   ::
::              SISTEMA DE CURADORIA DE ARTE E LEILÕES ONLINE                 ::
::                                                                            ::
::                                                                            ::
::              []                                       []                   ::
::              []                                       []                   ::
::             .[]:.                                 ,: :[]:.                 ::
::           .: []: :-.                           ,-: : :[]: :.               ::
::         .: : []: : :`._                   _.,': : : : []: : :.             ::
::       .: : : []: : : : :-._           _.-: : : : : : :[]: : : :.           ::
::___..: : : :  []: : : : : : :-._____.-: : : : : : : : :[]: : : : :-.________::
::!_!!_!_!_!_!_![]!_!_!_!_!_!_!_!_!_!_!_!_!_!_!_!_!_!_!_![]!_!_!_!_!_!_!_!!_!::
::!!!!!!!!!!!!! []!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!![]!!!!!!!!!!!!!!!!!!!::
::^^^^^^^^^^^^^^[]^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^[]^^^^^^^^^^^^^^^^^^^::
::              []                                       []                   ::
::              []                                       []                   ::
::              []                                       []                   ::
::              []                                       []                   ::
:: ~ ~- ^ ~ ~- /  \~^-~^~_~^-~_^~-^~_^~~-^~_~^~-~_~-^~_^/  \~^-~_~^- ~ ~- ^ ~ ::
::~ _~~-~ _~~- ~^-^~-^~~- ^~_^-^~~_ -~^_ -~_-~~^- _~~_~-^_ ~^-^~~-_^-~ ~^~ _~~::
:: ~ ^-  ~ ^- ~ ^- _~~_-  ~~ _ ~  ^~  - ~~^ _ -  ^~-  ~ _  ~~^  - ~_   - ~^_~ ::
::  ~-  ^_ ~-  ^_  ~^ -  ^~ _ - ~^~ _   _~^~-  _ ~~^ - _ ~ - _ ~~^ -  ~-  ^_  ::
::  ~^ -_~^ -_ ~^^ -_ ~ _ - _ ~^~-  _~ -_   ~- _ ~^ _ -  ~ ^-  ~^ -_  ~^ -_   ::
:: ~^~ - ~^~ - ~^~ - ~^~ - ~^~ ~^~ - _ ^ - ~~~ _ - _ ~-^ ~ __- ~_ - ~  ~^_- ~^::
::  ~ ~- ^ ~ ~- ^ ~ ~- ^ ~ ~- ^ ~ ~- ^ ~ ~- ^ ~ ~- ^ ~ ~- ^ ~ ~- ^ ~ ~- ^ ~ ~-::
::────────────────────────────────────────────────────────────────────────────::
";

        Console.Clear();
        int larguraConsole = Console.WindowWidth;
        int alturaConsole = Console.WindowHeight;
        string[] linhas = arte.Split('\n');
        int inicioVertical = Math.Max((alturaConsole - linhas.Length) / 2, 0);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = 0; i < linhas.Length; i++)
        {
            string linha = linhas[i];
            int posHorizontal = Math.Max((larguraConsole - linha.Length) / 2, 0);
            Console.SetCursorPosition(posHorizontal, inicioVertical + i);
            Console.WriteLine(linha);
        }
    }
}
