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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "Admin" && txt_senha.Text == "admin")
            {
                MessageBox.Show("Login efetuado com sucesso", "", MessageBoxButtons.OK);
                frm_menu_cadastros tela_cadastros = new frm_menu_cadastros();
                tela_cadastros.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Login incorreto", "", MessageBoxButtons.OK);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu_principal tela_principal = new frm_menu_principal();
            tela_principal.Show();
            this.Hide();
        }
    }
}
