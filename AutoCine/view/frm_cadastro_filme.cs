using AutoCine.dao;
using AutoCine.model;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCine.view
{
    public partial class frm_cadastro_filme : Form
    {
        public frm_cadastro_filme()
        {
            InitializeComponent();
        }

        public string arquivo;

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            filme.Nome = txt_titulo.Text;
            filme.Duracao = txt_duracao.Text;
            filme.Classificacao = txt_classificacao.Text;
            filme.Genero= txt_genero.Text;
            filme.Codigo = 7;
            filme.Sinopse= txt_sinopse.Text;

            FilmeDAO dao = new FilmeDAO();
            dao.cadastrar(filme, arquivo);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu_cadastros tela_cadastros = new frm_menu_cadastros();
            tela_cadastros.Show();
            this.Hide();
        }

        private void btn_carrega_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            String imageLocation = "";
            try
            {

                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    foto.ImageLocation = imageLocation;
                    string nomeArquivo = Path.GetFileNameWithoutExtension(dialog.FileName);
                    arquivo = nomeArquivo;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_cadastro_filme_Load(object sender, EventArgs e)
        {
            txt_titulo.Text = "Pantera Negra: Wakanda Para Sempre";
            txt_duracao.Text = "161";
            txt_genero.Text = "Ação/Aventura";
            txt_classificacao.Text = "12";
            txt_sinopse.Text = "A Rainha Ramonda, Shuri, M’Baku, Okoye e as Dora Milaje, lutam para proteger sua nação contra as potências " +
                "mundiais intervenientes logo após a morte do Rei T’Challa. Enquanto os Wakandanos se esforçam para aceitar este próximo capítulo, " +
                "os heróis devem se unir com a ajuda da veterana guerreira Nakia e Everett Ross e forjar um novo caminho para o reino de Wakanda. " +
                "Apresentando como Namor, rei de uma oculta nação submarina, o filme também é estrelado por Dominique Thorne, Michaela Coel, Mabel " +
                "Cadena e Alex Livanalli.";
        }
    }
}
