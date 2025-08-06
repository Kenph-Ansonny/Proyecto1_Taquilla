using Proyecto_Taquilla.Vistas;
using System.Diagnostics;

namespace Prototipo_Taquilla_Cliente
{
    public partial class vistaMDIGeneral : Form
    {
        public vistaMDIGeneral()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //Se utiliza como un botón que cambia de color al pasar el mouse
        Panel panelMouse = new Panel();
        private void btnMouseEntrada(object sender, EventArgs e)
        {
            Button btn = sender as Button; //Boton que lo esta invocando
            panelMenu.Controls.Add(panelMouse); //Agrega el panel al menu
            panelMouse.BackColor = Color.FromArgb(90, 120, 2);
            panelMouse.Size = new Size(198, 5);
            panelMouse.Location = new Point(btn.Location.X, btn.Location.Y + 40); //Posiciona la linea debajo del boton
        }

        //Remove el color sobre el panel
        private void btnMouseSalida(object sender, EventArgs e)
        {
            panelMenu.Controls.Remove(panelMouse); //Remueve el panel del menu
        }

        //boton para salir
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea cerrar sesion?", "Confirmar cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //regresa al login
                vistaLogin login = new vistaLogin();
                login.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panelServicios.Visible)
                panelServicios.Visible = true; //Muestra el panel de servicios
            else
                panelServicios.Visible = false; //Oculta el panel de servicios
        }

        private void panelServicios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panelServicio4.Visible)
                panelServicio4.Visible = true; //Muestra el panel de servicios
            else
                panelServicio4.Visible = false; //Oculta el panel de servicios
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vistaPeliculas ventanaPeliculas = new vistaPeliculas();
            ventanaPeliculas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vistaUsuarios ventanaUsuarios = new vistaUsuarios();
            ventanaUsuarios.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vistaCine ventanaCine = new vistaCine();
            ventanaCine.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vistaBitacora ventanaBitacora = new vistaBitacora();
            ventanaBitacora.Show();
        }

        private void btnFuncion_Click(object sender, EventArgs e)
        {
            vistaFuncion ventanaFuncion = new vistaFuncion();
            ventanaFuncion.Show();
        }

        private void btnReportePeliculaTaquilla_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta relativa desde bin/Debug o bin/Release de Vista/
                string rutaVisor = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "visor_ReportesPrograma", "VisorReportes.exe");

                // Normalizar ruta completa
                string rutaFinal = Path.GetFullPath(rutaVisor);

                if (File.Exists(rutaFinal))
                {
                    Process.Start(rutaFinal);
                }
                else
                {
                    MessageBox.Show("No se encontró el visor de reportes en:\n" + rutaFinal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el visor:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtReporte_Click(object sender, EventArgs e)
        {
            if (!pnlReportes.Visible)
                pnlReportes.Visible = true; //Muestra el panel de servicios
            else
                pnlReportes.Visible = false; //Oculta el panel de servicios
        }
    }
}
