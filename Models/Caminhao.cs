using System.Collections;

namespace Model {
    
    public class Caminhao {
        public int id { get; set; }
        public string placa { get; set; }
        public string motorista { get; set; }
        public int rotas { get; set; }
        public double faturamento { get; set; }
        public Caminhao(int id, string placa, string motorista) {
            this.id = id;
            this.placa = placa;
            this.motorista = motorista;
            this.rotas = 0;
            this.faturamento = 0;
        }
        public override string ToString() {
            return $"Caminhão: ID: {id}, Placa: {placa}, Motorista: {motorista}, Rotas: {rotas}, Faturamento: {faturamento}";
        }
    }
}