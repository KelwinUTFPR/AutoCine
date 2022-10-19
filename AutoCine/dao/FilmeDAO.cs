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
            conexao.Open();
        }
        public void cadastrar(Filme obj)
        {
            try
            {
                string sql = @"insert into filmes (nome_filme, sinopse, classificacao, genero, duracao) 
             values (@nome, @sinopse, @classificacao, @genero, @duracao)";
                MySqlCommand comandosql = new MySqlCommand(sql, conexao);
                comandosql.Parameters.AddWithValue("@nome", obj.Nome);
                comandosql.Parameters.AddWithValue("@sinopse", obj.Sinopse);
                comandosql.Parameters.AddWithValue("@classificacao", obj.Classificacao);
                comandosql.Parameters.AddWithValue("@genero", obj.Genero);
                comandosql.Parameters.AddWithValue("@duracao", obj.Duracao);

                comandosql.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Cadastro executado com sucesso");
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro ao inserir: " + erro);
            }
        }

        public DataTable listarFilme(int cod_filme)
        {
            string sql = @"select * from filmes where codigo_filme=@codigo";

            MySqlCommand comandosql = new MySqlCommand(sql, conexao);

            comandosql.Parameters.AddWithValue("@codigo", cod_filme);

            comandosql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(comandosql);

            DataTable tabelaFilme = new DataTable();
            da.Fill(tabelaFilme);

            conexao.Close();

            return tabelaFilme;
        }
    }
}
