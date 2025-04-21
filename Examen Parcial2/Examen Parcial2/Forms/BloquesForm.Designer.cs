namespace MinecraftManagerWinForms.Forms
{
    partial class BloquesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            dgvBloques = new DataGridView();
            grpDatos = new GroupBox();
            cboRareza = new ComboBox();
            cboTipo = new ComboBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lblRareza = new Label();
            lblTipo = new Label();
            lblNombre = new Label();
            lblId = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            grpBusqueda = new GroupBox();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBloques).BeginInit();
            grpDatos.SuspendLayout();
            grpBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(14, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(234, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Bloques";
            // 
            // dgvBloques
            // 
            dgvBloques.AllowUserToAddRows = false;
            dgvBloques.AllowUserToDeleteRows = false;
            dgvBloques.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBloques.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBloques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBloques.Location = new Point(14, 124);
            dgvBloques.Margin = new Padding(3, 4, 3, 4);
            dgvBloques.MultiSelect = false;
            dgvBloques.Name = "dgvBloques";
            dgvBloques.ReadOnly = true;
            dgvBloques.RowHeadersWidth = 51;
            dgvBloques.RowTemplate.Height = 25;
            dgvBloques.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBloques.Size = new Size(526, 324);
            dgvBloques.TabIndex = 1;
            dgvBloques.SelectionChanged += dgvBloques_SelectionChanged;
            // 
            // grpDatos
            // 
            grpDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpDatos.Controls.Add(cboRareza);
            grpDatos.Controls.Add(cboTipo);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(txtId);
            grpDatos.Controls.Add(lblRareza);
            grpDatos.Controls.Add(lblTipo);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(lblId);
            grpDatos.Location = new Point(546, 124);
            grpDatos.Margin = new Padding(3, 4, 3, 4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(3, 4, 3, 4);
            grpDatos.Size = new Size(333, 231);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Bloque";
            // 
            // cboRareza
            // 
            cboRareza.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRareza.FormattingEnabled = true;
            cboRareza.Location = new Point(135, 167);
            cboRareza.Margin = new Padding(3, 4, 3, 4);
            cboRareza.Name = "cboRareza";
            cboRareza.Size = new Size(177, 28);
            cboRareza.TabIndex = 7;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(135, 123);
            cboTipo.Margin = new Padding(3, 4, 3, 4);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(177, 28);
            cboTipo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 80);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(135, 39);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 4;
            // 
            // lblRareza
            // 
            lblRareza.AutoSize = true;
            lblRareza.Location = new Point(21, 171);
            lblRareza.Name = "lblRareza";
            lblRareza.Size = new Size(57, 20);
            lblRareza.TabIndex = 3;
            lblRareza.Text = "Rareza:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(21, 127);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(21, 43);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevo.Location = new Point(546, 363);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(97, 39);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Location = new Point(650, 363);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 39);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(754, 363);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 39);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // grpBusqueda
            // 
            grpBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBusqueda.Controls.Add(txtBuscar);
            grpBusqueda.Controls.Add(lblBuscar);
            grpBusqueda.Location = new Point(14, 49);
            grpBusqueda.Margin = new Padding(3, 4, 3, 4);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Padding = new Padding(3, 4, 3, 4);
            grpBusqueda.Size = new Size(865, 67);
            grpBusqueda.TabIndex = 7;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = "Búsqueda";
            grpBusqueda.Enter += grpBusqueda_Enter;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(91, 25);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(766, 27);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(7, 29);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(82, 20);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar por:";
            // 
            // BloquesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 464);
            Controls.Add(grpBusqueda);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(grpDatos);
            Controls.Add(dgvBloques);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BloquesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Bloques - Minecraft Manager";
            Load += BloquesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBloques).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvBloques;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.ComboBox cboRareza;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblRareza;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
    }
}