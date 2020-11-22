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
    public partial class Cuestionario1 : Form
    {

        Usuario usuario = new Usuario();
        bool contDrama, contMusicales, contInfantiles, contComedia, contCF, contAventura, contGuerra, contTerror, contAccion, contCrimen;

        public Cuestionario1()
        {
            InitializeComponent();
        }

        private void Cuestionario1_Load(object sender, EventArgs e)
        {
            string[] preguntas = usuario.pedirCuestionario(); //pide las preguntas al azar

            pregunta1.Text = preguntas[0]; //Coloca las preguntas en los label con las preguntas que venian en el arreglo
            pregunta2.Text = preguntas[1];
            pregunta3.Text = preguntas[2];
            pregunta4.Text = preguntas[3];
            pregunta5.Text = preguntas[4];
            pregunta6.Text = preguntas[5];
            pregunta7.Text = preguntas[6];
            pregunta8.Text = preguntas[7];
            pregunta9.Text = preguntas[8];
            pregunta10.Text = preguntas[9];
        }

        private void si1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void no1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void siguiente_btn_Click(object sender, EventArgs e)
        {

            if (si1.Checked == true) //Si el checkbox esta activo se el cont se vuelve verdadero para que aumente un contador que esta en la clase Usuario
            {
                contDrama = true;
            }
            if(si2.Checked == true)
            {
                contMusicales =true;
            }
            if (si3.Checked == true)
            {
                contInfantiles = true;
            }
            if (si4.Checked == true)
            {
                contComedia = true;
            }
            if (si5.Checked == true)
            {
                contCF = true;
            }
            if (si6.Checked == true)
            {
                contAventura = true;
            }
            if (si7.Checked == true)
            {
                contGuerra = true;
            }
            if (si8.Checked == true)
            {
                contTerror = true;
            }
            if (si9.Checked == true)
            {
                contAccion = true;
            }
            if (si10.Checked == true)
            {
                contCrimen = true;
            }

            //Manda como parametro todos los contadores ya se en verdadero o falso
            usuario.hacerCuestionario(contDrama,contMusicales,contInfantiles,contComedia,contCF,contAventura,contGuerra,contTerror,contAccion,contCrimen); 

            Cuestionario2 frm = new Cuestionario2();
            frm.Show();
            this.Hide();
        }
    }
}
