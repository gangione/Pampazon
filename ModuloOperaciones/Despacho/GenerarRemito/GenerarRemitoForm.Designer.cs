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
        columnHeaderOrdenDePreparacionNro = new ColumnHeader();
        columnOrdenDePreparacionCliente = new ColumnHeader();
        columnHeaderOrdenDePrepracionMercaderiaCantidad = new ColumnHeader();
        listViewOrdenesDePreparacionPreparadas = new ListView();
        buttonGenerarOrden = new Button();
        groupBoxRemito = new GroupBox();
        groupBoxTransportista = new GroupBox();
        labelDNITransportista = new Label();
        labelNombreTransportista = new Label();
        textBoxDNITransportista = new TextBox();
        textBoxNombreTransportista = new TextBox();
        groupBoxOrdenesDePreparacion = new GroupBox();
        columnHeaderMercaderiaSKU = new ColumnHeader();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxRemito.SuspendLayout();
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
        // columnHeaderOrdenDePrepracionMercaderiaCantidad
        // 
        columnHeaderOrdenDePrepracionMercaderiaCantidad.Text = "Cantidad de Mercaderías";
        columnHeaderOrdenDePrepracionMercaderiaCantidad.Width = 180;
        // 
        // listViewOrdenesDePreparacionPreparadas
        // 
        listViewOrdenesDePreparacionPreparadas.Columns.AddRange(new ColumnHeader[] { columnHeaderOrdenDePreparacionNro, columnOrdenDePreparacionCliente, columnHeaderMercaderiaSKU, columnHeaderOrdenDePrepracionMercaderiaCantidad });
        listViewOrdenesDePreparacionPreparadas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewOrdenesDePreparacionPreparadas.FullRowSelect = true;
        listViewOrdenesDePreparacionPreparadas.GridLines = true;
        listViewOrdenesDePreparacionPreparadas.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewOrdenesDePreparacionPreparadas.Location = new Point(7, 28);
        listViewOrdenesDePreparacionPreparadas.MultiSelect = false;
        listViewOrdenesDePreparacionPreparadas.Name = "listViewOrdenesDePreparacionPreparadas";
        listViewOrdenesDePreparacionPreparadas.Size = new Size(663, 261);
        listViewOrdenesDePreparacionPreparadas.TabIndex = 24;
        listViewOrdenesDePreparacionPreparadas.UseCompatibleStateImageBehavior = false;
        listViewOrdenesDePreparacionPreparadas.View = View.Details;
        // 
        // buttonGenerarOrden
        // 
        buttonGenerarOrden.BackColor = Color.FromArgb(33, 150, 243);
        buttonGenerarOrden.FlatAppearance.BorderSize = 0;
        buttonGenerarOrden.FlatStyle = FlatStyle.Flat;
        buttonGenerarOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonGenerarOrden.ForeColor = Color.White;
        buttonGenerarOrden.Location = new Point(472, 434);
        buttonGenerarOrden.Name = "buttonGenerarOrden";
        buttonGenerarOrden.Size = new Size(199, 47);
        buttonGenerarOrden.TabIndex = 40;
        buttonGenerarOrden.Text = "Confirmar Despacho y Generar Remito";
        buttonGenerarOrden.UseVisualStyleBackColor = false;
        buttonGenerarOrden.Click += buttonGenerarOrden_Click;
        // 
        // groupBoxRemito
        // 
        groupBoxRemito.Controls.Add(buttonGenerarOrden);
        groupBoxRemito.Controls.Add(groupBoxTransportista);
        groupBoxRemito.Controls.Add(groupBoxOrdenesDePreparacion);
        groupBoxRemito.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        groupBoxRemito.Location = new Point(12, 62);
        groupBoxRemito.Name = "groupBoxRemito";
        groupBoxRemito.Size = new Size(671, 481);
        groupBoxRemito.TabIndex = 41;
        groupBoxRemito.TabStop = false;
        groupBoxRemito.Text = "Remito";
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
        groupBoxOrdenesDePreparacion.Controls.Add(listViewOrdenesDePreparacionPreparadas);
        groupBoxOrdenesDePreparacion.Location = new Point(0, 125);
        groupBoxOrdenesDePreparacion.Name = "groupBoxOrdenesDePreparacion";
        groupBoxOrdenesDePreparacion.Size = new Size(670, 289);
        groupBoxOrdenesDePreparacion.TabIndex = 41;
        groupBoxOrdenesDePreparacion.TabStop = false;
        groupBoxOrdenesDePreparacion.Text = "Ordenes de Preparación Preparadas";
        // 
        // columnHeaderMercaderiaSKU
        // 
        columnHeaderMercaderiaSKU.Text = "SKU";
        columnHeaderMercaderiaSKU.Width = 150;
        // 
        // GenerarRemitoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(699, 563);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Controls.Add(groupBoxRemito);
        Name = "GenerarRemitoForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generar Remito";
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxRemito.ResumeLayout(false);
        groupBoxTransportista.ResumeLayout(false);
        groupBoxTransportista.PerformLayout();
        groupBoxOrdenesDePreparacion.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private ColumnHeader columnHeaderOrdenDePreparacionNro;
    private ColumnHeader columnOrdenDePreparacionCliente;
    private ColumnHeader columnHeaderOrdenDePrepracionMercaderiaCantidad;
    private ListView listViewOrdenesDePreparacionPreparadas;
    private Button buttonGenerarOrden;
    private GroupBox groupBoxRemito;
    private GroupBox groupBoxTransportista;
    private Label labelDNITransportista;
    private Label labelNombreTransportista;
    private TextBox textBoxDNITransportista;
    private TextBox textBoxNombreTransportista;
    private GroupBox groupBoxOrdenesDePreparacion;
    private ColumnHeader columnHeaderMercaderiaSKU;
}