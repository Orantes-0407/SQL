namespace guiP1B
{
    partial class Form1
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
            this.buttonSaludar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxEstudiante = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.labelNota1 = new System.Windows.Forms.Label();
            this.labelNota2 = new System.Windows.Forms.Label();
            this.labelNota3 = new System.Windows.Forms.Label();
            this.labelNota4 = new System.Windows.Forms.Label();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.textBoxNota3 = new System.Windows.Forms.TextBox();
            this.textBoxNota4 = new System.Windows.Forms.TextBox();
            this.ButtonActualizarNota = new System.Windows.Forms.Button();
            this.buttonEliminarRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaludar
            // 
            this.buttonSaludar.Location = new System.Drawing.Point(12, 371);
            this.buttonSaludar.Name = "buttonSaludar";
            this.buttonSaludar.Size = new System.Drawing.Size(133, 55);
            this.buttonSaludar.TabIndex = 0;
            this.buttonSaludar.Text = "Saludar ✌️";
            this.buttonSaludar.UseVisualStyleBackColor = true;
            this.buttonSaludar.Click += new System.EventHandler(this.buttonSaludar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Correo";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(248, 46);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(304, 22);
            this.textBoxCarnet.TabIndex = 5;
            // 
            // textBoxEstudiante
            // 
            this.textBoxEstudiante.Location = new System.Drawing.Point(258, 94);
            this.textBoxEstudiante.Name = "textBoxEstudiante";
            this.textBoxEstudiante.Size = new System.Drawing.Size(375, 22);
            this.textBoxEstudiante.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(258, 194);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(318, 22);
            this.textBoxEmail.TabIndex = 8;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(217, 376);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(162, 45);
            this.buttonCrear.TabIndex = 9;
            this.buttonCrear.Text = "Crear Registro";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(558, 39);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBoxSeccion.Location = new System.Drawing.Point(258, 146);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSeccion.TabIndex = 11;
            // 
            // labelNota1
            // 
            this.labelNota1.AutoSize = true;
            this.labelNota1.Location = new System.Drawing.Point(80, 252);
            this.labelNota1.Name = "labelNota1";
            this.labelNota1.Size = new System.Drawing.Size(46, 16);
            this.labelNota1.TabIndex = 12;
            this.labelNota1.Text = "Nota 1";
            // 
            // labelNota2
            // 
            this.labelNota2.AutoSize = true;
            this.labelNota2.Location = new System.Drawing.Point(80, 294);
            this.labelNota2.Name = "labelNota2";
            this.labelNota2.Size = new System.Drawing.Size(46, 16);
            this.labelNota2.TabIndex = 14;
            this.labelNota2.Text = "Nota 2";
            // 
            // labelNota3
            // 
            this.labelNota3.AutoSize = true;
            this.labelNota3.Location = new System.Drawing.Point(279, 252);
            this.labelNota3.Name = "labelNota3";
            this.labelNota3.Size = new System.Drawing.Size(46, 16);
            this.labelNota3.TabIndex = 16;
            this.labelNota3.Text = "Nota 3";
            // 
            // labelNota4
            // 
            this.labelNota4.AutoSize = true;
            this.labelNota4.Location = new System.Drawing.Point(279, 294);
            this.labelNota4.Name = "labelNota4";
            this.labelNota4.Size = new System.Drawing.Size(46, 16);
            this.labelNota4.TabIndex = 18;
            this.labelNota4.Text = "Nota 4";
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(142, 252);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(100, 22);
            this.textBoxNota1.TabIndex = 13;
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(142, 294);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(100, 22);
            this.textBoxNota2.TabIndex = 15;
            // 
            // textBoxNota3
            // 
            this.textBoxNota3.Location = new System.Drawing.Point(357, 249);
            this.textBoxNota3.Name = "textBoxNota3";
            this.textBoxNota3.Size = new System.Drawing.Size(100, 22);
            this.textBoxNota3.TabIndex = 17;
            // 
            // textBoxNota4
            // 
            this.textBoxNota4.Location = new System.Drawing.Point(357, 294);
            this.textBoxNota4.Name = "textBoxNota4";
            this.textBoxNota4.Size = new System.Drawing.Size(100, 22);
            this.textBoxNota4.TabIndex = 19;
            // 
            // ButtonActualizarNota
            // 
            this.ButtonActualizarNota.Location = new System.Drawing.Point(407, 398);
            this.ButtonActualizarNota.Name = "ButtonActualizarNota";
            this.ButtonActualizarNota.Size = new System.Drawing.Size(124, 23);
            this.ButtonActualizarNota.TabIndex = 20;
            this.ButtonActualizarNota.Text = "Actualizar Nota";
            this.ButtonActualizarNota.UseVisualStyleBackColor = true;
            this.ButtonActualizarNota.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminarRegistro
            // 
            this.buttonEliminarRegistro.Location = new System.Drawing.Point(558, 398);
            this.buttonEliminarRegistro.Name = "buttonEliminarRegistro";
            this.buttonEliminarRegistro.Size = new System.Drawing.Size(128, 23);
            this.buttonEliminarRegistro.TabIndex = 21;
            this.buttonEliminarRegistro.Text = "Eliminar Registro";
            this.buttonEliminarRegistro.UseVisualStyleBackColor = true;
            this.buttonEliminarRegistro.Click += new System.EventHandler(this.buttonEliminarRegistro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEliminarRegistro);
            this.Controls.Add(this.ButtonActualizarNota);
            this.Controls.Add(this.textBoxNota4);
            this.Controls.Add(this.labelNota4);
            this.Controls.Add(this.textBoxNota3);
            this.Controls.Add(this.labelNota3);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.labelNota2);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.labelNota1);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxEstudiante);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaludar);
            this.Name = "Form1";
            this.Text = "Crud de Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaludar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.TextBox textBoxEstudiante;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxSeccion;
        private System.Windows.Forms.Label labelNota1;
        private System.Windows.Forms.Label labelNota2;
        private System.Windows.Forms.Label labelNota3;
        private System.Windows.Forms.Label labelNota4;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.TextBox textBoxNota3;
        private System.Windows.Forms.TextBox textBoxNota4;
        private System.Windows.Forms.Button ButtonActualizarNota;
        private System.Windows.Forms.Button buttonEliminarRegistro;
    }
}
