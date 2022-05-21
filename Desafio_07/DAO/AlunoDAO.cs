using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient; // objeto responsavel pela comunicação em MySql
using Desafio_07.Entidades;

namespace Desafio_07.DAO 
{
    public class AlunoDAO : IDaoBase
    {

//-----------------------------------------------------------------------------------conexão AlunoDAO
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
                Console.WriteLine("Erro ao abrir conexao AlunoDAO:" + ex.Message);
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
        
 //------------------------------------------------------------------------------------  Salvar aluno

        public void salvarAlunoDAO(AlunoEntidade dado)
        {
            try
            {
                AbrirConexao();
                sql = new MySqlCommand("INSERT INTO aluno(nome, idade) VALUES(@nome, @idade) ", con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@idade", dado.Idade);
                sql.ExecuteNonQuery();
                FecharConexao();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Salvar Dados do aluno na DAO: " + ex.Message);
            }

        }

    }
}
