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
        public string idPeli;
        public MostrarPeliculas()
        {

            InitializeComponent();
        }

        private void MostrarPeliculas_Load(object sender, EventArgs e)
        {
            usuario.elegirPelicula(); //Pide las peliculas
            string[] img_peliculas = usuario.peliMostrar;
            string[] nmb_peliculas = usuario.peli_nmbMostrar;
            int[] ID_peliculas = usuario.peli_IdMostrar;

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

            idlabel1.Text = ID_peliculas[0].ToString();
            idlabel2.Text = ID_peliculas[1].ToString();
            idlabel3.Text = ID_peliculas[2].ToString();
            idlabel4.Text = ID_peliculas[3].ToString();
            idlabel5.Text = ID_peliculas[4].ToString();
            idlabel6.Text = ID_peliculas[5].ToString();


            //pictureBox1.Image = Image.FromFile("C:/Users/Christopher/Desktop/Peliculas/Resources/peliculas/drama1.jpg");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            idPeli = idlabel1.Text;
            Mostrar_Descripciones frm = new Mostrar_Descripciones();
            frm.Show();
            this.Hide();
        }
    }
}
