using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperacaoPO2.Classes
{
    internal class Deletar_Carros
    {
        private string _servidor = "localhost";
        private string _porta = "3306";
        private string _usuario = "root";
        private string _senha = "samasquini";
        private string _bancoDadosNome = "recuperacaopo2";
        private MySqlConnection conecxao;

        public Deletar_Carros()
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
        public void Deletar_Carro(int id)
        {
            string query = $"DELETE FROM Carros WHERE id_car = {id}";
            MySqlCommand comandoDelete = new MySqlCommand(query, conecxao);
            comandoDelete.ExecuteNonQuery();
            string query2 = $"DELETE FROM Informacoes WHERE id_inf = {id}";
            MySqlCommand comandoDelete2 = new MySqlCommand(query2, conecxao);
            comandoDelete2.ExecuteNonQuery();
            string query3 = $"DELETE FROM Documentacoes WHERE id_doc = {id}";
            MySqlCommand comandoDelete3 = new MySqlCommand(query3, conecxao);
            comandoDelete3.ExecuteNonQuery();
        }

    }
}
