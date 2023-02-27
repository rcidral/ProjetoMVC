using System.Collections;
using CidadeController;

namespace CidadeModel {
    
    public class Cidade {
        public int id { get; set; }
        public string nome { get; set; } 
        public Cidade(int id, string nome) {
            this.id = id;
            this.nome = nome;
        }
        public override string ToString() {
            return $"Cidade: ID: {id}, Nome: {nome}";
        }
    }
}