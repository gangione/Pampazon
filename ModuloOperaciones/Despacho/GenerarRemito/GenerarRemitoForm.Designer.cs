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
        columnHeaderMercaderiaSKU = new ColumnHeader();
        buttonGenerarOrden = new Button();
        groupBoxRemito = new GroupBox();
        labelDeposito = new Label();
        comboBoxDeposito = new ComboBox();
        comboBoxTransportistas = new ComboBox();
        labelTransportista = new Label();
        groupBoxOrdenesDePreparacion = new GroupBox();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxRemito.SuspendLayout();
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
        listViewOrdenesDePreparacionPreparadas.Size = new Size(663, 379);
        listViewOrdenesDePreparacionPreparadas.TabIndex = 24;
        listViewOrdenesDePreparacionPreparadas.UseCompatibleStateImageBehavior = false;
        listViewOrdenesDePreparacionPreparadas.View = View.Details;
        // 
        // columnHeaderMercaderiaSKU
        // 
        columnHeaderMercaderiaSKU.Text = "SKU";
        columnHeaderMercaderiaSKU.Width = 150;
        // 
        // buttonGenerarOrden
        // 
        buttonGenerarOrden.BackColor = Color.FromArgb(33, 150, 243);
        buttonGenerarOrden.FlatAppearance.BorderSize = 0;
        buttonGenerarOrden.FlatStyle = FlatStyle.Flat;
        buttonGenerarOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonGenerarOrden.ForeColor = Color.White;
        buttonGenerarOrden.Location = new Point(484, 577);
        buttonGenerarOrden.Name = "buttonGenerarOrden";
        buttonGenerarOrden.Size = new Size(199, 47);
        buttonGenerarOrden.TabIndex = 40;
        buttonGenerarOrden.Text = "Confirmar Despacho y Generar Remito";
        buttonGenerarOrden.UseVisualStyleBackColor = false;
        buttonGenerarOrden.Click += buttonGenerarOrden_Click;
        // 
        // groupBoxRemito
        // 
        groupBoxRemito.Controls.Add(labelDeposito);
        groupBoxRemito.Controls.Add(comboBoxDeposito);
        groupBoxRemito.Controls.Add(comboBoxTransportistas);
        groupBoxRemito.Controls.Add(labelTransportista);
        groupBoxRemito.Controls.Add(groupBoxOrdenesDePreparacion);
        groupBoxRemito.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        groupBoxRemito.Location = new Point(12, 75);
        groupBoxRemito.Name = "groupBoxRemito";
        groupBoxRemito.Size = new Size(671, 549);
        groupBoxRemito.TabIndex = 41;
        groupBoxRemito.TabStop = false;
        groupBoxRemito.Text = "Remito";
        // 
        // labelDeposito
        // 
        labelDeposito.AutoSize = true;
        labelDeposito.Font = new Font("Segoe UI Symbol", 9.75F);
        labelDeposito.Location = new Point(6, 36);
        labelDeposito.Name = "labelDeposito";
        labelDeposito.Size = new Size(61, 17);
        labelDeposito.TabIndex = 57;
        labelDeposito.Text = "Depósito";
        // 
        // comboBoxDeposito
        // 
        comboBoxDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDeposito.FormattingEnabled = true;
        comboBoxDeposito.Location = new Point(7, 54);
        comboBoxDeposito.Name = "comboBoxDeposito";
        comboBoxDeposito.Size = new Size(267, 29);
        comboBoxDeposito.TabIndex = 56;
        comboBoxDeposito.SelectedIndexChanged += comboBoxTransportistas_SelectedIndexChanged;
        // 
        // comboBoxTransportistas
        // 
        comboBoxTransportistas.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxTransportistas.FormattingEnabled = true;
        comboBoxTransportistas.Location = new Point(297, 54);
        comboBoxTransportistas.Name = "comboBoxTransportistas";
        comboBoxTransportistas.Size = new Size(273, 29);
        comboBoxTransportistas.TabIndex = 43;
        comboBoxTransportistas.SelectedIndexChanged += comboBoxTransportistas_SelectedIndexChanged;
        // 
        // labelTransportista
        // 
        labelTransportista.AutoSize = true;
        labelTransportista.Font = new Font("Segoe UI Symbol", 9.75F);
        labelTransportista.Location = new Point(295, 34);
        labelTransportista.Name = "labelTransportista";
        labelTransportista.Size = new Size(164, 17);
        labelTransportista.TabIndex = 42;
        labelTransportista.Text = "Seleccionar Transportista *";
        // 
        // groupBoxOrdenesDePreparacion
        // 
        groupBoxOrdenesDePreparacion.Controls.Add(listViewOrdenesDePreparacionPreparadas);
        groupBoxOrdenesDePreparacion.Location = new Point(0, 89);
        groupBoxOrdenesDePreparacion.Name = "groupBoxOrdenesDePreparacion";
        groupBoxOrdenesDePreparacion.Size = new Size(670, 420);
        groupBoxOrdenesDePreparacion.TabIndex = 41;
        groupBoxOrdenesDePreparacion.TabStop = false;
        groupBoxOrdenesDePreparacion.Text = "Ordenes de Preparación a entregar";
        // 
        // GenerarRemitoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(699, 636);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Controls.Add(buttonGenerarOrden);
        Controls.Add(groupBoxRemito);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "GenerarRemitoForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generar Remito";
        Load += GenerarRemitoForm_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxRemito.ResumeLayout(false);
        groupBoxRemito.PerformLayout();
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
    private GroupBox groupBoxOrdenesDePreparacion;
    private ColumnHeader columnHeaderMercaderiaSKU;
    private ComboBox comboBoxTransportistas;
    private Label labelTransportista;
    private Label labelDeposito;
    private ComboBox comboBoxDeposito;
}