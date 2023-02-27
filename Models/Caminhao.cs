using System.Collections;

namespace Model {
    
    public class Caminhao {
        public int id { get; set; }
        public string placa { get; set; }
        public string motorista { get; set; }
        public Caminhao(int id, string placa, string motorista) {
            this.id = id;
            this.placa = placa;
            this.motorista = motorista;
        }
        public override string ToString() {
            return $"Caminhão: ID: {id}, Placa: {placa}, Motorista: {motorista}";
        }
    }
}