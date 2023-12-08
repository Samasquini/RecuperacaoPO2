using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacaoPO2.Classes
{
    public class Informacoes
    {
        public int id_inf {  get; set; } 
        public string num_chassi_inf { get; set; }
        public string num_motor_inf { get; set; }
        public string tipo_combustivel_inf { get; set; }
        public int capacidade_motor_inf { get; set; }
        public string potencia_motor_inf { get; set; }
        public string transmissao_inf { get; set; }
        public string tipo_tracao_inf { get; set; }

        public Informacoes() { }

        public Informacoes(int id_inf, string num_chassi_inf, string num_motor_inf, string tipo_combustivel_inf, int capacidade_motor_inf, string potencia_motor_inf, string transmissao_inf, string tipo_tracao_inf)
        {
            this.id_inf = id_inf;
            this.num_chassi_inf = num_chassi_inf;
            this.num_motor_inf = num_motor_inf;
            this.tipo_combustivel_inf = tipo_combustivel_inf;
            this.capacidade_motor_inf = capacidade_motor_inf;
            this.potencia_motor_inf = potencia_motor_inf;
            this.transmissao_inf = transmissao_inf;
            this.tipo_tracao_inf = tipo_tracao_inf;
        }

        public Informacoes(string num_chassi_inf, string num_motor_inf, string tipo_combustivel_inf, int capacidade_motor_inf, string potencia_motor_inf, string transmissao_inf, string tipo_tracao_inf)
        {
            this.num_chassi_inf = num_chassi_inf;
            this.num_motor_inf = num_motor_inf;
            this.tipo_combustivel_inf = tipo_combustivel_inf;
            this.capacidade_motor_inf = capacidade_motor_inf;
            this.potencia_motor_inf = potencia_motor_inf;
            this.transmissao_inf = transmissao_inf;
            this.tipo_tracao_inf = tipo_tracao_inf;
        }
    }
}
