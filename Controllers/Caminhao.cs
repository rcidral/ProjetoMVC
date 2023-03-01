using System.Collections;
using Model;

namespace Controller {
    public class CaminhaoCollection : IEnumerable<Caminhao> {
        public static List<Caminhao> caminhoes = new List<Caminhao>();

        public static void Add(Caminhao caminhao) {
            caminhoes.Add(caminhao);
        }

        public static void Remove(int id) {
            Caminhao caminhao = GetById(id);
            if (caminhao != null) {
                caminhoes.Remove(caminhao);
            }
        }

        public static void Update(Caminhao caminhao) {
            Caminhao caminhaoAntigo = GetById(caminhao.id);
            if (caminhaoAntigo != null) {
                caminhaoAntigo.motorista = caminhao.motorista;
                caminhaoAntigo.placa = caminhao.placa;
            }
        }

        public static Caminhao GetById(int id) {
            foreach (Caminhao caminhao in caminhoes) {
                if (caminhao.id == id) {
                    return caminhao;
                }
            }
            return null;
        }

        public IEnumerator<Caminhao> GetEnumerator() {
            return caminhoes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public static int totalRotas(int id) {
            int total = 0;
            foreach (Rota rota in RotaCollection.rotas) {
                if (rota.caminhao.id == id) {
                    total++;
                }
            }
            return total;
        }

        public static double faturamento(int id) {
            double total = 0;
            foreach (Rota rota in RotaCollection.rotas) {
                if (rota.caminhao.id == id) {
                    total += rota.preco;
                }
            }
            return total;
        }
    }

}