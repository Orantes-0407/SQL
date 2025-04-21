using System;
using System.Windows.Forms;
using MinecraftManagerWinForms.Utils;

namespace MinecraftManagerWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set form title
            this.Text = "Minecraft Manager";
            
            // Test database connection when application starts
            try
            {
                if (DatabaseManager.TestConnection())
                {
                    MessageBox.Show("Conexión a la base de datos DB_PARCIAL2 establecida correctamente.", 
                        "Conexión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos DB_PARCIAL2 en el servidor MELANY\\SQLEXPRESS." +
                        "\n\nPor favor verifique la conexión e intente nuevamente.", 
                        "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            // Open players form
            using (var form = new Forms.JugadoresForm())
            {
                form.ShowDialog();
            }
        }

        private void btnBloques_Click(object sender, EventArgs e)
        {
            // Open blocks form
            using (var form = new Forms.BloquesForm())
            {
                form.ShowDialog();
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Open inventory form
            using (var form = new Forms.InventarioForm())
            {
                form.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }
    }
}
