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
    public class Buscar_Informacoes
    {
        private string _servidor = "localhost";
        private string _porta = "3306";
        private string _usuario = "root";
        private string _senha = "samasquini";
        private string _bancoDadosNome = "recuperacaopo2";
        private MySqlConnection conecxao;

        public Buscar_Informacoes()
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

        public List<Informacoes> Buscar_InformacoesBD(int id)
        {
            Buscar_Informacoes conexao = new Buscar_Informacoes();
            List<Informacoes> info = new List<Informacoes>();

            string query = "SELECT * FROM Informacoes WHERE id_inf = @id_inf";

            MySqlCommand comando = new MySqlCommand(query, conecxao);

            comando.Parameters.AddWithValue("@id_inf", id);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int id_inf = Convert.ToInt32(reader["id_inf"]);
                string num_chassi_inf = reader["num_chassi_inf"].ToString();
                string num_motor_inf = reader["num_motor_inf"].ToString();
                string tipo_combustivel_inf = reader["tipo_combustivel_inf"].ToString();
                int capacidade_motor_inf = Convert.ToInt32(reader["capacidade_motor_inf"]);
                string potencia_motor_inf = reader["potencia_motor_inf"].ToString();
                string transmissao_inf = reader["transmissao_inf"].ToString();
                string tipo_tracao_inf = reader["tipo_tracao_inf"].ToString();
                Informacoes inf = new Informacoes(id_inf, num_chassi_inf, num_motor_inf, tipo_combustivel_inf,
                    capacidade_motor_inf, potencia_motor_inf, transmissao_inf, tipo_tracao_inf);

                info.Add(inf);
            }
            return info;
        }
    }
}

