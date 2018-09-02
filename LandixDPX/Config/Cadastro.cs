using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace LandixDPX.Config
{
    public class Cadastro
    {
        public string nome;
        public int cdtab;
        public DateTime dtsnasc;




        //CONEXAO COM O BANCO DE DADOS
        SqlConnection con = new SqlConnection(@"Data Source=POKERT-PC\SQLEXPRESS;Initial Catalog=LDXPSDB;Integrated Security=True");

        //COMANDO PARA INSERIR NO BANCO DE DADOS
        SqlCommand cmd = new SqlCommand();



        //CADASTAR VENDEDOR

        public void CadastrarVendedor(Guid geradorguiv, string dsnome, int cdtab, DateTime dtnasc)
        {
            try
            {

                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "INSERT INTO dbo.VENDEDORES (CDVEND,DSNOME, CDTAB, DTNASC) VALUES (@cdvend, @dsnome, @cdtab, @dtnasc)";

                cmd.Parameters.AddWithValue("@cdvend", geradorguiv);
                cmd.Parameters.AddWithValue("@dsnome", dsnome);
                cmd.Parameters.AddWithValue("@cdtab", cdtab);
                cmd.Parameters.AddWithValue("@dtnasc", dtnasc);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Vendedor cadastrado com sucesso", "Cadastro");
            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }

        }


        // DELETAr DADOS DO VENDEDOR

        public void DelVendedor(string dsnome)
        {

            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM VENDEDORES WHERE DSNOME=@DSNOME";
            cmd.Parameters.AddWithValue("@dsnome", dsnome);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos com sucesso", "Ok");

            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }

        }


        //ALTERAR DADOS DO VENDOR

        public void AlteVendedor(string dsnome, int cdtab, DateTime dtnasc)
        {
            cmd.Connection = con;

            cmd.CommandText = "UPDATE VENDEDORES SET DSNOME=@DSNOME, CDTAB=@CDTAB, DTNASC=@DTNASC ";

            cmd.Parameters.AddWithValue("@dsnome", dsnome);
            cmd.Parameters.AddWithValue("@cdtab", cdtab);
            cmd.Parameters.AddWithValue("@dtnasc", dtnasc);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com sucesso", "Ok");
            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }

        }



        //Deleta dados dos Cliente

        public void DelClientes(string DSNOME)
        {

            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM CLIENTES WHERE DSNOME=@DSNOME";

            cmd.Parameters.AddWithValue("@DSNOME", DSNOME);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos com sucesso", "Ok");

            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }

        }









        //CADASTRAR CLIENTES

        public void CadastrarClientes(Guid gerardorguidc, string dsnome, char idtipo, string CDVEND, decimal dslim)
        {

            try
            {
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "INSERT INTO dbo.CLIENTES (CDCL, DSNOME, IDTIPO, CDVEND, DSLIM) VALUES (@gerardorguidc, @dsnome, @idtipo, @cdvend,@dslim)";


                cmd.Parameters.AddWithValue("@gerardorguidc", gerardorguidc);
                cmd.Parameters.AddWithValue("@dsnome", dsnome);
                cmd.Parameters.AddWithValue("@idtipo", idtipo);
                cmd.Parameters.AddWithValue("@CDVEND", CDVEND);
                cmd.Parameters.AddWithValue("@dslim", dslim);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrador Com sucesso");

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
            finally
            {
                con.Close();
            }

        }


        //ALTERAR DADOS DOS CLIENTES

        public void AlterarCliente(string DSNOME, char IDTIPO, decimal DSLIM)
        {
            cmd.Connection = con;

            cmd.CommandText = "UPDATE CLIENTES SET (DSNOME,IDTIPO,DSLIM) WHERE (@DSNOME, @IDTIPO,@DSLIM)";

            cmd.Parameters.AddWithValue("@DSNOME", DSNOME);
            cmd.Parameters.AddWithValue("@IDTIPO", IDTIPO);
            cmd.Parameters.AddWithValue("@DSLIM", DSLIM);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com sucesso", "Ok");
            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }








            
        }

    }
}