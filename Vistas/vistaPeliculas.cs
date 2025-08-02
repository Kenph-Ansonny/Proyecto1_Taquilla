using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Taquilla.Controlador;
using Proyecto_Taquilla.Modelo;


namespace Proyecto_Taquilla.Vistas
{
    public partial class vistaPeliculas : Form
    {
        //codigo para registrar en bitacora la el CRUD de cine para registrar acciones en el sistema de auditoria
        //2030 para cine
        //2010 usuario
        //2020 peliculas
        int codigoAplicacion = 2020;
        BitacoraControlador bitacoraAuditoria = new BitacoraControlador();

        private PeliculaController controller = new PeliculaController();
        public vistaPeliculas()
        {
            InitializeComponent();
            CargarPeliculas();
        }

        private void CargarPeliculas()
        {
            List<Pelicula> lista = controller.ObtenerTodasLasPeliculas();
            dgvPeliculas.DataSource = null;
            dgvPeliculas.DataSource = lista;
        }

        private void dgvPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPeliculas.CurrentRow != null)
            {
                Pelicula seleccionada = (Pelicula)dgvPeliculas.CurrentRow.DataBoundItem;
                txtIdPelicula.Text = seleccionada.Id_Pelicula.ToString();
                txtNombre.Text = seleccionada.Nombre_Pelicula;
                txtDescripcion.Text = seleccionada.Descripcion;
            }
        }

        private void LimpiarCampos()
        {
            txtIdPelicula.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        private void vistaPeliculas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdPelicula.Text, out int id))
            {
                MessageBox.Show("El ID de la película debe ser un número.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre de la película es obligatorio.");
                return;
            }
            controller.CrearPelicula(id, nombre, descripcion);
            CargarPeliculas();
            LimpiarCampos();
            //registra acciones en bitacora de agregar
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "INS");
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdPelicula.Text, out int id))
            {
                MessageBox.Show("ID inválido para edición.");
                return;
            }

            string nuevoNombre = txtNombre.Text.Trim();
            string nuevaDescripcion = txtDescripcion.Text.Trim();

            controller.ActualizarPelicula(id, nuevoNombre, nuevaDescripcion);
            CargarPeliculas();
            LimpiarCampos();
            //registra acciones en bitacora de actualizar
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "UPD");
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdPelicula.Text, out int id))
            {
                MessageBox.Show("ID inválido para eliminación.");
                return;
            }

            var confirm = MessageBox.Show("¿Eliminar la película con ese ID?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                controller.EliminarPelicula(id);
                CargarPeliculas();
                LimpiarCampos();
            }
            //registra acciones en bitacora de eliminar
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "DEL");
        }
    } 
}

