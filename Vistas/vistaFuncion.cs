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
    public partial class vistaFuncion : Form
    {
        int codigoAplicacion = 2040; // Suponiendo código 2040 para funciones
        BitacoraControlador bitacoraAuditoria = new BitacoraControlador();

        public vistaFuncion()
        {
            InitializeComponent();
            CargarDatos();
            CargarCombos();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void txbIDFuncion_TextChanged(object sender, EventArgs e) { }

        private void txbHorario_TextChanged(object sender, EventArgs e) { }

        private void txbFecha_TextChanged(object sender, EventArgs e) { }

        private void txbCantBoletos_TextChanged(object sender, EventArgs e) { }

        private void cbxIdioma_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cbxProyeccion_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cbxPelicula_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cbxSalaCine_SelectedIndexChanged(object sender, EventArgs e) { }
        private void CargarCombos()
        {
            cbxIdioma.DataSource = CatalogoDAO.ObtenerIdiomas();
            cbxIdioma.DisplayMember = "Descripcion";
            cbxIdioma.ValueMember = "ID_Idioma";

            cbxProyeccion.DataSource = CatalogoDAO.ObtenerProyecciones();
            cbxProyeccion.DisplayMember = "Tipo_de_proyeccion";
            cbxProyeccion.ValueMember = "ID_Proyeccion";

            cbxPelicula.DataSource = CatalogoDAO.ObtenerPeliculas();
            cbxPelicula.DisplayMember = "Nombre";
            cbxPelicula.ValueMember = "id_pelicula";

            cbxSalaCine.DataSource = CatalogoDAO.ObtenerSalas();
            cbxSalaCine.DisplayMember = "No_Sala";
            cbxSalaCine.ValueMember = "ID_SALA_DE_CINE";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txbIDFuncion.Text = fila.Cells["ID_Funcion"].Value.ToString();
                txbHorario.Text = fila.Cells["Horario"].Value.ToString();
                txbFecha.Text = fila.Cells["Fecha"].Value.ToString();
                txbCantBoletos.Text = fila.Cells["Cantidad_Boletos"].Value.ToString();
                cbxIdioma.Text = fila.Cells["Idioma"].Value.ToString();
                cbxProyeccion.Text = fila.Cells["Tipo_Proyeccion"].Value.ToString();
                cbxPelicula.SelectedValue = fila.Cells["ID_Pelicula"].Value;
                cbxSalaCine.SelectedValue = fila.Cells["ID_SalaCine"].Value;
            }
        }

        private void CargarDatos()
        {
            FuncionControlador controlador = new FuncionControlador();
            List<Funcion> listaFunciones = controlador.ObtenerTodosFunciones();
            dataGridView1.DataSource = listaFunciones;
        }

        private void LimpiarCampos()
        {
            txbIDFuncion.Clear();
            txbHorario.Clear();
            txbFecha.Clear();
            txbCantBoletos.Clear();
            cbxIdioma.SelectedIndex = -1;
            cbxProyeccion.SelectedIndex = -1;
            cbxPelicula.SelectedIndex = -1;
            cbxSalaCine.SelectedIndex = -1;
        }

        // Agregar
        private void Agregar_Click(object sender, EventArgs e)
        {
            Funcion nuevaFuncion = new Funcion
            {
                ID_Funcion = int.Parse(txbIDFuncion.Text),
                Horario = txbHorario.Text,
                Fecha = DateTime.Parse(txbFecha.Text),
                Cantidad_Boletos = int.Parse(txbCantBoletos.Text),
                ID_Idioma = Convert.ToInt32(cbxIdioma.SelectedValue),
                ID_Proyeccion = Convert.ToInt32(cbxProyeccion.SelectedValue),
                ID_Pelicula = Convert.ToInt32(cbxPelicula.SelectedValue),
                ID_SALA_DE_CINE = Convert.ToInt32(cbxSalaCine.SelectedValue)
            };

            FuncionControlador controlador = new FuncionControlador();
            controlador.InsertarFuncion(nuevaFuncion);
            CargarDatos();
            LimpiarCampos();
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "INS");
        }


        // Actualizar
        private void button2_Click(object sender, EventArgs e)
        {
            Funcion funcionActualizar = new Funcion
            {
                ID_Funcion = int.Parse(txbIDFuncion.Text),
                Horario = txbHorario.Text,
                Fecha = DateTime.Parse(txbFecha.Text),
                Cantidad_Boletos = int.Parse(txbCantBoletos.Text),
                ID_Idioma = Convert.ToInt32(cbxIdioma.SelectedValue),
                ID_Proyeccion = Convert.ToInt32(cbxProyeccion.SelectedValue),
                ID_Pelicula = Convert.ToInt32(cbxPelicula.SelectedValue),
                ID_SALA_DE_CINE = Convert.ToInt32(cbxSalaCine.SelectedValue)
            };

            FuncionControlador controlador = new FuncionControlador();
            controlador.ActualizarFuncion(funcionActualizar);
            CargarDatos();
            LimpiarCampos();
            bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "UPD");
        }


        // Eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbIDFuncion.Text, out int idFuncion))
            {
                FuncionControlador controlador = new FuncionControlador();
                controlador.EliminarFuncion(idFuncion);
                CargarDatos();
                LimpiarCampos();
                bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "DEL");
            }
            else
            {
                MessageBox.Show("Por favor introduzca un ID válido", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
