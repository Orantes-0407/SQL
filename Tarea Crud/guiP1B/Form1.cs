using guiP1B.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiP1B
{
    public partial class Form1 : Form
    {

        Crud miCrud = new Crud();
        public Form1()
        { 
            InitializeComponent();
            
         
        }
        

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOla te saludo desde el formulario 👊👊👊");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            textBoxEstudiante.Text = miCrud.MostrarInformacion(textBoxCarnet.Text);  
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxEstudiante.Text;
            string carnet = textBoxCarnet.Text;
            string email = textBoxEmail.Text;
            string seccion = comboBoxSeccion.Text; // Cambiado a comboBoxSeccion
            string respuesta = miCrud.AgregarAlumno(carnet, nombre, email, seccion);
            MessageBox.Show(respuesta);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\USUARIO\\Downloads\\kirby.jpg");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            foreach (Control control in this.Controls)
            {
                control.Font = new System.Drawing.Font("Times New Roman", 8, System.Drawing.FontStyle.Bold);
            }
        }
    }
}
