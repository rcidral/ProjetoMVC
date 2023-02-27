using System;
using Controller;
using Model;

namespace View {
    public class CidadeView {
        public static void createCidade() {
            try {
                Console.WriteLine("Digite o ID da cidade: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome da cidade: ");
                string nome = Console.ReadLine();
                Cidade cidade = new Cidade(id, nome);
                CidadeCollection.Add(cidade);
                Console.WriteLine("Cidade criada com sucesso!");
            } catch (Exception e) {
                Console.WriteLine("Erro ao criar cidade: " + e.Message);
            }
        }
        public static void readCidade() {
            try {
                foreach (Cidade cidade in CidadeCollection.cidades) {
                    Console.WriteLine(cidade);
                }
            } catch (Exception e) {
                Console.WriteLine("Erro ao ler cidade: " + e.Message);
            }
        }
        public static void updateCidade() {
            try {
                Console.WriteLine("Digite o ID da cidade que deseja atualizar: ");
                int id = int.Parse(Console.ReadLine());
                Cidade cidade = CidadeCollection.GetById(id);
                if (cidade != null) {
                    Console.WriteLine("Digite o nome da cidade: ");
                    string nome = Console.ReadLine();
                    cidade.nome = nome;
                    Console.WriteLine("Cidade atualizada com sucesso!");
                } else {
                    Console.WriteLine("Cidade não encontrada!");
                }
            } catch (Exception e) {
                Console.WriteLine("Erro ao atualizar cidade: " + e.Message);
            }
        }
        public static void deleteCidade() {
            try {
                Console.WriteLine("Digite o ID da cidade que deseja deletar: ");
                int id = int.Parse(Console.ReadLine());
                Cidade cidade = CidadeCollection.GetById(id);
                if (cidade != null) {
                    CidadeCollection.Remove(id);
                    Console.WriteLine("Cidade deletada com sucesso!");
                } else {
                    Console.WriteLine("Cidade não encontrada!");
                }
            } catch (Exception e) {
                Console.WriteLine("Erro ao deletar cidade: " + e.Message);
            }
        }

        public static void menuCidade() {
            int opcao = 0;
            do {
                Console.WriteLine("1 - Criar cidade");
                Console.WriteLine("2 - Ler cidade");
                Console.WriteLine("3 - Atualizar cidade");
                Console.WriteLine("4 - Deletar cidade");
                Console.WriteLine("5 - Voltar");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao) {
                    case 1:
                        createCidade();
                        break;
                    case 2:
                        readCidade();
                        break;
                    case 3:
                        updateCidade();
                        break;
                    case 4:
                        deleteCidade();
                        break;
                    case 0:
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