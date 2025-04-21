namespace MinecraftManagerWinForms.Forms
{
    partial class InventarioForm
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
            dgvInventario = new DataGridView();
            grpDatos = new GroupBox();
            numCantidad = new NumericUpDown();
            cboBloque = new ComboBox();
            cboJugador = new ComboBox();
            txtId = new TextBox();
            lblCantidad = new Label();
            lblBloque = new Label();
            lblJugador = new Label();
            lblId = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            grpFiltro = new GroupBox();
            btnRecargar = new Button();
            cboJugadorFiltro = new ComboBox();
            lblFiltroJugador = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            grpFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(14, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(272, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Inventarios";
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(14, 124);
            dgvInventario.Margin = new Padding(3, 4, 3, 4);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.RowTemplate.Height = 25;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(526, 324);
            dgvInventario.TabIndex = 1;
            dgvInventario.SelectionChanged += dgvInventario_SelectionChanged;
            // 
            // grpDatos
            // 
            grpDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpDatos.Controls.Add(numCantidad);
            grpDatos.Controls.Add(cboBloque);
            grpDatos.Controls.Add(cboJugador);
            grpDatos.Controls.Add(txtId);
            grpDatos.Controls.Add(lblCantidad);
            grpDatos.Controls.Add(lblBloque);
            grpDatos.Controls.Add(lblJugador);
            grpDatos.Controls.Add(lblId);
            grpDatos.Location = new Point(546, 124);
            grpDatos.Margin = new Padding(3, 4, 3, 4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(3, 4, 3, 4);
            grpDatos.Size = new Size(333, 231);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Inventario";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(135, 167);
            numCantidad.Margin = new Padding(3, 4, 3, 4);
            numCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(177, 27);
            numCantidad.TabIndex = 7;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboBloque
            // 
            cboBloque.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBloque.FormattingEnabled = true;
            cboBloque.Location = new Point(135, 123);
            cboBloque.Margin = new Padding(3, 4, 3, 4);
            cboBloque.Name = "cboBloque";
            cboBloque.Size = new Size(177, 28);
            cboBloque.TabIndex = 6;
            // 
            // cboJugador
            // 
            cboJugador.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJugador.FormattingEnabled = true;
            cboJugador.Location = new Point(135, 80);
            cboJugador.Margin = new Padding(3, 4, 3, 4);
            cboJugador.Name = "cboJugador";
            cboJugador.Size = new Size(177, 28);
            cboJugador.TabIndex = 5;
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
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(21, 169);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblBloque
            // 
            lblBloque.AutoSize = true;
            lblBloque.Location = new Point(21, 127);
            lblBloque.Name = "lblBloque";
            lblBloque.Size = new Size(59, 20);
            lblBloque.TabIndex = 2;
            lblBloque.Text = "Bloque:";
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Location = new Point(21, 84);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(65, 20);
            lblJugador.TabIndex = 1;
            lblJugador.Text = "Jugador:";
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
            // grpFiltro
            // 
            grpFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFiltro.Controls.Add(btnRecargar);
            grpFiltro.Controls.Add(cboJugadorFiltro);
            grpFiltro.Controls.Add(lblFiltroJugador);
            grpFiltro.Location = new Point(14, 49);
            grpFiltro.Margin = new Padding(3, 4, 3, 4);
            grpFiltro.Name = "grpFiltro";
            grpFiltro.Padding = new Padding(3, 4, 3, 4);
            grpFiltro.Size = new Size(865, 67);
            grpFiltro.TabIndex = 7;
            grpFiltro.TabStop = false;
            grpFiltro.Text = "Filtro";
            // 
            // btnRecargar
            // 
            btnRecargar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRecargar.Location = new Point(759, 23);
            btnRecargar.Margin = new Padding(3, 4, 3, 4);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(99, 33);
            btnRecargar.TabIndex = 8;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // cboJugadorFiltro
            // 
            cboJugadorFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboJugadorFiltro.DisplayMember = "Nombre";
            cboJugadorFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJugadorFiltro.FormattingEnabled = true;
            cboJugadorFiltro.Location = new Point(135, 25);
            cboJugadorFiltro.Margin = new Padding(3, 4, 3, 4);
            cboJugadorFiltro.Name = "cboJugadorFiltro";
            cboJugadorFiltro.Size = new Size(617, 28);
            cboJugadorFiltro.TabIndex = 1;
            cboJugadorFiltro.ValueMember = "Id";
            cboJugadorFiltro.SelectedIndexChanged += cboJugadorFiltro_SelectedIndexChanged;
            // 
            // lblFiltroJugador
            // 
            lblFiltroJugador.AutoSize = true;
            lblFiltroJugador.Location = new Point(7, 29);
            lblFiltroJugador.Name = "lblFiltroJugador";
            lblFiltroJugador.Size = new Size(134, 20);
            lblFiltroJugador.TabIndex = 0;
            lblFiltroJugador.Text = "Filtrar por Jugador:";
            // 
            // button1
            // 
            button1.Location = new Point(549, 419);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Exportar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 464);
            Controls.Add(button1);
            Controls.Add(grpFiltro);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(grpDatos);
            Controls.Add(dgvInventario);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Inventarios - Minecraft Manager";
            Load += InventarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            grpFiltro.ResumeLayout(false);
            grpFiltro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.ComboBox cboBloque;
        private System.Windows.Forms.ComboBox cboJugador;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblBloque;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.ComboBox cboJugadorFiltro;
        private System.Windows.Forms.Label lblFiltroJugador;
        private Button button1;
    }
}