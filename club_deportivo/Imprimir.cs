using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_deportivo_EV
{
    public partial class frmImprimir : Form
    {
        public frmImprimir()
        {
            InitializeComponent();
        }

        public int cuota;
        public string? dicotomia;
        public string? nombre;
        public string? apellido;
        public DateTime f_pago;
        public DateTime f_vto;
        public DateTime contenidoVTO;
        public float monto;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmImprimir_Load(object sender, EventArgs e)
        {
            lblFTituloDateTime.Text = DateTime.UtcNow.ToShortDateString();
            lblMembreteCuota.Text = dicotomia;
            lblCuota.Text = Convert.ToString(cuota);
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            contenidoVTO = f_vto;
            lblF_vto.Text = contenidoVTO.ToString("dd/MM/yyyy");
            lblMonto.Text = Convert.ToString(monto);
            lblTotalMonto.Text = Convert.ToString(monto);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true; 

            MessageBox.Show("Operaación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
            }

            private void ImprimirForm1(object o, PrintPageEventArgs e)
            {
            btnImprimir.Visible = false;
            btnCerrar.Visible = false;

            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
    
}
