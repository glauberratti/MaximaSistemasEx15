using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class GerPedido
    {
        public static void Gravar(Pedido pedido)
        {
            SqlConnection con = new SqlConnection(Utils.connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = con;

            com.CommandText = "INSERT INTO Pedido VALUES (@filial, @prod, @cliente)";
            com.Parameters.AddWithValue("@filial", pedido.filial);
            com.Parameters.AddWithValue("@prod", pedido.produto);
            com.Parameters.AddWithValue("@cliente", pedido.pessoa);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public static void Excluir(Pedido pedido)
        {
            SqlConnection con = new SqlConnection(Utils.connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = con;

            com.CommandText = "DELETE FROM Pedido WHERE Filial = '@filial' Produto = '@cod' AND Cliente = '@cliente'";
            com.Parameters.AddWithValue("@filial", pedido.filial);
            com.Parameters.AddWithValue("@prod", pedido.produto);
            com.Parameters.AddWithValue("@cliente", pedido.pessoa);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
