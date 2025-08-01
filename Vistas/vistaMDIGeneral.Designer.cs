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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnCerrarSesion = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panelServicio4 = new Panel();
            button10 = new Button();
            panelServicios = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panelServicio4.SuspendLayout();
            panelServicios.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 62, 80);
            panelMenu.Controls.Add(pictureBox4);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
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
            pictureBox4.Location = new Point(989, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(798, 26);
            button4.Name = "button4";
            button4.Size = new Size(198, 40);
            button4.TabIndex = 5;
            button4.Text = "Seguridad";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            button4.MouseEnter += btnMouseEntrada;
            button4.MouseLeave += btnMouseSalida;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(604, 26);
            button3.Name = "button3";
            button3.Size = new Size(198, 40);
            button3.TabIndex = 4;
            button3.Text = "Reportes";
            button3.UseVisualStyleBackColor = true;
            button3.MouseEnter += btnMouseEntrada;
            button3.MouseLeave += btnMouseSalida;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(377, 26);
            button2.Name = "button2";
            button2.Size = new Size(198, 40);
            button2.TabIndex = 4;
            button2.Text = "Mantenimientos";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseEnter += btnMouseEntrada;
            button2.MouseLeave += btnMouseSalida;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(173, 26);
            button1.Name = "button1";
            button1.Size = new Size(198, 40);
            button1.TabIndex = 3;
            button1.Text = "Cartelera";
            button1.UseVisualStyleBackColor = true;
            button1.MouseEnter += btnMouseEntrada;
            button1.MouseLeave += btnMouseSalida;
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
            panel4.Controls.Add(panelServicio4);
            panel4.Controls.Add(panelServicios);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(1135, 611);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // panelServicio4
            // 
            panelServicio4.BackColor = Color.FromArgb(51, 62, 80);
            panelServicio4.Controls.Add(button10);
            panelServicio4.Location = new Point(791, -2);
            panelServicio4.Name = "panelServicio4";
            panelServicio4.Size = new Size(198, 46);
            panelServicio4.TabIndex = 1;
            panelServicio4.Visible = false;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(0, 0);
            button10.Name = "button10";
            button10.Size = new Size(198, 46);
            button10.TabIndex = 7;
            button10.Text = "Bitacora";
            button10.UseVisualStyleBackColor = true;
            // 
            // panelServicios
            // 
            panelServicios.BackColor = Color.FromArgb(51, 62, 80);
            panelServicios.Controls.Add(button7);
            panelServicios.Controls.Add(button6);
            panelServicios.Controls.Add(button5);
            panelServicios.Location = new Point(370, -2);
            panelServicios.Name = "panelServicios";
            panelServicios.Size = new Size(198, 153);
            panelServicios.TabIndex = 0;
            panelServicios.Visible = false;
            panelServicios.Paint += panelServicios_Paint;
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
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 53);
            button6.Name = "button6";
            button6.Size = new Size(198, 40);
            button6.TabIndex = 8;
            button6.Text = "Peliculas";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 6);
            button5.Name = "button5";
            button5.Size = new Size(198, 40);
            button5.TabIndex = 7;
            button5.Text = "Usuarios";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox4;
        private Panel panelServicios;
        private Button button5;
        private Button button7;
        private Button button6;
        private Panel panelServicio4;
        private Button button10;
    }
}
