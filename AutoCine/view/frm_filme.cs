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
using AutoCine.Properties

namespace AutoCine.view
{
    public partial class frm_filme : Form
    {
        public frm_filme()
        {
            InitializeComponent();
        }

        private void frm_filme_Load(object sender, EventArgs e)
        {
            FilmeDAO dao = new FilmeDAO();
            DataTable teste = dao.listarFilme(1);
            lbl_titulo.Text = teste.Rows[0]["nome_filme"].ToString();
            lbl_sinopse.Text = teste.Rows[0]["sinopse"].ToString();
            lbl_genero.Text = teste.Rows[0]["genero"].ToString();
            lbl_classificacao.Text = teste.Rows[0]["classificacao"].ToString();
            lbl_duracao.Text = teste.Rows[0]["duracao"].ToString();
            foto.Image = Resources.black_adam;
        }
    }
}
