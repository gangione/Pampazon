
namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias;

partial class SeleccionarMercaderiasForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarMercaderiasForm));
        pictureBoxLogo = new PictureBox();
        labelTitulo = new Label();
        buttonConfirmarSeleccion = new Button();
        groupBoxOrdenDeSeleccion = new GroupBox();
        groupBoxMercaderiasASeleccionar = new GroupBox();
        listViewMercaderiasASeleccionar = new ListView();
        columnHeaderSeleccionMercaderiaUbicacion = new ColumnHeader();
        columnHeaderSeleccionMercaderiaCantidad = new ColumnHeader();
        columnHeaderMercaderiaSKU = new ColumnHeader();
        columnHeaderSeleccionMercaderia = new ColumnHeader();
        listViewOrdenesDeSeleccionPendientes = new ListView();
        columnHeaderOrdenDeSeleccionPendienteNumero = new ColumnHeader();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxOrdenDeSeleccion.SuspendLayout();
        groupBoxMercaderiasASeleccionar.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
        pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
        pictureBoxLogo.Location = new Point(407, 9);
        pictureBoxLogo.Name = "pictureBoxLogo";
        pictureBoxLogo.Size = new Size(300, 60);
        pictureBoxLogo.TabIndex = 18;
        pictureBoxLogo.TabStop = false;
        // 
        // labelTitulo
        // 
        labelTitulo.AutoSize = true;
        labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        labelTitulo.Location = new Point(12, 9);
        labelTitulo.Name = "labelTitulo";
        labelTitulo.Size = new Size(357, 32);
        labelTitulo.TabIndex = 19;
        labelTitulo.Text = "Baja de stock de Mercaderías";
        // 
        // buttonConfirmarSeleccion
        // 
        buttonConfirmarSeleccion.BackColor = Color.FromArgb(33, 150, 243);
        buttonConfirmarSeleccion.FlatAppearance.BorderSize = 0;
        buttonConfirmarSeleccion.FlatStyle = FlatStyle.Flat;
        buttonConfirmarSeleccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonConfirmarSeleccion.ForeColor = Color.White;
        buttonConfirmarSeleccion.Location = new Point(526, 523);
        buttonConfirmarSeleccion.Name = "buttonConfirmarSeleccion";
        buttonConfirmarSeleccion.Size = new Size(163, 27);
        buttonConfirmarSeleccion.TabIndex = 21;
        buttonConfirmarSeleccion.Text = "Confirmar seleccion";
        buttonConfirmarSeleccion.UseVisualStyleBackColor = false;
        buttonConfirmarSeleccion.Click += buttonConfirmarSeleccion_Click;
        // 
        // groupBoxOrdenDeSeleccion
        // 
        groupBoxOrdenDeSeleccion.Controls.Add(groupBoxMercaderiasASeleccionar);
        groupBoxOrdenDeSeleccion.Controls.Add(buttonConfirmarSeleccion);
        groupBoxOrdenDeSeleccion.Controls.Add(listViewOrdenesDeSeleccionPendientes);
        groupBoxOrdenDeSeleccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxOrdenDeSeleccion.Location = new Point(18, 75);
        groupBoxOrdenDeSeleccion.Name = "groupBoxOrdenDeSeleccion";
        groupBoxOrdenDeSeleccion.Size = new Size(689, 550);
        groupBoxOrdenDeSeleccion.TabIndex = 31;
        groupBoxOrdenDeSeleccion.TabStop = false;
        groupBoxOrdenDeSeleccion.Text = "Ordenes de Selección Pendientes";
        // 
        // groupBoxMercaderiasASeleccionar
        // 
        groupBoxMercaderiasASeleccionar.Controls.Add(listViewMercaderiasASeleccionar);
        groupBoxMercaderiasASeleccionar.Location = new Point(0, 240);
        groupBoxMercaderiasASeleccionar.Name = "groupBoxMercaderiasASeleccionar";
        groupBoxMercaderiasASeleccionar.Size = new Size(689, 277);
        groupBoxMercaderiasASeleccionar.TabIndex = 38;
        groupBoxMercaderiasASeleccionar.TabStop = false;
        groupBoxMercaderiasASeleccionar.Text = "Detalle de Orden de Selección";
        // 
        // listViewMercaderiasASeleccionar
        // 
        listViewMercaderiasASeleccionar.Columns.AddRange(new ColumnHeader[] { columnHeaderSeleccionMercaderiaUbicacion, columnHeaderSeleccionMercaderiaCantidad, columnHeaderMercaderiaSKU, columnHeaderSeleccionMercaderia });
        listViewMercaderiasASeleccionar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewMercaderiasASeleccionar.FullRowSelect = true;
        listViewMercaderiasASeleccionar.GridLines = true;
        listViewMercaderiasASeleccionar.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewMercaderiasASeleccionar.Location = new Point(6, 28);
        listViewMercaderiasASeleccionar.MultiSelect = false;
        listViewMercaderiasASeleccionar.Name = "listViewMercaderiasASeleccionar";
        listViewMercaderiasASeleccionar.Size = new Size(683, 243);
        listViewMercaderiasASeleccionar.TabIndex = 34;
        listViewMercaderiasASeleccionar.UseCompatibleStateImageBehavior = false;
        listViewMercaderiasASeleccionar.View = View.Details;
        // 
        // columnHeaderSeleccionMercaderiaUbicacion
        // 
        columnHeaderSeleccionMercaderiaUbicacion.Text = "Ubicacion de Estiva (S-P-F)";
        columnHeaderSeleccionMercaderiaUbicacion.Width = 180;
        // 
        // columnHeaderSeleccionMercaderiaCantidad
        // 
        columnHeaderSeleccionMercaderiaCantidad.Text = "Cantidad Mercaderia";
        columnHeaderSeleccionMercaderiaCantidad.Width = 140;
        // 
        // columnHeaderMercaderiaSKU
        // 
        columnHeaderMercaderiaSKU.Text = "SKU";
        columnHeaderMercaderiaSKU.Width = 120;
        // 
        // columnHeaderSeleccionMercaderia
        // 
        columnHeaderSeleccionMercaderia.Text = "Tipo de Mercadería";
        columnHeaderSeleccionMercaderia.Width = 140;
        // 
        // listViewOrdenesDeSeleccionPendientes
        // 
        listViewOrdenesDeSeleccionPendientes.Columns.AddRange(new ColumnHeader[] { columnHeaderOrdenDeSeleccionPendienteNumero });
        listViewOrdenesDeSeleccionPendientes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewOrdenesDeSeleccionPendientes.FullRowSelect = true;
        listViewOrdenesDeSeleccionPendientes.GridLines = true;
        listViewOrdenesDeSeleccionPendientes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewOrdenesDeSeleccionPendientes.Location = new Point(6, 28);
        listViewOrdenesDeSeleccionPendientes.MultiSelect = false;
        listViewOrdenesDeSeleccionPendientes.Name = "listViewOrdenesDeSeleccionPendientes";
        listViewOrdenesDeSeleccionPendientes.RightToLeft = RightToLeft.No;
        listViewOrdenesDeSeleccionPendientes.Size = new Size(294, 193);
        listViewOrdenesDeSeleccionPendientes.TabIndex = 37;
        listViewOrdenesDeSeleccionPendientes.UseCompatibleStateImageBehavior = false;
        listViewOrdenesDeSeleccionPendientes.View = View.Details;
        listViewOrdenesDeSeleccionPendientes.SelectedIndexChanged += listViewOrdenesDeSeleccionPendientes_SelectedIndexChanged;
        // 
        // columnHeaderOrdenDeSeleccionPendienteNumero
        // 
        columnHeaderOrdenDeSeleccionPendienteNumero.Text = "N° Orden de Selección";
        columnHeaderOrdenDeSeleccionPendienteNumero.Width = 250;
        // 
        // SeleccionarMercaderiasForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(725, 637);
        Controls.Add(groupBoxOrdenDeSeleccion);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "SeleccionarMercaderiasForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Baja de Stock";
        Load += SeleccionarMercaderiasForm_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxOrdenDeSeleccion.ResumeLayout(false);
        groupBoxMercaderiasASeleccionar.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }


    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private Button buttonConfirmarSeleccion;
    private GroupBox groupBoxOrdenDeSeleccion;
    private ListView listViewOrdenesDeSeleccionPendientes;
    private ColumnHeader columnHeaderOrdenDeSeleccionPendienteNumero;
    private GroupBox groupBoxMercaderiasASeleccionar;
    private ListView listViewMercaderiasASeleccionar;
    private ColumnHeader columnHeaderSeleccionMercaderia;
    private ColumnHeader columnHeaderSeleccionMercaderiaCantidad;
    private ColumnHeader columnHeaderSeleccionMercaderiaUbicacion;
    private ColumnHeader columnHeaderMercaderiaSKU;
}