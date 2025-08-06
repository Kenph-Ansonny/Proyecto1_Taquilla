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

//cesar armando estrada elias 0901-22-10153
namespace Proyecto_Taquilla.Vistas
{
    public partial class vistaFuncion : Form
    {
        int codigoAplicacion = 2040;
        BitacoraControlador bitacoraAuditoria = new BitacoraControlador();

        public vistaFuncion()
        {
            InitializeComponent();
            CargarCombos();
            CargarDatos();
        }

        // Cargar ComboBoxes desde DAO personalizado
        private void CargarCombos()
        {
            cbxIdioma.DataSource = ComboboxFuncionDAO.ObtenerIdiomas();
            cbxIdioma.DisplayMember = "Descripcion";
            cbxIdioma.ValueMember = "ID_Idioma";
            cbxIdioma.SelectedIndex = -1;

            cbxPelicula.DataSource = ComboboxFuncionDAO.ObtenerPeliculas();
            cbxPelicula.DisplayMember = "Nombre";
            cbxPelicula.ValueMember = "ID_Pelicula";
            cbxPelicula.SelectedIndex = -1;

            cbxSalaCine.DataSource = ComboboxFuncionDAO.ObtenerSalas();
            cbxSalaCine.DisplayMember = "No_Sala";
            cbxSalaCine.ValueMember = "ID_SALA_DE_CINE";
            cbxSalaCine.SelectedIndex = -1;
        }

        // Mostrar funciones en DataGridView
        private void CargarDatos()
        {
            FuncionControlador controlador = new FuncionControlador();
            List<Funcion> listaFunciones = controlador.ObtenerTodosFunciones();

            var datosParaMostrar = listaFunciones.Select(f => new
            {
                f.ID_Funcion,
                f.Horario,
                Fecha = f.Fecha.ToString("dd/MM/yyyy"),
                f.Cantidad_Boletos,
                Pelicula = f.Nombre_Pelicula,
                Sala = f.No_Sala,
                Idioma = f.Descripcion_Idioma
            }).ToList();

            dataGridView1.DataSource = datosParaMostrar;
        }

        // Llenar campos al seleccionar fila
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txbIDFuncion.Text = fila.Cells["ID_Funcion"].Value.ToString();
                txbHorario.Text = fila.Cells["Horario"].Value.ToString();
                txbFecha.Text = fila.Cells["Fecha"].Value.ToString();
                txbCantBoletos.Text = fila.Cells["Cantidad_Boletos"].Value.ToString();

                // Selección en ComboBoxes
                cbxIdioma.Text = fila.Cells["Idioma"].Value.ToString();
                cbxPelicula.Text = fila.Cells["Pelicula"].Value.ToString();
                cbxSalaCine.Text = fila.Cells["Sala"].Value.ToString();
            }
        }

        // Limpiar campos del formulario
        private void LimpiarCampos()
        {
            txbIDFuncion.Clear();
            txbHorario.Clear();
            txbFecha.Clear();
            txbCantBoletos.Clear();

            cbxIdioma.SelectedIndex = -1;
            cbxPelicula.SelectedIndex = -1;
            cbxSalaCine.SelectedIndex = -1;
        }

        // Botón: Agregar
        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcion nuevaFuncion = new Funcion
                {
                    ID_Funcion = int.Parse(txbIDFuncion.Text),
                    Horario = txbHorario.Text,
                    Fecha = DateTime.Parse(txbFecha.Text),
                    Cantidad_Boletos = int.Parse(txbCantBoletos.Text),
                    ID_Idioma = Convert.ToInt32(cbxIdioma.SelectedValue),
                    ID_Pelicula = Convert.ToInt32(cbxPelicula.SelectedValue),
                    ID_Sala = Convert.ToInt32(cbxSalaCine.SelectedValue)
                };

                FuncionControlador controlador = new FuncionControlador();
                controlador.InsertarFuncion(nuevaFuncion);
                CargarDatos();
                LimpiarCampos();
                bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "INS");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la función: " + ex.Message);
            }
        }

        // Botón: Actualizar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Funcion funcionActualizar = new Funcion
                {
                    ID_Funcion = int.Parse(txbIDFuncion.Text),
                    Horario = txbHorario.Text,
                    Fecha = DateTime.Parse(txbFecha.Text),
                    Cantidad_Boletos = int.Parse(txbCantBoletos.Text),
                    ID_Idioma = Convert.ToInt32(cbxIdioma.SelectedValue),
                    ID_Pelicula = Convert.ToInt32(cbxPelicula.SelectedValue),
                    ID_Sala = Convert.ToInt32(cbxSalaCine.SelectedValue)
                };

                FuncionControlador controlador = new FuncionControlador();
                controlador.ActualizarFuncion(funcionActualizar);
                CargarDatos();
                LimpiarCampos();
                bitacoraAuditoria.InsertBitacora(usuarioConectadoControlador.IdUsuario, codigoAplicacion, "UPD");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la función: " + ex.Message);
            }
        }

        // Botón: Eliminar
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
                MessageBox.Show("Por favor, introduzca un ID válido", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Eventos vacíos (pueden eliminarse si no se usan)
        private void label1_Click(object sender, EventArgs e) { }
        private void txbIDFuncion_TextChanged(object sender, EventArgs e) { }
        private void txbHorario_TextChanged(object sender, EventArgs e) { }
        private void txbFecha_TextChanged(object sender, EventArgs e) { }
        private void txbCantBoletos_TextChanged(object sender, EventArgs e) { }
        private void cbxIdioma_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbxPelicula_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbxSalaCine_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
