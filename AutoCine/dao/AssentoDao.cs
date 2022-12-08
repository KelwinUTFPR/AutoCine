using AutoCine.conexao;
using AutoCine.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCine.dao
{
    public class AssentoDao
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public AssentoDao()
        {
        }
        public void update_assento(Assento obj)
        {
            try
            {
                conexao.Open();
                string sql = @"update assento set 
                selecionado= @selecionado where numero_assento = @assento and numero_sala = @sala";
                MySqlCommand comandosql = new MySqlCommand(sql, conexao);
                comandosql.Parameters.AddWithValue("@assento", obj.nmr_assento);
                comandosql.Parameters.AddWithValue("@sala", obj.nmr_sala);
                comandosql.Parameters.AddWithValue("@selecionado", obj.selecionado);

                comandosql.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar assento: " + erro);
            }
        }

        public DataTable listarSessao(string sala)
        {
            conexao.Open();

            string sql = @"select * from assento where numero_sala= " + sala + "";

            MySqlCommand comandosql = new MySqlCommand(sql, conexao);

            comandosql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(comandosql);

            DataTable tabelaAssento = new DataTable();
            da.Fill(tabelaAssento);

            conexao.Close();

            return tabelaAssento;
        }
    }
}
