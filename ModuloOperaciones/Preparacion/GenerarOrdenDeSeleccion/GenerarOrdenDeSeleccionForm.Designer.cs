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
        columnHeaderOPPendienteNumero = new ColumnHeader();
        columnHeaderOPFechaDespacho = new ColumnHeader();
        columnHeaderClienteNombre = new ColumnHeader();
        columnHeaderClientePrioridad = new ColumnHeader();
        columnHeaderOPPrioridad = new ColumnHeader();
        groupBoxOrdenDeSeleccion = new GroupBox();
        labelDeposito = new Label();
        comboBoxDeposito = new ComboBox();
        groupBoxMercaderiasASeleccionar = new GroupBox();
        listViewOrdenesASeleccionar = new ListView();
        columnHeaderSeleccionOrdenDePreparacionNro = new ColumnHeader();
        columnHeaderSeleccionMercaderiaSKU = new ColumnHeader();
        columnHeaderSeleccionMercaderiaDescripcion = new ColumnHeader();
        columnHeaderSeleccionMercaderiaUbicacion = new ColumnHeader();
        buttonEliminar = new Button();
        groupBoxOrdenesDePreparacionPendientes = new GroupBox();
        buttonBuscar = new Button();
        comboBoxBuscarPorCliente = new ComboBox();
        buttonAgregar = new Button();
        comboBoxBuscarPorPrioridad = new ComboBox();
        label3 = new Label();
        labelCliente = new Label();
        buttonGenerarOrden = new Button();
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
        listViewOrdenesDePreparacion.Columns.AddRange(new ColumnHeader[] { columnHeaderOPPendienteNumero, columnHeaderOPFechaDespacho, columnHeaderClienteNombre, columnHeaderClientePrioridad, columnHeaderOPPrioridad });
        listViewOrdenesDePreparacion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewOrdenesDePreparacion.FullRowSelect = true;
        listViewOrdenesDePreparacion.GridLines = true;
        listViewOrdenesDePreparacion.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewOrdenesDePreparacion.Location = new Point(7, 80);
        listViewOrdenesDePreparacion.MultiSelect = false;
        listViewOrdenesDePreparacion.Name = "listViewOrdenesDePreparacion";
        listViewOrdenesDePreparacion.Size = new Size(760, 128);
        listViewOrdenesDePreparacion.TabIndex = 18;
        listViewOrdenesDePreparacion.UseCompatibleStateImageBehavior = false;
        listViewOrdenesDePreparacion.View = View.Details;
        // 
        // columnHeaderOPPendienteNumero
        // 
        columnHeaderOPPendienteNumero.Text = "N° Orden de Preparación";
        columnHeaderOPPendienteNumero.Width = 170;
        // 
        // columnHeaderOPFechaDespacho
        // 
        columnHeaderOPFechaDespacho.Text = "Fecha a Despachar";
        columnHeaderOPFechaDespacho.Width = 130;
        // 
        // columnHeaderClienteNombre
        // 
        columnHeaderClienteNombre.Text = "Cliente";
        columnHeaderClienteNombre.Width = 180;
        // 
        // columnHeaderClientePrioridad
        // 
        columnHeaderClientePrioridad.Text = "Prioridad de Cliente";
        columnHeaderClientePrioridad.Width = 135;
        // 
        // columnHeaderOPPrioridad
        // 
        columnHeaderOPPrioridad.Text = "Prioridad de la OP";
        columnHeaderOPPrioridad.Width = 135;
        // 
        // groupBoxOrdenDeSeleccion
        // 
        groupBoxOrdenDeSeleccion.Controls.Add(labelDeposito);
        groupBoxOrdenDeSeleccion.Controls.Add(comboBoxDeposito);
        groupBoxOrdenDeSeleccion.Controls.Add(groupBoxMercaderiasASeleccionar);
        groupBoxOrdenDeSeleccion.Controls.Add(groupBoxOrdenesDePreparacionPendientes);
        groupBoxOrdenDeSeleccion.Controls.Add(buttonGenerarOrden);
        groupBoxOrdenDeSeleccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxOrdenDeSeleccion.Location = new Point(18, 75);
        groupBoxOrdenDeSeleccion.Name = "groupBoxOrdenDeSeleccion";
        groupBoxOrdenDeSeleccion.Size = new Size(767, 596);
        groupBoxOrdenDeSeleccion.TabIndex = 31;
        groupBoxOrdenDeSeleccion.TabStop = false;
        groupBoxOrdenDeSeleccion.Text = "Orden de Selección";
        // 
        // labelDeposito
        // 
        labelDeposito.AutoSize = true;
        labelDeposito.Font = new Font("Segoe UI Symbol", 9.75F);
        labelDeposito.Location = new Point(6, 25);
        labelDeposito.Name = "labelDeposito";
        labelDeposito.Size = new Size(61, 17);
        labelDeposito.TabIndex = 51;
        labelDeposito.Text = "Depósito";
        // 
        // comboBoxDeposito
        // 
        comboBoxDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDeposito.FormattingEnabled = true;
        comboBoxDeposito.Location = new Point(7, 43);
        comboBoxDeposito.Name = "comboBoxDeposito";
        comboBoxDeposito.Size = new Size(267, 29);
        comboBoxDeposito.TabIndex = 50;
        comboBoxDeposito.SelectedIndexChanged += comboBoxDeposito_SelectedIndexChanged;
        // 
        // groupBoxMercaderiasASeleccionar
        // 
        groupBoxMercaderiasASeleccionar.Controls.Add(listViewOrdenesASeleccionar);
        groupBoxMercaderiasASeleccionar.Controls.Add(buttonEliminar);
        groupBoxMercaderiasASeleccionar.Location = new Point(0, 330);
        groupBoxMercaderiasASeleccionar.Name = "groupBoxMercaderiasASeleccionar";
        groupBoxMercaderiasASeleccionar.Size = new Size(767, 217);
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
        listViewOrdenesASeleccionar.Size = new Size(758, 146);
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
        buttonEliminar.Location = new Point(566, 184);
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
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(buttonAgregar);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(comboBoxBuscarPorPrioridad);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(label3);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(listViewOrdenesDePreparacion);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(labelCliente);
        groupBoxOrdenesDePreparacionPendientes.Location = new Point(0, 78);
        groupBoxOrdenesDePreparacionPendientes.Name = "groupBoxOrdenesDePreparacionPendientes";
        groupBoxOrdenesDePreparacionPendientes.Size = new Size(767, 246);
        groupBoxOrdenesDePreparacionPendientes.TabIndex = 42;
        groupBoxOrdenesDePreparacionPendientes.TabStop = false;
        groupBoxOrdenesDePreparacionPendientes.Text = "Ordenes de Preparación Pendientes";
        // 
        // buttonBuscar
        // 
        buttonBuscar.BackColor = Color.FromArgb(33, 150, 243);
        buttonBuscar.FlatAppearance.BorderSize = 0;
        buttonBuscar.FlatStyle = FlatStyle.Flat;
        buttonBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonBuscar.ForeColor = Color.White;
        buttonBuscar.Location = new Point(591, 46);
        buttonBuscar.Name = "buttonBuscar";
        buttonBuscar.Size = new Size(158, 28);
        buttonBuscar.TabIndex = 35;
        buttonBuscar.Text = "Buscar";
        buttonBuscar.UseVisualStyleBackColor = false;
        buttonBuscar.Click += buttonBuscar_Click;
        // 
        // comboBoxBuscarPorCliente
        // 
        comboBoxBuscarPorCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxBuscarPorCliente.FormattingEnabled = true;
        comboBoxBuscarPorCliente.Location = new Point(7, 45);
        comboBoxBuscarPorCliente.Name = "comboBoxBuscarPorCliente";
        comboBoxBuscarPorCliente.Size = new Size(375, 29);
        comboBoxBuscarPorCliente.TabIndex = 34;
        // 
        // buttonAgregar
        // 
        buttonAgregar.BackColor = Color.FromArgb(33, 150, 243);
        buttonAgregar.FlatAppearance.BorderSize = 0;
        buttonAgregar.FlatStyle = FlatStyle.Flat;
        buttonAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonAgregar.ForeColor = Color.White;
        buttonAgregar.Location = new Point(566, 216);
        buttonAgregar.Name = "buttonAgregar";
        buttonAgregar.Size = new Size(201, 30);
        buttonAgregar.TabIndex = 25;
        buttonAgregar.Text = "+ Agregar a la selección";
        buttonAgregar.UseVisualStyleBackColor = false;
        buttonAgregar.Click += buttonAgregar_Click;
        // 
        // comboBoxBuscarPorPrioridad
        // 
        comboBoxBuscarPorPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxBuscarPorPrioridad.FormattingEnabled = true;
        comboBoxBuscarPorPrioridad.Location = new Point(405, 46);
        comboBoxBuscarPorPrioridad.Name = "comboBoxBuscarPorPrioridad";
        comboBoxBuscarPorPrioridad.Size = new Size(152, 29);
        comboBoxBuscarPorPrioridad.TabIndex = 34;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(405, 24);
        label3.Name = "label3";
        label3.Size = new Size(124, 17);
        label3.TabIndex = 33;
        label3.Text = "Filtrar por Prioridad";
        // 
        // labelCliente
        // 
        labelCliente.AutoSize = true;
        labelCliente.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelCliente.Location = new Point(9, 25);
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
        buttonGenerarOrden.Location = new Point(566, 553);
        buttonGenerarOrden.Name = "buttonGenerarOrden";
        buttonGenerarOrden.Size = new Size(201, 43);
        buttonGenerarOrden.TabIndex = 26;
        buttonGenerarOrden.Text = "Generar Orden";
        buttonGenerarOrden.UseVisualStyleBackColor = false;
        buttonGenerarOrden.Click += buttonGenerarOrden_Click;
        // 
        // GenerarOrdenDeSeleccionForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(802, 683);
        Controls.Add(groupBoxOrdenDeSeleccion);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
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
    private ColumnHeader columnHeaderOPPendienteNumero;
    private GroupBox groupBoxOrdenDeSeleccion;
    private Label labelCliente;
    private TextBox textBoxCliente;
    private Button buttonEliminar;
    private Button buttonAgregar;
    private Button buttonGenerarOrden;
    private ColumnHeader columnHeaderOPFechaDespacho;
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
    private ComboBox comboBoxBuscarPorCliente;
    private Button buttonBuscar;
    private ColumnHeader columnHeaderOPPrioridad;
    private Label labelDeposito;
    private ComboBox comboBoxDeposito;
}