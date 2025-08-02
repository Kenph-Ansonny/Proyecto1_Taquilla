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
        //codigo para registrar en bitacora la el CRUD de cine para registrar acciones en el sistema de auditoria
        //2030 para cine
        //2010 usuario
        //2020 peliculas
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
                ID_plaza = int.Parse(txbID_plaza.Text)
            };
            CineController controlador= new CineController();
            controlador.InsertarCine(nuevoCine);
            CargarDatos();
            LimpiarCampos();
            //registra acciones en bitacora de agregar
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "INS");
        }

        private void dgvCine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow fila = dgvCine.Rows[e.RowIndex];
                txbIDCine.Text = fila.Cells["IdCine"].Value.ToString();
                txbNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txbID_plaza.Text = fila.Cells["IdPlaza"].Value.ToString();
            }
        }
        private void LimpiarCampos()
        {
            txbIDCine.Clear();
            txbNombre.Clear();
            txbID_plaza.Clear();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CineController CineController = new CineController();
            Cine cineModificar = new Cine()
            {
                ID_Cine = int.Parse(txbIDCine.Text),
                Nombre = txbNombre.Text,
                ID_plaza = int.Parse(txbID_plaza.Text)
            };
           CineController.ActualizarCine(cineModificar.ID_Cine, cineModificar.Nombre, cineModificar.ID_plaza);
            CargarDatos();
            LimpiarCampos();
            //registra acciones en bitacora de actualizar
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "UPD");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbIDCine.Text, out int idCine))
            {
                CineDAO.EliminarCine(idCine);
                CargarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Porfavor introduzca un ID valido ", "Entrada invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //registra acciones en bitacora de eliminar
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "DEL");
        }
    }
}
