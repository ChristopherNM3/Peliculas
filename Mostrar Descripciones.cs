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
    public partial class Mostrar_Descripciones : Form
    {
        public static int idPeli;
        Descripcion descripcion = new Descripcion();
        public Mostrar_Descripciones()
        {
            InitializeComponent();
        }

        private void Mostrar_Descripciones_Load(object sender, EventArgs e)
        {
            
            MostrarPeliculas mostrarPeli = new MostrarPeliculas();
            idPeli = mostrarPeli.idPeli;
            string[] descripcionPelicula = descripcion.pedirDescripcion(idPeli);

            pictureBox1.Image = Image.FromFile(descripcionPelicula[0]);
            nmblabel.Text = descripcionPelicula[1];
            diclabel.Text = descripcionPelicula[2];
            durlabel.Text = descripcionPelicula[3];
            siplabel.Text = descripcionPelicula[4];


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarPeliculas frm = new MostrarPeliculas();
            frm.Show();
            this.Hide();
        }

        private void nmblabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
