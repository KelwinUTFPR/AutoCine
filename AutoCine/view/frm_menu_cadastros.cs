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
    public partial class frm_menu_cadastros : Form
    {
        public frm_menu_cadastros()
        {
            InitializeComponent();
        }

        private void btn_filmes_Click(object sender, EventArgs e)
        {
            frm_cadastro_filme tela_filme = new frm_cadastro_filme();
            tela_filme.Show();
            this.Hide();
        }

        private void btn_sessoes_Click(object sender, EventArgs e)
        {
            frm_cadastro_sessoes tela_sessoes = new frm_cadastro_sessoes();
            tela_sessoes.Show();
            this.Hide();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_login tela_login = new frm_login();
            tela_login.Show();
            this.Hide();
        }
    }
}
