using System;
using Controller;
using Model;

namespace View {
    public class RotaView {
        public static void createRota() {
            try {
                Console.WriteLine("Digite o id da rota: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o id do caminhão: ");
                int idCaminhao = int.Parse(Console.ReadLine());
                Caminhao idCaminhaoVerificado = CaminhaoCollection.GetById(idCaminhao);
                Console.WriteLine("Digite o id da cidade de partida: ");
                int idPartida = int.Parse(Console.ReadLine());
                Cidade idCidadePartidaVerificado = CidadeCollection.GetById(idPartida);
                Console.WriteLine("Digite o id da cidade de chegada: ");
                int idChegada = int.Parse(Console.ReadLine());
                Cidade idCidadeChegadaVerificado = CidadeCollection.GetById(idChegada);
                Console.WriteLine("Digite a data da rota: ");
                string data = Console.ReadLine();
                Console.WriteLine("Digite o preço da rota: ");
                double preco = double.Parse(Console.ReadLine());
                Rota rota = new Rota(id, idCaminhaoVerificado, idCidadePartidaVerificado, idCidadeChegadaVerificado, data, preco);
                RotaCollection.Add(rota);
            } catch (Exception e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void readRota() {
            try {
                foreach (Rota rota in RotaCollection.rotas) {
                    Console.WriteLine(rota);
                }
            } catch (Exception e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void updateRota() {
            try {
                Console.WriteLine("Digite o ID da rota que deseja atualizar: ");
                int id = int.Parse(Console.ReadLine());
                Rota rota = RotaCollection.GetById(id);
                if (rota != null) {
                    Console.WriteLine("Digite o id do caminhão: ");
                    int idCaminhao = int.Parse(Console.ReadLine());
                    Caminhao idCaminhaoVerificado = CaminhaoCollection.GetById(idCaminhao);
                    Console.WriteLine("Digite o id da cidade de partida: ");
                    int idPartida = int.Parse(Console.ReadLine());
                    Cidade idCidadePartidaVerificado = CidadeCollection.GetById(idPartida);
                    Console.WriteLine("Digite o id da cidade de chegada: ");
                    int idChegada = int.Parse(Console.ReadLine());
                    Cidade idCidadeChegadaVerificado = CidadeCollection.GetById(idChegada);
                    Console.WriteLine("Digite a data da rota: ");
                    string data = Console.ReadLine();
                    Console.WriteLine("Digite o preço da rota: ");
                    double preco = double.Parse(Console.ReadLine());
                    rota.caminhao = idCaminhaoVerificado;
                    rota.partida = idCidadePartidaVerificado;
                    rota.chegada = idCidadeChegadaVerificado;
                    rota.data = data;
                    rota.preco = preco;
                    Console.WriteLine("Rota atualizada com sucesso!");
                } else {
                    Console.WriteLine("Rota não encontrada!");
                }
            } catch (Exception e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void deleteRota() {
            try {
                Console.WriteLine("Digite o ID da rota que deseja deletar: ");
                int id = int.Parse(Console.ReadLine());
                Rota rota = RotaCollection.GetById(id);
            } catch (Exception e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void menuRota() {
            RotaCollection.mediaRotas();
            try {
                int opcao = 0;
                while (opcao != 5) {
                    Console.WriteLine("1 - Cadastrar rota");
                    Console.WriteLine("2 - Listar rotas");
                    Console.WriteLine("3 - Atualizar rota");
                    Console.WriteLine("4 - Deletar rota");
                    Console.WriteLine("5 - Voltar");
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao) {
                        case 1:
                            createRota();
                            break;
                        case 2:
                            readRota();
                            break;
                        case 3:
                            updateRota();
                            break;
                        case 4:
                            deleteRota();
                            break;
                        case 5:
                            Console.WriteLine("Voltando...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}