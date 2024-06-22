namespace Club_deportivo_EV
{
    partial class frmAltaSocio
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
            lblDni = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnAltaSocio = new Button();
            btnLimpiar = new Button();
            lblAsterisco1 = new Label();
            lblAsterisco2 = new Label();
            lblAsterisco3 = new Label();
            SuspendLayout();
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Teal;
            lblDni.ForeColor = SystemColors.ButtonHighlight;
            lblDni.Location = new Point(51, 51);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(51, 107);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = SystemColors.ButtonHighlight;
            lblApellido.Location = new Point(51, 162);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(159, 43);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(198, 23);
            txtDni.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(159, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(159, 154);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(198, 23);
            txtApellido.TabIndex = 5;
            // 
            // btnAltaSocio
            // 
            btnAltaSocio.BackColor = Color.DarkSlateGray;
            btnAltaSocio.ForeColor = SystemColors.ButtonHighlight;
            btnAltaSocio.Location = new Point(159, 217);
            btnAltaSocio.Name = "btnAltaSocio";
            btnAltaSocio.Size = new Size(75, 43);
            btnAltaSocio.TabIndex = 6;
            btnAltaSocio.Text = "Alta Socio";
            btnAltaSocio.UseVisualStyleBackColor = false;
            btnAltaSocio.Click += btnAltaSocio_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkSlateGray;
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(282, 217);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 43);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblAsterisco1
            // 
            lblAsterisco1.AutoSize = true;
            lblAsterisco1.Font = new Font("Segoe UI", 14F);
            lblAsterisco1.ForeColor = Color.Orange;
            lblAsterisco1.Location = new Point(363, 46);
            lblAsterisco1.Name = "lblAsterisco1";
            lblAsterisco1.Size = new Size(20, 25);
            lblAsterisco1.TabIndex = 8;
            lblAsterisco1.Text = "*";
            // 
            // lblAsterisco2
            // 
            lblAsterisco2.AutoSize = true;
            lblAsterisco2.Font = new Font("Segoe UI", 14F);
            lblAsterisco2.ForeColor = Color.Orange;
            lblAsterisco2.Location = new Point(363, 99);
            lblAsterisco2.Name = "lblAsterisco2";
            lblAsterisco2.Size = new Size(20, 25);
            lblAsterisco2.TabIndex = 9;
            lblAsterisco2.Text = "*";
            // 
            // lblAsterisco3
            // 
            lblAsterisco3.AutoSize = true;
            lblAsterisco3.Font = new Font("Segoe UI", 14F);
            lblAsterisco3.ForeColor = Color.Orange;
            lblAsterisco3.Location = new Point(363, 154);
            lblAsterisco3.Name = "lblAsterisco3";
            lblAsterisco3.Size = new Size(20, 25);
            lblAsterisco3.TabIndex = 10;
            lblAsterisco3.Text = "*";
            // 
            // frmAltaSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(434, 296);
            Controls.Add(lblAsterisco3);
            Controls.Add(lblAsterisco2);
            Controls.Add(lblAsterisco1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAltaSocio);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDni);
            Name = "frmAltaSocio";
            Text = "Alta Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDni;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnAltaSocio;
        private Button btnLimpiar;
        private Label lblAsterisco1;
        private Label lblAsterisco2;
        private Label lblAsterisco3;
    }
}