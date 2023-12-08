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
    public class Buscar_Documentacao
    {
        private string _servidor = "localhost";
        private string _porta = "3306";
        private string _usuario = "root";
        private string _senha = "samasquini";
        private string _bancoDadosNome = "recuperacaopo2";
        private MySqlConnection conecxao;

        public Buscar_Documentacao()
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

        public List<Documentacao> Buscar_DocumentacaoBD(int id)
        {
            Buscar_Documentacao conexao = new Buscar_Documentacao();
            List<Documentacao> documentacao = new List<Documentacao>();

            string query = "SELECT * FROM Documentacoes WHERE id_doc = @id_doc";

            MySqlCommand comando = new MySqlCommand(query, conecxao);

            comando.Parameters.AddWithValue("@id_doc", id);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int id_doc = Convert.ToInt32(reader["id_doc"]);
                string renavam_doc = reader["renavam_doc"].ToString();
                string num_placa_doc = reader["num_placa_doc"].ToString();
                DateTime data_licenciamento_doc = Convert.ToDateTime(reader["data_licenciamento_doc"]);
                DateTime data_inspecao_doc = Convert.ToDateTime(reader["data_inspecao_doc"]);
                Documentacao doc = new Documentacao(id_doc, renavam_doc, num_placa_doc, data_licenciamento_doc, data_inspecao_doc);

                documentacao.Add(doc);
            }
            return documentacao;
        }
    }
}

