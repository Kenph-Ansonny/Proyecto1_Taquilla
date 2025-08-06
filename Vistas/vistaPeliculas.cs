using MySql.Data.MySqlClient;
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
//cambiar despues en el datagriuv la columna de clasificacion como = Clasificacion(G, PG, PG-13, R, NC-17)
namespace Proyecto_Taquilla.Vistas
{
    public partial class vistaPeliculas : Form
    {
        int codigoAplicacion = 2020;
        BitacoraControlador bitacoraAuditoria = new BitacoraControlador();
        private PeliculaController controller = new PeliculaController();

        public vistaPeliculas()
        {
            InitializeComponent();
            CargarGeneros();
            CargarClasificaciones();
            CargarPeliculas();
        }

        private void vistaPeliculas_Load(object sender, EventArgs e) { }

        private void CargarPeliculas()
        {
            var peliculas = controller.ObtenerTodasLasPeliculas();

            dgvPeliculas.DataSource = null;
            dgvPeliculas.DataSource = peliculas;

            // Ocultar columnas internas
            if (dgvPeliculas.Columns.Contains("Id_Genero"))
                dgvPeliculas.Columns["Id_Genero"].Visible = false;

            if (dgvPeliculas.Columns.Contains("Id_Clasificacion"))
                dgvPeliculas.Columns["Id_Clasificacion"].Visible = false;

            // Renombrar encabezados visibles
            if (dgvPeliculas.Columns.Contains("Nombre_Genero"))
                dgvPeliculas.Columns["Nombre_Genero"].HeaderText = "Género";

            if (dgvPeliculas.Columns.Contains("Nombre_Clasificacion"))
                dgvPeliculas.Columns["Nombre_Clasificacion"].HeaderText = "Clasificación";
        }



        private void dgvPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPeliculas.CurrentRow != null)
            {
                Pelicula seleccionada = (Pelicula)dgvPeliculas.CurrentRow.DataBoundItem;
                txtIdPelicula.Text = seleccionada.Id_Pelicula.ToString();
                txtNombre.Text = seleccionada.Nombre;
                txtDescripcion.Text = seleccionada.Sinopsis;

                cbxGenero.SelectedValue = seleccionada.Id_Genero;
                cbxClasificacion.SelectedValue = seleccionada.Id_Clasificacion;
            }
        }

        private void CargarGeneros()
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                string sql = "SELECT ID_Genero, Nombre_Genero FROM Genero";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<int, string> generos = new Dictionary<int, string>();
                while (reader.Read())
                {
                    generos.Add(reader.GetInt32("ID_Genero"), reader.GetString("Nombre_Genero"));
                }

                cbxGenero.DataSource = new BindingSource(generos, null);
                cbxGenero.DisplayMember = "Value";
                cbxGenero.ValueMember = "Key";
            }
        }

        private void CargarClasificaciones()
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                string sql = "SELECT ID_Clasificacion, Descripcion FROM Clasificacion_Edad";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<int, string> clasificaciones = new Dictionary<int, string>();
                while (reader.Read())
                {
                    clasificaciones.Add(reader.GetInt32("ID_Clasificacion"), reader.GetString("Descripcion"));
                }

                cbxClasificacion.DataSource = new BindingSource(clasificaciones, null);
                cbxClasificacion.DisplayMember = "Value";
                cbxClasificacion.ValueMember = "Key";
            }
        }

        private void LimpiarCampos()
        {
            txtIdPelicula.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdPelicula.Text, out int id))
            {
                MessageBox.Show("El ID de la película debe ser un número.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string sinopsis = txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre de la película es obligatorio.");
                return;
            }

            int idGenero = ((KeyValuePair<int, string>)cbxGenero.SelectedItem).Key;
            int idClasificacion = ((KeyValuePair<int, string>)cbxClasificacion.SelectedItem).Key;

            controller.CrearPelicula(id, nombre, sinopsis, idGenero, idClasificacion);
            CargarPeliculas();
            LimpiarCampos();
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
            string sinopsis = txtDescripcion.Text.Trim();  // ← aquí defines la variable sinopsis

            int idGenero = ((KeyValuePair<int, string>)cbxGenero.SelectedItem).Key;
            int idClasificacion = ((KeyValuePair<int, string>)cbxClasificacion.SelectedItem).Key;

            controller.ActualizarPelicula(id, nuevoNombre, sinopsis, idGenero, idClasificacion);
            CargarPeliculas();
            LimpiarCampos();
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
                bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "DEL");
            }
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void cbxGenero_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbxClasificacion_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
