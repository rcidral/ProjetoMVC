using System.Collections;
using RotaModel;

namespace RotaController {
    public class RotaCollection : IEnumerable<Rota> {
        public static List<Rota> rotas = new List<Rota>();

        public static void Add(Rota rota) {
            rotas.Add(rota);
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
    }
}