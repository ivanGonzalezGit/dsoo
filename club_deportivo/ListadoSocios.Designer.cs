namespace Club_deportivo_EV
{
    partial class frmListadoSocios
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
            btnCerrar = new Button();
            dtgvListadoSocios = new DataGridView();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvListadoSocios).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.DarkSlateGray;
            btnCerrar.ForeColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(340, 360);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dtgvListadoSocios
            // 
            dtgvListadoSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListadoSocios.Columns.AddRange(new DataGridViewColumn[] { dni, nombre, apellido });
            dtgvListadoSocios.Location = new Point(44, 27);
            dtgvListadoSocios.Name = "dtgvListadoSocios";
            dtgvListadoSocios.Size = new Size(343, 314);
            dtgvListadoSocios.TabIndex = 2;
            // 
            // dni
            // 
            dni.HeaderText = "N° DNI";
            dni.Name = "dni";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // frmListadoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(434, 461);
            Controls.Add(dtgvListadoSocios);
            Controls.Add(btnCerrar);
            Name = "frmListadoSocios";
            Text = "Listado de Socios";
            Load += frmListadoSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvListadoSocios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrar;
        private DataGridView dtgvListadoSocios;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
    }
}