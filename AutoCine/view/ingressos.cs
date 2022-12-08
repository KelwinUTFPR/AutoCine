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
    public partial class ingressos : Form
    {
        public ingressos(int cod_filme, Sessao s, int c, List<Assento> listaAssentos)
        {
            InitializeComponent();
            this.codigo = cod_filme;
            this.sessao = s;
            this.count = c;
            this.lista = listaAssentos;
        }
        public int codigo { get; set; }
        public Sessao sessao { get; set; }
        public int valor { get; set; }

        List<Assento> lista = new List<Assento>();

        List<Assento> lista_selecionados= new List<Assento>();

        int count;

        private void ingressos_Load(object sender, EventArgs e)
        {
            FilmeDAO dao = new FilmeDAO();
            DataTable filme = dao.listarFilme();
            lbl_titulo1.Text = filme.Rows[codigo - 1]["nome"].ToString();
            lbl_titulo2.Text = filme.Rows[codigo - 1]["nome"].ToString();
            lbl_titulo3.Text = filme.Rows[codigo - 1]["nome"].ToString();
            lbl_titulo4.Text = filme.Rows[codigo - 1]["nome"].ToString();

            setaSessao(lbl_Sessao1);
            setaSessao(lbl_Sessao2);
            setaSessao(lbl_Sessao3);
            setaSessao(lbl_Sessao4);

            AssentoDao adao = new AssentoDao();

            for (int i = 0; i < lista.Count; i++) {
                if (lista[i].selecionado == "1") {
                    lista_selecionados.Add(lista[i]);
                    adao.update_assento(lista[i]);
                }
            }

            seta_assento(lbl_assento1, 0);
            seta_assento(lbl_assento2, 1);
            seta_assento(lbl_assento3, 2);
            seta_assento(lbl_assento4, 3);

            switch (count) {
                case 1:
                    gb2.Visible = false;
                    gb3.Visible = false;
                    gb4.Visible = false;
                    break;
                case 2:
                    gb3.Visible = false;
                    gb4.Visible = false;
                    break;
                case 3:
                    gb4.Visible = false;
                    break;
                default: break;
            }
        }

        public void setaSessao(Label lbl_sessao)
        {
            var data = DateTime.Now;

            lbl_sessao.Text = data.Day.ToString() + "/" + data.Month.ToString() + " " + sessao.horario + " - Sala " + sessao.sala + "";
        }

        private void seta_assento(Label lbl_assento, int index) {
            try
            {
                lbl_assento.Text = lista_selecionados[index].nome;
            }
            catch {
                lbl_assento.Text = "";
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            frm_menu_principal tela_principal = new frm_menu_principal();
            tela_principal.Show();
            this.Hide();
        }
    }
}
