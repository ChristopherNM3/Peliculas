using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peliculas
{
    public partial class MostrarPeliculas : Form
    {

        Usuario usuario = new Usuario();
        Pelicula pelicula = new Pelicula();
        Random random = new Random();
        public int idPeli;
        public static int idPelist =0;
        public int idRecomendacion1, idRecomendacion2, idRecomendacion3, idRecomendacion4, idRecomendacion5, idRecomendacion6;



        public MostrarPeliculas()
        {
            usuario.elegirPelicula();
            int[] ID_peliculas = usuario.peli_IdMostrar;
            idRecomendacion1 = ID_peliculas[0];
            idRecomendacion2 = ID_peliculas[1];
            idRecomendacion3 = ID_peliculas[2];
            idRecomendacion4 = ID_peliculas[3];
            idRecomendacion5 = ID_peliculas[4];
            idRecomendacion6 = ID_peliculas[5];
            darIpPelicula(idPelist);
            InitializeComponent();
        }

        private void MostrarPeliculas_Load(object sender, EventArgs e)
        {
            usuario.elegirPelicula(); //Pide las peliculas
            string[] img_peliculas = usuario.peliMostrar;
            string[] nmb_peliculas = usuario.peli_nmbMostrar;
            


            pictureBox1.Image = Image.FromFile(img_peliculas[0]); //Carga las imagenes de las peliculas
            pictureBox2.Image = Image.FromFile(img_peliculas[1]);
            pictureBox3.Image = Image.FromFile(img_peliculas[2]);
            pictureBox4.Image = Image.FromFile(img_peliculas[3]);
            pictureBox5.Image = Image.FromFile(img_peliculas[4]);
            pictureBox6.Image = Image.FromFile(img_peliculas[5]);

            nmb1.Text = nmb_peliculas[0].ToString();
            nmb2.Text = nmb_peliculas[1].ToString();
            nmb3.Text = nmb_peliculas[2].ToString();
            nmb4.Text = nmb_peliculas[3].ToString();
            nmb5.Text = nmb_peliculas[4].ToString();
            nmb6.Text = nmb_peliculas[5].ToString();

            
            //pictureBox1.Image = Image.FromFile("C:/Users/Christopher/Desktop/Peliculas/Resources/peliculas/drama1.jpg");

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mostrar_Descripciones frm = new Mostrar_Descripciones();
            idPelist = idRecomendacion1;
            darIpPelicula(idPelist);
            frm.Show();
            this.Hide();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mostrar_Descripciones frm = new Mostrar_Descripciones();
            idPelist = idRecomendacion2;
            darIpPelicula(idPelist);
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mostrar_Descripciones frm = new Mostrar_Descripciones();
            idPelist = idRecomendacion3;
            darIpPelicula(idPelist);
            frm.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Mostrar_Descripciones frm = new Mostrar_Descripciones();
            idPelist = idRecomendacion4;
            darIpPelicula(idPelist);
            frm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Mostrar_Descripciones frm = new Mostrar_Descripciones();
            idPelist = idRecomendacion5;
            darIpPelicula(idPelist);
            frm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Mostrar_Descripciones frm = new Mostrar_Descripciones();
            idPelist = idRecomendacion6;
            darIpPelicula(idPelist);
            frm.Show();
            this.Hide();

        }

        public void darIpPelicula(int num)
        {
            idPeli = num;
        }
    }
}
