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
        Random random = new Random();
        public MostrarPeliculas()
        {

            InitializeComponent();
        }

        private void MostrarPeliculas_Load(object sender, EventArgs e)
        {
            string[] peliculas = usuario.elegirPelicula(); //Pide las peliculas

            pictureBox1.Image = Image.FromFile(peliculas[0]); //Carga las imagenes de las peliculas
            pictureBox2.Image = Image.FromFile(peliculas[1]);
            pictureBox3.Image = Image.FromFile(peliculas[2]);
            pictureBox4.Image = Image.FromFile(peliculas[3]);
            pictureBox5.Image = Image.FromFile(peliculas[4]);
            pictureBox6.Image = Image.FromFile(peliculas[5]);
            //pictureBox1.Image = Image.FromFile("C:/Users/Christopher/Desktop/Peliculas/Resources/peliculas/drama1.jpg");

        }
    }
}
