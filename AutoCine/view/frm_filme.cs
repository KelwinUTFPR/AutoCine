using AutoCine.dao;
using AutoCine.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            List<ToolStripMenuItem> lista_menu = new List<ToolStripMenuItem>();

            lista_menu.Add(toolStripMenuItem1);
            lista_menu.Add(toolStripMenuItem2);
            lista_menu.Add(toolStripMenuItem3);
            lista_menu.Add(toolStripMenuItem4);
            lista_menu.Add(toolStripMenuItem5);
            lista_menu.Add(toolStripMenuItem6);
            lista_menu.Add(toolStripMenuItem7);
            lista_menu.Add(toolStripMenuItem8);
            lista_menu.Add(toolStripMenuItem9);
            lista_menu.Add(toolStripMenuItem10);

            var data = DateTime.Now;

            for (int k = 0; k < lista_menu.Count; k++) {
                lista_menu[k].Text = (data.Day+k).ToString() + "/" + data.Month.ToString();
            }

           
            FilmeDAO dao = new FilmeDAO();
            DataTable filme = dao.listarFilme();

            lbl_titulo.Text = filme.Rows[codigo - 1]["nome"].ToString();
            lbl_sinopse.Text = filme.Rows[codigo - 1]["sinopse"].ToString();
            lbl_genero.Text = filme.Rows[codigo - 1]["genero"].ToString();
            lbl_classificacao.Text = filme.Rows[codigo - 1]["classificacao_etaria"].ToString();
            lbl_duracao.Text = filme.Rows[codigo - 1]["duracao"].ToString() + " min";
            string imagem = filme.Rows[codigo - 1]["foto"].ToString();
            foto.Image = Image.FromFile("C:/banco_fotos/" + imagem + ".jpg ");

            List<Sessao> lista = new List<Sessao>();

            SessaoDAO Sdao = new SessaoDAO();
            DataTable sessoes = Sdao.listarSessao(codigo);

            for (int i = 0; i < sessoes.Rows.Count; i++)
            {
                var sessaooo = new Sessao(sessoes.Rows[i]["id_sessao"].ToString(), sessoes.Rows[i]["numero_sala"].ToString(), sessoes.Rows[i]["horario"].ToString(),
                    sessoes.Rows[i]["id_filme"].ToString());
                lista.Add(sessaooo);
            }

            int x = 1;
            int z = 0;
            Boolean soma = false;

            AtivaBotao(lista, ref x, ref z, ref soma, btn1);
            AtivaBotao(lista, ref x, ref z, ref soma, btn2);
            AtivaBotao(lista, ref x, ref z, ref soma, btn3);
            AtivaBotao(lista, ref x, ref z, ref soma, btn4);
            AtivaBotao(lista, ref x, ref z, ref soma, btn5);
            AtivaBotao(lista, ref x, ref z, ref soma, btn6);
            AtivaBotao(lista, ref x, ref z, ref soma, btn7);
            AtivaBotao(lista, ref x, ref z, ref soma, btn8);
            AtivaBotao(lista, ref x, ref z, ref soma, btn9);
            AtivaBotao(lista, ref x, ref z, ref soma, btn10);
            AtivaBotao(lista, ref x, ref z, ref soma, btn11);
            AtivaBotao(lista, ref x, ref z, ref soma, btn12);


        }

        private void AtivaBotao(List<Sessao> lista, ref int x, ref int z,  ref bool soma, Button btn)
        {
            try
            {
                var s = lista[z];
                if (s.sala == x.ToString())
                {
                    btn.Text = s.horario;
                    btn.Visible = true;
                    z++;
                }
                if (soma)
                {
                    x++;
                    soma = false;
                }
                else
                {
                    soma = true;
                }
            }
            catch {
            }
           
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu_principal tela_menu = new frm_menu_principal();
            tela_menu.Show();
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn1, 1);
        }

        private void MostraTelaAssentos(Button btn, int sala)
        {
            string horario = btn.Text;
            SessaoDAO Sdao = new SessaoDAO();
            Sessao s = Sdao.listarSessaoBtn(codigo, sala, horario);
            frm_assentos tela_assentos = new frm_assentos(s, codigo);
            tela_assentos.Show();
            this.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn2, 1);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn3, 2);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn4, 2);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn5, 3);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn6, 3);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn7, 4);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn8, 4);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn9, 5);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn10, 5);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn11, 6);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            MostraTelaAssentos(btn12, 6);
        }
    }
}
