using RecuperacaoPO2.Classes;
using RecuperacaoPO2.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RecuperacaoPO2
{
    public partial class Consultar_Carros : Form
    {
        public Consultar_Carros()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void PreencherDataGridView()
        {
            dataGridView1.RowCount = 1;
            Buscar_Carros busca = new Buscar_Carros();
            List<Carros> carros = busca.Buscar_CarrosBD();

            dataGridView1.AutoGenerateColumns = false;

            foreach (var carro in carros)
            {
                dataGridView1.Rows.Add(carro.id_car,carro.marca_car,carro.modelo_car,carro.ano_fabricacao_car,carro.ano_modelo_car,carro.cor_car,carro.num_portas_car,carro.tipo_carroceria_car);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSelecionado = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                idSelecionado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value);
            }

            Ver_Informacoes_e_Documentos ver = new Ver_Informacoes_e_Documentos(idSelecionado);
            ver.ShowDialog();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Deletar_Carros conexao = new Deletar_Carros();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Codigo"].Value);

                conexao.Deletar_Carro(id);
                PreencherDataGridView();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para deletar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            btnDeletar.Enabled = true;
            PreencherDataGridView();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
