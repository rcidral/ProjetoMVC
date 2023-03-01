using System.Collections;
using Model;

namespace Controller {
    public class CidadeCollection : IEnumerable<Cidade> {
        public static List<Cidade> cidades = new List<Cidade>();

        public static void Add(Cidade cidade) {
            cidades.Add(cidade);
        }

        public static void Remove(int id) {
            Cidade cidade = GetById(id);
            if (cidade != null) {
                cidades.Remove(cidade);
            }
        }

        public static void Update(Cidade cidade) {
            Cidade cidadeAntiga = GetById(cidade.id);
            if (cidadeAntiga != null) {
                cidadeAntiga.nome = cidade.nome;
            }
        }

        public static Cidade GetById(int id) {
            foreach (Cidade cidade in cidades) {
                if (cidade.id == id) {
                    return cidade;
                }
            }
            return null;
        }

        public IEnumerator<Cidade> GetEnumerator() {
            return cidades.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
