namespace Club_deportivo_EV
{
    partial class frmPagarInscripcion
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
            btnPagar = new Button();
            btnLimpiar = new Button();
            lblMonto = new Label();
            lblDniSocio = new Label();
            txtMonto = new TextBox();
            txtDniSocio = new TextBox();
            SuspendLayout();
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.DarkSlateGray;
            btnPagar.ForeColor = SystemColors.ButtonHighlight;
            btnPagar.Location = new Point(120, 159);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 0;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkSlateGray;
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(120, 208);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.ForeColor = SystemColors.ButtonHighlight;
            lblMonto.Location = new Point(27, 46);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto";
            // 
            // lblDniSocio
            // 
            lblDniSocio.AutoSize = true;
            lblDniSocio.ForeColor = SystemColors.ButtonHighlight;
            lblDniSocio.Location = new Point(27, 93);
            lblDniSocio.Name = "lblDniSocio";
            lblDniSocio.Size = new Size(59, 15);
            lblDniSocio.TabIndex = 3;
            lblDniSocio.Text = "DNI Socio";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(107, 38);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 4;
            // 
            // txtDniSocio
            // 
            txtDniSocio.Location = new Point(107, 93);
            txtDniSocio.Name = "txtDniSocio";
            txtDniSocio.Size = new Size(100, 23);
            txtDniSocio.TabIndex = 5;
            // 
            // frmPagarInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(234, 261);
            Controls.Add(txtDniSocio);
            Controls.Add(txtMonto);
            Controls.Add(lblDniSocio);
            Controls.Add(lblMonto);
            Controls.Add(btnLimpiar);
            Controls.Add(btnPagar);
            Name = "frmPagarInscripcion";
            Text = "Pagar Inscripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPagar;
        private Button btnLimpiar;
        private Label lblMonto;
        private Label lblDniSocio;
        private TextBox txtMonto;
        private TextBox txtDniSocio;
    }
}