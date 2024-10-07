
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
        listViewMercaderiasEnStock = new ListView();
        columnHeaderNumeroDeOrden = new ColumnHeader();
        columnMercaderia = new ColumnHeader();
        columnHeaderCantidad = new ColumnHeader();
        columnUbicacion = new ColumnHeader();
        buttonSeleccionar = new Button();
        groupBoxOrdenDeSeleccion = new GroupBox();
        labelNumeroDeOrden = new Label();
        textBox2 = new TextBox();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxOrdenDeSeleccion.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
        pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
        pictureBoxLogo.Location = new Point(322, 12);
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
        labelTitulo.Size = new Size(171, 32);
        labelTitulo.TabIndex = 19;
        labelTitulo.Text = "Baja de stock";
        // 
        // listViewMercaderiasEnStock
        // 
        listViewMercaderiasEnStock.Columns.AddRange(new ColumnHeader[] { columnHeaderNumeroDeOrden, columnMercaderia, columnHeaderCantidad, columnUbicacion });
        listViewMercaderiasEnStock.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewMercaderiasEnStock.FullRowSelect = true;
        listViewMercaderiasEnStock.GridLines = true;
        listViewMercaderiasEnStock.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewMercaderiasEnStock.Location = new Point(18, 186);
        listViewMercaderiasEnStock.MultiSelect = false;
        listViewMercaderiasEnStock.Name = "listViewMercaderiasEnStock";
        listViewMercaderiasEnStock.Size = new Size(604, 203);
        listViewMercaderiasEnStock.TabIndex = 20;
        listViewMercaderiasEnStock.UseCompatibleStateImageBehavior = false;
        listViewMercaderiasEnStock.View = View.Details;
        listViewMercaderiasEnStock.SelectedIndexChanged += listViewMercaderiasEnStock_SelectedIndexChanged;
        // 
        // columnHeaderNumeroDeOrden
        // 
        columnHeaderNumeroDeOrden.Text = "Numero de Orden";
        columnHeaderNumeroDeOrden.Width = 150;
        // 
        // columnMercaderia
        // 
        columnMercaderia.Text = "Mercadería";
        columnMercaderia.Width = 150;
        // 
        // columnHeaderCantidad
        // 
        columnHeaderCantidad.Text = "Cantidad";
        columnHeaderCantidad.Width = 150;
        // 
        // columnUbicacion
        // 
        columnUbicacion.Text = "Ubicacion";
        columnUbicacion.Width = 150;
        // 
        // buttonSeleccionar
        // 
        buttonSeleccionar.BackColor = Color.FromArgb(33, 150, 243);
        buttonSeleccionar.FlatAppearance.BorderSize = 0;
        buttonSeleccionar.FlatStyle = FlatStyle.Flat;
        buttonSeleccionar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonSeleccionar.ForeColor = Color.White;
        buttonSeleccionar.Location = new Point(317, 395);
        buttonSeleccionar.Name = "buttonSeleccionar";
        buttonSeleccionar.Size = new Size(163, 27);
        buttonSeleccionar.TabIndex = 21;
        buttonSeleccionar.Text = "Confirmar seleccion";
        buttonSeleccionar.UseVisualStyleBackColor = false;
        buttonSeleccionar.Click += buttonSeleccionar_Click;
        // 
        // groupBoxOrdenDeSeleccion
        // 
        groupBoxOrdenDeSeleccion.Controls.Add(labelNumeroDeOrden);
        groupBoxOrdenDeSeleccion.Controls.Add(textBox2);
        groupBoxOrdenDeSeleccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxOrdenDeSeleccion.Location = new Point(18, 75);
        groupBoxOrdenDeSeleccion.Name = "groupBoxOrdenDeSeleccion";
        groupBoxOrdenDeSeleccion.Size = new Size(604, 91);
        groupBoxOrdenDeSeleccion.TabIndex = 31;
        groupBoxOrdenDeSeleccion.TabStop = false;
        groupBoxOrdenDeSeleccion.Text = "Orden de Selección";
        groupBoxOrdenDeSeleccion.Enter += groupBoxTransportista_Enter;
        // 
        // labelNumeroDeOrden
        // 
        labelNumeroDeOrden.AutoSize = true;
        labelNumeroDeOrden.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelNumeroDeOrden.Location = new Point(7, 36);
        labelNumeroDeOrden.Name = "labelNumeroDeOrden";
        labelNumeroDeOrden.Size = new Size(118, 15);
        labelNumeroDeOrden.TabIndex = 14;
        labelNumeroDeOrden.Text = "Numero de Orden";
        // 
        // textBox2
        // 
        textBox2.CharacterCasing = CharacterCasing.Upper;
        textBox2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBox2.Location = new Point(7, 59);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(186, 27);
        textBox2.TabIndex = 3;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(33, 150, 243);
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button1.ForeColor = Color.White;
        button1.Location = new Point(491, 395);
        button1.Name = "button1";
        button1.Size = new Size(131, 27);
        button1.TabIndex = 32;
        button1.Text = "Cancelar";
        button1.UseVisualStyleBackColor = false;
        // 
        // SeleccionarMercaderiasForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(647, 450);
        Controls.Add(button1);
        Controls.Add(groupBoxOrdenDeSeleccion);
        Controls.Add(buttonSeleccionar);
        Controls.Add(listViewMercaderiasEnStock);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Name = "SeleccionarMercaderiasForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Baja de Stock";
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxOrdenDeSeleccion.ResumeLayout(false);
        groupBoxOrdenDeSeleccion.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }


    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private ListView listViewMercaderiasEnStock;
    private ColumnHeader columnHeaderNumeroDeOrden;
    private ColumnHeader columnHeaderCantidad;
    private Button buttonSeleccionar;
    private GroupBox groupBoxOrdenDeSeleccion;
    private Label labelNumeroDeOrden;
    private TextBox textBox2;
    private ColumnHeader columnMercaderia;
    private ColumnHeader columnUbicacion;
    private Button button1;
}