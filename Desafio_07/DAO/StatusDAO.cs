using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using Desafio_07.Entidades;

namespace Desafio_07.DAO
{
    public class StatusDAO : IDaoBase
    {

        //-----------------------------------------------------------------------------------conexão StatusDAO
        string conexao = "SERVER=localhost; DATABASE=sistema_alunos; UID=root; PWD=;";
        public MySqlConnection con = null;
        MySqlCommand sql = null;
        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir conexao StatusDAO:" + ex.Message);
            }

        }

        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //------------------------------------------------------------------------------------  Salvar status

        public void salvarStatusDAO(StatusEntidade dado)
        {
            try
            {
                AbrirConexao();
                sql = new MySqlCommand("INSERT INTO status(nota_1, nota_2, nota_3, nota_4, media, status)" +
                    " VALUES(@nota_1, @nota_2, @nota_3, @nota_4, @media, @status) ", con);
                sql.Parameters.AddWithValue("@nota_1", dado.Nota_1);
                sql.Parameters.AddWithValue("@nota_2", dado.Nota_2);
                sql.Parameters.AddWithValue("@nota_3", dado.Nota_3);
                sql.Parameters.AddWithValue("@nota_4", dado.Nota_4);
                sql.Parameters.AddWithValue("@media", dado.Media);
                sql.Parameters.AddWithValue("@status", dado.Status);

                sql.ExecuteNonQuery();
                FecharConexao();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Salvar Dados do StatusDAO: " + ex.Message);
            }

        }

    }
}
