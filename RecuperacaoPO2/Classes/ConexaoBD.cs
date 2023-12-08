using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using MySqlX.XDevAPI;

namespace RecuperacaoPO2.Classes
{
    public class ConexaoBD
    {
        private string _servidor = "localhost";
        private string _porta = "3306";
        private string _usuario = "root";
        private string _senha = "samasquini";
        private string _bancoDadosNome = "recuperacaopo2";
        private MySqlConnection conecxao;

        

        public ConexaoBD()
        {
            try
            {
                conecxao = new MySqlConnection($"server={_servidor};database={_bancoDadosNome};port={_porta} ;user={_usuario};password={_senha}");
                conecxao.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Inserir_Carro(Carros car)
        {
            try
            {
                ConexaoBD conexao = new ConexaoBD();

                var query = "INSERT INTO Carros VALUES (null, @marca, @modelo, @ano_fabricacao, @ano_modelo, @cor, @num_porta, @tipo_carroceria)";
                MySqlCommand comando_carro = new MySqlCommand(query, conecxao);

                comando_carro.Parameters.AddWithValue("@marca", car.marca_car);
                comando_carro.Parameters.AddWithValue("@modelo", car.modelo_car);
                comando_carro.Parameters.AddWithValue("@ano_fabricacao", car.ano_fabricacao_car);
                comando_carro.Parameters.AddWithValue("@ano_modelo", car.ano_modelo_car);
                comando_carro.Parameters.AddWithValue("@cor", car.cor_car);
                comando_carro.Parameters.AddWithValue("@num_porta", car.num_portas_car);
                comando_carro.Parameters.AddWithValue("@tipo_carroceria", car.tipo_carroceria_car);


                var resultado = comando_carro.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void Inserir_Informacoes(Informacoes inf)
        {
            try
            {
                ConexaoBD conexao = new ConexaoBD();

                var query = "INSERT INTO Informacoes VALUES (null, @num_chassi_inf,@num_motor_inf,@tipo_combustivel_inf,@capacidade_motor_inf,@potencia_motor_inf,@transmissao_inf,@tipo_tracao_inf)";
                MySqlCommand comando_informacoes = new MySqlCommand(query, conecxao);

                comando_informacoes.Parameters.AddWithValue("@num_chassi_inf", inf.num_chassi_inf);
                comando_informacoes.Parameters.AddWithValue("@num_motor_inf", inf.num_motor_inf);
                comando_informacoes.Parameters.AddWithValue("@tipo_combustivel_inf", inf.tipo_combustivel_inf);
                comando_informacoes.Parameters.AddWithValue("@capacidade_motor_inf", inf.capacidade_motor_inf);
                comando_informacoes.Parameters.AddWithValue("@potencia_motor_inf", inf.potencia_motor_inf);
                comando_informacoes.Parameters.AddWithValue("@transmissao_inf", inf.transmissao_inf);
                comando_informacoes.Parameters.AddWithValue("@tipo_tracao_inf", inf.tipo_tracao_inf);


                var resultado = comando_informacoes.ExecuteNonQuery();

                MessageBox.Show("Cadastrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Inserir_Documentacao(Documentacao inf)
        {
            try
            {
                ConexaoBD conexao = new ConexaoBD();

                var query = "INSERT INTO Documentacoes VALUES (null, @renavam_doc, @num_placa_doc, @data_licenciamento_doc, @data_inspecao_doc)";
                MySqlCommand comando_Documentacao = new MySqlCommand(query, conecxao);

                comando_Documentacao.Parameters.AddWithValue("@renavam_doc", inf.renavam_doc);
                comando_Documentacao.Parameters.AddWithValue("@num_placa_doc", inf.num_placa_doc);
                comando_Documentacao.Parameters.AddWithValue("@data_licenciamento_doc", inf.data_licenciamento_doc);
                comando_Documentacao.Parameters.AddWithValue("@data_inspecao_doc", inf.data_inspecao_doc);


                var resultado = comando_Documentacao.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
