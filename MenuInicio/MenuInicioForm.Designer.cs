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
            groupBoxOperaciones = new GroupBox();
            buttonDespachar = new Button();
            buttonEmpaquetar = new Button();
            buttonSeleccionMercaderias = new Button();
            buttonOrdenDeSeleccion = new Button();
            labelOperaciones = new Label();
            labelConsultas = new Label();
            groupBoxConsultas = new GroupBox();
            buttonConsultarOrdenesDePreparacion = new Button();
            buttonConsultarStockDeMercaderias = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxOperaciones.SuspendLayout();
            groupBoxConsultas.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 12);
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
            labelTitulo.Location = new Point(174, 75);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(185, 32);
            labelTitulo.TabIndex = 16;
            labelTitulo.Text = "Menú de Inicio";
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
            // groupBoxOperaciones
            // 
            groupBoxOperaciones.Controls.Add(buttonDespachar);
            groupBoxOperaciones.Controls.Add(buttonEmpaquetar);
            groupBoxOperaciones.Controls.Add(buttonOrdenDePreparacion);
            groupBoxOperaciones.Controls.Add(buttonSeleccionMercaderias);
            groupBoxOperaciones.Controls.Add(buttonOrdenDeSeleccion);
            groupBoxOperaciones.Location = new Point(37, 146);
            groupBoxOperaciones.Name = "groupBoxOperaciones";
            groupBoxOperaciones.Size = new Size(220, 493);
            groupBoxOperaciones.TabIndex = 19;
            groupBoxOperaciones.TabStop = false;
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
            // labelOperaciones
            // 
            labelOperaciones.AutoSize = true;
            labelOperaciones.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelOperaciones.ForeColor = Color.FromArgb(64, 64, 64);
            labelOperaciones.Location = new Point(68, 111);
            labelOperaciones.Name = "labelOperaciones";
            labelOperaciones.Size = new Size(156, 32);
            labelOperaciones.TabIndex = 20;
            labelOperaciones.Text = "Operaciones";
            // 
            // labelConsultas
            // 
            labelConsultas.AutoSize = true;
            labelConsultas.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelConsultas.ForeColor = Color.FromArgb(64, 64, 64);
            labelConsultas.Location = new Point(311, 111);
            labelConsultas.Name = "labelConsultas";
            labelConsultas.Size = new Size(127, 32);
            labelConsultas.TabIndex = 21;
            labelConsultas.Text = "Consultas";
            // 
            // groupBoxConsultas
            // 
            groupBoxConsultas.Controls.Add(buttonConsultarOrdenesDePreparacion);
            groupBoxConsultas.Controls.Add(buttonConsultarStockDeMercaderias);
            groupBoxConsultas.Location = new Point(272, 146);
            groupBoxConsultas.Name = "groupBoxConsultas";
            groupBoxConsultas.Size = new Size(220, 493);
            groupBoxConsultas.TabIndex = 22;
            groupBoxConsultas.TabStop = false;
            // 
            // buttonConsultarOrdenesDePreparacion
            // 
            buttonConsultarOrdenesDePreparacion.BackColor = Color.FromArgb(33, 150, 243);
            buttonConsultarOrdenesDePreparacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonConsultarOrdenesDePreparacion.ForeColor = Color.White;
            buttonConsultarOrdenesDePreparacion.Location = new Point(6, 22);
            buttonConsultarOrdenesDePreparacion.Name = "buttonConsultarOrdenesDePreparacion";
            buttonConsultarOrdenesDePreparacion.Size = new Size(200, 87);
            buttonConsultarOrdenesDePreparacion.TabIndex = 18;
            buttonConsultarOrdenesDePreparacion.Text = "1. Consultar Ordenes de Preparación";
            buttonConsultarOrdenesDePreparacion.UseVisualStyleBackColor = false;
            buttonConsultarOrdenesDePreparacion.Click += buttonConsultarOrdenesDePreparacion_Click;
            // 
            // buttonConsultarStockDeMercaderias
            // 
            buttonConsultarStockDeMercaderias.BackColor = Color.FromArgb(33, 150, 243);
            buttonConsultarStockDeMercaderias.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonConsultarStockDeMercaderias.ForeColor = Color.White;
            buttonConsultarStockDeMercaderias.Location = new Point(6, 115);
            buttonConsultarStockDeMercaderias.Name = "buttonConsultarStockDeMercaderias";
            buttonConsultarStockDeMercaderias.Size = new Size(200, 87);
            buttonConsultarStockDeMercaderias.TabIndex = 19;
            buttonConsultarStockDeMercaderias.Text = "2. Consultar Stock de Mercaderías";
            buttonConsultarStockDeMercaderias.UseVisualStyleBackColor = false;
            buttonConsultarStockDeMercaderias.Click += buttonConsultarStockDeMercaderias_Click;
            // 
            // MenuInicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 651);
            Controls.Add(groupBoxConsultas);
            Controls.Add(labelConsultas);
            Controls.Add(labelOperaciones);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Controls.Add(groupBoxOperaciones);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MenuInicioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxOperaciones.ResumeLayout(false);
            groupBoxConsultas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTitulo;
        private Button buttonOrdenDePreparacion;
        private GroupBox groupBoxOperaciones;
        private Button buttonSeleccionMercaderias;
        private Button buttonOrdenDeSeleccion;
        private Button buttonEmpaquetar;
        private Button buttonDespachar;
        private Label labelOperaciones;
        private Label labelConsultas;
        private GroupBox groupBoxConsultas;
        private Button buttonConsultarOrdenesDePreparacion;
        private Button buttonConsultarStockDeMercaderias;
    }
}