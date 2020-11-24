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
    public partial class login : Form
    {
        Usuario usuario = new Usuario();
        Administrador admi = new Administrador();
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == admi.nombreAdministrador && textBox2.Text == admi.contraseña)
            {
                AdministradorForm frm1 = new AdministradorForm();
                frm1.Show();
                this.Hide();
            }
            else
            {
                Cuestionario1 frm = new Cuestionario1();
                frm.Show();
                this.Hide();
            }



        }

        private void login_Load(object sender, EventArgs e)
        {
            usuario.reinciar();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cuestionario1 frm = new Cuestionario1();
            frm.Show();
            this.Hide();

        }
    }
}
