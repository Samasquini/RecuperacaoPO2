using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacaoPO2.Classes
{
    public class Carros
    {
        public int id_car {  get; set; }
        public string marca_car { get; set; }
        public string modelo_car { get; set; }
        public int ano_fabricacao_car { get; set; }
        public int ano_modelo_car { get; set; }
        public string cor_car { get; set; }
        public int num_portas_car { get; set; }
        public string tipo_carroceria_car { get; set; }

        public Carros() { }

        public Carros(int id_car, string marca_car, string modelo_car, int ano_fabricacao_car, int ano_modelo_car, string cor_car, int num_portas_car, string tipo_carroceria_car)
        {
            this.id_car = id_car;
            this.marca_car = marca_car;
            this.modelo_car = modelo_car;
            this.ano_fabricacao_car = ano_fabricacao_car;
            this.ano_modelo_car = ano_modelo_car;
            this.cor_car = cor_car;
            this.num_portas_car = num_portas_car;
            this.tipo_carroceria_car = tipo_carroceria_car;
        }

        public Carros(string marca_car, string modelo_car, int ano_fabricacao_car, int ano_modelo_car, string cor_car, int num_portas_car, string tipo_carroceria_car)
        {
            this.marca_car = marca_car;
            this.modelo_car = modelo_car;
            this.ano_fabricacao_car = ano_fabricacao_car;
            this.ano_modelo_car = ano_modelo_car;
            this.cor_car = cor_car;
            this.num_portas_car = num_portas_car;
            this.tipo_carroceria_car = tipo_carroceria_car;
        }
    }
}
