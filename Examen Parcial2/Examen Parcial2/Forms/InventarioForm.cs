using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MinecraftManagerWinForms.Models;
using MinecraftManagerWinForms.Services;

namespace MinecraftManagerWinForms.Forms
{
    public partial class InventarioForm : Form
    {

        private List<Inventario> ObtenerInventario()
        {
            // Devuelve la lista de inventarios cargada en el formulario
            return _inventarios ?? new List<Inventario>();
        }
        private void ExportarInventarioACSV(List<Inventario> inventario, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Escribir encabezados
                writer.WriteLine("Id,Jugador,Bloque,Cantidad");

                // Escribir datos
                foreach (var item in inventario)
                {
                    writer.WriteLine($"{item.Id},{item.JugadorNombre},{item.BloqueNombre},{item.Cantidad}");
                }
            }
        }

        private readonly InventarioService _inventarioService;
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;
        private List<Inventario> _inventarios;
        private List<Jugador> _jugadores;
        private List<Bloque> _bloques;
        private Inventario _selectedInventario;

        public InventarioForm()
        {
            InitializeComponent();
            _inventarioService = new InventarioService();
            _jugadorService = new JugadorService();
            _bloqueService = new BloqueService();
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            // Configure DataGridView
            ConfigureDataGridView();

            // Load combo boxes
            CargarComboBoxes();

            // Load inventario data
            CargarInventarios();
        }

        private void ConfigureDataGridView()
        {
            // Configure columns
            dgvInventario.AutoGenerateColumns = false;
            dgvInventario.Columns.Clear();

            // Add columns
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50,
                ReadOnly = true
            };
            dgvInventario.Columns.Add(colId);

            DataGridViewTextBoxColumn colJugador = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "JugadorNombre",
                HeaderText = "Jugador",
                Width = 150,
                ReadOnly = true
            };
            dgvInventario.Columns.Add(colJugador);

            DataGridViewTextBoxColumn colBloque = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BloqueNombre",
                HeaderText = "Bloque",
                Width = 150,
                ReadOnly = true
            };
            dgvInventario.Columns.Add(colBloque);

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Width = 80,
                ReadOnly = true
            };
            dgvInventario.Columns.Add(colCantidad);
        }

        private void CargarComboBoxes()
        {
            try
            {
                // Jugadores
                _jugadores = _jugadorService.GetAllJugadores();
                cboJugador.DataSource = null;
                cboJugador.DisplayMember = "Nombre";
                cboJugador.ValueMember = "Id";
                cboJugador.DataSource = _jugadores;
                cboJugador.SelectedIndex = -1;

                // Bloques
                _bloques = _bloqueService.GetAllBloques();
                cboBloque.DataSource = null;
                cboBloque.DisplayMember = "Nombre";
                cboBloque.ValueMember = "Id";
                cboBloque.DataSource = _bloques;
                cboBloque.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarInventarios()
        {
            try
            {
                _inventarios = _inventarioService.GetAllInventarios();
                dgvInventario.DataSource = null;
                dgvInventario.DataSource = _inventarios;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar inventarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInventario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvInventario.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < _inventarios.Count)
                {
                    _selectedInventario = _inventarios[selectedIndex];
                    MostrarDatosInventario();
                }
            }
        }

        private void MostrarDatosInventario()
        {
            if (_selectedInventario != null)
            {
                txtId.Text = _selectedInventario.Id.ToString();
                cboJugador.SelectedValue = _selectedInventario.JugadorId;
                cboBloque.SelectedValue = _selectedInventario.BloqueId;
                numCantidad.Value = _selectedInventario.Cantidad;
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            cboJugador.SelectedIndex = -1;
            cboBloque.SelectedIndex = -1;
            numCantidad.Value = 1;
            _selectedInventario = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            cboJugador.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboJugador.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un jugador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboJugador.Focus();
                return;
            }

            if (cboBloque.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un bloque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBloque.Focus();
                return;
            }

            try
            {
                if (_selectedInventario == null) // Nuevo inventario
                {
                    Inventario nuevoInventario = new Inventario
                    {
                        JugadorId = (int)cboJugador.SelectedValue,
                        BloqueId = (int)cboBloque.SelectedValue,
                        Cantidad = (int)numCantidad.Value
                    };

                    _inventarioService.CreateInventario(nuevoInventario);
                    MessageBox.Show("Inventario creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Actualizar inventario existente
                {
                    _selectedInventario.JugadorId = (int)cboJugador.SelectedValue;
                    _selectedInventario.BloqueId = (int)cboBloque.SelectedValue;
                    _selectedInventario.Cantidad = (int)numCantidad.Value;

                    _inventarioService.UpdateInventario(_selectedInventario);
                    MessageBox.Show("Inventario actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarInventarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_selectedInventario == null)
            {
                MessageBox.Show("Debe seleccionar un inventario para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"¿Está seguro que desea eliminar este inventario?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _inventarioService.DeleteInventario(_selectedInventario.Id);
                    MessageBox.Show("Inventario eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarInventarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboJugadorFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarInventarios();
        }

        private void FiltrarInventarios()
        {
            try
            {
                if (cboJugadorFiltro.SelectedIndex == -1)
                {
                    _inventarios = _inventarioService.GetAllInventarios();
                }
                else
                {
                    int jugadorId = (int)cboJugadorFiltro.SelectedValue;
                    _inventarios = _inventarioService.GetInventariosByJugador(jugadorId);
                }

                dgvInventario.DataSource = null;
                dgvInventario.DataSource = _inventarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar inventarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cboJugadorFiltro.SelectedIndex = -1;
            CargarInventarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del inventario
                var inventario = ObtenerInventario(); // Método que devuelve una lista de objetos del inventario

                // Verificar si hay datos
                if (inventario == null || inventario.Count == 0)
                {
                    MessageBox.Show("No hay datos en el inventario para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Seleccionar ubicación para guardar el archivo
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
                    saveFileDialog.Title = "Guardar archivo CSV";
                    saveFileDialog.FileName = "Inventario.csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Exportar a CSV
                        ExportarInventarioACSV(inventario, saveFileDialog.FileName);
                        MessageBox.Show("Inventario exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar el inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}