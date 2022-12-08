using AutoCine.dao;
using AutoCine.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AutoCine.view
{
    public partial class frm_checkout : Form
    {
        public frm_checkout(Sessao s, int cod_filme, int c, List<Assento> listaAssentos)
        {
            InitializeComponent();
            this.codigo = cod_filme;
            this.sessao = s;
            this.count = c;
            this.lista = listaAssentos;
        }
        public int codigo { get; set; }
        public Sessao sessao { get; set; }
        public int count { get; set; }
        public List<Assento> lista { get; set; }

        int x, y = 0;

        private void frm_checkout_Load(object sender, EventArgs e)
        {
            FilmeDAO dao = new FilmeDAO();
            DataTable filme = dao.listarFilme();
            lbl_titulo.Text = filme.Rows[codigo - 1]["nome"].ToString();
            lbl_sinopse.Text = filme.Rows[codigo - 1]["sinopse"].ToString();
            lbl_genero.Text = filme.Rows[codigo - 1]["genero"].ToString();
            lbl_classificacao.Text = filme.Rows[codigo - 1]["classificacao_etaria"].ToString();
            lbl_duracao.Text = filme.Rows[codigo - 1]["duracao"].ToString() + " min";
            string imagem = filme.Rows[codigo - 1]["foto"].ToString();
            foto.Image = Image.FromFile("C:/banco_fotos/" + imagem + ".jpg ");
            var data = DateTime.Now;

            label_sessao.Text = "Sessão: " + data.Day.ToString() + "/" + data.Month.ToString() + "  " + sessao.horario + "  -  Sala " + sessao.sala + "";
            preencheCMB(cmb_inteira);
            preencheCMB(cmb_meia);
        }

        private void preencheCMB(System.Windows.Forms.ComboBox cmb)
        {
            for (int i = 0; i <= count; i++)
            {
                cmb.Items.Add(i);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_assentos tela_assentos = new frm_assentos(sessao, codigo);
            tela_assentos.Show();
            this.Close();
        }

        private void cmb_inteira_SelectedIndexChanged(object sender, EventArgs e)
        {
            y = int.Parse(cmb_inteira.SelectedItem.ToString());
            if (x + y > count)
            {
                cmb_inteira.SelectedIndex = 0;
                MessageBox.Show("Você não pode selecionar mais de " + count + " igressos, pois excede o numero de assentos selecionados anteriormente.");
            }
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            int valor = (x * 15 + y * 30);
            frm_pagamento tela_pagamento = new frm_pagamento(codigo, sessao, count, lista, valor);
            tela_pagamento.Show();
            this.Close();
        }

        private void cmb_meia_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = int.Parse(cmb_meia.SelectedItem.ToString());
            if (x + y > count){
                cmb_meia.SelectedIndex = 0;
                MessageBox.Show("Você não pode selecionar mais de "+ count + " igressos, pois excede o numero de assentos selecionados anteriormente.");
            }
        }
    }
}
