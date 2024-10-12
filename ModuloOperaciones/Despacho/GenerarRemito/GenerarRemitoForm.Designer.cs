namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito;

partial class GenerarRemitoForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarRemitoForm));
        pictureBoxLogo = new PictureBox();
        labelTitulo = new Label();
        buttonDespachar = new Button();
        columnHeaderOrdenDePreparacionNro = new ColumnHeader();
        columnOrdenDePreparacionCliente = new ColumnHeader();
        columnHeaderOrdenDePrepracionObservaciones = new ColumnHeader();
        listViewOrdenesDePreparacionPreparadas = new ListView();
        listViewMercaderiasAEntregar = new ListView();
        columnHeaderRemitoMercaderia = new ColumnHeader();
        columnHeaderRemitoMercaderiaCantidad = new ColumnHeader();
        columnHeaderRemitoMercaderiaNroOrden = new ColumnHeader();
        buttonGenerarOrden = new Button();
        groupBoxRemito = new GroupBox();
        groupBoxMercaderiasAEntregar = new GroupBox();
        groupBoxTransportista = new GroupBox();
        labelDNITransportista = new Label();
        labelNombreTransportista = new Label();
        textBoxDNITransportista = new TextBox();
        textBoxNombreTransportista = new TextBox();
        groupBoxOrdenesDePreparacion = new GroupBox();
        labelDetalleOrdenDePreparacion = new Label();
        listViewOrdenDePreparacionMercaderias = new ListView();
        columnHeaderOrdenDePreparacionMercaderia = new ColumnHeader();
        columnHeaderOrdenDePreparacionMercaderiaCantidad = new ColumnHeader();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxRemito.SuspendLayout();
        groupBoxMercaderiasAEntregar.SuspendLayout();
        groupBoxTransportista.SuspendLayout();
        groupBoxOrdenesDePreparacion.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
        pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
        pictureBoxLogo.Location = new Point(382, 9);
        pictureBoxLogo.Name = "pictureBoxLogo";
        pictureBoxLogo.Size = new Size(300, 60);
        pictureBoxLogo.TabIndex = 22;
        pictureBoxLogo.TabStop = false;
        // 
        // labelTitulo
        // 
        labelTitulo.AutoSize = true;
        labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        labelTitulo.Location = new Point(12, 9);
        labelTitulo.Name = "labelTitulo";
        labelTitulo.Size = new Size(313, 32);
        labelTitulo.TabIndex = 23;
        labelTitulo.Text = "Despacho de Mercaderías";
        // 
        // buttonDespachar
        // 
        buttonDespachar.BackColor = Color.FromArgb(33, 150, 243);
        buttonDespachar.FlatAppearance.BorderSize = 0;
        buttonDespachar.FlatStyle = FlatStyle.Flat;
        buttonDespachar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonDespachar.ForeColor = Color.White;
        buttonDespachar.Location = new Point(471, 262);
        buttonDespachar.Name = "buttonDespachar";
        buttonDespachar.Size = new Size(200, 27);
        buttonDespachar.TabIndex = 35;
        buttonDespachar.Text = "Confirmar Despacho";
        buttonDespachar.UseVisualStyleBackColor = false;
        buttonDespachar.Click += buttonDespachar_Click;
        // 
        // columnHeaderOrdenDePreparacionNro
        // 
        columnHeaderOrdenDePreparacionNro.Text = "N° Orden de Preparación";
        columnHeaderOrdenDePreparacionNro.Width = 170;
        // 
        // columnOrdenDePreparacionCliente
        // 
        columnOrdenDePreparacionCliente.Text = "Cliente";
        columnOrdenDePreparacionCliente.Width = 150;
        // 
        // columnHeaderOrdenDePrepracionObservaciones
        // 
        columnHeaderOrdenDePrepracionObservaciones.Text = "Observaciones";
        columnHeaderOrdenDePrepracionObservaciones.Width = 330;
        // 
        // listViewOrdenesDePreparacionPreparadas
        // 
        listViewOrdenesDePreparacionPreparadas.Columns.AddRange(new ColumnHeader[] { columnHeaderOrdenDePreparacionNro, columnOrdenDePreparacionCliente, columnHeaderOrdenDePrepracionObservaciones });
        listViewOrdenesDePreparacionPreparadas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewOrdenesDePreparacionPreparadas.FullRowSelect = true;
        listViewOrdenesDePreparacionPreparadas.GridLines = true;
        listViewOrdenesDePreparacionPreparadas.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewOrdenesDePreparacionPreparadas.Location = new Point(7, 28);
        listViewOrdenesDePreparacionPreparadas.MultiSelect = false;
        listViewOrdenesDePreparacionPreparadas.Name = "listViewOrdenesDePreparacionPreparadas";
        listViewOrdenesDePreparacionPreparadas.Size = new Size(663, 97);
        listViewOrdenesDePreparacionPreparadas.TabIndex = 24;
        listViewOrdenesDePreparacionPreparadas.UseCompatibleStateImageBehavior = false;
        listViewOrdenesDePreparacionPreparadas.View = View.Details;
        // 
        // listViewMercaderiasAEntregar
        // 
        listViewMercaderiasAEntregar.Columns.AddRange(new ColumnHeader[] { columnHeaderRemitoMercaderia, columnHeaderRemitoMercaderiaCantidad, columnHeaderRemitoMercaderiaNroOrden });
        listViewMercaderiasAEntregar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewMercaderiasAEntregar.FullRowSelect = true;
        listViewMercaderiasAEntregar.GridLines = true;
        listViewMercaderiasAEntregar.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewMercaderiasAEntregar.Location = new Point(7, 38);
        listViewMercaderiasAEntregar.MultiSelect = false;
        listViewMercaderiasAEntregar.Name = "listViewMercaderiasAEntregar";
        listViewMercaderiasAEntregar.Size = new Size(664, 104);
        listViewMercaderiasAEntregar.TabIndex = 37;
        listViewMercaderiasAEntregar.UseCompatibleStateImageBehavior = false;
        listViewMercaderiasAEntregar.View = View.Details;
        // 
        // columnHeaderRemitoMercaderia
        // 
        columnHeaderRemitoMercaderia.Text = "Tipo de Mercaderia";
        columnHeaderRemitoMercaderia.Width = 150;
        // 
        // columnHeaderRemitoMercaderiaCantidad
        // 
        columnHeaderRemitoMercaderiaCantidad.Text = "Cantidad de Mercadería";
        columnHeaderRemitoMercaderiaCantidad.Width = 160;
        // 
        // columnHeaderRemitoMercaderiaNroOrden
        // 
        columnHeaderRemitoMercaderiaNroOrden.Text = "N° Orden de Preparación";
        columnHeaderRemitoMercaderiaNroOrden.Width = 170;
        // 
        // buttonGenerarOrden
        // 
        buttonGenerarOrden.BackColor = Color.FromArgb(33, 150, 243);
        buttonGenerarOrden.FlatAppearance.BorderSize = 0;
        buttonGenerarOrden.FlatStyle = FlatStyle.Flat;
        buttonGenerarOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonGenerarOrden.ForeColor = Color.White;
        buttonGenerarOrden.Location = new Point(483, 643);
        buttonGenerarOrden.Name = "buttonGenerarOrden";
        buttonGenerarOrden.Size = new Size(199, 43);
        buttonGenerarOrden.TabIndex = 40;
        buttonGenerarOrden.Text = "Generar Remito";
        buttonGenerarOrden.UseVisualStyleBackColor = false;
        buttonGenerarOrden.Click += buttonGenerarOrden_Click;
        // 
        // groupBoxRemito
        // 
        groupBoxRemito.Controls.Add(groupBoxMercaderiasAEntregar);
        groupBoxRemito.Controls.Add(groupBoxTransportista);
        groupBoxRemito.Controls.Add(groupBoxOrdenesDePreparacion);
        groupBoxRemito.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        groupBoxRemito.Location = new Point(12, 62);
        groupBoxRemito.Name = "groupBoxRemito";
        groupBoxRemito.Size = new Size(671, 624);
        groupBoxRemito.TabIndex = 41;
        groupBoxRemito.TabStop = false;
        groupBoxRemito.Text = "Remito";
        // 
        // groupBoxMercaderiasAEntregar
        // 
        groupBoxMercaderiasAEntregar.Controls.Add(listViewMercaderiasAEntregar);
        groupBoxMercaderiasAEntregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxMercaderiasAEntregar.Location = new Point(0, 420);
        groupBoxMercaderiasAEntregar.Name = "groupBoxMercaderiasAEntregar";
        groupBoxMercaderiasAEntregar.Size = new Size(671, 149);
        groupBoxMercaderiasAEntregar.TabIndex = 42;
        groupBoxMercaderiasAEntregar.TabStop = false;
        groupBoxMercaderiasAEntregar.Text = "Mercaderías a entregar al Transportista";
        // 
        // groupBoxTransportista
        // 
        groupBoxTransportista.Controls.Add(labelDNITransportista);
        groupBoxTransportista.Controls.Add(labelNombreTransportista);
        groupBoxTransportista.Controls.Add(textBoxDNITransportista);
        groupBoxTransportista.Controls.Add(textBoxNombreTransportista);
        groupBoxTransportista.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxTransportista.Location = new Point(0, 28);
        groupBoxTransportista.Name = "groupBoxTransportista";
        groupBoxTransportista.Size = new Size(671, 91);
        groupBoxTransportista.TabIndex = 40;
        groupBoxTransportista.TabStop = false;
        groupBoxTransportista.Text = "Transportista";
        // 
        // labelDNITransportista
        // 
        labelDNITransportista.AutoSize = true;
        labelDNITransportista.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelDNITransportista.Location = new Point(221, 36);
        labelDNITransportista.Name = "labelDNITransportista";
        labelDNITransportista.Size = new Size(40, 15);
        labelDNITransportista.TabIndex = 16;
        labelDNITransportista.Text = "DNI *";
        // 
        // labelNombreTransportista
        // 
        labelNombreTransportista.AutoSize = true;
        labelNombreTransportista.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelNombreTransportista.Location = new Point(7, 36);
        labelNombreTransportista.Name = "labelNombreTransportista";
        labelNombreTransportista.Size = new Size(132, 15);
        labelNombreTransportista.TabIndex = 14;
        labelNombreTransportista.Text = "Nombre y apellido *";
        // 
        // textBoxDNITransportista
        // 
        textBoxDNITransportista.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBoxDNITransportista.Location = new Point(220, 59);
        textBoxDNITransportista.Name = "textBoxDNITransportista";
        textBoxDNITransportista.Size = new Size(186, 27);
        textBoxDNITransportista.TabIndex = 5;
        // 
        // textBoxNombreTransportista
        // 
        textBoxNombreTransportista.CharacterCasing = CharacterCasing.Upper;
        textBoxNombreTransportista.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBoxNombreTransportista.Location = new Point(7, 59);
        textBoxNombreTransportista.Name = "textBoxNombreTransportista";
        textBoxNombreTransportista.Size = new Size(186, 27);
        textBoxNombreTransportista.TabIndex = 4;
        // 
        // groupBoxOrdenesDePreparacion
        // 
        groupBoxOrdenesDePreparacion.Controls.Add(labelDetalleOrdenDePreparacion);
        groupBoxOrdenesDePreparacion.Controls.Add(listViewOrdenDePreparacionMercaderias);
        groupBoxOrdenesDePreparacion.Controls.Add(buttonDespachar);
        groupBoxOrdenesDePreparacion.Controls.Add(listViewOrdenesDePreparacionPreparadas);
        groupBoxOrdenesDePreparacion.Location = new Point(0, 125);
        groupBoxOrdenesDePreparacion.Name = "groupBoxOrdenesDePreparacion";
        groupBoxOrdenesDePreparacion.Size = new Size(670, 289);
        groupBoxOrdenesDePreparacion.TabIndex = 41;
        groupBoxOrdenesDePreparacion.TabStop = false;
        groupBoxOrdenesDePreparacion.Text = "Ordenes de Preparación Preparadas";
        // 
        // labelDetalleOrdenDePreparacion
        // 
        labelDetalleOrdenDePreparacion.AutoSize = true;
        labelDetalleOrdenDePreparacion.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelDetalleOrdenDePreparacion.Location = new Point(7, 133);
        labelDetalleOrdenDePreparacion.Name = "labelDetalleOrdenDePreparacion";
        labelDetalleOrdenDePreparacion.Size = new Size(224, 15);
        labelDetalleOrdenDePreparacion.TabIndex = 38;
        labelDetalleOrdenDePreparacion.Text = "Detalle de Mercaderías de la Orden";
        // 
        // listViewOrdenDePreparacionMercaderias
        // 
        listViewOrdenDePreparacionMercaderias.Columns.AddRange(new ColumnHeader[] { columnHeaderOrdenDePreparacionMercaderia, columnHeaderOrdenDePreparacionMercaderiaCantidad });
        listViewOrdenDePreparacionMercaderias.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewOrdenDePreparacionMercaderias.FullRowSelect = true;
        listViewOrdenDePreparacionMercaderias.GridLines = true;
        listViewOrdenDePreparacionMercaderias.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewOrdenDePreparacionMercaderias.Location = new Point(7, 151);
        listViewOrdenDePreparacionMercaderias.MultiSelect = false;
        listViewOrdenDePreparacionMercaderias.Name = "listViewOrdenDePreparacionMercaderias";
        listViewOrdenDePreparacionMercaderias.Size = new Size(663, 92);
        listViewOrdenDePreparacionMercaderias.TabIndex = 37;
        listViewOrdenDePreparacionMercaderias.UseCompatibleStateImageBehavior = false;
        listViewOrdenDePreparacionMercaderias.View = View.Details;
        // 
        // columnHeaderOrdenDePreparacionMercaderia
        // 
        columnHeaderOrdenDePreparacionMercaderia.Text = "Tipo de Mercaderia";
        columnHeaderOrdenDePreparacionMercaderia.Width = 150;
        // 
        // columnHeaderOrdenDePreparacionMercaderiaCantidad
        // 
        columnHeaderOrdenDePreparacionMercaderiaCantidad.Text = "Cantidad de Mercadería";
        columnHeaderOrdenDePreparacionMercaderiaCantidad.Width = 160;
        // 
        // GenerarRemitoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(699, 702);
        Controls.Add(buttonGenerarOrden);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Controls.Add(groupBoxRemito);
        Name = "GenerarRemitoForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generar Remito";
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxRemito.ResumeLayout(false);
        groupBoxMercaderiasAEntregar.ResumeLayout(false);
        groupBoxTransportista.ResumeLayout(false);
        groupBoxTransportista.PerformLayout();
        groupBoxOrdenesDePreparacion.ResumeLayout(false);
        groupBoxOrdenesDePreparacion.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private Button buttonDespachar;
    private ColumnHeader columnHeaderOrdenDePreparacionNro;
    private ColumnHeader columnOrdenDePreparacionCliente;
    private ColumnHeader columnHeaderOrdenDePrepracionObservaciones;
    private ListView listViewOrdenesDePreparacionPreparadas;
    private ListView listViewMercaderiasAEntregar;
    private ColumnHeader columnHeaderRemitoMercaderia;
    private ColumnHeader columnHeaderRemitoMercaderiaCantidad;
    private ColumnHeader columnHeaderRemitoMercaderiaNroOrden;
    private Button buttonGenerarOrden;
    private GroupBox groupBoxRemito;
    private GroupBox groupBoxTransportista;
    private Label labelDNITransportista;
    private Label labelNombreTransportista;
    private TextBox textBoxDNITransportista;
    private TextBox textBoxNombreTransportista;
    private GroupBox groupBoxMercaderiasAEntregar;
    private GroupBox groupBoxOrdenesDePreparacion;
    private Label labelDetalleOrdenDePreparacion;
    private ListView listViewOrdenDePreparacionMercaderias;
    private ColumnHeader columnHeaderOrdenDePreparacionMercaderia;
    private ColumnHeader columnHeaderOrdenDePreparacionMercaderiaCantidad;
}