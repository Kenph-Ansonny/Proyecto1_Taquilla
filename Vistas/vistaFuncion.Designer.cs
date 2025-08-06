namespace Proyecto_Taquilla.Vistas
{
    partial class vistaFuncion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAgregar;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbID_funcion = new Label();
            txbIDFuncion = new TextBox();
            txbHorario = new TextBox();
            lbHorario = new Label();
            lbFecha = new Label();
            txbFecha = new TextBox();
            lbPelicula = new Label();
            cbxPelicula = new ComboBox();
            lbCantidadBoleto = new Label();
            txbCantBoletos = new TextBox();
            lbSalaCine = new Label();
            cbxSalaCine = new ComboBox();
            lbIdioma = new Label();
            cbxIdioma = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            lbFunciones = new Label();
            Agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbID_funcion
            // 
            lbID_funcion.AutoSize = true;
            lbID_funcion.Location = new Point(119, 9);
            lbID_funcion.Name = "lbID_funcion";
            lbID_funcion.Size = new Size(99, 25);
            lbID_funcion.TabIndex = 0;
            lbID_funcion.Text = "ID_Funcion";
            lbID_funcion.Click += label1_Click;
            // 
            // txbIDFuncion
            // 
            txbIDFuncion.Location = new Point(75, 37);
            txbIDFuncion.Name = "txbIDFuncion";
            txbIDFuncion.Size = new Size(182, 31);
            txbIDFuncion.TabIndex = 1;
            txbIDFuncion.TextChanged += txbIDFuncion_TextChanged;
            // 
            // txbHorario
            // 
            txbHorario.Location = new Point(365, 37);
            txbHorario.Name = "txbHorario";
            txbHorario.Size = new Size(182, 31);
            txbHorario.TabIndex = 2;
            txbHorario.TextChanged += txbHorario_TextChanged;
            // 
            // lbHorario
            // 
            lbHorario.AutoSize = true;
            lbHorario.Location = new Point(422, 9);
            lbHorario.Name = "lbHorario";
            lbHorario.Size = new Size(72, 25);
            lbHorario.TabIndex = 3;
            lbHorario.Text = "Horario";
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Location = new Point(139, 102);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(57, 25);
            lbFecha.TabIndex = 4;
            lbFecha.Text = "Fecha";
            // 
            // txbFecha
            // 
            txbFecha.Location = new Point(75, 130);
            txbFecha.Name = "txbFecha";
            txbFecha.Size = new Size(182, 31);
            txbFecha.TabIndex = 5;
            txbFecha.TextChanged += txbFecha_TextChanged;
            // 
            // lbPelicula
            // 
            lbPelicula.AutoSize = true;
            lbPelicula.Location = new Point(259, 405);
            lbPelicula.Name = "lbPelicula";
            lbPelicula.Size = new Size(69, 25);
            lbPelicula.TabIndex = 6;
            lbPelicula.Text = "Pelicula";
            // 
            // cbxPelicula
            // 
            cbxPelicula.FormattingEnabled = true;
            cbxPelicula.Location = new Point(174, 433);
            cbxPelicula.Name = "cbxPelicula";
            cbxPelicula.Size = new Size(239, 33);
            cbxPelicula.TabIndex = 7;
            cbxPelicula.SelectedIndexChanged += cbxPelicula_SelectedIndexChanged;
            // 
            // lbCantidadBoleto
            // 
            lbCantidadBoleto.AutoSize = true;
            lbCantidadBoleto.Location = new Point(383, 102);
            lbCantidadBoleto.Name = "lbCantidadBoleto";
            lbCantidadBoleto.Size = new Size(147, 25);
            lbCantidadBoleto.TabIndex = 8;
            lbCantidadBoleto.Text = "Cantidad Boletos";
            // 
            // txbCantBoletos
            // 
            txbCantBoletos.Location = new Point(365, 130);
            txbCantBoletos.Name = "txbCantBoletos";
            txbCantBoletos.Size = new Size(182, 31);
            txbCantBoletos.TabIndex = 9;
            txbCantBoletos.TextChanged += txbCantBoletos_TextChanged;
            // 
            // lbSalaCine
            // 
            lbSalaCine.AutoSize = true;
            lbSalaCine.Location = new Point(421, 198);
            lbSalaCine.Name = "lbSalaCine";
            lbSalaCine.Size = new Size(83, 25);
            lbSalaCine.TabIndex = 10;
            lbSalaCine.Text = "Sala Cine";
            // 
            // cbxSalaCine
            // 
            cbxSalaCine.FormattingEnabled = true;
            cbxSalaCine.Location = new Point(334, 226);
            cbxSalaCine.Name = "cbxSalaCine";
            cbxSalaCine.Size = new Size(239, 33);
            cbxSalaCine.TabIndex = 11;
            cbxSalaCine.SelectedIndexChanged += cbxSalaCine_SelectedIndexChanged;
            // 
            // lbIdioma
            // 
            lbIdioma.AutoSize = true;
            lbIdioma.Location = new Point(103, 198);
            lbIdioma.Name = "lbIdioma";
            lbIdioma.Size = new Size(68, 25);
            lbIdioma.TabIndex = 12;
            lbIdioma.Text = "Idioma";
            // 
            // cbxIdioma
            // 
            cbxIdioma.FormattingEnabled = true;
            cbxIdioma.Location = new Point(18, 226);
            cbxIdioma.Name = "cbxIdioma";
            cbxIdioma.Size = new Size(239, 33);
            cbxIdioma.TabIndex = 13;
            cbxIdioma.SelectedIndexChanged += cbxIdioma_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(948, 152);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 17;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1491, 152);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 18;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(640, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1008, 396);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbFunciones
            // 
            lbFunciones.AutoSize = true;
            lbFunciones.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFunciones.Location = new Point(948, 37);
            lbFunciones.Name = "lbFunciones";
            lbFunciones.Size = new Size(418, 54);
            lbFunciones.TabIndex = 20;
            lbFunciones.Text = "Administrar Funciones";
            // 
            // Agregar
            // 
            Agregar.Location = new Point(788, 152);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(112, 34);
            Agregar.TabIndex = 21;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // vistaFuncion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1660, 615);
            Controls.Add(Agregar);
            Controls.Add(lbFunciones);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(cbxIdioma);
            Controls.Add(lbIdioma);
            Controls.Add(cbxSalaCine);
            Controls.Add(lbSalaCine);
            Controls.Add(txbCantBoletos);
            Controls.Add(lbCantidadBoleto);
            Controls.Add(cbxPelicula);
            Controls.Add(lbPelicula);
            Controls.Add(txbFecha);
            Controls.Add(lbFecha);
            Controls.Add(lbHorario);
            Controls.Add(txbHorario);
            Controls.Add(txbIDFuncion);
            Controls.Add(lbID_funcion);
            Name = "vistaFuncion";
            Text = "vistaFuncion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID_funcion;
        private TextBox txbIDFuncion;
        private TextBox txbHorario;
        private Label lbHorario;
        private Label lbFecha;
        private TextBox txbFecha;
        private Label lbPelicula;
        private ComboBox cbxPelicula;
        private Label lbCantidadBoleto;
        private TextBox txbCantBoletos;
        private Label lbSalaCine;
        private ComboBox cbxSalaCine;
        private Label lbIdioma;
        private ComboBox cbxIdioma;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label lbFunciones;
        private Button Agregar;
    }
}