namespace Club_deportivo_EV
{
    partial class frmListadoMorosos
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
            dtgvListadoMorosos = new DataGridView();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvListadoMorosos).BeginInit();
            SuspendLayout();
            // 
            // dtgvListadoMorosos
            // 
            dtgvListadoMorosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListadoMorosos.Columns.AddRange(new DataGridViewColumn[] { dni, nombre, apellido });
            dtgvListadoMorosos.Location = new Point(47, 27);
            dtgvListadoMorosos.Name = "dtgvListadoMorosos";
            dtgvListadoMorosos.Size = new Size(343, 314);
            dtgvListadoMorosos.TabIndex = 1;
            dtgvListadoMorosos.CellContentClick += dtgvListadoMorosos_CellContentClick;
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
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.DarkSlateGray;
            btnCerrar.ForeColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(315, 382);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmListadoMorosos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(434, 461);
            Controls.Add(btnCerrar);
            Controls.Add(dtgvListadoMorosos);
            Name = "frmListadoMorosos";
            Text = "Listado Morosos";
            Load += frmListadoMorosos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvListadoMorosos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtgvListadoMorosos;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private Button btnCerrar;
    }
}