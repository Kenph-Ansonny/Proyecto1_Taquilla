namespace Proyecto_Taquilla.Vistas
{
    partial class vistaCine
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
            labelCine = new Label();
            txbIDCine = new TextBox();
            labelNombre = new Label();
            txbNombre = new TextBox();
            labelPlaza = new Label();
            txbID_plaza = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvCine = new DataGridView();
            label1 = new Label();
            txbCantSalas = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCine).BeginInit();
            SuspendLayout();
            // 
            // labelCine
            // 
            labelCine.AutoSize = true;
            labelCine.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCine.Location = new Point(32, 87);
            labelCine.Name = "labelCine";
            labelCine.Size = new Size(74, 20);
            labelCine.TabIndex = 0;
            labelCine.Text = "ID_Cine";
            labelCine.Click += label1_Click;
            // 
            // txbIDCine
            // 
            txbIDCine.Location = new Point(32, 115);
            txbIDCine.Name = "txbIDCine";
            txbIDCine.Size = new Size(150, 31);
            txbIDCine.TabIndex = 1;
            txbIDCine.TextChanged += txbIDCine_TextChanged;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(33, 183);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(72, 20);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            labelNombre.Click += labelNombre_Click;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(33, 211);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(150, 31);
            txbNombre.TabIndex = 3;
            txbNombre.TextChanged += txbNombre_TextChanged;
            // 
            // labelPlaza
            // 
            labelPlaza.AutoSize = true;
            labelPlaza.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlaza.Location = new Point(33, 285);
            labelPlaza.Name = "labelPlaza";
            labelPlaza.Size = new Size(79, 20);
            labelPlaza.TabIndex = 4;
            labelPlaza.Text = "ID_plaza";
            labelPlaza.Click += labelPlaza_Click;
            // 
            // txbID_plaza
            // 
            txbID_plaza.Location = new Point(33, 313);
            txbID_plaza.Name = "txbID_plaza";
            txbID_plaza.Size = new Size(150, 31);
            txbID_plaza.TabIndex = 5;
            txbID_plaza.TextChanged += txbID_plaza_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(14, 524);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(132, 524);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(835, 524);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCine
            // 
            dgvCine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCine.Location = new Point(226, 115);
            dgvCine.Name = "dgvCine";
            dgvCine.RowHeadersWidth = 62;
            dgvCine.Size = new Size(687, 339);
            dgvCine.TabIndex = 9;
            dgvCine.CellContentClick += dgvCine_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 416);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 10;
            label1.Text = "Cantidad de Salas";
            // 
            // txbCantSalas
            // 
            txbCantSalas.Location = new Point(32, 439);
            txbCantSalas.Name = "txbCantSalas";
            txbCantSalas.Size = new Size(151, 31);
            txbCantSalas.TabIndex = 11;
            txbCantSalas.TextChanged += txbCantSalas_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(440, 41);
            label2.Name = "label2";
            label2.Size = new Size(245, 36);
            label2.TabIndex = 12;
            label2.Text = "Control de Cines";
            // 
            // vistaCine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 590);
            Controls.Add(label2);
            Controls.Add(txbCantSalas);
            Controls.Add(label1);
            Controls.Add(dgvCine);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txbID_plaza);
            Controls.Add(labelPlaza);
            Controls.Add(txbNombre);
            Controls.Add(labelNombre);
            Controls.Add(txbIDCine);
            Controls.Add(labelCine);
            Name = "vistaCine";
            Text = "vistaCine";
            Load += vistaCine_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCine;
        private TextBox txbIDCine;
        private Label labelNombre;
        private TextBox txbNombre;
        private Label labelPlaza;
        private TextBox txbID_plaza;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvCine;
        private Label label1;
        private TextBox txbCantSalas;
        private Label label2;
    }
}