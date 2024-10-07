namespace Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion;

partial class GenerarOrdenDePreparacionForm
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarOrdenDePreparacionForm));
        pictureBoxLogo = new PictureBox();
        labelTitulo = new Label();
        groupBoxOrdenDePreparacion = new GroupBox();
        labelFechaADespachar = new Label();
        labelCliente = new Label();
        textBoxFechaADespachar = new TextBox();
        textBoxCliente = new TextBox();
        buttonGenerarOrden = new Button();
        textBoxObservaciones = new TextBox();
        labelObservaciones = new Label();
        groupBoxMercaderiasEnStock = new GroupBox();
        listViewMercaderiasEnStock = new ListView();
        columnHeaderDescripcion = new ColumnHeader();
        columnHeaderUM = new ColumnHeader();
        columnHeaderCantidadEnStock = new ColumnHeader();
        labelCantidadAPreparar = new Label();
        buttonAgregar = new Button();
        textBoxCantidadAPreparar = new TextBox();
        label1 = new Label();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        listView1 = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        buttonEliminar = new Button();
        groupBoxMercaderiasARetirar = new GroupBox();
        groupBox3 = new GroupBox();
        label5 = new Label();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        listView2 = new ListView();
        columnHeader4 = new ColumnHeader();
        columnHeader5 = new ColumnHeader();
        columnHeader6 = new ColumnHeader();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        listViewMercaderiasARetirar = new ListView();
        columnHeaderDescripcionMercaderiaARetirar = new ColumnHeader();
        columnHeaderUMMercaderiaARetirar = new ColumnHeader();
        columnHeaderCantidadARetirar = new ColumnHeader();
        columnHeaderStockFuturo = new ColumnHeader();
        textBoxNombreTransportista = new TextBox();
        textBoxDNITransportista = new TextBox();
        labelNombreTransportista = new Label();
        labelDNITransportista = new Label();
        groupBoxTransportista = new GroupBox();
        errorProviderCliente = new ErrorProvider(components);
        errorProviderFechaADespachar = new ErrorProvider(components);
        errorProviderTransportistaDNI = new ErrorProvider(components);
        errorProviderTransportistaNombre = new ErrorProvider(components);
        errorProviderCantidadAPreparar = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        groupBoxOrdenDePreparacion.SuspendLayout();
        groupBoxMercaderiasEnStock.SuspendLayout();
        groupBoxMercaderiasARetirar.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBoxTransportista.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProviderCliente).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorProviderFechaADespachar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorProviderTransportistaDNI).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorProviderTransportistaNombre).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorProviderCantidadAPreparar).BeginInit();
        SuspendLayout();
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
        pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
        pictureBoxLogo.Location = new Point(688, 9);
        pictureBoxLogo.Name = "pictureBoxLogo";
        pictureBoxLogo.Size = new Size(300, 60);
        pictureBoxLogo.TabIndex = 14;
        pictureBoxLogo.TabStop = false;
        // 
        // labelTitulo
        // 
        labelTitulo.AutoSize = true;
        labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        labelTitulo.Location = new Point(12, 9);
        labelTitulo.Name = "labelTitulo";
        labelTitulo.Size = new Size(373, 32);
        labelTitulo.TabIndex = 15;
        labelTitulo.Text = "Generar Orden De Preparación";
        // 
        // groupBoxOrdenDePreparacion
        // 
        groupBoxOrdenDePreparacion.Controls.Add(labelFechaADespachar);
        groupBoxOrdenDePreparacion.Controls.Add(labelCliente);
        groupBoxOrdenDePreparacion.Controls.Add(textBoxFechaADespachar);
        groupBoxOrdenDePreparacion.Controls.Add(textBoxCliente);
        groupBoxOrdenDePreparacion.Controls.Add(buttonGenerarOrden);
        groupBoxOrdenDePreparacion.Controls.Add(textBoxObservaciones);
        groupBoxOrdenDePreparacion.Controls.Add(labelObservaciones);
        groupBoxOrdenDePreparacion.Controls.Add(groupBoxMercaderiasEnStock);
        groupBoxOrdenDePreparacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        groupBoxOrdenDePreparacion.Location = new Point(18, 69);
        groupBoxOrdenDePreparacion.Name = "groupBoxOrdenDePreparacion";
        groupBoxOrdenDePreparacion.Size = new Size(970, 698);
        groupBoxOrdenDePreparacion.TabIndex = 16;
        groupBoxOrdenDePreparacion.TabStop = false;
        groupBoxOrdenDePreparacion.Text = "Orden De Preparación";
        // 
        // labelFechaADespachar
        // 
        labelFechaADespachar.AutoSize = true;
        labelFechaADespachar.Font = new Font("Segoe UI Symbol", 10.25F, FontStyle.Bold);
        labelFechaADespachar.Location = new Point(220, 36);
        labelFechaADespachar.Name = "labelFechaADespachar";
        labelFechaADespachar.Size = new Size(152, 19);
        labelFechaADespachar.TabIndex = 16;
        labelFechaADespachar.Text = "Fecha a Despachar *";
        // 
        // labelCliente
        // 
        labelCliente.AutoSize = true;
        labelCliente.Font = new Font("Segoe UI Symbol", 10.25F, FontStyle.Bold);
        labelCliente.Location = new Point(7, 36);
        labelCliente.Name = "labelCliente";
        labelCliente.Size = new Size(70, 19);
        labelCliente.TabIndex = 16;
        labelCliente.Text = "Cliente *";
        // 
        // textBoxFechaADespachar
        // 
        textBoxFechaADespachar.AllowDrop = true;
        textBoxFechaADespachar.CharacterCasing = CharacterCasing.Upper;
        textBoxFechaADespachar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBoxFechaADespachar.Location = new Point(220, 59);
        textBoxFechaADespachar.Name = "textBoxFechaADespachar";
        textBoxFechaADespachar.PlaceholderText = "Dia / Mes / Año";
        textBoxFechaADespachar.Size = new Size(186, 27);
        textBoxFechaADespachar.TabIndex = 2;
        textBoxFechaADespachar.TextChanged += textBoxCliente_TextChanged;
        // 
        // textBoxCliente
        // 
        textBoxCliente.AllowDrop = true;
        textBoxCliente.CharacterCasing = CharacterCasing.Upper;
        textBoxCliente.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBoxCliente.Location = new Point(5, 59);
        textBoxCliente.Name = "textBoxCliente";
        textBoxCliente.PlaceholderText = " Nombre / Razón Social";
        textBoxCliente.Size = new Size(186, 27);
        textBoxCliente.TabIndex = 1;
        textBoxCliente.TextChanged += textBoxCliente_TextChanged;
        // 
        // buttonGenerarOrden
        // 
        buttonGenerarOrden.BackColor = Color.FromArgb(33, 150, 243);
        buttonGenerarOrden.FlatAppearance.BorderSize = 0;
        buttonGenerarOrden.FlatStyle = FlatStyle.Flat;
        buttonGenerarOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonGenerarOrden.ForeColor = Color.White;
        buttonGenerarOrden.Location = new Point(761, 645);
        buttonGenerarOrden.Name = "buttonGenerarOrden";
        buttonGenerarOrden.Size = new Size(199, 43);
        buttonGenerarOrden.TabIndex = 7;
        buttonGenerarOrden.Text = "Generar Orden";
        buttonGenerarOrden.UseVisualStyleBackColor = false;
        buttonGenerarOrden.Click += buttonGenerarOrden_Click;
        // 
        // textBoxObservaciones
        // 
        textBoxObservaciones.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBoxObservaciones.Location = new Point(8, 599);
        textBoxObservaciones.Multiline = true;
        textBoxObservaciones.Name = "textBoxObservaciones";
        textBoxObservaciones.Size = new Size(952, 40);
        textBoxObservaciones.TabIndex = 6;
        textBoxObservaciones.TabStop = false;
        // 
        // labelObservaciones
        // 
        labelObservaciones.AutoSize = true;
        labelObservaciones.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelObservaciones.Location = new Point(8, 581);
        labelObservaciones.Name = "labelObservaciones";
        labelObservaciones.Size = new Size(92, 15);
        labelObservaciones.TabIndex = 0;
        labelObservaciones.Text = "Obsevaciones";
        // 
        // groupBoxMercaderiasEnStock
        // 
        groupBoxMercaderiasEnStock.Controls.Add(listViewMercaderiasEnStock);
        groupBoxMercaderiasEnStock.Controls.Add(labelCantidadAPreparar);
        groupBoxMercaderiasEnStock.Controls.Add(buttonAgregar);
        groupBoxMercaderiasEnStock.Controls.Add(textBoxCantidadAPreparar);
        groupBoxMercaderiasEnStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxMercaderiasEnStock.Location = new Point(0, 92);
        groupBoxMercaderiasEnStock.Name = "groupBoxMercaderiasEnStock";
        groupBoxMercaderiasEnStock.Size = new Size(970, 216);
        groupBoxMercaderiasEnStock.TabIndex = 19;
        groupBoxMercaderiasEnStock.TabStop = false;
        groupBoxMercaderiasEnStock.Text = "Mercaderías en Stock";
        // 
        // listViewMercaderiasEnStock
        // 
        listViewMercaderiasEnStock.Columns.AddRange(new ColumnHeader[] { columnHeaderDescripcion, columnHeaderUM, columnHeaderCantidadEnStock });
        listViewMercaderiasEnStock.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewMercaderiasEnStock.FullRowSelect = true;
        listViewMercaderiasEnStock.GridLines = true;
        listViewMercaderiasEnStock.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewMercaderiasEnStock.Location = new Point(6, 28);
        listViewMercaderiasEnStock.MultiSelect = false;
        listViewMercaderiasEnStock.Name = "listViewMercaderiasEnStock";
        listViewMercaderiasEnStock.Size = new Size(956, 110);
        listViewMercaderiasEnStock.TabIndex = 10;
        listViewMercaderiasEnStock.UseCompatibleStateImageBehavior = false;
        listViewMercaderiasEnStock.View = View.Details;
        // 
        // columnHeaderDescripcion
        // 
        columnHeaderDescripcion.Text = "Descripcion";
        columnHeaderDescripcion.Width = 150;
        // 
        // columnHeaderUM
        // 
        columnHeaderUM.Text = "Unidad de Medida";
        columnHeaderUM.Width = 150;
        // 
        // columnHeaderCantidadEnStock
        // 
        columnHeaderCantidadEnStock.Text = "Cantidad en Stock";
        columnHeaderCantidadEnStock.Width = 150;
        // 
        // labelCantidadAPreparar
        // 
        labelCantidadAPreparar.AutoSize = true;
        labelCantidadAPreparar.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelCantidadAPreparar.Location = new Point(711, 153);
        labelCantidadAPreparar.Name = "labelCantidadAPreparar";
        labelCantidadAPreparar.Size = new Size(140, 15);
        labelCantidadAPreparar.TabIndex = 26;
        labelCantidadAPreparar.Text = "Cantidad a preparar *";
        // 
        // buttonAgregar
        // 
        buttonAgregar.BackColor = Color.FromArgb(33, 150, 243);
        buttonAgregar.FlatAppearance.BorderSize = 0;
        buttonAgregar.FlatStyle = FlatStyle.Flat;
        buttonAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonAgregar.ForeColor = Color.White;
        buttonAgregar.Location = new Point(873, 177);
        buttonAgregar.Name = "buttonAgregar";
        buttonAgregar.Size = new Size(89, 27);
        buttonAgregar.TabIndex = 10;
        buttonAgregar.Text = "+ Agregar";
        buttonAgregar.UseVisualStyleBackColor = false;
        buttonAgregar.Click += buttonAgregar_Click;
        // 
        // textBoxCantidadAPreparar
        // 
        textBoxCantidadAPreparar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBoxCantidadAPreparar.Location = new Point(711, 177);
        textBoxCantidadAPreparar.Name = "textBoxCantidadAPreparar";
        textBoxCantidadAPreparar.Size = new Size(135, 27);
        textBoxCantidadAPreparar.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label1.Location = new Point(498, 33);
        label1.Name = "label1";
        label1.Size = new Size(139, 15);
        label1.TabIndex = 26;
        label1.Text = "Cantidad rechazada *";
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(33, 150, 243);
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button1.ForeColor = Color.White;
        button1.Location = new Point(866, 57);
        button1.Name = "button1";
        button1.Size = new Size(98, 27);
        button1.TabIndex = 27;
        button1.Text = "Editar";
        button1.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(33, 150, 243);
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button2.ForeColor = Color.White;
        button2.Location = new Point(766, 57);
        button2.Name = "button2";
        button2.Size = new Size(94, 27);
        button2.TabIndex = 11;
        button2.TabStop = false;
        button2.Text = "- Eliminar";
        button2.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.BackColor = Color.FromArgb(33, 150, 243);
        button3.FlatAppearance.BorderSize = 0;
        button3.FlatStyle = FlatStyle.Flat;
        button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button3.ForeColor = Color.White;
        button3.Location = new Point(670, 57);
        button3.Name = "button3";
        button3.Size = new Size(89, 27);
        button3.TabIndex = 10;
        button3.Text = "+ Agregar";
        button3.UseVisualStyleBackColor = false;
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
        listView1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listView1.FullRowSelect = true;
        listView1.GridLines = true;
        listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listView1.Location = new Point(8, 99);
        listView1.MultiSelect = false;
        listView1.Name = "listView1";
        listView1.Size = new Size(956, 110);
        listView1.TabIndex = 10;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Descripcion";
        columnHeader1.Width = 150;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Unidad de Medida";
        columnHeader2.Width = 150;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "Cantidad en Stock";
        columnHeader3.Width = 150;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label2.Location = new Point(8, 34);
        label2.Name = "label2";
        label2.Size = new Size(90, 15);
        label2.TabIndex = 19;
        label2.Text = "Descripción *";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label3.Location = new Point(340, 34);
        label3.Name = "label3";
        label3.Size = new Size(127, 15);
        label3.TabIndex = 21;
        label3.Text = "Cantidad recibida *";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label4.Location = new Point(174, 34);
        label4.Name = "label4";
        label4.Size = new Size(131, 15);
        label4.TabIndex = 20;
        label4.Text = "Unidad De Medida *";
        // 
        // buttonEliminar
        // 
        buttonEliminar.BackColor = Color.FromArgb(33, 150, 243);
        buttonEliminar.FlatAppearance.BorderSize = 0;
        buttonEliminar.FlatStyle = FlatStyle.Flat;
        buttonEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonEliminar.ForeColor = Color.White;
        buttonEliminar.Location = new Point(867, 144);
        buttonEliminar.Name = "buttonEliminar";
        buttonEliminar.Size = new Size(94, 27);
        buttonEliminar.TabIndex = 11;
        buttonEliminar.TabStop = false;
        buttonEliminar.Text = "- Eliminar";
        buttonEliminar.UseVisualStyleBackColor = false;
        buttonEliminar.Click += buttonEliminar_Click;
        // 
        // groupBoxMercaderiasARetirar
        // 
        groupBoxMercaderiasARetirar.Controls.Add(groupBox3);
        groupBoxMercaderiasARetirar.Controls.Add(listViewMercaderiasARetirar);
        groupBoxMercaderiasARetirar.Controls.Add(buttonEliminar);
        groupBoxMercaderiasARetirar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxMercaderiasARetirar.Location = new Point(17, 371);
        groupBoxMercaderiasARetirar.Name = "groupBoxMercaderiasARetirar";
        groupBoxMercaderiasARetirar.Size = new Size(970, 181);
        groupBoxMercaderiasARetirar.TabIndex = 20;
        groupBoxMercaderiasARetirar.TabStop = false;
        groupBoxMercaderiasARetirar.Text = "Mercaderías a Retirar por Transportista";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label5);
        groupBox3.Controls.Add(button4);
        groupBox3.Controls.Add(button5);
        groupBox3.Controls.Add(button6);
        groupBox3.Controls.Add(listView2);
        groupBox3.Controls.Add(label6);
        groupBox3.Controls.Add(label7);
        groupBox3.Controls.Add(label8);
        groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBox3.Location = new Point(5, 217);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(970, 222);
        groupBox3.TabIndex = 20;
        groupBox3.TabStop = false;
        groupBox3.Text = "Mercaderías en Stock";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label5.Location = new Point(498, 33);
        label5.Name = "label5";
        label5.Size = new Size(139, 15);
        label5.TabIndex = 26;
        label5.Text = "Cantidad rechazada *";
        // 
        // button4
        // 
        button4.BackColor = Color.FromArgb(33, 150, 243);
        button4.FlatAppearance.BorderSize = 0;
        button4.FlatStyle = FlatStyle.Flat;
        button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button4.ForeColor = Color.White;
        button4.Location = new Point(866, 57);
        button4.Name = "button4";
        button4.Size = new Size(98, 27);
        button4.TabIndex = 27;
        button4.Text = "Editar";
        button4.UseVisualStyleBackColor = false;
        // 
        // button5
        // 
        button5.BackColor = Color.FromArgb(33, 150, 243);
        button5.FlatAppearance.BorderSize = 0;
        button5.FlatStyle = FlatStyle.Flat;
        button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button5.ForeColor = Color.White;
        button5.Location = new Point(766, 57);
        button5.Name = "button5";
        button5.Size = new Size(94, 27);
        button5.TabIndex = 11;
        button5.TabStop = false;
        button5.Text = "- Eliminar";
        button5.UseVisualStyleBackColor = false;
        // 
        // button6
        // 
        button6.BackColor = Color.FromArgb(33, 150, 243);
        button6.FlatAppearance.BorderSize = 0;
        button6.FlatStyle = FlatStyle.Flat;
        button6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button6.ForeColor = Color.White;
        button6.Location = new Point(670, 57);
        button6.Name = "button6";
        button6.Size = new Size(89, 27);
        button6.TabIndex = 10;
        button6.Text = "+ Agregar";
        button6.UseVisualStyleBackColor = false;
        // 
        // listView2
        // 
        listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
        listView2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listView2.FullRowSelect = true;
        listView2.GridLines = true;
        listView2.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listView2.Location = new Point(8, 99);
        listView2.MultiSelect = false;
        listView2.Name = "listView2";
        listView2.Size = new Size(956, 110);
        listView2.TabIndex = 10;
        listView2.UseCompatibleStateImageBehavior = false;
        listView2.View = View.Details;
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "Descripcion";
        columnHeader4.Width = 150;
        // 
        // columnHeader5
        // 
        columnHeader5.Text = "Unidad de Medida";
        columnHeader5.Width = 150;
        // 
        // columnHeader6
        // 
        columnHeader6.Text = "Cantidad en Stock";
        columnHeader6.Width = 150;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label6.Location = new Point(8, 34);
        label6.Name = "label6";
        label6.Size = new Size(90, 15);
        label6.TabIndex = 19;
        label6.Text = "Descripción *";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label7.Location = new Point(340, 34);
        label7.Name = "label7";
        label7.Size = new Size(127, 15);
        label7.TabIndex = 21;
        label7.Text = "Cantidad recibida *";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        label8.Location = new Point(174, 34);
        label8.Name = "label8";
        label8.Size = new Size(131, 15);
        label8.TabIndex = 20;
        label8.Text = "Unidad De Medida *";
        // 
        // listViewMercaderiasARetirar
        // 
        listViewMercaderiasARetirar.Columns.AddRange(new ColumnHeader[] { columnHeaderDescripcionMercaderiaARetirar, columnHeaderUMMercaderiaARetirar, columnHeaderCantidadARetirar, columnHeaderStockFuturo });
        listViewMercaderiasARetirar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        listViewMercaderiasARetirar.FullRowSelect = true;
        listViewMercaderiasARetirar.GridLines = true;
        listViewMercaderiasARetirar.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewMercaderiasARetirar.Location = new Point(6, 28);
        listViewMercaderiasARetirar.MultiSelect = false;
        listViewMercaderiasARetirar.Name = "listViewMercaderiasARetirar";
        listViewMercaderiasARetirar.Size = new Size(956, 110);
        listViewMercaderiasARetirar.TabIndex = 10;
        listViewMercaderiasARetirar.UseCompatibleStateImageBehavior = false;
        listViewMercaderiasARetirar.View = View.Details;
        // 
        // columnHeaderDescripcionMercaderiaARetirar
        // 
        columnHeaderDescripcionMercaderiaARetirar.Text = "Descripcion";
        columnHeaderDescripcionMercaderiaARetirar.Width = 150;
        // 
        // columnHeaderUMMercaderiaARetirar
        // 
        columnHeaderUMMercaderiaARetirar.Text = "Unidad de Medida";
        columnHeaderUMMercaderiaARetirar.Width = 150;
        // 
        // columnHeaderCantidadARetirar
        // 
        columnHeaderCantidadARetirar.Text = "Cantidad";
        columnHeaderCantidadARetirar.Width = 100;
        // 
        // columnHeaderStockFuturo
        // 
        columnHeaderStockFuturo.Text = "Stock a Actualizar";
        columnHeaderStockFuturo.Width = 150;
        // 
        // textBoxNombreTransportista
        // 
        textBoxNombreTransportista.CharacterCasing = CharacterCasing.Upper;
        textBoxNombreTransportista.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBoxNombreTransportista.Location = new Point(7, 59);
        textBoxNombreTransportista.Name = "textBoxNombreTransportista";
        textBoxNombreTransportista.Size = new Size(186, 27);
        textBoxNombreTransportista.TabIndex = 4;
        textBoxNombreTransportista.TextChanged += textBoxNombreTransportista_TextChanged;
        // 
        // textBoxDNITransportista
        // 
        textBoxDNITransportista.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        textBoxDNITransportista.Location = new Point(220, 59);
        textBoxDNITransportista.Name = "textBoxDNITransportista";
        textBoxDNITransportista.Size = new Size(186, 27);
        textBoxDNITransportista.TabIndex = 5;
        // 
        // labelNombreTransportista
        // 
        labelNombreTransportista.AutoSize = true;
        labelNombreTransportista.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelNombreTransportista.Location = new Point(7, 36);
        labelNombreTransportista.Name = "labelNombreTransportista";
        labelNombreTransportista.Size = new Size(132, 15);
        labelNombreTransportista.TabIndex = 14;
        labelNombreTransportista.Text = "Nombre y apellido *";
        // 
        // labelDNITransportista
        // 
        labelDNITransportista.AutoSize = true;
        labelDNITransportista.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
        labelDNITransportista.Location = new Point(221, 36);
        labelDNITransportista.Name = "labelDNITransportista";
        labelDNITransportista.Size = new Size(40, 15);
        labelDNITransportista.TabIndex = 16;
        labelDNITransportista.Text = "DNI *";
        // 
        // groupBoxTransportista
        // 
        groupBoxTransportista.Controls.Add(labelDNITransportista);
        groupBoxTransportista.Controls.Add(labelNombreTransportista);
        groupBoxTransportista.Controls.Add(textBoxDNITransportista);
        groupBoxTransportista.Controls.Add(textBoxNombreTransportista);
        groupBoxTransportista.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBoxTransportista.Location = new Point(18, 547);
        groupBoxTransportista.Name = "groupBoxTransportista";
        groupBoxTransportista.Size = new Size(970, 91);
        groupBoxTransportista.TabIndex = 30;
        groupBoxTransportista.TabStop = false;
        groupBoxTransportista.Text = "Transportista";
        // 
        // errorProviderCliente
        // 
        errorProviderCliente.ContainerControl = this;
        // 
        // errorProviderFechaADespachar
        // 
        errorProviderFechaADespachar.ContainerControl = this;
        // 
        // errorProviderTransportistaDNI
        // 
        errorProviderTransportistaDNI.ContainerControl = this;
        // 
        // errorProviderTransportistaNombre
        // 
        errorProviderTransportistaNombre.ContainerControl = this;
        // 
        // errorProviderCantidadAPreparar
        // 
        errorProviderCantidadAPreparar.ContainerControl = this;
        // 
        // GenerarOrdenDePreparacionForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1008, 781);
        Controls.Add(groupBoxMercaderiasARetirar);
        Controls.Add(groupBoxTransportista);
        Controls.Add(pictureBoxLogo);
        Controls.Add(labelTitulo);
        Controls.Add(groupBoxOrdenDePreparacion);
        Name = "GenerarOrdenDePreparacionForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generar Orden De Preparacion";
        FormClosing += GenerarOrdenDePreparacionForm_FormClosing;
        Load += GenerarOrdenDePreparacionForm_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        groupBoxOrdenDePreparacion.ResumeLayout(false);
        groupBoxOrdenDePreparacion.PerformLayout();
        groupBoxMercaderiasEnStock.ResumeLayout(false);
        groupBoxMercaderiasEnStock.PerformLayout();
        groupBoxMercaderiasARetirar.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBoxTransportista.ResumeLayout(false);
        groupBoxTransportista.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)errorProviderCliente).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorProviderFechaADespachar).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorProviderTransportistaDNI).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorProviderTransportistaNombre).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorProviderCantidadAPreparar).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelTitulo;
    private GroupBox groupBoxOrdenDePreparacion;
    private Label labelCliente;
    private TextBox textBoxCliente;
    private Button buttonGenerarOrden;
    private TextBox textBoxObservaciones;
    private Label labelObservaciones;
    private GroupBox groupBoxMercaderiasEnStock;
    private Label labelCantidadAPreparar;
    private Button buttonEliminar;
    private Button buttonAgregar;
    private TextBox textBoxCantidadAPreparar;
    private ListView listViewMercaderiasEnStock;
    private ColumnHeader columnHeaderDescripcion;
    private ColumnHeader columnHeaderUM;
    private ColumnHeader columnHeaderCantidadEnStock;
    private Label label1;
    private Button button1;
    private Button button2;
    private Button button3;
    private ListView listView1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private Label label2;
    private Label label3;
    private Label label4;
    private GroupBox groupBoxMercaderiasARetirar;
    private GroupBox groupBox3;
    private Label label5;
    private Button button4;
    private Button button5;
    private Button button6;
    private ListView listView2;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private Label label6;
    private Label label7;
    private Label label8;
    private ListView listViewMercaderiasARetirar;
    private ColumnHeader columnHeaderDescripcionMercaderiaARetirar;
    private ColumnHeader columnHeaderUMMercaderiaARetirar;
    private ColumnHeader columnHeaderStockFuturo;
    private ColumnHeader columnHeaderCantidadARetirar;
    private TextBox textBoxNombreTransportista;
    private TextBox textBoxDNITransportista;
    private Label labelNombreTransportista;
    private Label labelDNITransportista;
    private GroupBox groupBoxTransportista;
    private Label labelFechaADespachar;
    private TextBox textBoxFechaADespachar;
    private ErrorProvider errorProviderCliente;
    private ErrorProvider errorProviderFechaADespachar;
    private ErrorProvider errorProviderTransportistaDNI;
    private ErrorProvider errorProviderTransportistaNombre;
    private ErrorProvider errorProviderCantidadAPreparar;
}