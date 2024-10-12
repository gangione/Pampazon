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
        groupBoxOrdenDeSeleccion = new GroupBox();
        buttonConfirmarPreparacion = new Button();
        groupBox1 = new GroupBox();
        listViewMercaderiasPreparadas = new ListView();
        columnHeaderNroOrdenDePreparacionPreparada = new ColumnHeader();
        columnHeaderMercaderiaPreparada = new ColumnHeader();
        columnHeaderCantidadMercaderiaPreparada = new ColumnHeader();
        buttonBuscarSiguienteOrden = new Button();
        groupBoxMercaderiasAEmpaquetar = new GroupBox();
        buttonEmpaquetar = new Button();
        listViewMercaderiasAEmpaquetar = new ListView();
        columnHeaderNroOrdenDePreparacionAEmpaquetar = new ColumnHeader();
        columnHeaderMercaderiaAEmpaquetar = new ColumnHeader();
        columnHeaderCantidadMercaderiaAEmpaquetar = new ColumnHeader();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxOrdenDeSeleccion.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBoxMercaderiasAEmpaquetar.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
        pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
        pictureBoxLogo.Location = new Point(225, 9);
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
        labelTitulo.Size = new Size(177, 32);
        labelTitulo.TabIndex = 21;
        labelTitulo.Text = "Empaquetado";
        // 
        // groupBoxOrdenDeSeleccion
        // 
        groupBoxOrdenDeSeleccion.Controls.Add(buttonConfirmarPreparacion);
        groupBoxOrdenDeSeleccion.Controls.Add(groupBox1);
        groupBoxOrdenDeSeleccion.Controls.Add(buttonBuscarSiguienteOrden);
        groupBoxOrdenDeSeleccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        groupBoxOrdenDeSeleccion.Location = new Point(12, 70);
        groupBoxOrdenDeSeleccion.Name = "groupBoxOrdenDeSeleccion";
        groupBoxOrdenDeSeleccion.Size = new Size(513, 546);
        groupBoxOrdenDeSeleccion.TabIndex = 22;
        groupBoxOrdenDeSeleccion.TabStop = false;
        groupBoxOrdenDeSeleccion.Text = "Orden de Selección";
        // 
        // buttonConfirmarPreparacion
        // 
        buttonConfirmarPreparacion.BackColor = Color.FromArgb(33, 150, 243);
        buttonConfirmarPreparacion.FlatAppearance.BorderSize = 0;
        buttonConfirmarPreparacion.FlatStyle = FlatStyle.Flat;
        buttonConfirmarPreparacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonConfirmarPreparacion.ForeColor = Color.White;
        buttonConfirmarPreparacion.Location = new Point(312, 519);
        buttonConfirmarPreparacion.Name = "buttonConfirmarPreparacion";
        buttonConfirmarPreparacion.Size = new Size(201, 27);
        buttonConfirmarPreparacion.TabIndex = 26;
        buttonConfirmarPreparacion.Text = "Confirmar Preparación";
        buttonConfirmarPreparacion.UseVisualStyleBackColor = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(listViewMercaderiasPreparadas);
        groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        groupBox1.Location = new Point(0, 307);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(513, 199);
        groupBox1.TabIndex = 40;
        groupBox1.TabStop = false;
        groupBox1.Text = "Mercaderias Preparadas";
        // 
        // listViewMercaderiasPreparadas
        // 
        listViewMercaderiasPreparadas.Columns.AddRange(new ColumnHeader[] { columnHeaderNroOrdenDePreparacionPreparada, columnHeaderMercaderiaPreparada, columnHeaderCantidadMercaderiaPreparada });
        listViewMercaderiasPreparadas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewMercaderiasPreparadas.FullRowSelect = true;
        listViewMercaderiasPreparadas.GridLines = true;
        listViewMercaderiasPreparadas.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewMercaderiasPreparadas.Location = new Point(6, 28);
        listViewMercaderiasPreparadas.MultiSelect = false;
        listViewMercaderiasPreparadas.Name = "listViewMercaderiasPreparadas";
        listViewMercaderiasPreparadas.Size = new Size(507, 158);
        listViewMercaderiasPreparadas.TabIndex = 34;
        listViewMercaderiasPreparadas.UseCompatibleStateImageBehavior = false;
        listViewMercaderiasPreparadas.View = View.Details;
        // 
        // columnHeaderNroOrdenDePreparacionPreparada
        // 
        columnHeaderNroOrdenDePreparacionPreparada.Text = "N° Orden de Preparación";
        columnHeaderNroOrdenDePreparacionPreparada.Width = 170;
        // 
        // columnHeaderMercaderiaPreparada
        // 
        columnHeaderMercaderiaPreparada.Text = "Tipo de Mercadería";
        columnHeaderMercaderiaPreparada.Width = 160;
        // 
        // columnHeaderCantidadMercaderiaPreparada
        // 
        columnHeaderCantidadMercaderiaPreparada.Text = "Cantidad Mercaderia";
        columnHeaderCantidadMercaderiaPreparada.Width = 140;
        // 
        // buttonBuscarSiguienteOrden
        // 
        buttonBuscarSiguienteOrden.BackColor = Color.FromArgb(33, 150, 243);
        buttonBuscarSiguienteOrden.FlatAppearance.BorderSize = 0;
        buttonBuscarSiguienteOrden.FlatStyle = FlatStyle.Flat;
        buttonBuscarSiguienteOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonBuscarSiguienteOrden.ForeColor = Color.White;
        buttonBuscarSiguienteOrden.Location = new Point(6, 28);
        buttonBuscarSiguienteOrden.Name = "buttonBuscarSiguienteOrden";
        buttonBuscarSiguienteOrden.Size = new Size(201, 27);
        buttonBuscarSiguienteOrden.TabIndex = 26;
        buttonBuscarSiguienteOrden.Text = "Buscar siguiente Orden";
        buttonBuscarSiguienteOrden.UseVisualStyleBackColor = false;
        buttonBuscarSiguienteOrden.Click += buttonBuscarSiguienteOrden_Click;
        // 
        // groupBoxMercaderiasAEmpaquetar
        // 
        groupBoxMercaderiasAEmpaquetar.Controls.Add(buttonEmpaquetar);
        groupBoxMercaderiasAEmpaquetar.Controls.Add(listViewMercaderiasAEmpaquetar);
        groupBoxMercaderiasAEmpaquetar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        groupBoxMercaderiasAEmpaquetar.Location = new Point(12, 131);
        groupBoxMercaderiasAEmpaquetar.Name = "groupBoxMercaderiasAEmpaquetar";
        groupBoxMercaderiasAEmpaquetar.Size = new Size(513, 240);
        groupBoxMercaderiasAEmpaquetar.TabIndex = 39;
        groupBoxMercaderiasAEmpaquetar.TabStop = false;
        groupBoxMercaderiasAEmpaquetar.Text = "Mercaderias a Empaquetar";
        // 
        // buttonEmpaquetar
        // 
        buttonEmpaquetar.BackColor = Color.FromArgb(33, 150, 243);
        buttonEmpaquetar.FlatAppearance.BorderSize = 0;
        buttonEmpaquetar.FlatStyle = FlatStyle.Flat;
        buttonEmpaquetar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonEmpaquetar.ForeColor = Color.White;
        buttonEmpaquetar.Location = new Point(312, 213);
        buttonEmpaquetar.Name = "buttonEmpaquetar";
        buttonEmpaquetar.Size = new Size(201, 27);
        buttonEmpaquetar.TabIndex = 26;
        buttonEmpaquetar.Text = "Empaquetar";
        buttonEmpaquetar.UseVisualStyleBackColor = false;
        buttonEmpaquetar.Click += buttonEmpaquetar_Click;
        // 
        // listViewMercaderiasAEmpaquetar
        // 
        listViewMercaderiasAEmpaquetar.Columns.AddRange(new ColumnHeader[] { columnHeaderNroOrdenDePreparacionAEmpaquetar, columnHeaderMercaderiaAEmpaquetar, columnHeaderCantidadMercaderiaAEmpaquetar });
        listViewMercaderiasAEmpaquetar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewMercaderiasAEmpaquetar.FullRowSelect = true;
        listViewMercaderiasAEmpaquetar.GridLines = true;
        listViewMercaderiasAEmpaquetar.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewMercaderiasAEmpaquetar.Location = new Point(6, 28);
        listViewMercaderiasAEmpaquetar.MultiSelect = false;
        listViewMercaderiasAEmpaquetar.Name = "listViewMercaderiasAEmpaquetar";
        listViewMercaderiasAEmpaquetar.Size = new Size(507, 174);
        listViewMercaderiasAEmpaquetar.TabIndex = 34;
        listViewMercaderiasAEmpaquetar.UseCompatibleStateImageBehavior = false;
        listViewMercaderiasAEmpaquetar.View = View.Details;
        // 
        // columnHeaderNroOrdenDePreparacionAEmpaquetar
        // 
        columnHeaderNroOrdenDePreparacionAEmpaquetar.Text = "N° Orden de Preparación";
        columnHeaderNroOrdenDePreparacionAEmpaquetar.Width = 170;
        // 
        // columnHeaderMercaderiaAEmpaquetar
        // 
        columnHeaderMercaderiaAEmpaquetar.Text = "Tipo de Mercadería";
        columnHeaderMercaderiaAEmpaquetar.Width = 160;
        // 
        // columnHeaderCantidadMercaderiaAEmpaquetar
        // 
        columnHeaderCantidadMercaderiaAEmpaquetar.Text = "Cantidad Mercaderia";
        columnHeaderCantidadMercaderiaAEmpaquetar.Width = 140;
        // 
        // GenerarOrdenDeEntregaForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(541, 628);
        Controls.Add(groupBoxMercaderiasAEmpaquetar);
        Controls.Add(groupBoxOrdenDeSeleccion);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Name = "GenerarOrdenDeEntregaForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generar Orden De Entrega";
        Load += GenerarOrdenDeEntregaForm_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxOrdenDeSeleccion.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBoxMercaderiasAEmpaquetar.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private GroupBox groupBoxOrdenDeSeleccion;
    private Button buttonBuscarSiguienteOrden;
    private GroupBox groupBoxMercaderiasAEmpaquetar;
    private ListView listViewMercaderiasAEmpaquetar;
    private ColumnHeader columnHeaderNroOrdenDePreparacionAEmpaquetar;
    private ColumnHeader columnHeaderMercaderiaAEmpaquetar;
    private ColumnHeader columnHeaderCantidadMercaderiaAEmpaquetar;
    private Button buttonConfirmarPreparacion;
    private GroupBox groupBox1;
    private ListView listViewMercaderiasPreparadas;
    private ColumnHeader columnHeaderNroOrdenDePreparacionPreparada;
    private ColumnHeader columnHeaderMercaderiaPreparada;
    private ColumnHeader columnHeaderCantidadMercaderiaPreparada;
    private Button buttonEmpaquetar;
}