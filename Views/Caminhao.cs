using System;
using Controller;
using Model;

namespace View {

    public class CaminhaoView {

        public static void createCaminhao() {
            try {
                Console.WriteLine("Digite o ID do caminhão: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a placa do caminhão sem o -: ");
                string placa = Console.ReadLine();
                verificaPlaca(placa);
                placa = placa.Insert(3, "-");
                Console.WriteLine("Digite o nome do motorista: ");
                string motorista = Console.ReadLine();
                Caminhao caminhao = new Caminhao(id, placa, motorista);
                CaminhaoCollection.Add(caminhao);
                Console.WriteLine("Caminhão criado com sucesso!");
            } catch (Exception e) {
                Console.WriteLine("Erro ao criar caminhão: " + e.Message);
            }
        }

        public static void readCaminhao() {
            try {
                foreach (Caminhao caminhao in CaminhaoCollection.caminhoes) {
                    Console.WriteLine(caminhao);
                }
            } catch (Exception e) {
                Console.WriteLine("Erro ao ler caminhão: " + e.Message);
            }
        }

        public static void updateCaminhao() {
            try {
                Console.WriteLine("Digite o ID do caminhão que deseja atualizar: ");
                int id = int.Parse(Console.ReadLine());
                Caminhao caminhao = CaminhaoCollection.GetById(id);
                if (caminhao != null) {
                    Console.WriteLine("Digite a placa do caminhão: ");
                    string placa = Console.ReadLine();
                    Console.WriteLine("Digite o nome do motorista: ");
                    string motorista = Console.ReadLine();
                    caminhao.placa = placa;
                    caminhao.motorista = motorista;
                    Console.WriteLine("Caminhão atualizado com sucesso!");
                } else {
                    Console.WriteLine("Caminhão não encontrado!");
                }
            } catch (Exception e) {
                Console.WriteLine("Erro ao atualizar caminhão: " + e.Message);
            }
        }

        public static void deleteCaminhao() {
            try {
                Console.WriteLine("Digite o ID do caminhão que deseja deletar: ");
                int id = int.Parse(Console.ReadLine());
                Caminhao caminhao = CaminhaoCollection.GetById(id);
                if (caminhao != null) {
                    CaminhaoCollection.Remove(id);
                    Console.WriteLine("Caminhão deletado com sucesso!");
                } else {
                    Console.WriteLine("Caminhão não encontrado!");
                }
            } catch (Exception e) {
                Console.WriteLine("Erro ao deletar caminhão: " + e.Message);
            }
        }

        public static void verificaPlaca(string placa) {
            if (placa.Length != 7) {
                throw new Exception("Placa inválida!");
            }
            for (int i = 0; i < 3; i++) {
                if (!char.IsLetter(placa[i])) {
                    throw new Exception("Placa inválida!");
                }
            }
            for (int i = 3; i < 7; i++) {
                if (!char.IsDigit(placa[i])) {
                    throw new Exception("Placa inválida!");
                }
            }
        }

        public static void menuCaminhao() {
            int opcao = 0;
            do {
                Console.WriteLine("1 - Criar caminhão");
                Console.WriteLine("2 - Ler caminhões");
                Console.WriteLine("3 - Atualizar caminhão");
                Console.WriteLine("4 - Deletar caminhão");
                Console.WriteLine("5 - Voltar");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao) {
                    case 1:
                        createCaminhao();
                        break;
                    case 2:
                        readCaminhao();
                        break;
                    case 3:
                        updateCaminhao();
                        break;
                    case 4:
                        deleteCaminhao();
                        break;
                    case 5:
                        Console.WriteLine("Voltando...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 5);
        }
    }
}