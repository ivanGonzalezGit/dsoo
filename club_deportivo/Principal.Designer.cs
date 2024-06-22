namespace Club_deportivo_EV
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            picDeporte = new PictureBox();
            btnAltaSocio = new Button();
            btnPagarInscripcion = new Button();
            btnPagarCuota = new Button();
            btnListarMorosos = new Button();
            btnListarSocios = new Button();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            lblAdministrador = new Label();
            lblNombreAdmin = new Label();
            ((System.ComponentModel.ISupportInitialize)picDeporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picDeporte
            // 
            picDeporte.Image = (Image)resources.GetObject("picDeporte.Image");
            picDeporte.Location = new Point(12, 70);
            picDeporte.Name = "picDeporte";
            picDeporte.Size = new Size(400, 114);
            picDeporte.TabIndex = 0;
            picDeporte.TabStop = false;
            // 
            // btnAltaSocio
            // 
            btnAltaSocio.BackColor = Color.DarkSlateGray;
            btnAltaSocio.ForeColor = SystemColors.ButtonHighlight;
            btnAltaSocio.Location = new Point(88, 230);
            btnAltaSocio.Name = "btnAltaSocio";
            btnAltaSocio.Size = new Size(75, 49);
            btnAltaSocio.TabIndex = 1;
            btnAltaSocio.Text = "Alta Socio";
            btnAltaSocio.UseVisualStyleBackColor = false;
            btnAltaSocio.Click += btnAltaSocio_Click;
            // 
            // btnPagarInscripcion
            // 
            btnPagarInscripcion.BackColor = Color.DarkSlateGray;
            btnPagarInscripcion.ForeColor = SystemColors.ButtonHighlight;
            btnPagarInscripcion.Location = new Point(169, 230);
            btnPagarInscripcion.Name = "btnPagarInscripcion";
            btnPagarInscripcion.Size = new Size(75, 49);
            btnPagarInscripcion.TabIndex = 2;
            btnPagarInscripcion.Text = "Pagar Inscripción";
            btnPagarInscripcion.UseVisualStyleBackColor = false;
            btnPagarInscripcion.Click += btnPagarInscripcion_Click;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = Color.DarkSlateGray;
            btnPagarCuota.ForeColor = SystemColors.ButtonHighlight;
            btnPagarCuota.Location = new Point(250, 230);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(75, 49);
            btnPagarCuota.TabIndex = 3;
            btnPagarCuota.Text = "Pagar Cuota";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnListarMorosos
            // 
            btnListarMorosos.BackColor = Color.DarkSlateGray;
            btnListarMorosos.ForeColor = SystemColors.ButtonHighlight;
            btnListarMorosos.Location = new Point(88, 292);
            btnListarMorosos.Name = "btnListarMorosos";
            btnListarMorosos.Size = new Size(75, 49);
            btnListarMorosos.TabIndex = 4;
            btnListarMorosos.Text = "Listar Morosos";
            btnListarMorosos.UseVisualStyleBackColor = false;
            btnListarMorosos.Click += btnListarMorosos_Click;
            // 
            // btnListarSocios
            // 
            btnListarSocios.BackColor = Color.DarkSlateGray;
            btnListarSocios.ForeColor = SystemColors.ButtonHighlight;
            btnListarSocios.Location = new Point(169, 292);
            btnListarSocios.Name = "btnListarSocios";
            btnListarSocios.Size = new Size(75, 49);
            btnListarSocios.TabIndex = 5;
            btnListarSocios.Text = "Listar Socios";
            btnListarSocios.UseVisualStyleBackColor = false;
            btnListarSocios.Click += btnListarSocios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LimeGreen;
            pictureBox1.Location = new Point(79, 218);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 138);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Crimson;
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(337, 404);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblAdministrador
            // 
            lblAdministrador.AutoSize = true;
            lblAdministrador.ForeColor = SystemColors.ButtonHighlight;
            lblAdministrador.Location = new Point(12, 20);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(116, 15);
            lblAdministrador.TabIndex = 8;
            lblAdministrador.Text = "ADMINISTRADOR/A:";
            lblAdministrador.Click += label1_Click;
            // 
            // lblNombreAdmin
            // 
            lblNombreAdmin.AutoSize = true;
            lblNombreAdmin.ForeColor = SystemColors.ButtonHighlight;
            lblNombreAdmin.Location = new Point(134, 20);
            lblNombreAdmin.Name = "lblNombreAdmin";
            lblNombreAdmin.Size = new Size(35, 15);
            lblNombreAdmin.TabIndex = 11;
            lblNombreAdmin.Text = "value";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(434, 461);
            Controls.Add(lblNombreAdmin);
            Controls.Add(lblAdministrador);
            Controls.Add(btnSalir);
            Controls.Add(btnListarSocios);
            Controls.Add(btnListarMorosos);
            Controls.Add(btnPagarCuota);
            Controls.Add(btnPagarInscripcion);
            Controls.Add(btnAltaSocio);
            Controls.Add(picDeporte);
            Controls.Add(pictureBox1);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)picDeporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picDeporte;
        private Button btnAltaSocio;
        private Button btnPagarInscripcion;
        private Button btnPagarCuota;
        private Button btnListarMorosos;
        private Button btnListarSocios;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private Label lblAdministrador;
        private Label lblNombreAdmin;
    }
}