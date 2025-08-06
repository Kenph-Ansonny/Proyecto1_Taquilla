namespace Proyecto_Taquilla.Vistas
{
    partial class vistaPeliculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            dgvPeliculas = new DataGridView();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtIdPelicula = new TextBox();
            btnLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Generolb = new Label();
            label6 = new Label();
            cbxGenero = new ComboBox();
            cbxClasificacion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(571, 28);
            dgvPeliculas.Margin = new Padding(4);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.ReadOnly = true;
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.Size = new Size(816, 558);
            dgvPeliculas.TabIndex = 0;
            dgvPeliculas.SelectionChanged += dgvPeliculas_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(55, 241);
            txtNombre.Margin = new Padding(4);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 33);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(55, 343);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(476, 31);
            txtDescripcion.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Times New Roman", 12F);
            btnAgregar.Location = new Point(571, 598);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 36);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Times New Roman", 12F);
            btnEditar.Location = new Point(737, 598);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 36);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Times New Roman", 12F);
            btnEliminar.Location = new Point(1269, 598);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 36);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // txtIdPelicula
            // 
            txtIdPelicula.Location = new Point(55, 135);
            txtIdPelicula.Margin = new Padding(4);
            txtIdPelicula.Name = "txtIdPelicula";
            txtIdPelicula.Size = new Size(155, 31);
            txtIdPelicula.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Times New Roman", 12F);
            btnLimpiar.Location = new Point(189, 598);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(0, 0);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(55, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 26);
            label1.TabIndex = 15;
            label1.Text = "Id Pelicula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(55, 198);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 26);
            label2.TabIndex = 16;
            label2.Text = "Peliculas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(55, 310);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 26);
            label3.TabIndex = 17;
            label3.Text = "Sinopsis";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(116, 28);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(285, 41);
            label4.TabIndex = 18;
            label4.Text = "CRUD - Peliculas";
            // 
            // Generolb
            // 
            Generolb.AutoSize = true;
            Generolb.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Generolb.Location = new Point(55, 426);
            Generolb.Name = "Generolb";
            Generolb.Size = new Size(88, 26);
            Generolb.TabIndex = 19;
            Generolb.Text = "Genero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(290, 426);
            label6.Name = "label6";
            label6.Size = new Size(144, 26);
            label6.TabIndex = 20;
            label6.Text = "Clasificacion";
            // 
            // cbxGenero
            // 
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Location = new Point(53, 466);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(182, 33);
            cbxGenero.TabIndex = 21;
            cbxGenero.SelectedIndexChanged += cbxGenero_SelectedIndexChanged;
            // 
            // cbxClasificacion
            // 
            cbxClasificacion.FormattingEnabled = true;
            cbxClasificacion.Location = new Point(290, 466);
            cbxClasificacion.Name = "cbxClasificacion";
            cbxClasificacion.Size = new Size(241, 33);
            cbxClasificacion.TabIndex = 22;
            cbxClasificacion.SelectedIndexChanged += cbxClasificacion_SelectedIndexChanged;
            // 
            // vistaPeliculas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 657);
            Controls.Add(cbxClasificacion);
            Controls.Add(cbxGenero);
            Controls.Add(label6);
            Controls.Add(Generolb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(txtIdPelicula);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(dgvPeliculas);
            Margin = new Padding(4);
            Name = "vistaPeliculas";
            Text = "vistaPeliculas";
            Load += vistaPeliculas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPeliculas;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtIdPelicula;
        private Button btnLimpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Generolb;
        private Label label6;
        private ComboBox cbxGenero;
        private ComboBox cbxClasificacion;
    }
}