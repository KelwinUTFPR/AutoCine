using AutoCine.dao;
using AutoCine.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCine.view
{
    public partial class frm_cadastro_sessoes : Form
    {
        public frm_cadastro_sessoes()
        {
            InitializeComponent();
        }

        public string sala;

        public string filme; 

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Sessao sessao = new Sessao("0", sala, txt_horario.Text, filme);
            SessaoDAO dao = new SessaoDAO();
            dao.cadastrar(sessao);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu_cadastros tela_cadastros = new frm_menu_cadastros();
            tela_cadastros.Show();
            this.Hide();
        }

        private void frm_cadastro_sessoes_Load(object sender, EventArgs e)
        {
            FilmeDAO dao = new FilmeDAO();
            DataTable filmes = dao.listarFilme();
            for (int i = 0; i < filmes.Rows.Count; i++)
            {
                string titulo = filmes.Rows[i]["nome"].ToString();
                string id = filmes.Rows[i]["id_filme"].ToString();
                cmb_filme.Items.Add(id + " - " + titulo);
            }
               
        }

        private void cmb_sala_SelectedIndexChanged(object sender, EventArgs e)
        {
            sala = cmb_sala.SelectedIndex+1.ToString();
        }

        private void cmb_filme_SelectedIndexChanged(object sender, EventArgs e)
        {
            filme = cmb_filme.SelectedItem.ToString();
            string[] filme_separado = filme.Split(' ');
            filme = filme_separado[0];
        }
    }
}
