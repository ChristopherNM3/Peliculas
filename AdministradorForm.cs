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
    public partial class AdministradorForm : Form
    {
        Pelicula pelicula = new Pelicula();

        Descripcion descripcion = new Descripcion();
        int idPeliculaAdmi;
        string nmbPeliculaAdmi;
        string imgPeliculaAdmi;
        string dicPeliculaAdmi;
        string durPeliculaAdmi;
        string sipPeliculaAdmi;
        string[] arrPeliculaAdmi = new string[20];
        public AdministradorForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdministradorForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            idPeliculaAdmi = int.Parse(idtxt.Text);
            arrPeliculaAdmi = descripcion.pedirDescripcion(idPeliculaAdmi);
            imagentxt.Text = arrPeliculaAdmi[0];
            nmbtxt.Text = arrPeliculaAdmi[1];
            directortxt.Text = arrPeliculaAdmi[2];
            duraciontxt.Text = arrPeliculaAdmi[3];
            sipnosistxt.Text = arrPeliculaAdmi[4];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idPeliculaAdmi = int.Parse(idtxt.Text);
            imgPeliculaAdmi = imagentxt.Text;
            nmbPeliculaAdmi = nmbtxt.Text;
            dicPeliculaAdmi = directortxt.Text;
            durPeliculaAdmi = duraciontxt.Text;
            sipPeliculaAdmi = sipnosistxt.Text;

            pelicula.modificar(idPeliculaAdmi, imgPeliculaAdmi, nmbPeliculaAdmi, dicPeliculaAdmi, durPeliculaAdmi, sipPeliculaAdmi);
            MessageBox.Show("Modificacion hecha");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            idPeliculaAdmi = int.Parse(idtxt.Text);
            imgPeliculaAdmi = imagentxt.Text;
            nmbPeliculaAdmi = nmbtxt.Text;
            dicPeliculaAdmi = directortxt.Text;
            durPeliculaAdmi = duraciontxt.Text;
            sipPeliculaAdmi = sipnosistxt.Text;

            pelicula.eliminar(idPeliculaAdmi, imgPeliculaAdmi, nmbPeliculaAdmi, dicPeliculaAdmi, durPeliculaAdmi, sipPeliculaAdmi);
            MessageBox.Show("Pelicula con el id: " + idPeliculaAdmi + " eliminado");
            idtxt.Text = "";
            imagentxt.Text = "";
            nmbtxt.Text = "";
            directortxt.Text = "";
            duraciontxt.Text = "";
            sipnosistxt.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            imgPeliculaAdmi = imagentxt.Text;
            nmbPeliculaAdmi = nmbtxt.Text;
            dicPeliculaAdmi = directortxt.Text;
            durPeliculaAdmi = duraciontxt.Text;
            sipPeliculaAdmi = sipnosistxt.Text;

            pelicula.insertar(imgPeliculaAdmi, nmbPeliculaAdmi, dicPeliculaAdmi, durPeliculaAdmi, sipPeliculaAdmi);
            MessageBox.Show("Se inserto: " + imgPeliculaAdmi +" "+ nmbPeliculaAdmi +" "+ dicPeliculaAdmi +" "+ durPeliculaAdmi +" "+ sipPeliculaAdmi);
        }
    }
}
