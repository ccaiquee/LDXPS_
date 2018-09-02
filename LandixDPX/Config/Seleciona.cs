using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandixDPX.Config
{
    public class Seleciona
    {

        //CONEXÃO COM O BANCO DE DADOS

        SqlConnection con = new SqlConnection(@"Data Source=POKERT-PC\SQLEXPRESS;Initial Catalog=LDXPSDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();


        public DataTable Vendedores()
        {
         


            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT * FROM VENDEDORES";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                DataRow fila = dt.NewRow();


                fila["DSNOME"] = "";

                dt.Rows.InsertAt(fila, 0);

                con.Close();

                return dt;
            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);
                return null;
            }
        }


        public DataTable Clientes()
        {
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT * FROM CLIENTES ORDER BY DSNOME";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            DataRow fila = dt.NewRow();


            fila["DSNOME"] = "";
           
            dt.Rows.InsertAt(fila, 0);

            con.Close();

            return dt;
        }




    }
}
