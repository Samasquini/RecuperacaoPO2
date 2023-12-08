using RecuperacaoPO2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperacaoPO2.Telas
{
    public partial class Ver_Informacoes_e_Documentos : Form
    {
        public Ver_Informacoes_e_Documentos(int id)
        {
            InitializeComponent();
            PreencherDataGridView_Informacoes(id);
            PreencherDataGridView_Documentacao(id);
        }

        private void Ver_Informacoes_e_Documentos_Load(object sender, EventArgs e)
        {

        }
        private void PreencherDataGridView_Informacoes(int id)
        {
            Buscar_Informacoes busca = new Buscar_Informacoes();
            List<Informacoes> info = busca.Buscar_InformacoesBD(id);

            dataGridView1.AutoGenerateColumns = false;

            foreach (var inf in info)
            {
                dataGridView1.Rows.Add(inf.id_inf, inf.num_chassi_inf, inf.num_motor_inf, inf.tipo_combustivel_inf, inf.capacidade_motor_inf, inf.potencia_motor_inf, inf.transmissao_inf, inf.tipo_tracao_inf);
            }
        }
        private void PreencherDataGridView_Documentacao(int id)
        {
            Buscar_Documentacao busca = new Buscar_Documentacao();
            List<Documentacao> documentos = busca.Buscar_DocumentacaoBD(id);

            dataGridView1.AutoGenerateColumns = false;

            foreach (var doc in documentos)
            {
                dataGridView2.Rows.Add(doc.id_doc, doc.num_placa_doc, doc.num_placa_doc, doc.data_licenciamento_doc, doc.data_inspecao_doc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
