using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class GerProduto
    {
        public static DataTable ConsultarDataTable()
        {
            SqlConnection con = new SqlConnection(Utils.connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produtos",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void Gravar(Produto produto)
        {
            SqlConnection con = new SqlConnection(Utils.connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "INSERT INTO Produtos VALUES (@cod, @emb, @preco)";
            com.Parameters.AddWithValue("@cod", produto.codigo);
            com.Parameters.AddWithValue("@emb", produto.embalagem);
            com.Parameters.AddWithValue("@preco", produto.preco);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public static void Excluir(Produto produto)
        {
            SqlConnection con = new SqlConnection(Utils.connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "DELETE FROM Produtos WHERE NumDocumento = '@cod'";
            com.Parameters.AddWithValue("@cod", produto.codigo);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
