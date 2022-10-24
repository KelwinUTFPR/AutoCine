using AutoCine.dao;
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
    public partial class frm_filme : Form
    {
        public frm_filme(int cod_filme)
        {
            InitializeComponent();
            this.codigo = cod_filme;
        }

        public int codigo { get; set; }

        public void frm_filme_Load(object sender, EventArgs e)
        {
            FilmeDAO dao = new FilmeDAO();
            DataTable teste = dao.listarFilme();
            lbl_titulo.Text = teste.Rows[codigo-1]["nome_filme"].ToString();
            lbl_sinopse.Text = teste.Rows[codigo-1]["sinopse"].ToString();
            lbl_genero.Text = teste.Rows[codigo-1]["genero"].ToString();
            lbl_classificacao.Text = teste.Rows[codigo - 1]["classificacao"].ToString();
            lbl_duracao.Text = teste.Rows[codigo - 1]["duracao"].ToString();
            string imagem = teste.Rows[codigo - 1]["foto"].ToString();
            foto.Image = Image.FromFile("C:/banco_fotos/" + imagem + ".jpg ");
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu_principal tela_menu = new frm_menu_principal();
            tela_menu.Show();
            this.Close();
        }
    }
}
