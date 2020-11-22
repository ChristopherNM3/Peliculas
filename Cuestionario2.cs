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
    public partial class Cuestionario2 : Form
    {
        
        bool contDrama, contMusicales, contInfantiles, contComedia, contCF, contAventura, contGuerra, contTerror, contAccion, contCrimen;

        public Cuestionario2()
        {
            InitializeComponent();
        }

        private void Cuestionario2_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            string[] preguntas = usuario.pedirCuestionario();

            pregunta1.Text = preguntas[0];
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

        private void siguiente_btn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (si1.Checked == true)
            {
                contDrama = true;
            }
            if (si2.Checked == true)
            {
                contMusicales = true;
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

            usuario.hacerCuestionario(contDrama, contMusicales, contInfantiles, contComedia, contCF, contAventura, contGuerra, contTerror, contAccion, contCrimen);

            Cuestionario3 frm = new Cuestionario3();
            frm.Show();
            this.Hide();
        }
    }
}
