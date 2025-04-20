namespace MinecraftManagerWinForms;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        btnJugadores = new Button();
        btnBloques = new Button();
        btnInventario = new Button();
        btnSalir = new Button();
        SuspendLayout();
        // 
        // btnJugadores
        // 
        btnJugadores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnJugadores.Location = new Point(252, 381);
        btnJugadores.Margin = new Padding(3, 4, 3, 4);
        btnJugadores.Name = "btnJugadores";
        btnJugadores.Size = new Size(183, 53);
        btnJugadores.TabIndex = 1;
        btnJugadores.Text = " Jugadores";
        btnJugadores.UseVisualStyleBackColor = true;
        btnJugadores.Click += btnJugadores_Click;
        // 
        // btnBloques
        // 
        btnBloques.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnBloques.Location = new Point(25, 381);
        btnBloques.Margin = new Padding(3, 4, 3, 4);
        btnBloques.Name = "btnBloques";
        btnBloques.Size = new Size(183, 53);
        btnBloques.TabIndex = 2;
        btnBloques.Text = " Bloques";
        btnBloques.UseVisualStyleBackColor = true;
        btnBloques.Click += btnBloques_Click;
        // 
        // btnInventario
        // 
        btnInventario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnInventario.Location = new Point(482, 381);
        btnInventario.Margin = new Padding(3, 4, 3, 4);
        btnInventario.Name = "btnInventario";
        btnInventario.Size = new Size(183, 53);
        btnInventario.TabIndex = 3;
        btnInventario.Text = " Inventario";
        btnInventario.UseVisualStyleBackColor = true;
        btnInventario.Click += btnInventario_Click;
        // 
        // btnSalir
        // 
        btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnSalir.Location = new Point(749, 381);
        btnSalir.Margin = new Padding(3, 4, 3, 4);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(183, 53);
        btnSalir.TabIndex = 4;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        ClientSize = new Size(961, 463);
        Controls.Add(btnSalir);
        Controls.Add(btnInventario);
        Controls.Add(btnBloques);
        Controls.Add(btnJugadores);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Minecraft Manager";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    #endregion
    private System.Windows.Forms.Button btnJugadores;
    private System.Windows.Forms.Button btnBloques;
    private System.Windows.Forms.Button btnInventario;
    private System.Windows.Forms.Button btnSalir;
}
