using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class GerPessoa
    {
        public static DataTable ConsultarDataTable()
        {
            List<object> lista = new List<object>();

            SqlConnection con = new SqlConnection(Utils.connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pessoa", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void Gravar(Pessoa pessoa)
        {
            SqlConnection con = new SqlConnection(Utils.connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "INSERT INTO Pessoa VALUES (@nome, @tipo, @numDoc, @tel)";
            com.Parameters.AddWithValue("@nome", pessoa.nome);
            com.Parameters.AddWithValue("@tipo", pessoa.tipoPessoa);
            com.Parameters.AddWithValue("@numDoc", pessoa.numDocumento);
            com.Parameters.AddWithValue("@tel", pessoa.telefone);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public static void Excluir(Pessoa pessoa)
        {
            SqlConnection con = new SqlConnection(Utils.connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "DELETE FROM Pessoa WHERE NumDocumento = '@numDoc'";
            com.Parameters.AddWithValue("@numDoc", pessoa.numDocumento);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
