namespace Club_deportivo_EV
{
    partial class frmPagarCuota
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
            txtDniSocio = new TextBox();
            txtMonto = new TextBox();
            lblDniSocio = new Label();
            lblMonto = new Label();
            btnLimpiar = new Button();
            btnPagar = new Button();
            SuspendLayout();
            // 
            // txtDniSocio
            // 
            txtDniSocio.Location = new Point(107, 89);
            txtDniSocio.Name = "txtDniSocio";
            txtDniSocio.Size = new Size(100, 23);
            txtDniSocio.TabIndex = 11;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(107, 34);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 10;
            // 
            // lblDniSocio
            // 
            lblDniSocio.AutoSize = true;
            lblDniSocio.ForeColor = SystemColors.ButtonHighlight;
            lblDniSocio.Location = new Point(27, 89);
            lblDniSocio.Name = "lblDniSocio";
            lblDniSocio.Size = new Size(59, 15);
            lblDniSocio.TabIndex = 9;
            lblDniSocio.Text = "DNI Socio";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.ForeColor = SystemColors.ButtonHighlight;
            lblMonto.Location = new Point(27, 42);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 8;
            lblMonto.Text = "Monto";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkSlateGray;
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(120, 204);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.DarkSlateGray;
            btnPagar.ForeColor = SystemColors.ButtonHighlight;
            btnPagar.Location = new Point(120, 155);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 6;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // frmPagarCuota
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
            Name = "frmPagarCuota";
            Text = "Pagar Cuota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDniSocio;
        private TextBox txtMonto;
        private Label lblDniSocio;
        private Label lblMonto;
        private Button btnLimpiar;
        private Button btnPagar;
    }
}