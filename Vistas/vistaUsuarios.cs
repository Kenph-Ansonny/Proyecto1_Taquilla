using Proyecto_Taquilla.Controlador;
using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaquillaPeliculas.Controlador;



namespace Proyecto_Taquilla.Vistas
{
    public partial class vistaUsuarios : Form
    {
        //codigo aplicacion y objeto bitacoraAuditoria para registrar acciones del sistema en auditoria
        int codigoAplicacion = 2010; //codigo de aplicacion "Usuario"
        BitacoraControlador bitacoraAuditoria = new BitacoraControlador();


        private UsuarioController controller = new UsuarioController();
        public vistaUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            List<Usuario> lista = controller.CargarUsuarios();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = lista;
        }

        private void LimpiarCampos()
        {
            txtIdUsuario.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdUsuario.Text, out int id))
            {
                MessageBox.Show("ID invalido.");
                return;
            }

            string nombre = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            int? idClienteNuevo = null;
            int? idEmpleadoNuevo = null;
            bool identificadorNuevo = false;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            controller.AgregarUsuario(id, nombre, contraseña, idClienteNuevo, idEmpleadoNuevo, identificadorNuevo);
            CargarUsuarios();
            LimpiarCampos();

            // Registrar acción en bitacora de insertar "insert"
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "INS");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdUsuario.Text, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            string nombre = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            int? idClienteNuevo = null;
            int? idEmpleadoNuevo = null;
            bool identificadorNuevo = false; // o true, según tu lógica


            controller.ActualizarUsuario(id, nombre, contraseña, idClienteNuevo, idEmpleadoNuevo, identificadorNuevo);
            CargarUsuarios();
            LimpiarCampos();

            //registrar acción en bitacora de actualidar "update"
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "UPD");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdUsuario.Text, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            var confirm = MessageBox.Show("¿Eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                controller.EliminarUsuario(id);
                CargarUsuarios();
                LimpiarCampos();
            }

            //registrar acción en bitacora de eliminar "delete"
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "DEL");
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                Usuario seleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                txtIdUsuario.Text = seleccionado.Id_usuario.ToString();
                txtUsuario.Text = seleccionado.UsuarioNombre;
                txtContraseña.Text = seleccionado.Contraseña;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
