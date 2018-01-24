using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class GerFilial
    {
        public static DataTable ConsultarDataTable()
        {
            SqlConnection con = new SqlConnection(Utils.connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Filial", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void Gravar(Filial filial)
        {
            SqlConnection con = new SqlConnection(Utils.connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "INSERT INTO Filial VALUES (@nome, @cnpj)";
            com.Parameters.AddWithValue("@nome", filial.nome );
            com.Parameters.AddWithValue("@cnpj", filial.numCNPJ);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public static void Excluir(Filial filial)
        {
            SqlConnection con = new SqlConnection(Utils.connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "DELETE FROM Filial WHERE Cnpj = '@cnpj'";
            com.Parameters.AddWithValue("@cnpj", filial.numCNPJ);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
