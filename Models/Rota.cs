using System.Collections;
using CaminhaoModel;
using CidadeModel;

namespace RotaModel {
    
    public class Rota {
        public int id { get; set; }
        public Caminhao caminhao { get; set; }
        public Cidade partida { get; set; }
        public Cidade chegada { get; set; }
        public string data { get; set; } 

        public Rota(int id, Caminhao caminhao, Cidade partida, Cidade chegada, string data) {
            this.id = id;
            this.caminhao = caminhao;
            this.partida = partida;
            this.chegada = chegada;
            this.data = data;
        }

         public override string ToString() {
            return $"Rota: ID: {id}, Caminhão: {caminhao.motorista}, Partida: {partida.nome}, Chegada: {chegada.nome}, Data: {data}";
        }
    }
}