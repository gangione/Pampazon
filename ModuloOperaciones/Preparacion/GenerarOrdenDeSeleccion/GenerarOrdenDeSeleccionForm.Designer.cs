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
        columnHeaderNumero = new ColumnHeader();
        columnHeaderCliente = new ColumnHeader();
        columnHeaderCuit = new ColumnHeader();
        columnHeaderFechaDespacho = new ColumnHeader();
        groupBoxOrdenDeSeleccion = new GroupBox();
        listViewOrdenesASeleccionar = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        columnHeaderPrioridad = new ColumnHeader();
        groupBoxOrdenDePreparacion = new GroupBox();
        comboBoxPrioridad = new ComboBox();
        labelPrioridad = new Label();
        labelMercaderiasASeleccionar = new Label();
        listViewMercaderiasAPreparar = new ListView();
        columnHeaderMercaderia = new ColumnHeader();
        columnHeaderUM = new ColumnHeader();
        columnHeaderCantidad = new ColumnHeader();
        columnHeaderUbicacion = new ColumnHeader();
        buttonAgregar = new Button();
        buttonGenerarOrden = new Button();
        buttonEliminar = new Button();
        label2 = new Label();
        labelCliente = new Label();
        textBoxCliente = new TextBox();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxOrdenDeSeleccion.SuspendLayout();
        groupBoxOrdenDePreparacion.SuspendLayout();
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
        // listViewOrdenesDePreparacion
        // 
        listViewOrdenesDePreparacion.Columns.AddRange(new ColumnHeader[] { columnHeaderNumero, columnHeaderCliente, columnHeaderCuit, columnHeaderFechaDespacho });
        listViewOrdenesDePreparacion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewOrdenesDePreparacion.FullRowSelect = true;
        listViewOrdenesDePreparacion.GridLines = true;
        listViewOrdenesDePreparacion.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewOrdenesDePreparacion.Location = new Point(9, 28);
        listViewOrdenesDePreparacion.MultiSelect = false;
        listViewOrdenesDePreparacion.Name = "listViewOrdenesDePreparacion";
        listViewOrdenesDePreparacion.Size = new Size(942, 120);
        listViewOrdenesDePreparacion.TabIndex = 18;
        listViewOrdenesDePreparacion.UseCompatibleStateImageBehavior = false;
        listViewOrdenesDePreparacion.View = View.Details;
        listViewOrdenesDePreparacion.ItemSelectionChanged += listViewOrdenesDePreparacion_ItemSelectionChanged;
        // 
        // columnHeaderNumero
        // 
        columnHeaderNumero.Text = "Numero Orden";
        columnHeaderNumero.Width = 160;
        // 
        // columnHeaderCliente
        // 
        columnHeaderCliente.Text = "Cliente";
        columnHeaderCliente.Width = 200;
        // 
        // columnHeaderCuit
        // 
        columnHeaderCuit.Text = "CUIT";
        columnHeaderCuit.Width = 125;
        // 
        // columnHeaderFechaDespacho
        // 
        columnHeaderFechaDespacho.Text = "Fecha a Despachar";
        columnHeaderFechaDespacho.Width = 150;
        // 
        // groupBoxOrdenDeSeleccion
        // 
        groupBoxOrdenDeSeleccion.Controls.Add(listViewOrdenesASeleccionar);
        groupBoxOrdenDeSeleccion.Controls.Add(groupBoxOrdenDePreparacion);
        groupBoxOrdenDeSeleccion.Controls.Add(buttonGenerarOrden);
        groupBoxOrdenDeSeleccion.Controls.Add(buttonEliminar);
        groupBoxOrdenDeSeleccion.Controls.Add(label2);
        groupBoxOrdenDeSeleccion.Controls.Add(labelCliente);
        groupBoxOrdenDeSeleccion.Controls.Add(textBoxCliente);
        groupBoxOrdenDeSeleccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxOrdenDeSeleccion.Location = new Point(18, 75);
        groupBoxOrdenDeSeleccion.Name = "groupBoxOrdenDeSeleccion";
        groupBoxOrdenDeSeleccion.Size = new Size(970, 672);
        groupBoxOrdenDeSeleccion.TabIndex = 31;
        groupBoxOrdenDeSeleccion.TabStop = false;
        groupBoxOrdenDeSeleccion.Text = "Orden de Selección";
        // 
        // listViewOrdenesASeleccionar
        // 
        listViewOrdenesASeleccionar.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeaderPrioridad });
        listViewOrdenesASeleccionar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewOrdenesASeleccionar.FullRowSelect = true;
        listViewOrdenesASeleccionar.GridLines = true;
        listViewOrdenesASeleccionar.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewOrdenesASeleccionar.Location = new Point(9, 451);
        listViewOrdenesASeleccionar.MultiSelect = false;
        listViewOrdenesASeleccionar.Name = "listViewOrdenesASeleccionar";
        listViewOrdenesASeleccionar.Size = new Size(942, 120);
        listViewOrdenesASeleccionar.TabIndex = 33;
        listViewOrdenesASeleccionar.UseCompatibleStateImageBehavior = false;
        listViewOrdenesASeleccionar.View = View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Numero Orden";
        columnHeader1.Width = 160;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Cliente";
        columnHeader2.Width = 200;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "CUIT";
        columnHeader3.Width = 125;
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "Fecha a Despachar";
        columnHeader4.Width = 150;
        // 
        // columnHeaderPrioridad
        // 
        columnHeaderPrioridad.Text = "Prioridad";
        columnHeaderPrioridad.Width = 100;
        // 
        // groupBoxOrdenDePreparacion
        // 
        groupBoxOrdenDePreparacion.Controls.Add(comboBoxPrioridad);
        groupBoxOrdenDePreparacion.Controls.Add(labelPrioridad);
        groupBoxOrdenDePreparacion.Controls.Add(labelMercaderiasASeleccionar);
        groupBoxOrdenDePreparacion.Controls.Add(listViewMercaderiasAPreparar);
        groupBoxOrdenDePreparacion.Controls.Add(listViewOrdenesDePreparacion);
        groupBoxOrdenDePreparacion.Controls.Add(buttonAgregar);
        groupBoxOrdenDePreparacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxOrdenDePreparacion.Location = new Point(0, 91);
        groupBoxOrdenDePreparacion.Name = "groupBoxOrdenDePreparacion";
        groupBoxOrdenDePreparacion.Size = new Size(970, 339);
        groupBoxOrdenDePreparacion.TabIndex = 32;
        groupBoxOrdenDePreparacion.TabStop = false;
        groupBoxOrdenDePreparacion.Text = "Ordenes de Preparacion";
        // 
        // comboBoxPrioridad
        // 
        comboBoxPrioridad.FormattingEnabled = true;
        comboBoxPrioridad.Location = new Point(506, 170);
        comboBoxPrioridad.Name = "comboBoxPrioridad";
        comboBoxPrioridad.Size = new Size(121, 29);
        comboBoxPrioridad.TabIndex = 2;
        // 
        // labelPrioridad
        // 
        labelPrioridad.AutoSize = true;
        labelPrioridad.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelPrioridad.Location = new Point(506, 152);
        labelPrioridad.Name = "labelPrioridad";
        labelPrioridad.Size = new Size(64, 15);
        labelPrioridad.TabIndex = 30;
        labelPrioridad.Text = "Prioridad";
        // 
        // labelMercaderiasASeleccionar
        // 
        labelMercaderiasASeleccionar.AutoSize = true;
        labelMercaderiasASeleccionar.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelMercaderiasASeleccionar.Location = new Point(9, 152);
        labelMercaderiasASeleccionar.Name = "labelMercaderiasASeleccionar";
        labelMercaderiasASeleccionar.Size = new Size(168, 15);
        labelMercaderiasASeleccionar.TabIndex = 29;
        labelMercaderiasASeleccionar.Text = "Mercaderías a Seleccionar";
        // 
        // listViewMercaderiasAPreparar
        // 
        listViewMercaderiasAPreparar.Columns.AddRange(new ColumnHeader[] { columnHeaderMercaderia, columnHeaderUM, columnHeaderCantidad, columnHeaderUbicacion });
        listViewMercaderiasAPreparar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewMercaderiasAPreparar.FullRowSelect = true;
        listViewMercaderiasAPreparar.GridLines = true;
        listViewMercaderiasAPreparar.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewMercaderiasAPreparar.Location = new Point(9, 170);
        listViewMercaderiasAPreparar.MultiSelect = false;
        listViewMercaderiasAPreparar.Name = "listViewMercaderiasAPreparar";
        listViewMercaderiasAPreparar.Size = new Size(491, 120);
        listViewMercaderiasAPreparar.TabIndex = 27;
        listViewMercaderiasAPreparar.UseCompatibleStateImageBehavior = false;
        listViewMercaderiasAPreparar.View = View.Details;
        // 
        // columnHeaderMercaderia
        // 
        columnHeaderMercaderia.Text = "Mercaderia";
        columnHeaderMercaderia.Width = 125;
        // 
        // columnHeaderUM
        // 
        columnHeaderUM.Text = "Unidad de Medida";
        columnHeaderUM.Width = 130;
        // 
        // columnHeaderCantidad
        // 
        columnHeaderCantidad.Text = "Cantidad";
        columnHeaderCantidad.Width = 100;
        // 
        // columnHeaderUbicacion
        // 
        columnHeaderUbicacion.Text = "Ubicacion";
        columnHeaderUbicacion.Width = 100;
        // 
        // buttonAgregar
        // 
        buttonAgregar.BackColor = Color.FromArgb(33, 150, 243);
        buttonAgregar.FlatAppearance.BorderSize = 0;
        buttonAgregar.FlatStyle = FlatStyle.Flat;
        buttonAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonAgregar.ForeColor = Color.White;
        buttonAgregar.Location = new Point(750, 306);
        buttonAgregar.Name = "buttonAgregar";
        buttonAgregar.Size = new Size(201, 27);
        buttonAgregar.TabIndex = 25;
        buttonAgregar.Text = "+ Agregar a la selección";
        buttonAgregar.UseVisualStyleBackColor = false;
        buttonAgregar.Click += buttonAgregar_Click;
        // 
        // buttonGenerarOrden
        // 
        buttonGenerarOrden.BackColor = Color.FromArgb(33, 150, 243);
        buttonGenerarOrden.FlatAppearance.BorderSize = 0;
        buttonGenerarOrden.FlatStyle = FlatStyle.Flat;
        buttonGenerarOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonGenerarOrden.ForeColor = Color.White;
        buttonGenerarOrden.Location = new Point(752, 623);
        buttonGenerarOrden.Name = "buttonGenerarOrden";
        buttonGenerarOrden.Size = new Size(199, 43);
        buttonGenerarOrden.TabIndex = 26;
        buttonGenerarOrden.Text = "Generar Orden";
        buttonGenerarOrden.UseVisualStyleBackColor = false;
        buttonGenerarOrden.Click += buttonGenerarOrden_Click;
        // 
        // buttonEliminar
        // 
        buttonEliminar.BackColor = Color.FromArgb(33, 150, 243);
        buttonEliminar.FlatAppearance.BorderSize = 0;
        buttonEliminar.FlatStyle = FlatStyle.Flat;
        buttonEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonEliminar.ForeColor = Color.White;
        buttonEliminar.Location = new Point(750, 577);
        buttonEliminar.Name = "buttonEliminar";
        buttonEliminar.Size = new Size(201, 27);
        buttonEliminar.TabIndex = 24;
        buttonEliminar.TabStop = false;
        buttonEliminar.Text = "- Eliminar de la selección";
        buttonEliminar.UseVisualStyleBackColor = false;
        buttonEliminar.Click += buttonEliminar_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label2.Location = new Point(8, 433);
        label2.Name = "label2";
        label2.Size = new Size(240, 15);
        label2.TabIndex = 23;
        label2.Text = "Ordenes de Preparación a seleccionar";
        // 
        // labelCliente
        // 
        labelCliente.AutoSize = true;
        labelCliente.Font = new Font("Segoe UI Symbol", 10.25F, FontStyle.Bold);
        labelCliente.Location = new Point(9, 35);
        labelCliente.Name = "labelCliente";
        labelCliente.Size = new Size(70, 19);
        labelCliente.TabIndex = 21;
        labelCliente.Text = "Cliente *";
        // 
        // textBoxCliente
        // 
        textBoxCliente.AllowDrop = true;
        textBoxCliente.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBoxCliente.Location = new Point(7, 58);
        textBoxCliente.Name = "textBoxCliente";
        textBoxCliente.PlaceholderText = " Nombre / Razón Social";
        textBoxCliente.Size = new Size(186, 27);
        textBoxCliente.TabIndex = 1;
        // 
        // GenerarOrdenDeSeleccionForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1008, 759);
        Controls.Add(groupBoxOrdenDeSeleccion);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Name = "GenerarOrdenDeSeleccionForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generar Orden De Seleccion";
        Load += GenerarOrdenDeSeleccionForm_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxOrdenDeSeleccion.ResumeLayout(false);
        groupBoxOrdenDeSeleccion.PerformLayout();
        groupBoxOrdenDePreparacion.ResumeLayout(false);
        groupBoxOrdenDePreparacion.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private ListView listViewOrdenesDePreparacion;
    private ColumnHeader columnHeaderNumero;
    private ColumnHeader columnHeaderCuit;
    private GroupBox groupBoxOrdenDeSeleccion;
    private Label labelCliente;
    private TextBox textBoxCliente;
    private Label label2;
    private Button buttonEliminar;
    private Button buttonAgregar;
    private Button buttonGenerarOrden;
    private ColumnHeader columnHeaderFechaDespacho;
    private ColumnHeader columnHeaderCliente;
    private GroupBox groupBoxOrdenDePreparacion;
    private Label labelMercaderiasASeleccionar;
    private ListView listViewMercaderiasAPreparar;
    private ColumnHeader columnHeaderMercaderia;
    private ColumnHeader columnHeaderCantidad;
    private ColumnHeader columnHeaderUbicacion;
    private Label labelPrioridad;
    private ComboBox comboBoxPrioridad;
    private ListView listViewOrdenesASeleccionar;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeaderPrioridad;
    private ColumnHeader columnHeaderUM;
}