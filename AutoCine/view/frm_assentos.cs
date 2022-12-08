using AutoCine.dao;
using AutoCine.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCine.view
{
    public partial class frm_assentos : Form
    {
        public frm_assentos(Sessao s, int cod_filme)
        {
            InitializeComponent();
            this.codigo = cod_filme;
            this.sessao = s;
        }
        public int codigo { get; set; }
        public Sessao sessao { get; set; }

        List<Assento> lista = new List<Assento>();

        int count = 0;

        private void frm_assentos_Load(object sender, EventArgs e)
        {
            var data = DateTime.Now;
            FilmeDAO daof = new FilmeDAO();
            DataTable filme = daof.listarFilme();
            string titulo = filme.Rows[codigo - 1]["nome"].ToString();
            label_sessao.Text = titulo + " - Sala " + sessao.sala + " - " + data.Day.ToString() + "/" + data.Month.ToString() + " " + sessao.horario;


            AssentoDao dao = new AssentoDao();
            DataTable assentos = dao.listarSessao(sessao.sala);

            for (int i = 0; i < assentos.Rows.Count; i++)
            {
                var assentol = new Assento(assentos.Rows[i]["id_assento"].ToString(), assentos.Rows[i]["numero_assento"].ToString(), assentos.Rows[i]["numero_sala"].ToString(),
                    assentos.Rows[i]["selecionado"].ToString());
                lista.Add(assentol);
            }

            List<Button> listaBotoes = new List<Button>();
            AdicionaBotoes(listaBotoes);

            for (int x = 0; x < lista.Count; x++)
            {
                if (lista[x].selecionado == "1")
                {
                    seleciona_assento_inicial(listaBotoes[x], lista, x);

                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_filme tela_filme= new frm_filme(codigo);
            tela_filme.Show();
            this.Close();
        }

        private void seleciona_assento(Button btn, List<Assento> lista, int nmr) {
            if (lista[nmr].selecionado == "0")
            {
                lista[nmr].selecionado = "1";
                lista[nmr].nome = btn.Name;
                btn.BackColor = Color.FromArgb(255, 128, 128);
                count++;
            }
            else if (lista[nmr].selecionado == "1") {
                lista[nmr].selecionado = "0";
                btn.BackColor = Color.FromArgb(128, 255, 128);
                count--; 
            }

        }


        private void seleciona_assento_inicial(Button btn, List<Assento> lista, int nmr)
        { 
                lista[nmr].selecionado = "1";
                lista[nmr].nome = btn.Name;
                btn.BackColor = Color.FromArgb(255, 128, 128);
                btn.Enabled = false;
        }
        private void desmarca_assento(Button btn)
        {
            btn.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void A1_Click(object sender, EventArgs e)
        {
            seleciona_assento(A1, lista, 0);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            seleciona_assento(A2, lista, 1);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            seleciona_assento(A3, lista, 2);
        }

        private void A4_Click(object sender, EventArgs e)
        {
            seleciona_assento(A4, lista, 3);
        }

        private void A5_Click(object sender, EventArgs e)
        {
            seleciona_assento(A5, lista, 4);
        }

        private void A6_Click(object sender, EventArgs e)
        {
            seleciona_assento(A6, lista, 5);
        }

        private void A7_Click(object sender, EventArgs e)
        {
            seleciona_assento(A7, lista, 6);
        }

        private void A8_Click(object sender, EventArgs e)
        {
            seleciona_assento(A8, lista, 7);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            seleciona_assento(B1, lista, 8);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            seleciona_assento(B2, lista, 9);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            seleciona_assento(B3, lista, 10);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            seleciona_assento(B4, lista, 11);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            seleciona_assento(B5, lista, 12);
        }

        private void B6_Click(object sender, EventArgs e)
        {
            seleciona_assento(B6, lista, 13);
        }

        private void B7_Click(object sender, EventArgs e)
        {
            seleciona_assento(B7, lista, 14);
        }

        private void B8_Click(object sender, EventArgs e)
        {
            seleciona_assento(B8, lista, 15);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            seleciona_assento(C1, lista, 16);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            seleciona_assento(C2, lista, 17);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            seleciona_assento(C3, lista, 18);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            seleciona_assento(C4, lista, 19);
        }

        private void C5_Click(object sender, EventArgs e)
        {
            seleciona_assento(C5, lista, 20);
        }

        private void C6_Click(object sender, EventArgs e)
        {
            seleciona_assento(C6, lista, 21);
        }

        private void C7_Click(object sender, EventArgs e)
        {
            seleciona_assento(C7, lista, 22);
        }

        private void C8_Click(object sender, EventArgs e)
        {
            seleciona_assento(C8, lista, 23);
        }

        private void D1_Click(object sender, EventArgs e)
        {
            seleciona_assento(D1, lista, 24);
        }

        private void D2_Click(object sender, EventArgs e)
        {
            seleciona_assento(D2, lista, 25);
        }

        private void D3_Click(object sender, EventArgs e)
        {
            seleciona_assento(D3, lista, 26);
        }

        private void D4_Click(object sender, EventArgs e)
        {
            seleciona_assento(D4, lista, 27);
        }

        private void D5_Click(object sender, EventArgs e)
        {
            seleciona_assento(D5, lista, 28);
        }

        private void D6_Click(object sender, EventArgs e)
        {
            seleciona_assento(D6, lista, 29);
        }

        private void D7_Click(object sender, EventArgs e)
        {
            seleciona_assento(D7, lista, 30);
        }

        private void D8_Click(object sender, EventArgs e)
        {
            seleciona_assento(D8, lista, 31);
        }

        private void E1_Click(object sender, EventArgs e)
        {
            seleciona_assento(E1, lista, 32);
        }

        private void E2_Click(object sender, EventArgs e)
        {
            seleciona_assento(E2, lista, 33);
        }

        private void E3_Click(object sender, EventArgs e)
        {
            seleciona_assento(E3, lista, 34);
        }

        private void E4_Click(object sender, EventArgs e)
        {
            seleciona_assento(E4, lista, 35);
        }

        private void E5_Click(object sender, EventArgs e)
        {
            seleciona_assento(E5, lista, 36);
        }

        private void E6_Click(object sender, EventArgs e)
        {
            seleciona_assento(E6, lista, 37);
        }

        private void E7_Click(object sender, EventArgs e)
        {
            seleciona_assento(E7, lista, 38);
        }

        private void E8_Click(object sender, EventArgs e)
        {
            seleciona_assento(E8, lista, 39);
        }

        private void F1_Click(object sender, EventArgs e)
        {
            seleciona_assento(F1, lista, 40);
        }

        private void F2_Click(object sender, EventArgs e)
        {
            seleciona_assento(F2, lista, 41);
        }   

        private void F3_Click(object sender, EventArgs e)
        {
            seleciona_assento(F3, lista, 42);
        }

        private void F4_Click(object sender, EventArgs e)
        {
            seleciona_assento(F4, lista, 43);
        }

        private void F5_Click(object sender, EventArgs e)
        {
            seleciona_assento(F5, lista, 44);
        }

        private void F6_Click(object sender, EventArgs e)
        {
            seleciona_assento(F6, lista, 45);
        }

        private void F7_Click(object sender, EventArgs e)
        {
            seleciona_assento(F7, lista, 46);
        }

        private void F8_Click(object sender, EventArgs e)
        {
            seleciona_assento(F8, lista, 47);
        }

        private void G1_Click(object sender, EventArgs e)
        {
            seleciona_assento(G1, lista, 48);
        }

        private void G2_Click(object sender, EventArgs e)
        {
            seleciona_assento(G2, lista, 49);
        }

        private void G3_Click(object sender, EventArgs e)
        {
            seleciona_assento(G3, lista, 50);
        }

        private void G4_Click(object sender, EventArgs e)
        {
            seleciona_assento(G4, lista, 51);
        }

        private void G5_Click(object sender, EventArgs e)
        {
            seleciona_assento(G5, lista, 52);
        }

        private void G6_Click(object sender, EventArgs e)
        {
            seleciona_assento(G6, lista, 53);
        }

        private void G7_Click(object sender, EventArgs e)
        {
            seleciona_assento(G7, lista, 54);
        }

        private void G8_Click(object sender, EventArgs e)
        {
            seleciona_assento(G8, lista, 55);
        }

        private void H1_Click(object sender, EventArgs e)
        {
            seleciona_assento(H1, lista, 56);
        }

        private void H2_Click(object sender, EventArgs e)
        {
            seleciona_assento(H2, lista, 57);
        }

        private void H3_Click(object sender, EventArgs e)
        {   
            seleciona_assento(H3, lista, 58);
        }

        private void H4_Click(object sender, EventArgs e)
        {
            seleciona_assento(H4, lista, 59);
        }

        private void H5_Click(object sender, EventArgs e)
        {
            seleciona_assento(H5, lista, 60);
        }

        private void H6_Click(object sender, EventArgs e)
        {
            seleciona_assento(H6, lista, 61);
        }

        private void H7_Click(object sender, EventArgs e)
        {
            seleciona_assento(H7, lista, 62);
        }

        private void H8_Click(object sender, EventArgs e)
        {
            seleciona_assento(H8, lista, 63);
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            frm_checkout tela_checkout = new frm_checkout(sessao, codigo, count, lista);
            tela_checkout.Show();
            this.Close();
        }

        private void AdicionaBotoes(List<Button> listaBotoes)
        {
            listaBotoes.Add(A1);
            listaBotoes.Add(A2);
            listaBotoes.Add(A3);
            listaBotoes.Add(A4);
            listaBotoes.Add(A5);
            listaBotoes.Add(A6);
            listaBotoes.Add(A7);
            listaBotoes.Add(A8);
            listaBotoes.Add(B1);
            listaBotoes.Add(B2);
            listaBotoes.Add(B3);
            listaBotoes.Add(B4);
            listaBotoes.Add(B5);
            listaBotoes.Add(B6);
            listaBotoes.Add(B7);
            listaBotoes.Add(B8);
            listaBotoes.Add(C1);
            listaBotoes.Add(C2);
            listaBotoes.Add(C3);
            listaBotoes.Add(C4);
            listaBotoes.Add(C5);
            listaBotoes.Add(C6);
            listaBotoes.Add(C7);
            listaBotoes.Add(C8);
            listaBotoes.Add(D1);
            listaBotoes.Add(D2);
            listaBotoes.Add(D3);
            listaBotoes.Add(D4);
            listaBotoes.Add(D5);
            listaBotoes.Add(D6);
            listaBotoes.Add(D7);
            listaBotoes.Add(D8);
            listaBotoes.Add(E1);
            listaBotoes.Add(E2);
            listaBotoes.Add(E3);
            listaBotoes.Add(E4);
            listaBotoes.Add(E5);
            listaBotoes.Add(E6);
            listaBotoes.Add(E7);
            listaBotoes.Add(E8);
            listaBotoes.Add(F1);
            listaBotoes.Add(F2);
            listaBotoes.Add(F3);
            listaBotoes.Add(F4);
            listaBotoes.Add(F5);
            listaBotoes.Add(F6);
            listaBotoes.Add(F7);
            listaBotoes.Add(F8);
            listaBotoes.Add(G1);
            listaBotoes.Add(G2);
            listaBotoes.Add(G3);
            listaBotoes.Add(G4);
            listaBotoes.Add(G5);
            listaBotoes.Add(G6);
            listaBotoes.Add(G7);
            listaBotoes.Add(G8);
            listaBotoes.Add(H1);
            listaBotoes.Add(H2);
            listaBotoes.Add(H3);
            listaBotoes.Add(H4);
            listaBotoes.Add(H5);
            listaBotoes.Add(H6);
            listaBotoes.Add(H7);
            listaBotoes.Add(H8);
        }
    }
}


