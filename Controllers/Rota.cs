using System.Collections;
using Model;

namespace Controller {
    public class RotaCollection : IEnumerable<Rota> {
        public static List<Rota> rotas = new List<Rota>();

        public static void Add(Rota rota) {
            rotas.Add(rota);
            if (CaminhaoCollection.totalRotas(rota.caminhao.id) != 0) {
                rota.caminhao.rotas++;
            }
            if(CaminhaoCollection.faturamento(rota.caminhao.id) != 0) {
                rota.caminhao.faturamento += rota.preco;
            }
             
        }

        public static bool Remove(int id) {
            Rota rota = GetById(id);
            if (rota != null) {
                rotas.Remove(rota);
                return true;
            }
            return false;
        }

        public static bool Update(Rota rota) {
            Rota rotaAntiga = GetById(rota.id);
            if (rotaAntiga != null) {
                rotaAntiga.caminhao = rota.caminhao;
                rotaAntiga.partida = rota.partida;
                rotaAntiga.chegada = rota.chegada;
                rotaAntiga.data = rota.data;
                rotaAntiga.preco = rota.preco;
                return true;
            }
            return false;
        }

        public static Rota GetById(int id) {
            foreach (Rota rota in rotas) {
                if (rota.id == id) {
                    return rota;
                }
            }
            return null;
        }

        public IEnumerator<Rota> GetEnumerator() {
            return rotas.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public double mediaDasRotas() {
            double total = 0;
            foreach (Rota rota in rotas) {
                total += rota.preco;
            }
            return total / rotas.Count;
        }
    }
}