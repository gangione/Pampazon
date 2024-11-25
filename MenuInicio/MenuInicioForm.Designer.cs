namespace Pampazon.MenuInicio
{
    partial class MenuInicioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicioForm));
            pictureBox1 = new PictureBox();
            labelTitulo = new Label();
            buttonOrdenDePreparacion = new Button();
            groupBox1 = new GroupBox();
            buttonDespachar = new Button();
            buttonEmpaquetar = new Button();
            buttonSeleccionMercaderias = new Button();
            buttonOrdenDeSeleccion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 60);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            labelTitulo.Location = new Point(112, 72);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(351, 32);
            labelTitulo.TabIndex = 16;
            labelTitulo.Text = "Menú de Inicio - Operaciones";
            // 
            // buttonOrdenDePreparacion
            // 
            buttonOrdenDePreparacion.BackColor = Color.FromArgb(33, 150, 243);
            buttonOrdenDePreparacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonOrdenDePreparacion.ForeColor = Color.White;
            buttonOrdenDePreparacion.Location = new Point(6, 22);
            buttonOrdenDePreparacion.Name = "buttonOrdenDePreparacion";
            buttonOrdenDePreparacion.Size = new Size(200, 87);
            buttonOrdenDePreparacion.TabIndex = 18;
            buttonOrdenDePreparacion.Text = "1. Ingresar Orden de Preparación";
            buttonOrdenDePreparacion.UseVisualStyleBackColor = false;
            buttonOrdenDePreparacion.Click += buttonPedirMercaderiasDeCliente_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDespachar);
            groupBox1.Controls.Add(buttonEmpaquetar);
            groupBox1.Controls.Add(buttonOrdenDePreparacion);
            groupBox1.Controls.Add(buttonSeleccionMercaderias);
            groupBox1.Controls.Add(buttonOrdenDeSeleccion);
            groupBox1.Location = new Point(181, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 493);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // buttonDespachar
            // 
            buttonDespachar.BackColor = Color.FromArgb(33, 150, 243);
            buttonDespachar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDespachar.ForeColor = Color.White;
            buttonDespachar.Location = new Point(6, 394);
            buttonDespachar.Name = "buttonDespachar";
            buttonDespachar.Size = new Size(200, 87);
            buttonDespachar.TabIndex = 22;
            buttonDespachar.Text = "5. Despachar pedidos / Generar Remito.";
            buttonDespachar.UseVisualStyleBackColor = false;
            buttonDespachar.Click += buttonDespachar_Click;
            // 
            // buttonEmpaquetar
            // 
            buttonEmpaquetar.BackColor = Color.FromArgb(33, 150, 243);
            buttonEmpaquetar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonEmpaquetar.ForeColor = Color.White;
            buttonEmpaquetar.Location = new Point(6, 301);
            buttonEmpaquetar.Name = "buttonEmpaquetar";
            buttonEmpaquetar.Size = new Size(200, 87);
            buttonEmpaquetar.TabIndex = 21;
            buttonEmpaquetar.Text = "4. Empaquetar / Preparar pedidos.";
            buttonEmpaquetar.UseVisualStyleBackColor = false;
            buttonEmpaquetar.Click += buttonEmpaquetar_Click;
            // 
            // buttonSeleccionMercaderias
            // 
            buttonSeleccionMercaderias.BackColor = Color.FromArgb(33, 150, 243);
            buttonSeleccionMercaderias.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSeleccionMercaderias.ForeColor = Color.White;
            buttonSeleccionMercaderias.Location = new Point(6, 208);
            buttonSeleccionMercaderias.Name = "buttonSeleccionMercaderias";
            buttonSeleccionMercaderias.Size = new Size(200, 87);
            buttonSeleccionMercaderias.TabIndex = 20;
            buttonSeleccionMercaderias.Text = "3. Selección de Mercaderías / Baja de Almacen";
            buttonSeleccionMercaderias.UseVisualStyleBackColor = false;
            buttonSeleccionMercaderias.Click += buttonSeleccionMercaderias_Click;
            // 
            // buttonOrdenDeSeleccion
            // 
            buttonOrdenDeSeleccion.BackColor = Color.FromArgb(33, 150, 243);
            buttonOrdenDeSeleccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonOrdenDeSeleccion.ForeColor = Color.White;
            buttonOrdenDeSeleccion.Location = new Point(6, 115);
            buttonOrdenDeSeleccion.Name = "buttonOrdenDeSeleccion";
            buttonOrdenDeSeleccion.Size = new Size(200, 87);
            buttonOrdenDeSeleccion.TabIndex = 19;
            buttonOrdenDeSeleccion.Text = "2. Ordenar selección de pedidos";
            buttonOrdenDeSeleccion.UseVisualStyleBackColor = false;
            buttonOrdenDeSeleccion.Click += buttonOrdenDeSeleccion_Click;
            // 
            // MenuInicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 604);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MenuInicioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuInicioForm";
            Load += MenuInicioForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTitulo;
        private Button buttonOrdenDePreparacion;
        private GroupBox groupBox1;
        private Button buttonSeleccionMercaderias;
        private Button buttonOrdenDeSeleccion;
        private Button buttonEmpaquetar;
        private Button buttonDespachar;
    }
}