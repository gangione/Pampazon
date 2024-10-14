namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion;

partial class GenerarOrdenDeSeleccionForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarOrdenDeSeleccionForm));
        pictureBoxLogo = new PictureBox();
        labelTitulo = new Label();
        listViewOrdenesDePreparacion = new ListView();
        columnHeaderOrdenDePreparacionPendienteNumero = new ColumnHeader();
        columnHeaderOrdenDePreparacionFechaDespacho = new ColumnHeader();
        columnHeaderClienteNombre = new ColumnHeader();
        columnHeaderClientePrioridad = new ColumnHeader();
        groupBoxOrdenDeSeleccion = new GroupBox();
        label1 = new Label();
        comboBoxPrioridadDeOrden = new ComboBox();
        groupBoxMercaderiasASeleccionar = new GroupBox();
        listViewOrdenesASeleccionar = new ListView();
        columnHeaderSeleccionOrdenDePreparacionNro = new ColumnHeader();
        columnHeaderSeleccionMercaderiaSKU = new ColumnHeader();
        columnHeaderSeleccionMercaderiaDescripcion = new ColumnHeader();
        columnHeaderSeleccionMercaderiaUbicacion = new ColumnHeader();
        buttonEliminar = new Button();
        groupBoxOrdenesDePreparacionPendientes = new GroupBox();
        comboBoxBuscarPorCliente = new ComboBox();
        comboBoxBuscarPorPrioridad = new ComboBox();
        label3 = new Label();
        buttonAgregar = new Button();
        labelCliente = new Label();
        buttonGenerarOrden = new Button();
        buttonBuscar = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxOrdenDeSeleccion.SuspendLayout();
        groupBoxMercaderiasASeleccionar.SuspendLayout();
        groupBoxOrdenesDePreparacionPendientes.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
        pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
        pictureBoxLogo.Location = new Point(485, 9);
        pictureBoxLogo.Name = "pictureBoxLogo";
        pictureBoxLogo.Size = new Size(300, 60);
        pictureBoxLogo.TabIndex = 16;
        pictureBoxLogo.TabStop = false;
        // 
        // labelTitulo
        // 
        labelTitulo.AutoSize = true;
        labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        labelTitulo.Location = new Point(12, 9);
        labelTitulo.Name = "labelTitulo";
        labelTitulo.Size = new Size(337, 32);
        labelTitulo.TabIndex = 17;
        labelTitulo.Text = "Generar Orden De Selección";
        // 
        // listViewOrdenesDePreparacion
        // 
        listViewOrdenesDePreparacion.Columns.AddRange(new ColumnHeader[] { columnHeaderOrdenDePreparacionPendienteNumero, columnHeaderOrdenDePreparacionFechaDespacho, columnHeaderClienteNombre, columnHeaderClientePrioridad });
        listViewOrdenesDePreparacion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewOrdenesDePreparacion.FullRowSelect = true;
        listViewOrdenesDePreparacion.GridLines = true;
        listViewOrdenesDePreparacion.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewOrdenesDePreparacion.Location = new Point(7, 82);
        listViewOrdenesDePreparacion.MultiSelect = false;
        listViewOrdenesDePreparacion.Name = "listViewOrdenesDePreparacion";
        listViewOrdenesDePreparacion.Size = new Size(760, 129);
        listViewOrdenesDePreparacion.TabIndex = 18;
        listViewOrdenesDePreparacion.UseCompatibleStateImageBehavior = false;
        listViewOrdenesDePreparacion.View = View.Details;
        // 
        // columnHeaderOrdenDePreparacionPendienteNumero
        // 
        columnHeaderOrdenDePreparacionPendienteNumero.Text = "N° Orden de Preparación";
        columnHeaderOrdenDePreparacionPendienteNumero.Width = 170;
        // 
        // columnHeaderOrdenDePreparacionFechaDespacho
        // 
        columnHeaderOrdenDePreparacionFechaDespacho.Text = "Fecha a Despachar";
        columnHeaderOrdenDePreparacionFechaDespacho.Width = 170;
        // 
        // columnHeaderClienteNombre
        // 
        columnHeaderClienteNombre.Text = "Cliente";
        columnHeaderClienteNombre.Width = 200;
        // 
        // columnHeaderClientePrioridad
        // 
        columnHeaderClientePrioridad.Text = "Prioridad del Cliente";
        columnHeaderClientePrioridad.Width = 150;
        // 
        // groupBoxOrdenDeSeleccion
        // 
        groupBoxOrdenDeSeleccion.Controls.Add(label1);
        groupBoxOrdenDeSeleccion.Controls.Add(comboBoxPrioridadDeOrden);
        groupBoxOrdenDeSeleccion.Controls.Add(groupBoxMercaderiasASeleccionar);
        groupBoxOrdenDeSeleccion.Controls.Add(groupBoxOrdenesDePreparacionPendientes);
        groupBoxOrdenDeSeleccion.Controls.Add(buttonGenerarOrden);
        groupBoxOrdenDeSeleccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxOrdenDeSeleccion.Location = new Point(18, 75);
        groupBoxOrdenDeSeleccion.Name = "groupBoxOrdenDeSeleccion";
        groupBoxOrdenDeSeleccion.Size = new Size(767, 615);
        groupBoxOrdenDeSeleccion.TabIndex = 31;
        groupBoxOrdenDeSeleccion.TabStop = false;
        groupBoxOrdenDeSeleccion.Text = "Orden de Selección";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(9, 29);
        label1.Name = "label1";
        label1.Size = new Size(152, 17);
        label1.TabIndex = 45;
        label1.Text = "Prioridad de la selección";
        // 
        // comboBoxPrioridadDeOrden
        // 
        comboBoxPrioridadDeOrden.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxPrioridadDeOrden.FormattingEnabled = true;
        comboBoxPrioridadDeOrden.Location = new Point(9, 49);
        comboBoxPrioridadDeOrden.Name = "comboBoxPrioridadDeOrden";
        comboBoxPrioridadDeOrden.Size = new Size(152, 29);
        comboBoxPrioridadDeOrden.TabIndex = 44;
        // 
        // groupBoxMercaderiasASeleccionar
        // 
        groupBoxMercaderiasASeleccionar.Controls.Add(listViewOrdenesASeleccionar);
        groupBoxMercaderiasASeleccionar.Controls.Add(buttonEliminar);
        groupBoxMercaderiasASeleccionar.Location = new Point(0, 362);
        groupBoxMercaderiasASeleccionar.Name = "groupBoxMercaderiasASeleccionar";
        groupBoxMercaderiasASeleccionar.Size = new Size(767, 204);
        groupBoxMercaderiasASeleccionar.TabIndex = 43;
        groupBoxMercaderiasASeleccionar.TabStop = false;
        groupBoxMercaderiasASeleccionar.Text = "Mercaderías a Seleccionar del Almacén";
        // 
        // listViewOrdenesASeleccionar
        // 
        listViewOrdenesASeleccionar.Columns.AddRange(new ColumnHeader[] { columnHeaderSeleccionOrdenDePreparacionNro, columnHeaderSeleccionMercaderiaSKU, columnHeaderSeleccionMercaderiaDescripcion, columnHeaderSeleccionMercaderiaUbicacion });
        listViewOrdenesASeleccionar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewOrdenesASeleccionar.FullRowSelect = true;
        listViewOrdenesASeleccionar.GridLines = true;
        listViewOrdenesASeleccionar.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewOrdenesASeleccionar.Location = new Point(9, 28);
        listViewOrdenesASeleccionar.MultiSelect = false;
        listViewOrdenesASeleccionar.Name = "listViewOrdenesASeleccionar";
        listViewOrdenesASeleccionar.Size = new Size(758, 134);
        listViewOrdenesASeleccionar.TabIndex = 33;
        listViewOrdenesASeleccionar.UseCompatibleStateImageBehavior = false;
        listViewOrdenesASeleccionar.View = View.Details;
        // 
        // columnHeaderSeleccionOrdenDePreparacionNro
        // 
        columnHeaderSeleccionOrdenDePreparacionNro.Text = "N° Orden de Preparación";
        columnHeaderSeleccionOrdenDePreparacionNro.Width = 170;
        // 
        // columnHeaderSeleccionMercaderiaSKU
        // 
        columnHeaderSeleccionMercaderiaSKU.Text = "SKU";
        columnHeaderSeleccionMercaderiaSKU.Width = 160;
        // 
        // columnHeaderSeleccionMercaderiaDescripcion
        // 
        columnHeaderSeleccionMercaderiaDescripcion.Text = "Tipo de Mercadería";
        columnHeaderSeleccionMercaderiaDescripcion.Width = 140;
        // 
        // columnHeaderSeleccionMercaderiaUbicacion
        // 
        columnHeaderSeleccionMercaderiaUbicacion.Text = "Cantidad Mercaderia";
        columnHeaderSeleccionMercaderiaUbicacion.Width = 150;
        // 
        // buttonEliminar
        // 
        buttonEliminar.BackColor = Color.FromArgb(33, 150, 243);
        buttonEliminar.FlatAppearance.BorderSize = 0;
        buttonEliminar.FlatStyle = FlatStyle.Flat;
        buttonEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonEliminar.ForeColor = Color.White;
        buttonEliminar.Location = new Point(566, 168);
        buttonEliminar.Name = "buttonEliminar";
        buttonEliminar.Size = new Size(201, 27);
        buttonEliminar.TabIndex = 24;
        buttonEliminar.TabStop = false;
        buttonEliminar.Text = "- Eliminar de la selección";
        buttonEliminar.UseVisualStyleBackColor = false;
        buttonEliminar.Click += buttonEliminar_Click;
        // 
        // groupBoxOrdenesDePreparacionPendientes
        // 
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(buttonBuscar);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(comboBoxBuscarPorCliente);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(comboBoxBuscarPorPrioridad);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(label3);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(listViewOrdenesDePreparacion);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(buttonAgregar);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(labelCliente);
        groupBoxOrdenesDePreparacionPendientes.Location = new Point(0, 84);
        groupBoxOrdenesDePreparacionPendientes.Name = "groupBoxOrdenesDePreparacionPendientes";
        groupBoxOrdenesDePreparacionPendientes.Size = new Size(767, 300);
        groupBoxOrdenesDePreparacionPendientes.TabIndex = 42;
        groupBoxOrdenesDePreparacionPendientes.TabStop = false;
        groupBoxOrdenesDePreparacionPendientes.Text = "Ordenes de Preparación Pendientes";
        // 
        // comboBoxBuscarPorCliente
        // 
        comboBoxBuscarPorCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxBuscarPorCliente.FormattingEnabled = true;
        comboBoxBuscarPorCliente.Location = new Point(9, 47);
        comboBoxBuscarPorCliente.Name = "comboBoxBuscarPorCliente";
        comboBoxBuscarPorCliente.Size = new Size(375, 29);
        comboBoxBuscarPorCliente.TabIndex = 34;
        // 
        // comboBoxBuscarPorPrioridad
        // 
        comboBoxBuscarPorPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxBuscarPorPrioridad.FormattingEnabled = true;
        comboBoxBuscarPorPrioridad.Location = new Point(408, 48);
        comboBoxBuscarPorPrioridad.Name = "comboBoxBuscarPorPrioridad";
        comboBoxBuscarPorPrioridad.Size = new Size(152, 29);
        comboBoxBuscarPorPrioridad.TabIndex = 34;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(408, 26);
        label3.Name = "label3";
        label3.Size = new Size(124, 17);
        label3.TabIndex = 33;
        label3.Text = "Filtrar por Prioridad";
        // 
        // buttonAgregar
        // 
        buttonAgregar.BackColor = Color.FromArgb(33, 150, 243);
        buttonAgregar.FlatAppearance.BorderSize = 0;
        buttonAgregar.FlatStyle = FlatStyle.Flat;
        buttonAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonAgregar.ForeColor = Color.White;
        buttonAgregar.Location = new Point(566, 217);
        buttonAgregar.Name = "buttonAgregar";
        buttonAgregar.Size = new Size(201, 30);
        buttonAgregar.TabIndex = 25;
        buttonAgregar.Text = "+ Agregar a la selección";
        buttonAgregar.UseVisualStyleBackColor = false;
        buttonAgregar.Click += buttonAgregar_Click;
        // 
        // labelCliente
        // 
        labelCliente.AutoSize = true;
        labelCliente.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelCliente.Location = new Point(7, 27);
        labelCliente.Name = "labelCliente";
        labelCliente.Size = new Size(109, 17);
        labelCliente.TabIndex = 21;
        labelCliente.Text = "Filtrar por Cliente";
        // 
        // buttonGenerarOrden
        // 
        buttonGenerarOrden.BackColor = Color.FromArgb(33, 150, 243);
        buttonGenerarOrden.FlatAppearance.BorderSize = 0;
        buttonGenerarOrden.FlatStyle = FlatStyle.Flat;
        buttonGenerarOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonGenerarOrden.ForeColor = Color.White;
        buttonGenerarOrden.Location = new Point(566, 572);
        buttonGenerarOrden.Name = "buttonGenerarOrden";
        buttonGenerarOrden.Size = new Size(201, 43);
        buttonGenerarOrden.TabIndex = 26;
        buttonGenerarOrden.Text = "Generar Orden";
        buttonGenerarOrden.UseVisualStyleBackColor = false;
        buttonGenerarOrden.Click += buttonGenerarOrden_Click;
        // 
        // buttonBuscar
        // 
        buttonBuscar.BackColor = Color.FromArgb(33, 150, 243);
        buttonBuscar.FlatAppearance.BorderSize = 0;
        buttonBuscar.FlatStyle = FlatStyle.Flat;
        buttonBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonBuscar.ForeColor = Color.White;
        buttonBuscar.Location = new Point(594, 48);
        buttonBuscar.Name = "buttonBuscar";
        buttonBuscar.Size = new Size(158, 28);
        buttonBuscar.TabIndex = 35;
        buttonBuscar.Text = "Buscar";
        buttonBuscar.UseVisualStyleBackColor = false;
        buttonBuscar.Click += buttonBuscar_Click;
        // 
        // GenerarOrdenDeSeleccionForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(802, 702);
        Controls.Add(groupBoxOrdenDeSeleccion);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Name = "GenerarOrdenDeSeleccionForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generar Orden De Seleccion";
        FormClosing += GenerarOrdenDeSeleccionForm_FormClosing;
        Load += GenerarOrdenDeSeleccionForm_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxOrdenDeSeleccion.ResumeLayout(false);
        groupBoxOrdenDeSeleccion.PerformLayout();
        groupBoxMercaderiasASeleccionar.ResumeLayout(false);
        groupBoxOrdenesDePreparacionPendientes.ResumeLayout(false);
        groupBoxOrdenesDePreparacionPendientes.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private ListView listViewOrdenesDePreparacion;
    private ColumnHeader columnHeaderOrdenDePreparacionPendienteNumero;
    private GroupBox groupBoxOrdenDeSeleccion;
    private Label labelCliente;
    private TextBox textBoxCliente;
    private Button buttonEliminar;
    private Button buttonAgregar;
    private Button buttonGenerarOrden;
    private ColumnHeader columnHeaderOrdenDePreparacionFechaDespacho;
    private ColumnHeader columnHeaderClienteNombre;
    private Label labelPrioridad;
    private ComboBox comboBoxPrioridad;
    private ListView listViewOrdenesASeleccionar;
    private ColumnHeader columnHeaderSeleccionMercaderiaSKU;
    private ColumnHeader columnHeaderClientePrioridad;
    private GroupBox groupBoxOrdenesDePreparacionPendientes;
    private ColumnHeader columnHeaderSeleccionMercaderiaUbicacion;
    private ColumnHeader columnHeaderSeleccionOrdenDePreparacionNro;
    private ColumnHeader columnHeaderSeleccionMercaderiaDescripcion;
    private TextBox textBox2;
    private Label label3;
    private ComboBox comboBoxBuscarPorPrioridad;
    private GroupBox groupBoxMercaderiasASeleccionar;
    private Label label1;
    private ComboBox comboBoxPrioridadDeOrden;
    private ComboBox comboBoxBuscarPorCliente;
    private Button buttonBuscar;
}