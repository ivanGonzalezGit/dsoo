using System.Data;
using System.Windows.Forms;

namespace Club_deportivo_EV
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Administradores dato =new Datos.Administradores();

            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);

            if (tablaLogin.Rows.Count >0)
            {
                Form principal = new frmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                txtUsuario.Text = "";
                txtPass.Text = "";
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPass.Text = "";
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
