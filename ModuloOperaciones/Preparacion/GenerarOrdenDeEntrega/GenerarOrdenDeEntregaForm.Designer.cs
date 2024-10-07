namespace Pampazon.ModuloOperaciones.Empaquetado.GenerarOrdenDeEntrega;

partial class GenerarOrdenDeEntregaForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarOrdenDeEntregaForm));
        pictureBoxLogo = new PictureBox();
        labelTitulo = new Label();
        buttonSeleccionar = new Button();
        button1 = new Button();
        label1 = new Label();
        listView1 = new ListView();
        columnMercaderia = new ColumnHeader();
        columnCantidad = new ColumnHeader();
        button2 = new Button();
        listViewOrdenesDePreparacion = new ListView();
        columnHeaderNumeroDeOrden = new ColumnHeader();
        columnRazonSocial = new ColumnHeader();
        columnHeaderTransportista = new ColumnHeader();
        columnFechaDeDespacho = new ColumnHeader();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        SuspendLayout();
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
        pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
        pictureBoxLogo.Location = new Point(388, 4);
        pictureBoxLogo.Name = "pictureBoxLogo";
        pictureBoxLogo.Size = new Size(300, 60);
        pictureBoxLogo.TabIndex = 20;
        pictureBoxLogo.TabStop = false;
        // 
        // labelTitulo
        // 
        labelTitulo.AutoSize = true;
        labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        labelTitulo.Location = new Point(12, 9);
        labelTitulo.Name = "labelTitulo";
        labelTitulo.Size = new Size(323, 32);
        labelTitulo.TabIndex = 21;
        labelTitulo.Text = "Generar Orden De Entrega";
        // 
        // buttonSeleccionar
        // 
        buttonSeleccionar.BackColor = Color.FromArgb(33, 150, 243);
        buttonSeleccionar.FlatAppearance.BorderSize = 0;
        buttonSeleccionar.FlatStyle = FlatStyle.Flat;
        buttonSeleccionar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonSeleccionar.ForeColor = Color.White;
        buttonSeleccionar.Location = new Point(553, 261);
        buttonSeleccionar.Name = "buttonSeleccionar";
        buttonSeleccionar.Size = new Size(135, 27);
        buttonSeleccionar.TabIndex = 33;
        buttonSeleccionar.Text = "Seleccionar";
        buttonSeleccionar.UseVisualStyleBackColor = false;
        buttonSeleccionar.Click += buttonSeleccionar_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(33, 150, 243);
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button1.ForeColor = Color.White;
        button1.Location = new Point(400, 456);
        button1.Name = "button1";
        button1.Size = new Size(135, 27);
        button1.TabIndex = 34;
        button1.Text = "Aceptar";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label1.Location = new Point(19, 94);
        label1.Name = "label1";
        label1.Size = new Size(250, 15);
        label1.TabIndex = 35;
        label1.Text = "Seleccione la orden que desea preparar";
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new ColumnHeader[] { columnMercaderia, columnCantidad });
        listView1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listView1.FullRowSelect = true;
        listView1.GridLines = true;
        listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listView1.Location = new Point(19, 296);
        listView1.MultiSelect = false;
        listView1.Name = "listView1";
        listView1.Size = new Size(304, 134);
        listView1.TabIndex = 36;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
        // 
        // columnMercaderia
        // 
        columnMercaderia.Text = "Mercadería";
        columnMercaderia.Width = 150;
        // 
        // columnCantidad
        // 
        columnCantidad.Text = "Cantidad";
        columnCantidad.Width = 150;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(33, 150, 243);
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button2.ForeColor = Color.White;
        button2.Location = new Point(553, 456);
        button2.Name = "button2";
        button2.Size = new Size(135, 27);
        button2.TabIndex = 37;
        button2.Text = "Cancelar";
        button2.UseVisualStyleBackColor = false;
        // 
        // listViewOrdenesDePreparacion
        // 
        listViewOrdenesDePreparacion.Columns.AddRange(new ColumnHeader[] { columnHeaderNumeroDeOrden, columnRazonSocial, columnHeaderTransportista, columnFechaDeDespacho });
        listViewOrdenesDePreparacion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewOrdenesDePreparacion.FullRowSelect = true;
        listViewOrdenesDePreparacion.GridLines = true;
        listViewOrdenesDePreparacion.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewOrdenesDePreparacion.Location = new Point(19, 112);
        listViewOrdenesDePreparacion.MultiSelect = false;
        listViewOrdenesDePreparacion.Name = "listViewOrdenesDePreparacion";
        listViewOrdenesDePreparacion.Size = new Size(669, 134);
        listViewOrdenesDePreparacion.TabIndex = 22;
        listViewOrdenesDePreparacion.UseCompatibleStateImageBehavior = false;
        listViewOrdenesDePreparacion.View = View.Details;
        // 
        // columnHeaderNumeroDeOrden
        // 
        columnHeaderNumeroDeOrden.Text = "Numero de Orden";
        columnHeaderNumeroDeOrden.Width = 150;
        // 
        // columnRazonSocial
        // 
        columnRazonSocial.Text = "Razón Social";
        columnRazonSocial.Width = 150;
        // 
        // columnHeaderTransportista
        // 
        columnHeaderTransportista.Text = "Transportista";
        columnHeaderTransportista.Width = 150;
        // 
        // columnFechaDeDespacho
        // 
        columnFechaDeDespacho.Text = "Fecha de despacho";
        columnFechaDeDespacho.Width = 150;
        // 
        // GenerarOrdenDeEntregaForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(698, 495);
        Controls.Add(button2);
        Controls.Add(listView1);
        Controls.Add(label1);
        Controls.Add(button1);
        Controls.Add(buttonSeleccionar);
        Controls.Add(listViewOrdenesDePreparacion);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Name = "GenerarOrdenDeEntregaForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generar Orden De Entrega";
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private Button buttonSeleccionar;
    private Button button1;
    private Label label1;
    private ListView listView1;
    private ColumnHeader columnMercaderia;
    private ColumnHeader columnCantidad;
    private Button button2;
    private ListView listViewOrdenesDePreparacion;
    private ColumnHeader columnHeaderNumeroDeOrden;
    private ColumnHeader columnRazonSocial;
    private ColumnHeader columnHeaderTransportista;
    private ColumnHeader columnFechaDeDespacho;
}