namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega;

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
        groupBoxOrdenDePreparacion = new GroupBox();
        labelDeposito = new Label();
        buttonConfirmarPreparacion = new Button();
        comboBoxDeposito = new ComboBox();
        buttonBuscarSiguienteOrden = new Button();
        groupBoxMercaderiasAEmpaquetar = new GroupBox();
        listViewMercaderiasAEmpaquetar = new ListView();
        columnHeaderNroOrdenDePreparacionAEmpaquetar = new ColumnHeader();
        columnHeaderMercaderiaSKU = new ColumnHeader();
        columnHeaderMercaderiaDescripcion = new ColumnHeader();
        columnHeaderMercaderiaCantidad = new ColumnHeader();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxOrdenDePreparacion.SuspendLayout();
        groupBoxMercaderiasAEmpaquetar.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
        pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
        pictureBoxLogo.Location = new Point(295, 9);
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
        // groupBoxOrdenDePreparacion
        // 
        groupBoxOrdenDePreparacion.Controls.Add(labelDeposito);
        groupBoxOrdenDePreparacion.Controls.Add(buttonConfirmarPreparacion);
        groupBoxOrdenDePreparacion.Controls.Add(comboBoxDeposito);
        groupBoxOrdenDePreparacion.Controls.Add(buttonBuscarSiguienteOrden);
        groupBoxOrdenDePreparacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        groupBoxOrdenDePreparacion.Location = new Point(12, 70);
        groupBoxOrdenDePreparacion.Name = "groupBoxOrdenDePreparacion";
        groupBoxOrdenDePreparacion.Size = new Size(583, 546);
        groupBoxOrdenDePreparacion.TabIndex = 22;
        groupBoxOrdenDePreparacion.TabStop = false;
        groupBoxOrdenDePreparacion.Text = "Orden de Preparación";
        // 
        // labelDeposito
        // 
        labelDeposito.AutoSize = true;
        labelDeposito.Font = new Font("Segoe UI Symbol", 9.75F);
        labelDeposito.Location = new Point(5, 26);
        labelDeposito.Name = "labelDeposito";
        labelDeposito.Size = new Size(61, 17);
        labelDeposito.TabIndex = 55;
        labelDeposito.Text = "Depósito";
        // 
        // buttonConfirmarPreparacion
        // 
        buttonConfirmarPreparacion.BackColor = Color.FromArgb(33, 150, 243);
        buttonConfirmarPreparacion.FlatAppearance.BorderSize = 0;
        buttonConfirmarPreparacion.FlatStyle = FlatStyle.Flat;
        buttonConfirmarPreparacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonConfirmarPreparacion.ForeColor = Color.White;
        buttonConfirmarPreparacion.Location = new Point(382, 519);
        buttonConfirmarPreparacion.Name = "buttonConfirmarPreparacion";
        buttonConfirmarPreparacion.Size = new Size(201, 27);
        buttonConfirmarPreparacion.TabIndex = 26;
        buttonConfirmarPreparacion.Text = "Confirmar Empaquetado";
        buttonConfirmarPreparacion.UseVisualStyleBackColor = false;
        buttonConfirmarPreparacion.Click += buttonConfirmarPreparacion_Click;
        // 
        // comboBoxDeposito
        // 
        comboBoxDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDeposito.FormattingEnabled = true;
        comboBoxDeposito.Location = new Point(6, 44);
        comboBoxDeposito.Name = "comboBoxDeposito";
        comboBoxDeposito.Size = new Size(267, 29);
        comboBoxDeposito.TabIndex = 54;
        comboBoxDeposito.SelectedIndexChanged += comboBoxDeposito_SelectedIndexChanged;
        // 
        // buttonBuscarSiguienteOrden
        // 
        buttonBuscarSiguienteOrden.BackColor = Color.FromArgb(33, 150, 243);
        buttonBuscarSiguienteOrden.FlatAppearance.BorderSize = 0;
        buttonBuscarSiguienteOrden.FlatStyle = FlatStyle.Flat;
        buttonBuscarSiguienteOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonBuscarSiguienteOrden.ForeColor = Color.White;
        buttonBuscarSiguienteOrden.Location = new Point(169, 519);
        buttonBuscarSiguienteOrden.Name = "buttonBuscarSiguienteOrden";
        buttonBuscarSiguienteOrden.Size = new Size(201, 27);
        buttonBuscarSiguienteOrden.TabIndex = 26;
        buttonBuscarSiguienteOrden.Text = "Buscar siguiente Orden";
        buttonBuscarSiguienteOrden.UseVisualStyleBackColor = false;
        buttonBuscarSiguienteOrden.Click += buttonBuscarSiguienteOrden_Click;
        // 
        // groupBoxMercaderiasAEmpaquetar
        // 
        groupBoxMercaderiasAEmpaquetar.Controls.Add(listViewMercaderiasAEmpaquetar);
        groupBoxMercaderiasAEmpaquetar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        groupBoxMercaderiasAEmpaquetar.Location = new Point(12, 149);
        groupBoxMercaderiasAEmpaquetar.Name = "groupBoxMercaderiasAEmpaquetar";
        groupBoxMercaderiasAEmpaquetar.Size = new Size(583, 434);
        groupBoxMercaderiasAEmpaquetar.TabIndex = 39;
        groupBoxMercaderiasAEmpaquetar.TabStop = false;
        groupBoxMercaderiasAEmpaquetar.Text = "Mercaderias a Empaquetar";
        // 
        // listViewMercaderiasAEmpaquetar
        // 
        listViewMercaderiasAEmpaquetar.Columns.AddRange(new ColumnHeader[] { columnHeaderNroOrdenDePreparacionAEmpaquetar, columnHeaderMercaderiaSKU, columnHeaderMercaderiaDescripcion, columnHeaderMercaderiaCantidad });
        listViewMercaderiasAEmpaquetar.Enabled = false;
        listViewMercaderiasAEmpaquetar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewMercaderiasAEmpaquetar.FullRowSelect = true;
        listViewMercaderiasAEmpaquetar.GridLines = true;
        listViewMercaderiasAEmpaquetar.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewMercaderiasAEmpaquetar.Location = new Point(6, 28);
        listViewMercaderiasAEmpaquetar.MultiSelect = false;
        listViewMercaderiasAEmpaquetar.Name = "listViewMercaderiasAEmpaquetar";
        listViewMercaderiasAEmpaquetar.Size = new Size(571, 380);
        listViewMercaderiasAEmpaquetar.TabIndex = 34;
        listViewMercaderiasAEmpaquetar.UseCompatibleStateImageBehavior = false;
        listViewMercaderiasAEmpaquetar.View = View.Details;
        // 
        // columnHeaderNroOrdenDePreparacionAEmpaquetar
        // 
        columnHeaderNroOrdenDePreparacionAEmpaquetar.Text = "N° Orden de Preparación";
        columnHeaderNroOrdenDePreparacionAEmpaquetar.Width = 170;
        // 
        // columnHeaderMercaderiaSKU
        // 
        columnHeaderMercaderiaSKU.Text = "SKU";
        columnHeaderMercaderiaSKU.Width = 120;
        // 
        // columnHeaderMercaderiaDescripcion
        // 
        columnHeaderMercaderiaDescripcion.Text = "Tipo de Mercadería";
        columnHeaderMercaderiaDescripcion.Width = 130;
        // 
        // columnHeaderMercaderiaCantidad
        // 
        columnHeaderMercaderiaCantidad.Text = "Cantidad Mercaderia";
        columnHeaderMercaderiaCantidad.Width = 140;
        // 
        // GenerarOrdenDeEntregaForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(607, 628);
        Controls.Add(groupBoxMercaderiasAEmpaquetar);
        Controls.Add(groupBoxOrdenDePreparacion);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "GenerarOrdenDeEntregaForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generar Orden De Entrega";
        Load += GenerarOrdenDeEntregaForm_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxOrdenDePreparacion.ResumeLayout(false);
        groupBoxOrdenDePreparacion.PerformLayout();
        groupBoxMercaderiasAEmpaquetar.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private GroupBox groupBoxOrdenDePreparacion;
    private Button buttonBuscarSiguienteOrden;
    private GroupBox groupBoxMercaderiasAEmpaquetar;
    private ListView listViewMercaderiasAEmpaquetar;
    private ColumnHeader columnHeaderNroOrdenDePreparacionAEmpaquetar;
    private ColumnHeader columnHeaderMercaderiaDescripcion;
    private ColumnHeader columnHeaderMercaderiaCantidad;
    private Button buttonConfirmarPreparacion;
    private ColumnHeader columnHeaderMercaderiaSKU;
    private Label labelDeposito;
    private ComboBox comboBoxDeposito;
}