using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MinecraftManagerWinForms.Models;
using MinecraftManagerWinForms.Services;

namespace MinecraftManagerWinForms.Forms
{


    public partial class BloquesForm : Form
    {
        private readonly BloqueService _bloqueService;
        private List<Bloque> _bloques;
        private Bloque _selectedBloque;

        public BloquesForm()
        {
            InitializeComponent();
            _bloqueService = new BloqueService();
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                return null; // Maneja el caso de un arreglo nulo o vacío
            }

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void BloquesForm_Load(object sender, EventArgs e)
        {
            // Configure DataGridView
            ConfigureDataGridView();

            // Load blocks data
            CargarBloques();

            // Load comboboxes
            CargarComboBoxes();
        }

        private void ConfigureDataGridView()
        {
            // Configure columns
            dgvBloques.AutoGenerateColumns = false;
            dgvBloques.Columns.Clear();

            // Add columns
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50,
                ReadOnly = true
            };
            dgvBloques.Columns.Add(colId);

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 150,
                ReadOnly = true
            };
            dgvBloques.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colTipo = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Tipo",
                HeaderText = "Tipo",
                Width = 100,
                ReadOnly = true
            };
            dgvBloques.Columns.Add(colTipo);

            DataGridViewTextBoxColumn colRareza = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Rareza",
                HeaderText = "Rareza",
                Width = 100,
                ReadOnly = true
            };
            dgvBloques.Columns.Add(colRareza);
        }

        private void CargarBloques()
        {
            try
            {
                _bloques = _bloqueService.GetAllBloques();
                dgvBloques.DataSource = null;
                dgvBloques.DataSource = _bloques;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar bloques: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBoxes()
        {
            // Tipos de bloques
            cboTipo.Items.Clear();
            cboTipo.Items.AddRange(new object[] {
                "Construcción",
                "Decorativo",
                "Redstone",
                "Natural",
                "Minerales",
                "Otros"
            });

            // Rarezas
            cboRareza.Items.Clear();
            cboRareza.Items.AddRange(new object[] {
                "Común",
                "Poco común",
                "Raro",
                "Épico",
                "Legendario"
            });
        }

        private void dgvBloques_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBloques.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvBloques.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < _bloques.Count)
                {
                    _selectedBloque = _bloques[selectedIndex];
                    MostrarDatosBloque();
                }
            }
        }

        private void MostrarDatosBloque()
        {
            if (_selectedBloque != null)
            {
                txtId.Text = _selectedBloque.Id.ToString();
                txtNombre.Text = _selectedBloque.Nombre;
                cboTipo.SelectedItem = _selectedBloque.Tipo;
                cboRareza.SelectedItem = _selectedBloque.Rareza;
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cboTipo.SelectedIndex = -1;
            cboRareza.SelectedIndex = -1;
            _selectedBloque = null;
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
                MessageBox.Show("Debe ingresar un nombre para el bloque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de bloque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipo.Focus();
                return;
            }

            if (cboRareza.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una rareza para el bloque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboRareza.Focus();
                return;
            }

            try
            {
                if (_selectedBloque == null) // Nuevo bloque
                {
                    Bloque nuevoBloque = new Bloque
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Tipo = cboTipo.SelectedItem.ToString(),
                        Rareza = cboRareza.SelectedItem.ToString()
                    };

                    _bloqueService.CreateBloque(nuevoBloque);
                    MessageBox.Show("Bloque creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Actualizar bloque existente
                {
                    _selectedBloque.Nombre = txtNombre.Text.Trim();
                    _selectedBloque.Tipo = cboTipo.SelectedItem.ToString();
                    _selectedBloque.Rareza = cboRareza.SelectedItem.ToString();

                    _bloqueService.UpdateBloque(_selectedBloque);
                    MessageBox.Show("Bloque actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarBloques();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_selectedBloque == null)
            {
                MessageBox.Show("Debe seleccionar un bloque para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"¿Está seguro que desea eliminar el bloque '{_selectedBloque.Nombre}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _bloqueService.DeleteBloque(_selectedBloque.Id);
                    MessageBox.Show("Bloque eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarBloques();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                dgvBloques.DataSource = _bloques;
                return;
            }

            string buscar = txtBuscar.Text.ToLower();
            List<Bloque> filtrados = _bloques.FindAll(b =>
                b.Nombre.ToLower().Contains(buscar) ||
                b.Tipo.ToLower().Contains(buscar) ||
                b.Rareza.ToLower().Contains(buscar) ||
                b.Id.ToString().Contains(buscar));

            dgvBloques.DataSource = null;
            dgvBloques.DataSource = filtrados;
        }

        private void grpBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}