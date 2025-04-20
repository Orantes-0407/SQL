using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MinecraftManagerWinForms.Models;
using MinecraftManagerWinForms.Services;

namespace MinecraftManagerWinForms.Forms
{
    public partial class JugadoresForm : Form
    {
        private readonly JugadorService _jugadorService;
        private List<Jugador> _jugadores;
        private Jugador _selectedJugador;

        public JugadoresForm()
        {
            InitializeComponent();
            _jugadorService = new JugadorService();
        }

        private void JugadoresForm_Load(object sender, EventArgs e)
        {
            // Configure DataGridView
            ConfigureDataGridView();
            
            // Load players data
            CargarJugadores();
        }

        private void ConfigureDataGridView()
        {
            // Configure columns
            dgvJugadores.AutoGenerateColumns = false;
            dgvJugadores.Columns.Clear();

            // Add columns
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50,
                ReadOnly = true
            };
            dgvJugadores.Columns.Add(colId);

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 150,
                ReadOnly = true
            };
            dgvJugadores.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colNivel = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nivel",
                HeaderText = "Nivel",
                Width = 80,
                ReadOnly = true
            };
            dgvJugadores.Columns.Add(colNivel);

            DataGridViewTextBoxColumn colFechaCreacion = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaCreacion",
                HeaderText = "Fecha de Creación",
                Width = 150,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            };
            dgvJugadores.Columns.Add(colFechaCreacion);
        }

        private void CargarJugadores()
        {
            try
            {
                _jugadores = _jugadorService.GetAllJugadores();
                dgvJugadores.DataSource = null;
                dgvJugadores.DataSource = _jugadores;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar jugadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvJugadores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJugadores.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvJugadores.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < _jugadores.Count)
                {
                    _selectedJugador = _jugadores[selectedIndex];
                    MostrarDatosJugador();
                }
            }
        }

        private void MostrarDatosJugador()
        {
            if (_selectedJugador != null)
            {
                txtId.Text = _selectedJugador.Id.ToString();
                txtNombre.Text = _selectedJugador.Nombre;
                numNivel.Value = _selectedJugador.Nivel;
                dtpFechaCreacion.Value = _selectedJugador.FechaCreacion;
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            numNivel.Value = 1;
            dtpFechaCreacion.Value = DateTime.Now;
            _selectedJugador = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para el jugador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            try
            {
                if (_selectedJugador == null) // New player
                {
                    Jugador nuevoJugador = new Jugador
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Nivel = (int)numNivel.Value,
                        FechaCreacion = dtpFechaCreacion.Value
                    };

                    _jugadorService.CreateJugador(nuevoJugador);
                    MessageBox.Show("Jugador creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Update existing player
                {
                    _selectedJugador.Nombre = txtNombre.Text.Trim();
                    _selectedJugador.Nivel = (int)numNivel.Value;
                    _selectedJugador.FechaCreacion = dtpFechaCreacion.Value;

                    _jugadorService.UpdateJugador(_selectedJugador);
                    MessageBox.Show("Jugador actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarJugadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_selectedJugador == null)
            {
                MessageBox.Show("Debe seleccionar un jugador para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"¿Está seguro que desea eliminar al jugador '{_selectedJugador.Nombre}'?", 
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _jugadorService.DeleteJugador(_selectedJugador.Id);
                    MessageBox.Show("Jugador eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarJugadores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVerInventario_Click(object sender, EventArgs e)
        {
            if (_selectedJugador == null)
            {
                MessageBox.Show("Debe seleccionar un jugador para ver su inventario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new InventarioJugadorForm(_selectedJugador.Id, _selectedJugador.Nombre))
            {
                form.ShowDialog();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                dgvJugadores.DataSource = _jugadores;
                return;
            }

            string buscar = txtBuscar.Text.ToLower();
            List<Jugador> filtrados = _jugadores.FindAll(j => 
                j.Nombre.ToLower().Contains(buscar) || 
                j.Id.ToString().Contains(buscar) ||
                j.Nivel.ToString().Contains(buscar));

            dgvJugadores.DataSource = null;
            dgvJugadores.DataSource = filtrados;
        }
    }
}