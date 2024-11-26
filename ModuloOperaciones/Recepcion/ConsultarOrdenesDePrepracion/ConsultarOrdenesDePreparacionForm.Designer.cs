namespace Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion;

partial class ConsultarOrdenesDePreparacionForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarOrdenesDePreparacionForm));
        labelDeposito = new Label();
        comboBoxDeposito = new ComboBox();
        groupBoxMercaderiasASeleccionar = new GroupBox();
        listViewDetalle = new ListView();
        columnHeaderSeleccionMercaderiaSKU = new ColumnHeader();
        columnHeaderSeleccionMercaderiaDescripcion = new ColumnHeader();
        columnHeaderSeleccionMercaderiaUbicacion = new ColumnHeader();
        groupBoxOrdenesDePreparacionPendientes = new GroupBox();
        buttonLimpiarFiltros = new Button();
        buttonBuscar = new Button();
        comboBoxBuscarPorCliente = new ComboBox();
        comboBoxBuscarPorPrioridad = new ComboBox();
        label3 = new Label();
        listViewOrdenesDePreparacion = new ListView();
        columnHeaderOPPendienteNumero = new ColumnHeader();
        columnHeaderOPDeposito = new ColumnHeader();
        columnHeaderOPFechaDespacho = new ColumnHeader();
        columnHeaderClienteNombre = new ColumnHeader();
        columnHeaderClientePrioridad = new ColumnHeader();
        columnHeaderOPPrioridad = new ColumnHeader();
        labelCliente = new Label();
        pictureBoxLogo = new PictureBox();
        labelTitulo = new Label();
        groupBoxMercaderiasASeleccionar.SuspendLayout();
        groupBoxOrdenesDePreparacionPendientes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        SuspendLayout();
        // 
        // labelDeposito
        // 
        labelDeposito.AutoSize = true;
        labelDeposito.Font = new Font("Segoe UI Symbol", 9.75F);
        labelDeposito.Location = new Point(9, 36);
        labelDeposito.Name = "labelDeposito";
        labelDeposito.Size = new Size(123, 17);
        labelDeposito.TabIndex = 51;
        labelDeposito.Text = "Filtrar por Depósito";
        // 
        // comboBoxDeposito
        // 
        comboBoxDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDeposito.FormattingEnabled = true;
        comboBoxDeposito.Location = new Point(9, 56);
        comboBoxDeposito.Name = "comboBoxDeposito";
        comboBoxDeposito.Size = new Size(283, 29);
        comboBoxDeposito.TabIndex = 50;
        // 
        // groupBoxMercaderiasASeleccionar
        // 
        groupBoxMercaderiasASeleccionar.Controls.Add(listViewDetalle);
        groupBoxMercaderiasASeleccionar.Location = new Point(0, 310);
        groupBoxMercaderiasASeleccionar.Name = "groupBoxMercaderiasASeleccionar";
        groupBoxMercaderiasASeleccionar.Size = new Size(919, 261);
        groupBoxMercaderiasASeleccionar.TabIndex = 43;
        groupBoxMercaderiasASeleccionar.TabStop = false;
        groupBoxMercaderiasASeleccionar.Text = "Detalle";
        // 
        // listViewDetalle
        // 
        listViewDetalle.Columns.AddRange(new ColumnHeader[] { columnHeaderSeleccionMercaderiaSKU, columnHeaderSeleccionMercaderiaDescripcion, columnHeaderSeleccionMercaderiaUbicacion });
        listViewDetalle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewDetalle.FullRowSelect = true;
        listViewDetalle.GridLines = true;
        listViewDetalle.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewDetalle.Location = new Point(9, 28);
        listViewDetalle.MultiSelect = false;
        listViewDetalle.Name = "listViewDetalle";
        listViewDetalle.Size = new Size(484, 227);
        listViewDetalle.TabIndex = 33;
        listViewDetalle.UseCompatibleStateImageBehavior = false;
        listViewDetalle.View = View.Details;
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
        // groupBoxOrdenesDePreparacionPendientes
        // 
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(buttonLimpiarFiltros);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(buttonBuscar);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(labelDeposito);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(comboBoxBuscarPorCliente);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(comboBoxDeposito);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(groupBoxMercaderiasASeleccionar);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(comboBoxBuscarPorPrioridad);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(label3);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(listViewOrdenesDePreparacion);
        groupBoxOrdenesDePreparacionPendientes.Controls.Add(labelCliente);
        groupBoxOrdenesDePreparacionPendientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        groupBoxOrdenesDePreparacionPendientes.Location = new Point(12, 75);
        groupBoxOrdenesDePreparacionPendientes.Name = "groupBoxOrdenesDePreparacionPendientes";
        groupBoxOrdenesDePreparacionPendientes.Size = new Size(919, 571);
        groupBoxOrdenesDePreparacionPendientes.TabIndex = 42;
        groupBoxOrdenesDePreparacionPendientes.TabStop = false;
        groupBoxOrdenesDePreparacionPendientes.Text = "Ordenes de Preparación";
        // 
        // buttonLimpiarFiltros
        // 
        buttonLimpiarFiltros.BackColor = Color.FromArgb(33, 150, 243);
        buttonLimpiarFiltros.FlatAppearance.BorderSize = 0;
        buttonLimpiarFiltros.FlatStyle = FlatStyle.Flat;
        buttonLimpiarFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonLimpiarFiltros.ForeColor = Color.White;
        buttonLimpiarFiltros.Location = new Point(766, 109);
        buttonLimpiarFiltros.Name = "buttonLimpiarFiltros";
        buttonLimpiarFiltros.Size = new Size(147, 28);
        buttonLimpiarFiltros.TabIndex = 36;
        buttonLimpiarFiltros.Text = "Limpiar Filtros";
        buttonLimpiarFiltros.UseVisualStyleBackColor = false;
        buttonLimpiarFiltros.Click += buttonLimpiarFiltros_Click;
        // 
        // buttonBuscar
        // 
        buttonBuscar.BackColor = Color.FromArgb(33, 150, 243);
        buttonBuscar.FlatAppearance.BorderSize = 0;
        buttonBuscar.FlatStyle = FlatStyle.Flat;
        buttonBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonBuscar.ForeColor = Color.White;
        buttonBuscar.Location = new Point(658, 109);
        buttonBuscar.Name = "buttonBuscar";
        buttonBuscar.Size = new Size(102, 28);
        buttonBuscar.TabIndex = 35;
        buttonBuscar.Text = "Buscar";
        buttonBuscar.UseVisualStyleBackColor = false;
        buttonBuscar.Click += buttonBuscar_Click;
        // 
        // comboBoxBuscarPorCliente
        // 
        comboBoxBuscarPorCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxBuscarPorCliente.FormattingEnabled = true;
        comboBoxBuscarPorCliente.Location = new Point(9, 108);
        comboBoxBuscarPorCliente.Name = "comboBoxBuscarPorCliente";
        comboBoxBuscarPorCliente.Size = new Size(283, 29);
        comboBoxBuscarPorCliente.TabIndex = 34;
        // 
        // comboBoxBuscarPorPrioridad
        // 
        comboBoxBuscarPorPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxBuscarPorPrioridad.FormattingEnabled = true;
        comboBoxBuscarPorPrioridad.Location = new Point(310, 109);
        comboBoxBuscarPorPrioridad.Name = "comboBoxBuscarPorPrioridad";
        comboBoxBuscarPorPrioridad.Size = new Size(152, 29);
        comboBoxBuscarPorPrioridad.TabIndex = 34;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(310, 89);
        label3.Name = "label3";
        label3.Size = new Size(124, 17);
        label3.TabIndex = 33;
        label3.Text = "Filtrar por Prioridad";
        // 
        // listViewOrdenesDePreparacion
        // 
        listViewOrdenesDePreparacion.Columns.AddRange(new ColumnHeader[] { columnHeaderOPPendienteNumero, columnHeaderOPDeposito, columnHeaderOPFechaDespacho, columnHeaderClienteNombre, columnHeaderClientePrioridad, columnHeaderOPPrioridad });
        listViewOrdenesDePreparacion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewOrdenesDePreparacion.FullRowSelect = true;
        listViewOrdenesDePreparacion.GridLines = true;
        listViewOrdenesDePreparacion.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewOrdenesDePreparacion.Location = new Point(9, 152);
        listViewOrdenesDePreparacion.MultiSelect = false;
        listViewOrdenesDePreparacion.Name = "listViewOrdenesDePreparacion";
        listViewOrdenesDePreparacion.Size = new Size(904, 152);
        listViewOrdenesDePreparacion.TabIndex = 18;
        listViewOrdenesDePreparacion.UseCompatibleStateImageBehavior = false;
        listViewOrdenesDePreparacion.View = View.Details;
        listViewOrdenesDePreparacion.SelectedIndexChanged += listViewOrdenesDePreparacion_SelectedIndexChanged;
        // 
        // columnHeaderOPPendienteNumero
        // 
        columnHeaderOPPendienteNumero.Text = "N° Orden de Preparación";
        columnHeaderOPPendienteNumero.Width = 170;
        // 
        // columnHeaderOPDeposito
        // 
        columnHeaderOPDeposito.Text = "Depósito";
        columnHeaderOPDeposito.Width = 140;
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
        // labelCliente
        // 
        labelCliente.AutoSize = true;
        labelCliente.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelCliente.Location = new Point(11, 88);
        labelCliente.Name = "labelCliente";
        labelCliente.Size = new Size(109, 17);
        labelCliente.TabIndex = 21;
        labelCliente.Text = "Filtrar por Cliente";
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
        pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
        pictureBoxLogo.Location = new Point(625, 12);
        pictureBoxLogo.Name = "pictureBoxLogo";
        pictureBoxLogo.Size = new Size(300, 60);
        pictureBoxLogo.TabIndex = 52;
        pictureBoxLogo.TabStop = false;
        // 
        // labelTitulo
        // 
        labelTitulo.AutoSize = true;
        labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        labelTitulo.Location = new Point(21, 9);
        labelTitulo.Name = "labelTitulo";
        labelTitulo.Size = new Size(436, 32);
        labelTitulo.TabIndex = 53;
        labelTitulo.Text = "Consulta de Ordenes de Preparación";
        // 
        // ConsultarOrdenesDePreparacionForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(943, 658);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Controls.Add(groupBoxOrdenesDePreparacionPendientes);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "ConsultarOrdenesDePreparacionForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Consulta de Ordenes De Preparacion";
        Load += ConsultarOrdenesDePreparacionForm_Load;
        groupBoxMercaderiasASeleccionar.ResumeLayout(false);
        groupBoxOrdenesDePreparacionPendientes.ResumeLayout(false);
        groupBoxOrdenesDePreparacionPendientes.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelDeposito;
    private ComboBox comboBoxDeposito;
    private GroupBox groupBoxMercaderiasASeleccionar;
    private ListView listViewDetalle;
    private ColumnHeader columnHeaderSeleccionMercaderiaSKU;
    private ColumnHeader columnHeaderSeleccionMercaderiaDescripcion;
    private ColumnHeader columnHeaderSeleccionMercaderiaUbicacion;
    private GroupBox groupBoxOrdenesDePreparacionPendientes;
    private Button buttonLimpiarFiltros;
    private Button buttonBuscar;
    private ComboBox comboBoxBuscarPorCliente;
    private ComboBox comboBoxBuscarPorPrioridad;
    private Label label3;
    private ListView listViewOrdenesDePreparacion;
    private ColumnHeader columnHeaderOPPendienteNumero;
    private ColumnHeader columnHeaderOPFechaDespacho;
    private ColumnHeader columnHeaderClienteNombre;
    private ColumnHeader columnHeaderClientePrioridad;
    private ColumnHeader columnHeaderOPPrioridad;
    private Label labelCliente;
    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private ColumnHeader columnHeaderOPDeposito;
}