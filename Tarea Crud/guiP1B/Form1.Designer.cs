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
            this.SuspendLayout();
            // 
            // buttonSaludar
            // 
            this.buttonSaludar.Location = new System.Drawing.Point(12, 345);
            this.buttonSaludar.Name = "buttonSaludar";
            this.buttonSaludar.Size = new System.Drawing.Size(160, 81);
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
            this.label3.Text = "Seccion";
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
            this.buttonCrear.Location = new System.Drawing.Point(270, 255);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

