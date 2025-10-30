using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> opcoes = new List<string>
        {   "🧑‍🎨 Cadastrar Usuário",
            "🎨 Cadastrar Obra de Arte",
            "🖼️ Gerenciar Exposições",
            "💰 Leilões Ativos",
            "📦 Histórico de Compras",
            "🚪 Sair"
        };

        Tela tela = new Tela("Sistema de Curadoria de Arte e Leilões Online", opcoes);
        tela.Mostrar();
    }
}
