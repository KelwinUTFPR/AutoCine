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
    public partial class frm_pagamento : Form
    {
        public frm_pagamento(int cod_filme, Sessao s, int c, List<Assento> listaAssentos, int v)
        {
            InitializeComponent();
            this.codigo = cod_filme;
            this.sessao = s;
            this.count = c;
            this.lista = listaAssentos;
            this.valor = v;
        }
        public int codigo { get; set; }
        public Sessao sessao { get; set; }
        public int valor { get; set; }

        List<Assento> lista = new List<Assento>();

        int count;

        Boolean passou = false;

        Timer timer1 = new Timer();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Enabled = true;
            // Hook up timer's tick event handler.  
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void frm_pagamento_Load(object sender, EventArgs e)
        {
            lbl_valor.Text= "R$ " + valor.ToString() + ",00";
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            messageBox_pagamento processando = new messageBox_pagamento();
            if (passou)
            {
                processando.Hide();
                passaTela();
                timer1.Enabled=false;
            }
            else
            {
                processando.Show();
                timer1.Interval = 1000;
                passou = true;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_checkout tela_checkout = new frm_checkout(sessao, codigo, count, lista);
            tela_checkout.Show();
            this.Hide();
        }

        private void passaTela() { 
            ingressos tela_ingressos= new ingressos(codigo, sessao, count, lista);
            tela_ingressos.Show();
            this.Close();
        }
    }
}
