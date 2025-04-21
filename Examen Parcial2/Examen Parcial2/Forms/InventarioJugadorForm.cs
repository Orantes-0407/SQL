using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MinecraftManagerWinForms.Models;
using MinecraftManagerWinForms.Services;

namespace MinecraftManagerWinForms.Forms
{
    public partial class InventarioJugadorForm : Form
    {
        private readonly InventarioService _inventarioService;
        private readonly BloqueService _bloqueService;
        private List<Inventario> _inventarios;
        private List<Bloque> _bloques;
        private int _jugadorId;
        private string _jugadorNombre;

        public InventarioJugadorForm(int jugadorId, string jugadorNombre)
        {
            InitializeComponent();
            _inventarioService = new InventarioService();
            _bloqueService = new BloqueService();
            _jugadorId = jugadorId;
            _jugadorNombre = jugadorNombre;
        }

        private void InventarioJugadorForm_Load(object sender, EventArgs e)
        {
            // Set title
            this.Text = $"Inventario de {_jugadorNombre} - Minecraft Manager";
            lblTitulo.Text = $"Inventario de {_jugadorNombre}";
            
            // Configure DataGridView
            ConfigureDataGridView();
            
            // Load combo boxes
            CargarComboBoxes();
            
            // Load inventario data
            CargarInventario();
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
                ReadOnly = true,
                Visible = false
            };
            dgvInventario.Columns.Add(colId);

            DataGridViewTextBoxColumn colBloque = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BloqueNombre",
                HeaderText = "Bloque",
                Width = 200,
                ReadOnly = true
            };
            dgvInventario.Columns.Add(colBloque);

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Width = 100,
                ReadOnly = true
            };
            dgvInventario.Columns.Add(colCantidad);
        }

        private void CargarComboBoxes()
        {
            try
            {
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

        private void CargarInventario()
        {
            try
            {
                _inventarios = _inventarioService.GetInventariosByJugador(_jugadorId);
                dgvInventario.DataSource = null;
                dgvInventario.DataSource = _inventarios;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            cboBloque.SelectedIndex = -1;
            numCantidad.Value = 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboBloque.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un bloque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBloque.Focus();
                return;
            }

            try
            {
                Inventario nuevoInventario = new Inventario
                {
                    JugadorId = _jugadorId,
                    BloqueId = (int)cboBloque.SelectedValue,
                    Cantidad = (int)numCantidad.Value
                };

                _inventarioService.CreateInventario(nuevoInventario);
                MessageBox.Show("Bloque agregado al inventario exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar bloque al inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}