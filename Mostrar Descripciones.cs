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
        public Mostrar_Descripciones()
        {
            InitializeComponent();
        }

        private void Mostrar_Descripciones_Load(object sender, EventArgs e)
        {
            MostrarPeliculas mostrarPeli = new MostrarPeliculas();
            string idPeli = mostrarPeli.idPeli;



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
