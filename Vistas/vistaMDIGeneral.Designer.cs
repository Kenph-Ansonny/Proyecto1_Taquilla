namespace Prototipo_Taquilla_Cliente
{
    partial class vistaMDIGeneral
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistaMDIGeneral));
            panelMenu = new Panel();
            pictureBox4 = new PictureBox();
            txtSeguridad = new Button();
            txtReporte = new Button();
            txtMantenimiento = new Button();
            txtCartelera = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnCerrarSesion = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pnlReportes = new Panel();
            btnReportePeliculaTaquilla = new Button();
            panelServicio4 = new Panel();
            txtBitacora = new Button();
            panelServicios = new Panel();
            btnFuncion = new Button();
            button7 = new Button();
            txtPelicula = new Button();
            txtUsuarios = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            pnlReportes.SuspendLayout();
            panelServicio4.SuspendLayout();
            panelServicios.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 62, 80);
            panelMenu.Controls.Add(pictureBox4);
            panelMenu.Controls.Add(txtSeguridad);
            panelMenu.Controls.Add(txtReporte);
            panelMenu.Controls.Add(txtMantenimiento);
            panelMenu.Controls.Add(txtCartelera);
            panelMenu.Controls.Add(pictureBox3);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1145, 86);
            panelMenu.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1002, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // txtSeguridad
            // 
            txtSeguridad.FlatAppearance.BorderSize = 0;
            txtSeguridad.FlatAppearance.MouseOverBackColor = Color.Transparent;
            txtSeguridad.FlatStyle = FlatStyle.Flat;
            txtSeguridad.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSeguridad.ForeColor = Color.White;
            txtSeguridad.Image = (Image)resources.GetObject("txtSeguridad.Image");
            txtSeguridad.ImageAlign = ContentAlignment.MiddleLeft;
            txtSeguridad.Location = new Point(798, 26);
            txtSeguridad.Name = "txtSeguridad";
            txtSeguridad.Size = new Size(198, 40);
            txtSeguridad.TabIndex = 5;
            txtSeguridad.Text = "Seguridad";
            txtSeguridad.UseVisualStyleBackColor = true;
            txtSeguridad.Click += button4_Click;
            txtSeguridad.MouseEnter += btnMouseEntrada;
            txtSeguridad.MouseLeave += btnMouseSalida;
            // 
            // txtReporte
            // 
            txtReporte.FlatAppearance.BorderSize = 0;
            txtReporte.FlatAppearance.MouseOverBackColor = Color.Transparent;
            txtReporte.FlatStyle = FlatStyle.Flat;
            txtReporte.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReporte.ForeColor = Color.White;
            txtReporte.Image = (Image)resources.GetObject("txtReporte.Image");
            txtReporte.ImageAlign = ContentAlignment.MiddleLeft;
            txtReporte.Location = new Point(604, 26);
            txtReporte.Name = "txtReporte";
            txtReporte.Size = new Size(198, 40);
            txtReporte.TabIndex = 4;
            txtReporte.Text = "Reportes";
            txtReporte.UseVisualStyleBackColor = true;
            txtReporte.Click += txtReporte_Click;
            txtReporte.MouseEnter += btnMouseEntrada;
            txtReporte.MouseLeave += btnMouseSalida;
            // 
            // txtMantenimiento
            // 
            txtMantenimiento.FlatAppearance.BorderSize = 0;
            txtMantenimiento.FlatAppearance.MouseOverBackColor = Color.Transparent;
            txtMantenimiento.FlatStyle = FlatStyle.Flat;
            txtMantenimiento.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMantenimiento.ForeColor = Color.White;
            txtMantenimiento.Image = (Image)resources.GetObject("txtMantenimiento.Image");
            txtMantenimiento.ImageAlign = ContentAlignment.MiddleLeft;
            txtMantenimiento.Location = new Point(377, 26);
            txtMantenimiento.Name = "txtMantenimiento";
            txtMantenimiento.Size = new Size(198, 40);
            txtMantenimiento.TabIndex = 4;
            txtMantenimiento.Text = "Mantenimientos";
            txtMantenimiento.TextAlign = ContentAlignment.MiddleRight;
            txtMantenimiento.UseVisualStyleBackColor = true;
            txtMantenimiento.Click += button2_Click;
            txtMantenimiento.MouseEnter += btnMouseEntrada;
            txtMantenimiento.MouseLeave += btnMouseSalida;
            // 
            // txtCartelera
            // 
            txtCartelera.FlatAppearance.BorderSize = 0;
            txtCartelera.FlatAppearance.MouseOverBackColor = Color.Transparent;
            txtCartelera.FlatStyle = FlatStyle.Flat;
            txtCartelera.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCartelera.ForeColor = Color.White;
            txtCartelera.Image = (Image)resources.GetObject("txtCartelera.Image");
            txtCartelera.ImageAlign = ContentAlignment.MiddleLeft;
            txtCartelera.Location = new Point(173, 26);
            txtCartelera.Name = "txtCartelera";
            txtCartelera.Size = new Size(198, 40);
            txtCartelera.TabIndex = 3;
            txtCartelera.Text = "Cartelera";
            txtCartelera.UseVisualStyleBackColor = true;
            txtCartelera.MouseEnter += btnMouseEntrada;
            txtCartelera.MouseLeave += btnMouseSalida;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(775, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(0, 0);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(826, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 0);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.Location = new Point(1081, 3);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(64, 54);
            btnCerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.TabStop = false;
            btnCerrarSesion.Click += btnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 62, 80);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 611);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 62, 80);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1140, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 611);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(51, 62, 80);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(5, 697);
            panel3.Name = "panel3";
            panel3.Size = new Size(1135, 0);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(pnlReportes);
            panel4.Controls.Add(panelServicio4);
            panel4.Controls.Add(panelServicios);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(1135, 611);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // pnlReportes
            // 
            pnlReportes.BackColor = Color.FromArgb(51, 62, 80);
            pnlReportes.Controls.Add(btnReportePeliculaTaquilla);
            pnlReportes.Location = new Point(587, 1);
            pnlReportes.Name = "pnlReportes";
            pnlReportes.Size = new Size(198, 53);
            pnlReportes.TabIndex = 2;
            pnlReportes.Visible = false;
            pnlReportes.Paint += panelServicios_Paint;
            // 
            // btnReportePeliculaTaquilla
            // 
            btnReportePeliculaTaquilla.FlatAppearance.BorderSize = 0;
            btnReportePeliculaTaquilla.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            btnReportePeliculaTaquilla.FlatStyle = FlatStyle.Flat;
            btnReportePeliculaTaquilla.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportePeliculaTaquilla.ForeColor = Color.White;
            btnReportePeliculaTaquilla.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportePeliculaTaquilla.Location = new Point(0, 3);
            btnReportePeliculaTaquilla.Name = "btnReportePeliculaTaquilla";
            btnReportePeliculaTaquilla.Size = new Size(198, 40);
            btnReportePeliculaTaquilla.TabIndex = 7;
            btnReportePeliculaTaquilla.Text = "Peliculas Taquilla";
            btnReportePeliculaTaquilla.UseVisualStyleBackColor = true;
            btnReportePeliculaTaquilla.Click += btnReportePeliculaTaquilla_Click;
            // 
            // panelServicio4
            // 
            panelServicio4.BackColor = Color.FromArgb(51, 62, 80);
            panelServicio4.Controls.Add(txtBitacora);
            panelServicio4.Location = new Point(791, -2);
            panelServicio4.Name = "panelServicio4";
            panelServicio4.Size = new Size(198, 46);
            panelServicio4.TabIndex = 1;
            panelServicio4.Visible = false;
            // 
            // txtBitacora
            // 
            txtBitacora.FlatAppearance.BorderSize = 0;
            txtBitacora.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            txtBitacora.FlatStyle = FlatStyle.Flat;
            txtBitacora.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBitacora.ForeColor = Color.White;
            txtBitacora.ImageAlign = ContentAlignment.MiddleLeft;
            txtBitacora.Location = new Point(0, 0);
            txtBitacora.Name = "txtBitacora";
            txtBitacora.Size = new Size(198, 46);
            txtBitacora.TabIndex = 7;
            txtBitacora.Text = "Bitacora";
            txtBitacora.UseVisualStyleBackColor = true;
            txtBitacora.Click += button10_Click;
            // 
            // panelServicios
            // 
            panelServicios.BackColor = Color.FromArgb(51, 62, 80);
            panelServicios.Controls.Add(btnFuncion);
            panelServicios.Controls.Add(button7);
            panelServicios.Controls.Add(txtPelicula);
            panelServicios.Controls.Add(txtUsuarios);
            panelServicios.Location = new Point(370, -2);
            panelServicios.Name = "panelServicios";
            panelServicios.Size = new Size(198, 219);
            panelServicios.TabIndex = 0;
            panelServicios.Visible = false;
            panelServicios.Paint += panelServicios_Paint;
            // 
            // btnFuncion
            // 
            btnFuncion.FlatStyle = FlatStyle.Flat;
            btnFuncion.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFuncion.ForeColor = SystemColors.ButtonHighlight;
            btnFuncion.Location = new Point(0, 156);
            btnFuncion.Margin = new Padding(2);
            btnFuncion.Name = "btnFuncion";
            btnFuncion.Size = new Size(199, 54);
            btnFuncion.TabIndex = 10;
            btnFuncion.Text = "Funcion";
            btnFuncion.UseVisualStyleBackColor = true;
            btnFuncion.Click += btnFuncion_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 100);
            button7.Name = "button7";
            button7.Size = new Size(198, 40);
            button7.TabIndex = 9;
            button7.Text = "Cine";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // txtPelicula
            // 
            txtPelicula.FlatAppearance.BorderSize = 0;
            txtPelicula.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            txtPelicula.FlatStyle = FlatStyle.Flat;
            txtPelicula.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPelicula.ForeColor = Color.White;
            txtPelicula.ImageAlign = ContentAlignment.MiddleLeft;
            txtPelicula.Location = new Point(0, 54);
            txtPelicula.Name = "txtPelicula";
            txtPelicula.Size = new Size(198, 40);
            txtPelicula.TabIndex = 8;
            txtPelicula.Text = "Peliculas";
            txtPelicula.UseVisualStyleBackColor = true;
            txtPelicula.Click += button6_Click;
            // 
            // txtUsuarios
            // 
            txtUsuarios.FlatAppearance.BorderSize = 0;
            txtUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            txtUsuarios.FlatStyle = FlatStyle.Flat;
            txtUsuarios.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuarios.ForeColor = Color.White;
            txtUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            txtUsuarios.Location = new Point(0, 3);
            txtUsuarios.Name = "txtUsuarios";
            txtUsuarios.Size = new Size(198, 40);
            txtUsuarios.TabIndex = 7;
            txtUsuarios.Text = "Usuarios";
            txtUsuarios.UseVisualStyleBackColor = true;
            txtUsuarios.Click += button5_Click;
            // 
            // vistaMDIGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 697);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "vistaMDIGeneral";
            Text = "Proyecto Taquilla";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            pnlReportes.ResumeLayout(false);
            panelServicio4.ResumeLayout(false);
            panelServicios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox btnCerrarSesion;
        private Button txtCartelera;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button txtSeguridad;
        private Button txtReporte;
        private Button txtMantenimiento;
        private PictureBox pictureBox4;
        private Panel panelServicios;
        private Button txtUsuarios;
        private Button button7;
        private Button txtPelicula;
        private Panel panelServicio4;
        private Button txtBitacora;
        private Button btnFuncion;
        private Panel pnlReportes;
        private Button btnReportePeliculaTaquilla;
    }
}
