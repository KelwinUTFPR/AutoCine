using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AutoCine.conexao;
using AutoCine.model;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AutoCine.dao
{
    public class FilmeDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public FilmeDAO() {
        }
        public void cadastrar(Filme obj, string foto)
        {
            conexao.Open();

            try
            {

                string sql = @"insert into filme (id_filme, nome, sinopse, classificacao_etaria, genero, duracao, foto) 
                 values (@id, @nome, @sinopse, @classificacao, @genero, @duracao, @foto)";
                MySqlCommand comandosql = new MySqlCommand(sql, conexao);
                comandosql.Parameters.AddWithValue("@nome", obj.Nome);
                comandosql.Parameters.AddWithValue("@sinopse", obj.Sinopse);
                comandosql.Parameters.AddWithValue("@classificacao", obj.Classificacao);
                comandosql.Parameters.AddWithValue("@genero", obj.Genero);
                comandosql.Parameters.AddWithValue("@duracao", obj.Duracao);
                comandosql.Parameters.AddWithValue("@foto", foto);
                comandosql.Parameters.AddWithValue("@id", obj.Codigo);

                comandosql.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Cadastro efetuado com sucesso", "", MessageBoxButtons.OK);
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro ao inserir: " + erro);
            }
        }

        public DataTable listarFilme()
        {
            conexao.Open();

            string sql = @"select * from filme";

            MySqlCommand comandosql = new MySqlCommand(sql, conexao);

            comandosql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(comandosql);

            DataTable tabelaFilme = new DataTable();
            da.Fill(tabelaFilme);

            conexao.Close();

            return tabelaFilme;
        }
    }
}
