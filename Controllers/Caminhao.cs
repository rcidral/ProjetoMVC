using System.Collections;
using CaminhaoModel;

namespace CaminhaoController {
    public class CaminhaoCollection : IEnumerable<Caminhao> {
        public static List<Caminhao> caminhoes = new List<Caminhao>();

        public static void Add(Caminhao caminhao) {
            caminhoes.Add(caminhao);
        }

        public static bool Remove(int id) {
            Caminhao caminhao = GetById(id);
            if (caminhao != null) {
                caminhoes.Remove(caminhao);
                return true;
            }
            return false;
        }

        public static bool Update(Caminhao caminhao) {
            Caminhao caminhaoAntigo = GetById(caminhao.id);
            if (caminhaoAntigo != null) {
                caminhaoAntigo.placa = caminhao.placa;
                caminhaoAntigo.motorista = caminhao.motorista;
                return true;
            }
            return false;
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
    }

}