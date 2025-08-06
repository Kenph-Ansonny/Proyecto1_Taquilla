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
    public partial class vistaCine : Form
    {
        int codigoAplicacion = 2030;
        BitacoraControlador bitacoraAuditoria = new BitacoraControlador();

        public vistaCine()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cine nuevoCine = new Cine
            {
                ID_Cine = int.Parse(txbIDCine.Text),
                Nombre = txbNombre.Text,
                ID_plaza = int.Parse(txbID_plaza.Text),
                Cantidad_de_Salas = int.Parse(txbCantSalas.Text)
            };

            CineController controlador = new CineController();
            controlador.InsertarCine(nuevoCine);
            CargarDatos();
            LimpiarCampos();

            // Registrar acción en bitácora
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "INS");
        }

        private void dgvCine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCine.Rows[e.RowIndex];
                txbIDCine.Text = fila.Cells["ID_Cine"].Value.ToString();
                txbNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txbID_plaza.Text = fila.Cells["ID_plaza"].Value.ToString();
                txbCantSalas.Text = fila.Cells["Cantidad_de_Salas"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txbIDCine.Clear();
            txbNombre.Clear();
            txbID_plaza.Clear();
            txbCantSalas.Clear();
        }

        private void vistaCine_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            CineController controlador = new CineController();
            List<Cine> listaCines = controlador.ObtenerTodosLosCines();
            dgvCine.DataSource = listaCines;
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {
        }

        private void labelPlaza_Click(object sender, EventArgs e)
        {
        }

        private void txbIDCine_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbID_plaza_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbCantSalas_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CineController controlador = new CineController();
            Cine cineModificar = new Cine
            {
                ID_Cine = int.Parse(txbIDCine.Text),
                Nombre = txbNombre.Text,
                ID_plaza = int.Parse(txbID_plaza.Text),
                Cantidad_de_Salas = int.Parse(txbCantSalas.Text)
            };

            controlador.ActualizarCine(cineModificar.ID_Cine, cineModificar.Nombre, cineModificar.ID_plaza, cineModificar.Cantidad_de_Salas);
            CargarDatos();
            LimpiarCampos();

            // Registrar acción en bitácora
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "UPD");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbIDCine.Text, out int idCine))
            {
                CineController controlador = new CineController();
                controlador.EliminarCine(idCine);
                CargarDatos();
                LimpiarCampos();

                // Registrar acción en bitácora
                bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "DEL");
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un ID válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}