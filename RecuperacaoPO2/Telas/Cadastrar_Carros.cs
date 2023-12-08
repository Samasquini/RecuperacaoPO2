using RecuperacaoPO2.Classes;
using RecuperacaoPO2.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RecuperacaoPO2
{
    public partial class Cadastrar_Carros : Form
    {
        public Cadastrar_Carros()
        {
            InitializeComponent();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoBD conexaoBD = new ConexaoBD();

                string marca = tb_marca.Text;
                string modelo = tb_modelo.Text;
                int ano_fabricacao = Convert.ToInt32(tb_anofabricacao.Text);
                int ano_modelo = Convert.ToInt32(tb_anomodelo.Text);
                string cor = tb_cor.Text;
                int num_portas = Convert.ToInt32(nmr_numportas.Text);
                string tipo_carroceria = "";
                if (rbt_sedan.Checked) { tipo_carroceria = rbt_sedan.Text; }
                if (rbt_fastback.Checked) { tipo_carroceria = rbt_fastback.Text; }
                if (rbt_hatch.Checked) { tipo_carroceria = rbt_hatch.Text; }
                if (rbt_targa.Checked) { tipo_carroceria = rbt_targa.Text; }
                if (rbt_perua.Checked) { tipo_carroceria = rbt_perua.Text; }
                if (rbt_roadster.Checked) { tipo_carroceria = rbt_roadster.Text; }
                if (rbt_suv.Checked) { tipo_carroceria = rbt_suv.Text; }
                if (rbt_minivan.Checked) { tipo_carroceria = rbt_minivan.Text; }
                if (rbt_cupe.Checked) { tipo_carroceria = rbt_cupe.Text; }
                if (rbt_van.Checked) { tipo_carroceria = rbt_van.Text; }

                Carros carros = new Carros(marca, modelo, ano_fabricacao, ano_modelo, cor, num_portas, tipo_carroceria);

                conexaoBD.Inserir_Carro(carros);

                string num_chassi = tb_numchassi.Text;
                string num_motor = tb_nummotor.Text;
                int capacidade = Convert.ToInt32(nmr_capacidadedomotor.Text);
                string potencia = cb_potencia.Text;
                string trasmissao = cb_trasmissao.Text;
                string tracao = cb_tracao.Text;
                string combustivel = cb_tipocombustivel.Text;

                Informacoes informacoes = new Informacoes(num_chassi, num_motor, combustivel, capacidade, potencia, trasmissao, tracao);

                conexaoBD.Inserir_Informacoes(informacoes);

                string renavan = tb_renavam.Text;
                string placa = tb_numplaca.Text;
                DateTime data_licenciamento = Convert.ToDateTime(msk_licenciamento.Text);
                DateTime data_inspecao = Convert.ToDateTime(msk_inspecao.Text);

                Documentacao documentacao = new Documentacao(renavan, placa, data_licenciamento, data_inspecao);

                conexaoBD.Inserir_Documentacao(documentacao);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
            }
        }
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_marca.Text = "";
            tb_modelo.Text = "";
            tb_anofabricacao.Text = "";
            tb_anomodelo.Text = "";
            tb_cor.Text = "";
            nmr_numportas.Text = "0";
            if (rbt_sedan.Checked) { rbt_sedan.Checked = false; }
            if (rbt_fastback.Checked) { rbt_fastback.Checked = false; }
            if (rbt_hatch.Checked) { rbt_hatch.Checked = false; }
            if (rbt_targa.Checked) { rbt_targa.Checked = false; }
            if (rbt_perua.Checked) { rbt_perua.Checked = false; }
            if (rbt_roadster.Checked) { rbt_roadster.Checked = false; }
            if (rbt_suv.Checked) { rbt_suv.Checked = false; }
            if (rbt_minivan.Checked) { rbt_minivan.Checked = false; }
            if (rbt_cupe.Checked) { rbt_cupe.Checked = false; }
            if (rbt_van.Checked) { rbt_van.Checked = false; }

            tb_numchassi.Text = "";
            tb_nummotor.Text = "";
            nmr_capacidadedomotor.Text = "0";
            cb_potencia.Text = "";
            cb_trasmissao.Text = ""; 
            cb_tracao.Text = "";
            cb_tipocombustivel.Text = "";

            tb_renavam.Text = "";
            tb_numplaca.Text = "";
            msk_licenciamento.Text = "";
            msk_inspecao.Text = "";
        }
    }
}