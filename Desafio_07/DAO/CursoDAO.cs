using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Desafio_07.Entidades;
using MySql.Data.MySqlClient;

namespace Desafio_07.DAO
{
    public class CursoDAO : IDaoBase
    {
//-----------------------------------------------------------------------------------conexão
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
                Console.WriteLine("Erro ao abrir conexao CURSODAO :" + ex.Message);
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
 //------------------------------------------------------------------------------------  Salvar Curso

        public void salvarCursoDAO(CursoEntidade dado)
        {
            try
            {
                AbrirConexao();
                sql = new MySqlCommand("INSERT INTO curso(nome, ano) VALUES(@nome, @ano) ", con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@ano", dado.Ano);
                sql.ExecuteNonQuery();
                FecharConexao();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Salvar Dados do CURSO na DAO: " + ex.Message);
            }

        }
    }
}
