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
    public partial class frm_menu_principal : Form
    {
        public frm_menu_principal()
        {
            InitializeComponent();
        }

        private void frm_menu_principal_Load(object sender, EventArgs e)
        {
            FilmeDAO dao = new FilmeDAO();
            DataTable slot = dao.listarFilme();
            titulo1.Text = slot.Rows[0]["nome_filme"].ToString();
            string imagem1 = slot.Rows[0]["foto"].ToString();
            foto1.Image = Image.FromFile("C:/banco_fotos/" + imagem1 + ".jpg ");

            titulo2.Text = slot.Rows[1]["nome_filme"].ToString();
            string imagem2 = slot.Rows[1]["foto"].ToString();
            foto2.Image = Image.FromFile("C:/banco_fotos/" + imagem2 + ".jpg ");

            titulo3.Text = slot.Rows[2]["nome_filme"].ToString();
            string imagem3 = slot.Rows[2]["foto"].ToString();
            foto3.Image = Image.FromFile("C:/banco_fotos/" + imagem3 + ".jpg ");

            titulo4.Text = slot.Rows[3]["nome_filme"].ToString();
            string imagem4 = slot.Rows[3]["foto"].ToString();
            foto4.Image = Image.FromFile("C:/banco_fotos/" + imagem4 + ".jpg ");

            titulo5.Text = slot.Rows[4]["nome_filme"].ToString();
            string imagem5 = slot.Rows[4]["foto"].ToString();
            foto5.Image = Image.FromFile("C:/banco_fotos/" + imagem5 + ".jpg ");

            titulo6.Text = slot.Rows[5]["nome_filme"].ToString();
            string imagem6 = slot.Rows[5]["foto"].ToString();
            foto6.Image = Image.FromFile("C:/banco_fotos/" + imagem6 + ".jpg ");
        }

        private void foto1_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(1);
            tela_filme.Show();
            this.Hide();
        }

        private void foto2_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(2);
            tela_filme.Show();
            this.Hide();
        }

        private void foto3_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(3);
            tela_filme.Show();
            this.Hide();
        }

        private void foto4_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(4);
            tela_filme.Show();
            this.Hide();
        }

        private void foto5_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(5);
            tela_filme.Show();
            this.Hide();
        }

        private void foto6_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(6);
            tela_filme.Show();
            this.Hide();
        }

        private void titulo1_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(1);
            tela_filme.Show();
            this.Hide();
        }

        private void titulo2_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(2);
            tela_filme.Show();
            this.Hide();
        }

        private void titulo3_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(3);
            tela_filme.Show();
            this.Hide();
        }

        private void titulo4_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(4);
            tela_filme.Show();
            this.Hide();
        }

        private void titulo5_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(5);
            tela_filme.Show();
            this.Hide();
        }

        private void titulo6_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme = new frm_filme(6);
            tela_filme.Show();
            this.Hide();
        }
    }
}
