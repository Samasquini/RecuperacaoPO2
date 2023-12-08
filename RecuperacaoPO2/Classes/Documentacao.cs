using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacaoPO2.Classes
{
    public class Documentacao
    {
        public int id_doc { get; set; }
        public string renavam_doc { get; set; }
        public string num_placa_doc { get; set; }
        public DateTime data_licenciamento_doc { get; set; }
        public DateTime data_inspecao_doc {  get; set; }
        public Documentacao() { }

        public Documentacao(int id_doc, string renavam_doc, string num_placa_doc, DateTime data_licenciamento_doc, DateTime data_inspecao_doc)
        {
            this.id_doc = id_doc;
            this.renavam_doc = renavam_doc;
            this.num_placa_doc = num_placa_doc;
            this.data_licenciamento_doc = data_licenciamento_doc;
            this.data_inspecao_doc = data_inspecao_doc;
        }

        public Documentacao(string renavam_doc, string num_placa_doc, DateTime data_licenciamento_doc, DateTime data_inspecao_doc)
        {
            this.renavam_doc = renavam_doc;
            this.num_placa_doc = num_placa_doc;
            this.data_licenciamento_doc = data_licenciamento_doc;
            this.data_inspecao_doc = data_inspecao_doc;
        }
    }
}
