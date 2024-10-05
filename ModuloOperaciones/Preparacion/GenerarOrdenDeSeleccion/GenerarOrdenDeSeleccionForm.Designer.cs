namespace Pampazon.ModuloOperaciones.Empaquetado.GenerarOrdenDeSeleccion;

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
        listViewStockMercaderias = new ListView();
        columnHeaderNumeroOrden = new ColumnHeader();
        columnHeaderCuit = new ColumnHeader();
        columnHeaderCantidadMercaderia = new ColumnHeader();
        groupBoxTransportista = new GroupBox();
        label1 = new Label();
        labelCliente = new Label();
        textBoxCliente = new TextBox();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxTransportista.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
        pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
        pictureBoxLogo.Location = new Point(688, 9);
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
        // listViewStockMercaderias
        // 
        listViewStockMercaderias.Columns.AddRange(new ColumnHeader[] { columnHeaderNumeroOrden, columnHeaderCuit, columnHeaderCantidadMercaderia });
        listViewStockMercaderias.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewStockMercaderias.FullRowSelect = true;
        listViewStockMercaderias.GridLines = true;
        listViewStockMercaderias.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewStockMercaderias.Location = new Point(7, 119);
        listViewStockMercaderias.MultiSelect = false;
        listViewStockMercaderias.Name = "listViewStockMercaderias";
        listViewStockMercaderias.Size = new Size(952, 120);
        listViewStockMercaderias.TabIndex = 18;
        listViewStockMercaderias.UseCompatibleStateImageBehavior = false;
        listViewStockMercaderias.View = View.Details;
        // 
        // columnHeaderNumeroOrden
        // 
        columnHeaderNumeroOrden.Text = "Numero Orden";
        columnHeaderNumeroOrden.Width = 160;
        // 
        // columnHeaderCuit
        // 
        columnHeaderCuit.Text = "CUIT";
        columnHeaderCuit.Width = 125;
        // 
        // columnHeaderCantidadMercaderia
        // 
        columnHeaderCantidadMercaderia.Text = "Mercaderia";
        columnHeaderCantidadMercaderia.Width = 125;
        // 
        // groupBoxTransportista
        // 
        groupBoxTransportista.Controls.Add(labelCliente);
        groupBoxTransportista.Controls.Add(textBoxCliente);
        groupBoxTransportista.Controls.Add(label1);
        groupBoxTransportista.Controls.Add(listViewStockMercaderias);
        groupBoxTransportista.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxTransportista.Location = new Point(18, 75);
        groupBoxTransportista.Name = "groupBoxTransportista";
        groupBoxTransportista.Size = new Size(970, 363);
        groupBoxTransportista.TabIndex = 31;
        groupBoxTransportista.TabStop = false;
        groupBoxTransportista.Text = "Orden de Selección";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label1.Location = new Point(7, 101);
        label1.Name = "label1";
        label1.Size = new Size(155, 15);
        label1.TabIndex = 19;
        label1.Text = "Ordenes de Preparación";
        // 
        // labelCliente
        // 
        labelCliente.AutoSize = true;
        labelCliente.Font = new Font("Segoe UI Symbol", 10.25F, FontStyle.Bold);
        labelCliente.Location = new Point(9, 35);
        labelCliente.Name = "labelCliente";
        labelCliente.Size = new Size(58, 19);
        labelCliente.TabIndex = 21;
        labelCliente.Text = "Cliente";
        // 
        // textBoxCliente
        // 
        textBoxCliente.AllowDrop = true;
        textBoxCliente.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBoxCliente.Location = new Point(7, 58);
        textBoxCliente.Name = "textBoxCliente";
        textBoxCliente.PlaceholderText = " Nombre / Razón Social";
        textBoxCliente.Size = new Size(186, 27);
        textBoxCliente.TabIndex = 20;
        // 
        // GenerarOrdenDeSeleccionForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1008, 450);
        Controls.Add(groupBoxTransportista);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Name = "GenerarOrdenDeSeleccionForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generar Orden De Seleccion";
        Load += GenerarOrdenDeSeleccionForm_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxTransportista.ResumeLayout(false);
        groupBoxTransportista.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private ListView listViewStockMercaderias;
    private ColumnHeader columnHeaderNumeroOrden;
    private ColumnHeader columnHeaderCuit;
    private ColumnHeader columnHeaderCantidadMercaderia;
    private GroupBox groupBoxTransportista;
    private Label label1;
    private Label labelCliente;
    private TextBox textBoxCliente;
}