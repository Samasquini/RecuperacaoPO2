using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RecuperacaoPO2.Classes
{
    public class Buscar_Carros
    {
        private string _servidor = "localhost";
        private string _porta = "3306";
        private string _usuario = "root";
        private string _senha = "samasquini";
        private string _bancoDadosNome = "recuperacaopo2";
        private MySqlConnection conecxao;

        public Buscar_Carros()
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

        public List<Carros> Buscar_CarrosBD()
        {
            Buscar_Carros conexao = new Buscar_Carros();
            List<Carros> carros = new List<Carros>();

            string query = "SELECT * FROM Carros";

            MySqlCommand command = new MySqlCommand(query, conecxao);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id_car = Convert.ToInt32(reader["id_car"]);
                string marca_car = reader["marca_car"].ToString();
                string modelo_car = reader["modelo_car"].ToString();
                int ano_fabricacao_car = Convert.ToInt32(reader["ano_fabricacao_car"]);
                int ano_modelo_car = Convert.ToInt32(reader["ano_modelo_car"]);
                string cor_car = reader["cor_car"].ToString();
                int num_portas_car = Convert.ToInt32(reader["num_portas_car"]);
                string tipo_carroceria_car = reader["tipo_carroceria_car"].ToString();
                Carros carro = new Carros(id_car, marca_car, modelo_car, ano_fabricacao_car, ano_modelo_car, cor_car, num_portas_car, tipo_carroceria_car);

                carros.Add(carro);
            }
            return carros;
        }
    }
}

