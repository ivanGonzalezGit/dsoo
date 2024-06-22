namespace Club_deportivo_EV
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblUsuario = new Label();
            lblPass = new Label();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnLimpiar = new Button();
            picLogin = new PictureBox();
            lblEjemploUs = new Label();
            lblEjemploPass = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Location = new Point(40, 226);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.ForeColor = SystemColors.ButtonHighlight;
            lblPass.Location = new Point(40, 274);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(67, 15);
            lblPass.TabIndex = 2;
            lblPass.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DarkSlateGray;
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(185, 340);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(130, 218);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(198, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(130, 266);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(198, 23);
            txtPass.TabIndex = 5;
            txtPass.Enter += txtPass_Enter;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkSlateGray;
            btnLimpiar.FlatAppearance.BorderColor = Color.White;
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(185, 380);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // picLogin
            // 
            picLogin.Image = (Image)resources.GetObject("picLogin.Image");
            picLogin.Location = new Point(173, 51);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(120, 92);
            picLogin.TabIndex = 7;
            picLogin.TabStop = false;
            // 
            // lblEjemploUs
            // 
            lblEjemploUs.AutoSize = true;
            lblEjemploUs.ForeColor = SystemColors.ButtonHighlight;
            lblEjemploUs.Location = new Point(357, 221);
            lblEjemploUs.Name = "lblEjemploUs";
            lblEjemploUs.Size = new Size(49, 15);
            lblEjemploUs.TabIndex = 8;
            lblEjemploUs.Text = "(admin)";
            // 
            // lblEjemploPass
            // 
            lblEjemploPass.AutoSize = true;
            lblEjemploPass.ForeColor = SystemColors.ButtonHighlight;
            lblEjemploPass.Location = new Point(357, 269);
            lblEjemploPass.Name = "lblEjemploPass";
            lblEjemploPass.Size = new Size(49, 15);
            lblEjemploPass.TabIndex = 9;
            lblEjemploPass.Text = "(admin)";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(434, 461);
            Controls.Add(lblEjemploPass);
            Controls.Add(lblEjemploUs);
            Controls.Add(picLogin);
            Controls.Add(btnLimpiar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsuario;
        private Label lblPass;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnLimpiar;
        private PictureBox picLogin;
        private Label lblEjemploUs;
        private Label lblEjemploPass;
    }
}
