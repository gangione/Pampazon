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
        listViewMercaderiasEnStock = new ListView();
        columnHeaderNumeroDeOrden = new ColumnHeader();
        columnRazonSocial = new ColumnHeader();
        columnHeaderTransportista = new ColumnHeader();
        columnFechaDeDespacho = new ColumnHeader();
        groupBoxOrdenDePreparación = new GroupBox();
        labelTransportista = new Label();
        textBox1 = new TextBox();
        labelNumeroDeOrden = new Label();
        textBox2 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxOrdenDePreparación.SuspendLayout();
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
        // listViewMercaderiasEnStock
        // 
        listViewMercaderiasEnStock.Columns.AddRange(new ColumnHeader[] { columnHeaderNumeroDeOrden, columnRazonSocial, columnHeaderTransportista, columnFechaDeDespacho });
        listViewMercaderiasEnStock.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewMercaderiasEnStock.FullRowSelect = true;
        listViewMercaderiasEnStock.GridLines = true;
        listViewMercaderiasEnStock.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewMercaderiasEnStock.Location = new Point(12, 184);
        listViewMercaderiasEnStock.MultiSelect = false;
        listViewMercaderiasEnStock.Name = "listViewMercaderiasEnStock";
        listViewMercaderiasEnStock.Size = new Size(670, 193);
        listViewMercaderiasEnStock.TabIndex = 24;
        listViewMercaderiasEnStock.UseCompatibleStateImageBehavior = false;
        listViewMercaderiasEnStock.View = View.Details;
        // 
        // columnHeaderNumeroDeOrden
        // 
        columnHeaderNumeroDeOrden.Text = "Número de Orden";
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
        columnFechaDeDespacho.Text = "Fecha de Despacho";
        columnFechaDeDespacho.Width = 150;
        // 
        // groupBoxOrdenDePreparación
        // 
        groupBoxOrdenDePreparación.Controls.Add(labelTransportista);
        groupBoxOrdenDePreparación.Controls.Add(textBox1);
        groupBoxOrdenDePreparación.Controls.Add(labelNumeroDeOrden);
        groupBoxOrdenDePreparación.Controls.Add(textBox2);
        groupBoxOrdenDePreparación.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxOrdenDePreparación.Location = new Point(13, 75);
        groupBoxOrdenDePreparación.Name = "groupBoxOrdenDePreparación";
        groupBoxOrdenDePreparación.Size = new Size(669, 91);
        groupBoxOrdenDePreparación.TabIndex = 33;
        groupBoxOrdenDePreparación.TabStop = false;
        groupBoxOrdenDePreparación.Text = "Orden de Preparación";
        // 
        // labelTransportista
        // 
        labelTransportista.AutoSize = true;
        labelTransportista.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelTransportista.Location = new Point(209, 36);
        labelTransportista.Name = "labelTransportista";
        labelTransportista.Size = new Size(89, 15);
        labelTransportista.TabIndex = 16;
        labelTransportista.Text = "Transportista";
        // 
        // textBox1
        // 
        textBox1.CharacterCasing = CharacterCasing.Upper;
        textBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBox1.Location = new Point(209, 59);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(186, 27);
        textBox1.TabIndex = 15;
        // 
        // labelNumeroDeOrden
        // 
        labelNumeroDeOrden.AutoSize = true;
        labelNumeroDeOrden.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelNumeroDeOrden.Location = new Point(7, 36);
        labelNumeroDeOrden.Name = "labelNumeroDeOrden";
        labelNumeroDeOrden.Size = new Size(118, 15);
        labelNumeroDeOrden.TabIndex = 14;
        labelNumeroDeOrden.Text = "Número de Orden";
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
        button1.Location = new Point(407, 411);
        button1.Name = "button1";
        button1.Size = new Size(135, 27);
        button1.TabIndex = 35;
        button1.Text = "Aceptar";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(33, 150, 243);
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button2.ForeColor = Color.White;
        button2.Location = new Point(547, 411);
        button2.Name = "button2";
        button2.Size = new Size(135, 27);
        button2.TabIndex = 38;
        button2.Text = "Cancelar";
        button2.UseVisualStyleBackColor = false;
        // 
        // GenerarRemitoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(695, 450);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(groupBoxOrdenDePreparación);
        Controls.Add(listViewMercaderiasEnStock);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Name = "GenerarRemitoForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generar Remito";
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxOrdenDePreparación.ResumeLayout(false);
        groupBoxOrdenDePreparación.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private ListView listViewMercaderiasEnStock;
    private ColumnHeader columnHeaderNumeroDeOrden;
    private ColumnHeader columnRazonSocial;
    private ColumnHeader columnHeaderTransportista;
    private ColumnHeader columnFechaDeDespacho;
    private GroupBox groupBoxOrdenDePreparación;
    private Label labelNumeroDeOrden;
    private TextBox textBox2;
    private Label labelTransportista;
    private TextBox textBox1;
    private Button button1;
    private Button button2;
}