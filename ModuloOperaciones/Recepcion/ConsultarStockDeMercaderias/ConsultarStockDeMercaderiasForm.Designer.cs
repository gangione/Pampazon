namespace Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias;

partial class ConsultarStockDeMercaderiasForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarStockDeMercaderiasForm));
        groupBoxMercaderiasEnStock = new GroupBox();
        textBoxBuscarSKU = new TextBox();
        labelFiltroSKU = new Label();
        buttonLimpiarFiltros = new Button();
        buttonBuscar = new Button();
        labelDeposito = new Label();
        comboBoxBuscarPorCliente = new ComboBox();
        comboBoxDeposito = new ComboBox();
        groupBoxUbicaciones = new GroupBox();
        listViewDetalle = new ListView();
        columnHeaderDetalleUbicacion = new ColumnHeader();
        columnHeaderDetalleCantidad = new ColumnHeader();
        listViewMercaderiasEnStock = new ListView();
        columnHeaderSKU = new ColumnHeader();
        columnHeaderSKUDeposito = new ColumnHeader();
        columnHeaderSKUCantidad = new ColumnHeader();
        columnHeaderSKUTipo = new ColumnHeader();
        columnHeaderClienteNombre = new ColumnHeader();
        labelCliente = new Label();
        pictureBoxLogo = new PictureBox();
        labelTitulo = new Label();
        groupBoxMercaderiasEnStock.SuspendLayout();
        groupBoxUbicaciones.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        SuspendLayout();
        // 
        // groupBoxMercaderiasEnStock
        // 
        groupBoxMercaderiasEnStock.Controls.Add(textBoxBuscarSKU);
        groupBoxMercaderiasEnStock.Controls.Add(labelFiltroSKU);
        groupBoxMercaderiasEnStock.Controls.Add(buttonLimpiarFiltros);
        groupBoxMercaderiasEnStock.Controls.Add(buttonBuscar);
        groupBoxMercaderiasEnStock.Controls.Add(labelDeposito);
        groupBoxMercaderiasEnStock.Controls.Add(comboBoxBuscarPorCliente);
        groupBoxMercaderiasEnStock.Controls.Add(comboBoxDeposito);
        groupBoxMercaderiasEnStock.Controls.Add(groupBoxUbicaciones);
        groupBoxMercaderiasEnStock.Controls.Add(listViewMercaderiasEnStock);
        groupBoxMercaderiasEnStock.Controls.Add(labelCliente);
        groupBoxMercaderiasEnStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        groupBoxMercaderiasEnStock.Location = new Point(12, 78);
        groupBoxMercaderiasEnStock.Name = "groupBoxMercaderiasEnStock";
        groupBoxMercaderiasEnStock.Size = new Size(883, 589);
        groupBoxMercaderiasEnStock.TabIndex = 43;
        groupBoxMercaderiasEnStock.TabStop = false;
        groupBoxMercaderiasEnStock.Text = "Mercaderías en Stock";
        // 
        // textBoxBuscarSKU
        // 
        textBoxBuscarSKU.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBoxBuscarSKU.Location = new Point(311, 109);
        textBoxBuscarSKU.Name = "textBoxBuscarSKU";
        textBoxBuscarSKU.Size = new Size(135, 27);
        textBoxBuscarSKU.TabIndex = 53;
        // 
        // labelFiltroSKU
        // 
        labelFiltroSKU.AutoSize = true;
        labelFiltroSKU.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelFiltroSKU.Location = new Point(311, 89);
        labelFiltroSKU.Name = "labelFiltroSKU";
        labelFiltroSKU.Size = new Size(94, 17);
        labelFiltroSKU.TabIndex = 52;
        labelFiltroSKU.Text = "Filtrar por SKU";
        // 
        // buttonLimpiarFiltros
        // 
        buttonLimpiarFiltros.BackColor = Color.FromArgb(33, 150, 243);
        buttonLimpiarFiltros.FlatAppearance.BorderSize = 0;
        buttonLimpiarFiltros.FlatStyle = FlatStyle.Flat;
        buttonLimpiarFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonLimpiarFiltros.ForeColor = Color.White;
        buttonLimpiarFiltros.Location = new Point(727, 110);
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
        buttonBuscar.Location = new Point(619, 110);
        buttonBuscar.Name = "buttonBuscar";
        buttonBuscar.Size = new Size(102, 28);
        buttonBuscar.TabIndex = 35;
        buttonBuscar.Text = "Buscar";
        buttonBuscar.UseVisualStyleBackColor = false;
        buttonBuscar.Click += buttonBuscar_Click;
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
        // comboBoxBuscarPorCliente
        // 
        comboBoxBuscarPorCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxBuscarPorCliente.FormattingEnabled = true;
        comboBoxBuscarPorCliente.Location = new Point(9, 108);
        comboBoxBuscarPorCliente.Name = "comboBoxBuscarPorCliente";
        comboBoxBuscarPorCliente.Size = new Size(283, 29);
        comboBoxBuscarPorCliente.TabIndex = 34;
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
        // groupBoxUbicaciones
        // 
        groupBoxUbicaciones.Controls.Add(listViewDetalle);
        groupBoxUbicaciones.Location = new Point(0, 310);
        groupBoxUbicaciones.Name = "groupBoxUbicaciones";
        groupBoxUbicaciones.Size = new Size(874, 261);
        groupBoxUbicaciones.TabIndex = 43;
        groupBoxUbicaciones.TabStop = false;
        groupBoxUbicaciones.Text = "Detalle de Ubicaciones";
        // 
        // listViewDetalle
        // 
        listViewDetalle.Columns.AddRange(new ColumnHeader[] { columnHeaderDetalleUbicacion, columnHeaderDetalleCantidad });
        listViewDetalle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewDetalle.FullRowSelect = true;
        listViewDetalle.GridLines = true;
        listViewDetalle.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewDetalle.Location = new Point(9, 28);
        listViewDetalle.MultiSelect = false;
        listViewDetalle.Name = "listViewDetalle";
        listViewDetalle.Size = new Size(336, 227);
        listViewDetalle.TabIndex = 33;
        listViewDetalle.UseCompatibleStateImageBehavior = false;
        listViewDetalle.View = View.Details;
        // 
        // columnHeaderDetalleUbicacion
        // 
        columnHeaderDetalleUbicacion.Text = "Ubicacion";
        columnHeaderDetalleUbicacion.Width = 160;
        // 
        // columnHeaderDetalleCantidad
        // 
        columnHeaderDetalleCantidad.Text = "Cantidad Mercaderia";
        columnHeaderDetalleCantidad.Width = 150;
        // 
        // listViewMercaderiasEnStock
        // 
        listViewMercaderiasEnStock.Columns.AddRange(new ColumnHeader[] { columnHeaderSKU, columnHeaderSKUDeposito, columnHeaderSKUCantidad, columnHeaderSKUTipo, columnHeaderClienteNombre });
        listViewMercaderiasEnStock.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewMercaderiasEnStock.FullRowSelect = true;
        listViewMercaderiasEnStock.GridLines = true;
        listViewMercaderiasEnStock.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewMercaderiasEnStock.Location = new Point(9, 152);
        listViewMercaderiasEnStock.MultiSelect = false;
        listViewMercaderiasEnStock.Name = "listViewMercaderiasEnStock";
        listViewMercaderiasEnStock.Size = new Size(865, 152);
        listViewMercaderiasEnStock.TabIndex = 18;
        listViewMercaderiasEnStock.UseCompatibleStateImageBehavior = false;
        listViewMercaderiasEnStock.View = View.Details;
        listViewMercaderiasEnStock.SelectedIndexChanged += listViewMercaderiasEnStock_SelectedIndexChanged;
        // 
        // columnHeaderSKU
        // 
        columnHeaderSKU.Text = "SKU";
        columnHeaderSKU.Width = 170;
        // 
        // columnHeaderSKUDeposito
        // 
        columnHeaderSKUDeposito.Text = "Depósito";
        columnHeaderSKUDeposito.Width = 200;
        // 
        // columnHeaderSKUCantidad
        // 
        columnHeaderSKUCantidad.Text = "Cantidad Total";
        columnHeaderSKUCantidad.Width = 135;
        // 
        // columnHeaderSKUTipo
        // 
        columnHeaderSKUTipo.Text = "Tipo de Mercaderia";
        columnHeaderSKUTipo.Width = 150;
        // 
        // columnHeaderClienteNombre
        // 
        columnHeaderClienteNombre.Text = "Cliente";
        columnHeaderClienteNombre.Width = 200;
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
        pictureBoxLogo.Location = new Point(595, 12);
        pictureBoxLogo.Name = "pictureBoxLogo";
        pictureBoxLogo.Size = new Size(300, 60);
        pictureBoxLogo.TabIndex = 54;
        pictureBoxLogo.TabStop = false;
        // 
        // labelTitulo
        // 
        labelTitulo.AutoSize = true;
        labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        labelTitulo.Location = new Point(12, 9);
        labelTitulo.Name = "labelTitulo";
        labelTitulo.Size = new Size(436, 32);
        labelTitulo.TabIndex = 55;
        labelTitulo.Text = "Consulta de Ordenes de Preparación";
        // 
        // ConsultarStockDeMercaderiasForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(901, 679);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Controls.Add(groupBoxMercaderiasEnStock);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "ConsultarStockDeMercaderiasForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Consultar Stock De Mercaderias";
        Load += ConsultarStockDeMercaderiasForm_Load;
        groupBoxMercaderiasEnStock.ResumeLayout(false);
        groupBoxMercaderiasEnStock.PerformLayout();
        groupBoxUbicaciones.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox groupBoxMercaderiasEnStock;
    private Button buttonLimpiarFiltros;
    private Button buttonBuscar;
    private Label labelDeposito;
    private ComboBox comboBoxBuscarPorCliente;
    private ComboBox comboBoxDeposito;
    private GroupBox groupBoxUbicaciones;
    private ListView listViewDetalle;
    private ColumnHeader columnHeaderDetalleUbicacion;
    private ColumnHeader columnHeaderDetalleCantidad;
    private ListView listViewMercaderiasEnStock;
    private ColumnHeader columnHeaderSKU;
    private ColumnHeader columnHeaderSKUDeposito;
    private ColumnHeader columnHeaderClienteNombre;
    private ColumnHeader columnHeaderSKUCantidad;
    private Label labelCliente;
    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private Label labelFiltroSKU;
    private TextBox textBoxBuscarSKU;
    private ColumnHeader columnHeaderSKUTipo;
}