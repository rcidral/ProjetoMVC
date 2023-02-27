using System;
using View;

namespace Program {
    class Program {
        static void Main(string[] args) {
            int opcao = 0;
            while(opcao != 4) {
                Console.WriteLine("1 - CRUD Cidade");
                Console.WriteLine("2 - CRUD Caminhão");
                Console.WriteLine("3 - CRUD Rota");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao) {
                    case 1:
                        CidadeView.menuCidade();
                        break;
                    case 2:
                        CaminhaoView.menuCaminhao();
                        break;
                    case 3:
                        RotaView.menuRota();
                        break;
                    case 4: 
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}