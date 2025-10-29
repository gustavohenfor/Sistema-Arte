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
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();

        MostrarTelaCentralizada();
        Console.SetCursorPosition(0, Console.WindowHeight - 2);
        Console.ResetColor();
    }

    private void MostrarTelaCentralizada()
    {
        string arte = @"
::────────────────────────────────────────────────────────────────────────────::
::                                                                            ::
::                        SISTEMA DE CURADORIA DE ARTE E LEILÕES ONLINE       ::
::                                                                            ::
::                                                                            ::
::              []                                       []                   ::
::              []                                       []                   ::
::             .[]:.                                 ,: :[]:.                 ::
::           .: []: :-.                           ,-: : :[]: :.               ::
::         .: : []: : :`._                   _.,': : : : []: : :.             ::
::       .: : : []: : : : :-._           _.-: : : : : : :[]: : : :.           ::
::   _..: : : : []: : : : : : :-._____.-: : : : : : : : :[]: : : : :-._       ::
::   !_!_!_!_!_![]!_!_!_!_!_!_!_!_!_!_!_!_!_!_!_!_!_!_!_![]!_!_!_!_!_!_!_!    ::
::   !!!!!!!!!!![]!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!![]!!!!!!!!!!!!!!!!   ::
::   ^^^^^^^^^^^[]^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^[]^^^^^^^^^^^^^^^^   ::
::              []                                       []                   ::
::              []                                       []                   ::
::              []                                       []                   ::
::   ~~^-~^_~^~/  \~^-~^~_~^-~_^~-^~_^~~-^~_~^~-~_~-^~_^/  \~^-~_~^-~~-       ::
::  ~ _~~- ~^-^~-^~~- ^~_^-^~~_ -~^_ -~_-~~^- _~~_~-^_ ~^-^~~-_^-~ ~^         ::
::     ~ ^- _~~_-  ~~ _ ~  ^~  - ~~^ _ -  ^~-  ~ _  ~~^  - ~_   - ~^_~        ::
::       ~-  ^_  ~^ -  ^~ _ - ~^~ _   _~^~-  _ ~~^ - _ ~ - _ ~~^ -            ::
::          ~^ -_ ~^^ -_ ~ _ - _ ~^~-  _~ -_   ~- _ ~^ _ -  ~ ^-              ::
::              ~^~ - _ ^ - ~~~ _ - _ ~-^ ~ __- ~_ - ~  ~^_-                  ::
::                  ~ ~- ^~ -  ~^ -  ~ ^~ - ~~  ^~ - ~                        ::
::────────────────────────────────────────────────────────────────────────────::
";


        Console.Clear();
        int larguraConsole = Console.WindowWidth;
        int alturaConsole = Console.WindowHeight;

        // Centralização vertical e horizontal
        string[] linhas = arte.Split('\n');
        int inicioVertical = Math.Max((alturaConsole - linhas.Length) / 2, 0);



        // Arte centralizada
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        for (int i = 0; i < linhas.Length; i++)
        {
            string linha = linhas[i];
            int posHorizontal = Math.Max((larguraConsole - linha.Length) / 2, 0);
            Console.SetCursorPosition(posHorizontal, inicioVertical + i);
            Console.WriteLine(linha);
        }


    }
}
