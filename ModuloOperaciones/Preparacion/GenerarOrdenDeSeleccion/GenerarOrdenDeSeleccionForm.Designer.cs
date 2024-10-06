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
        labelCliente = new Label();
        textBoxCliente = new TextBox();
        label1 = new Label();
        label2 = new Label();
        listView1 = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        buttonEliminar = new Button();
        buttonAgregar = new Button();
        buttonGenerarOrden = new Button();
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
        groupBoxTransportista.Controls.Add(buttonGenerarOrden);
        groupBoxTransportista.Controls.Add(buttonAgregar);
        groupBoxTransportista.Controls.Add(buttonEliminar);
        groupBoxTransportista.Controls.Add(label2);
        groupBoxTransportista.Controls.Add(listView1);
        groupBoxTransportista.Controls.Add(labelCliente);
        groupBoxTransportista.Controls.Add(textBoxCliente);
        groupBoxTransportista.Controls.Add(label1);
        groupBoxTransportista.Controls.Add(listViewStockMercaderias);
        groupBoxTransportista.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxTransportista.Location = new Point(18, 75);
        groupBoxTransportista.Name = "groupBoxTransportista";
        groupBoxTransportista.Size = new Size(970, 556);
        groupBoxTransportista.TabIndex = 31;
        groupBoxTransportista.TabStop = false;
        groupBoxTransportista.Text = "Orden de Selección";
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
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label2.Location = new Point(6, 308);
        label2.Name = "label2";
        label2.Size = new Size(127, 15);
        label2.TabIndex = 23;
        label2.Text = "Orden de Selección";
        label2.Click += label2_Click;
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
        listView1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listView1.FullRowSelect = true;
        listView1.GridLines = true;
        listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listView1.Location = new Point(6, 326);
        listView1.MultiSelect = false;
        listView1.Name = "listView1";
        listView1.Size = new Size(952, 120);
        listView1.TabIndex = 22;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Numero Orden";
        columnHeader1.Width = 160;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "CUIT";
        columnHeader2.Width = 125;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "Mercaderia";
        columnHeader3.Width = 125;
        // 
        // buttonEliminar
        // 
        buttonEliminar.BackColor = Color.FromArgb(33, 150, 243);
        buttonEliminar.FlatAppearance.BorderSize = 0;
        buttonEliminar.FlatStyle = FlatStyle.Flat;
        buttonEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonEliminar.ForeColor = Color.White;
        buttonEliminar.Location = new Point(9, 452);
        buttonEliminar.Name = "buttonEliminar";
        buttonEliminar.Size = new Size(94, 27);
        buttonEliminar.TabIndex = 24;
        buttonEliminar.TabStop = false;
        buttonEliminar.Text = "- Eliminar";
        buttonEliminar.UseVisualStyleBackColor = false;
        // 
        // buttonAgregar
        // 
        buttonAgregar.BackColor = Color.FromArgb(33, 150, 243);
        buttonAgregar.FlatAppearance.BorderSize = 0;
        buttonAgregar.FlatStyle = FlatStyle.Flat;
        buttonAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonAgregar.ForeColor = Color.White;
        buttonAgregar.Location = new Point(9, 245);
        buttonAgregar.Name = "buttonAgregar";
        buttonAgregar.Size = new Size(89, 27);
        buttonAgregar.TabIndex = 25;
        buttonAgregar.Text = "+ Agregar";
        buttonAgregar.UseVisualStyleBackColor = false;
        // 
        // buttonGenerarOrden
        // 
        buttonGenerarOrden.BackColor = Color.FromArgb(33, 150, 243);
        buttonGenerarOrden.FlatAppearance.BorderSize = 0;
        buttonGenerarOrden.FlatStyle = FlatStyle.Flat;
        buttonGenerarOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonGenerarOrden.ForeColor = Color.White;
        buttonGenerarOrden.Location = new Point(750, 496);
        buttonGenerarOrden.Name = "buttonGenerarOrden";
        buttonGenerarOrden.Size = new Size(199, 43);
        buttonGenerarOrden.TabIndex = 26;
        buttonGenerarOrden.Text = "Generar Orden";
        buttonGenerarOrden.UseVisualStyleBackColor = false;
        // 
        // GenerarOrdenDeSeleccionForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1008, 643);
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
    private Label label2;
    private ListView listView1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private Button buttonEliminar;
    private Button buttonAgregar;
    private Button buttonGenerarOrden;
}