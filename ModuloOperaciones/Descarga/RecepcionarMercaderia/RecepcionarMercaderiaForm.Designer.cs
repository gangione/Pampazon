namespace Pampazon.ModuloOperaciones.Descarga.RecepcionMercaderia
{
    partial class RecepcionarMercaderiaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepcionarMercaderiaForm));
            pictureBoxLogo = new PictureBox();
            labelTitulo = new Label();
            groupBoxComprobarEspacio = new GroupBox();
            groupBoxNotaEspacio = new GroupBox();
            buttonActualizar = new Button();
            labelCantidadRechazada = new Label();
            label8 = new Label();
            radioButtonTotal = new RadioButton();
            textBoxCantidadRechazada = new TextBox();
            radioButtonParcial = new RadioButton();
            buttonGenerarNotaInsuficiente = new Button();
            labelRemito = new Label();
            textBoxRemito = new TextBox();
            labelCliente = new Label();
            textBoxCliente = new TextBox();
            buttonRestablecer = new Button();
            buttonGenerarOrdenYComprobantes = new Button();
            textBoxObservaciones = new TextBox();
            labelObservaciones = new Label();
            labelCantidadMercaderia = new Label();
            labelUMMercaderia = new Label();
            textBoxUMMercaderia = new TextBox();
            textBoxCantidadMercaderia = new TextBox();
            groupBoxTransportista = new GroupBox();
            labelDNITransportista = new Label();
            labelNombreTransportista = new Label();
            textBoxDNITransportista = new TextBox();
            textBoxNombreTransportista = new TextBox();
            groupBoxMercaderias = new GroupBox();
            buttonEliminar = new Button();
            buttonAgregar = new Button();
            listViewMercaderias = new ListView();
            columnHeaderDescripcion = new ColumnHeader();
            columnHeaderUM = new ColumnHeader();
            columnHeaderCantidadRecibida = new ColumnHeader();
            columnHeaderCantidadRechazada = new ColumnHeader();
            textBoxDescripcionMercaderia = new TextBox();
            labelDescripcionMercaderia = new Label();
            errorProviderCliente = new ErrorProvider(components);
            errorProviderNroRemito = new ErrorProvider(components);
            errorProviderDNITransportista = new ErrorProvider(components);
            errorProviderNombreTransportista = new ErrorProvider(components);
            errorProviderDescripcionMercaderia = new ErrorProvider(components);
            errorProviderUMMercaderia = new ErrorProvider(components);
            errorProviderCantidadMercaderia = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            groupBoxComprobarEspacio.SuspendLayout();
            groupBoxNotaEspacio.SuspendLayout();
            groupBoxTransportista.SuspendLayout();
            groupBoxMercaderias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNroRemito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDNITransportista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNombreTransportista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDescripcionMercaderia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUMMercaderia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCantidadMercaderia).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(688, 9);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(300, 60);
            pictureBoxLogo.TabIndex = 12;
            pictureBoxLogo.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            labelTitulo.Location = new Point(12, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(315, 32);
            labelTitulo.TabIndex = 13;
            labelTitulo.Text = "Recepción de Mercaderías";
            // 
            // groupBoxComprobarEspacio
            // 
            groupBoxComprobarEspacio.Controls.Add(labelRemito);
            groupBoxComprobarEspacio.Controls.Add(textBoxRemito);
            groupBoxComprobarEspacio.Controls.Add(labelCliente);
            groupBoxComprobarEspacio.Controls.Add(textBoxCliente);
            groupBoxComprobarEspacio.Controls.Add(buttonRestablecer);
            groupBoxComprobarEspacio.Controls.Add(buttonGenerarOrdenYComprobantes);
            groupBoxComprobarEspacio.Controls.Add(textBoxObservaciones);
            groupBoxComprobarEspacio.Controls.Add(labelObservaciones);
            groupBoxComprobarEspacio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBoxComprobarEspacio.Location = new Point(18, 69);
            groupBoxComprobarEspacio.Name = "groupBoxComprobarEspacio";
            groupBoxComprobarEspacio.Size = new Size(970, 602);
            groupBoxComprobarEspacio.TabIndex = 0;
            groupBoxComprobarEspacio.TabStop = false;
            groupBoxComprobarEspacio.Text = "Comprobante de Recepción";
            // 
            // groupBoxNotaEspacio
            // 
            groupBoxNotaEspacio.AccessibleRole = AccessibleRole.None;
            groupBoxNotaEspacio.Controls.Add(buttonActualizar);
            groupBoxNotaEspacio.Controls.Add(labelCantidadRechazada);
            groupBoxNotaEspacio.Controls.Add(label8);
            groupBoxNotaEspacio.Controls.Add(radioButtonTotal);
            groupBoxNotaEspacio.Controls.Add(textBoxCantidadRechazada);
            groupBoxNotaEspacio.Controls.Add(radioButtonParcial);
            groupBoxNotaEspacio.Controls.Add(buttonGenerarNotaInsuficiente);
            groupBoxNotaEspacio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxNotaEspacio.Location = new Point(18, 677);
            groupBoxNotaEspacio.Name = "groupBoxNotaEspacio";
            groupBoxNotaEspacio.Size = new Size(970, 115);
            groupBoxNotaEspacio.TabIndex = 17;
            groupBoxNotaEspacio.TabStop = false;
            groupBoxNotaEspacio.Text = "Nota de Espacio Insuficiente";
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.FromArgb(33, 150, 243);
            buttonActualizar.FlatAppearance.BorderSize = 0;
            buttonActualizar.FlatStyle = FlatStyle.Flat;
            buttonActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonActualizar.ForeColor = Color.White;
            buttonActualizar.Location = new Point(340, 62);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(131, 27);
            buttonActualizar.TabIndex = 27;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // labelCantidadRechazada
            // 
            labelCantidadRechazada.AutoSize = true;
            labelCantidadRechazada.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            labelCantidadRechazada.Location = new Point(174, 38);
            labelCantidadRechazada.Name = "labelCantidadRechazada";
            labelCantidadRechazada.Size = new Size(139, 15);
            labelCantidadRechazada.TabIndex = 26;
            labelCantidadRechazada.Text = "Cantidad rechazada *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label8.Location = new Point(8, 38);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 24;
            label8.Text = "Rechazo";
            // 
            // radioButtonTotal
            // 
            radioButtonTotal.AutoSize = true;
            radioButtonTotal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            radioButtonTotal.Location = new Point(12, 64);
            radioButtonTotal.Name = "radioButtonTotal";
            radioButtonTotal.Size = new Size(58, 23);
            radioButtonTotal.TabIndex = 11;
            radioButtonTotal.TabStop = true;
            radioButtonTotal.Text = "Total";
            radioButtonTotal.UseVisualStyleBackColor = true;
            // 
            // textBoxCantidadRechazada
            // 
            textBoxCantidadRechazada.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBoxCantidadRechazada.Location = new Point(174, 62);
            textBoxCantidadRechazada.Name = "textBoxCantidadRechazada";
            textBoxCantidadRechazada.Size = new Size(135, 27);
            textBoxCantidadRechazada.TabIndex = 13;
            // 
            // radioButtonParcial
            // 
            radioButtonParcial.AutoSize = true;
            radioButtonParcial.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            radioButtonParcial.Location = new Point(89, 64);
            radioButtonParcial.Name = "radioButtonParcial";
            radioButtonParcial.Size = new Size(69, 23);
            radioButtonParcial.TabIndex = 12;
            radioButtonParcial.TabStop = true;
            radioButtonParcial.Text = "Parcial";
            radioButtonParcial.UseVisualStyleBackColor = true;
            radioButtonParcial.CheckedChanged += radioButtonParcial_CheckedChanged;
            // 
            // buttonGenerarNotaInsuficiente
            // 
            buttonGenerarNotaInsuficiente.BackColor = Color.FromArgb(33, 150, 243);
            buttonGenerarNotaInsuficiente.FlatAppearance.BorderSize = 0;
            buttonGenerarNotaInsuficiente.FlatStyle = FlatStyle.Flat;
            buttonGenerarNotaInsuficiente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonGenerarNotaInsuficiente.ForeColor = Color.White;
            buttonGenerarNotaInsuficiente.Location = new Point(816, 76);
            buttonGenerarNotaInsuficiente.Name = "buttonGenerarNotaInsuficiente";
            buttonGenerarNotaInsuficiente.Size = new Size(148, 33);
            buttonGenerarNotaInsuficiente.TabIndex = 15;
            buttonGenerarNotaInsuficiente.Text = "Generar Nota";
            buttonGenerarNotaInsuficiente.UseVisualStyleBackColor = false;
            buttonGenerarNotaInsuficiente.Click += buttonGenerarNotaInsuficiente_Click;
            // 
            // labelRemito
            // 
            labelRemito.AutoSize = true;
            labelRemito.Font = new Font("Segoe UI Symbol", 10.25F, FontStyle.Bold);
            labelRemito.Location = new Point(220, 36);
            labelRemito.Name = "labelRemito";
            labelRemito.Size = new Size(105, 19);
            labelRemito.TabIndex = 23;
            labelRemito.Text = "Nro. Remito *";
            // 
            // textBoxRemito
            // 
            textBoxRemito.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBoxRemito.Location = new Point(220, 59);
            textBoxRemito.Name = "textBoxRemito";
            textBoxRemito.Size = new Size(130, 27);
            textBoxRemito.TabIndex = 2;
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
            // textBoxCliente
            // 
            textBoxCliente.AllowDrop = true;
            textBoxCliente.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBoxCliente.Location = new Point(5, 59);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.PlaceholderText = " Nombre / Razón Social";
            textBoxCliente.Size = new Size(186, 27);
            textBoxCliente.TabIndex = 1;
            textBoxCliente.TextChanged += textBoxCliente_TextChanged;
            // 
            // buttonRestablecer
            // 
            buttonRestablecer.BackColor = Color.FromArgb(33, 150, 243);
            buttonRestablecer.FlatAppearance.BorderSize = 0;
            buttonRestablecer.FlatStyle = FlatStyle.Flat;
            buttonRestablecer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonRestablecer.ForeColor = Color.White;
            buttonRestablecer.Location = new Point(756, 552);
            buttonRestablecer.Name = "buttonRestablecer";
            buttonRestablecer.Size = new Size(208, 43);
            buttonRestablecer.TabIndex = 18;
            buttonRestablecer.Text = "Restablecer";
            buttonRestablecer.UseVisualStyleBackColor = false;
            buttonRestablecer.Click += buttonRestablecer_Click;
            // 
            // buttonGenerarOrdenYComprobantes
            // 
            buttonGenerarOrdenYComprobantes.BackColor = Color.FromArgb(33, 150, 243);
            buttonGenerarOrdenYComprobantes.FlatAppearance.BorderSize = 0;
            buttonGenerarOrdenYComprobantes.FlatStyle = FlatStyle.Flat;
            buttonGenerarOrdenYComprobantes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonGenerarOrdenYComprobantes.ForeColor = Color.White;
            buttonGenerarOrdenYComprobantes.Location = new Point(498, 552);
            buttonGenerarOrdenYComprobantes.Name = "buttonGenerarOrdenYComprobantes";
            buttonGenerarOrdenYComprobantes.Size = new Size(252, 43);
            buttonGenerarOrdenYComprobantes.TabIndex = 17;
            buttonGenerarOrdenYComprobantes.Text = "Generar Orden y Comprobantes";
            buttonGenerarOrdenYComprobantes.UseVisualStyleBackColor = false;
            buttonGenerarOrdenYComprobantes.Click += buttonGenerarOrdenYComprobantes_Click;
            // 
            // textBoxObservaciones
            // 
            textBoxObservaciones.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBoxObservaciones.Location = new Point(8, 487);
            textBoxObservaciones.Multiline = true;
            textBoxObservaciones.Name = "textBoxObservaciones";
            textBoxObservaciones.Size = new Size(956, 48);
            textBoxObservaciones.TabIndex = 0;
            textBoxObservaciones.TabStop = false;
            // 
            // labelObservaciones
            // 
            labelObservaciones.AutoSize = true;
            labelObservaciones.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            labelObservaciones.Location = new Point(12, 469);
            labelObservaciones.Name = "labelObservaciones";
            labelObservaciones.Size = new Size(92, 15);
            labelObservaciones.TabIndex = 0;
            labelObservaciones.Text = "Obsevaciones";
            // 
            // labelCantidadMercaderia
            // 
            labelCantidadMercaderia.AutoSize = true;
            labelCantidadMercaderia.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            labelCantidadMercaderia.Location = new Point(340, 34);
            labelCantidadMercaderia.Name = "labelCantidadMercaderia";
            labelCantidadMercaderia.Size = new Size(127, 15);
            labelCantidadMercaderia.TabIndex = 21;
            labelCantidadMercaderia.Text = "Cantidad recibida *";
            // 
            // labelUMMercaderia
            // 
            labelUMMercaderia.AutoSize = true;
            labelUMMercaderia.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            labelUMMercaderia.Location = new Point(174, 34);
            labelUMMercaderia.Name = "labelUMMercaderia";
            labelUMMercaderia.Size = new Size(131, 15);
            labelUMMercaderia.TabIndex = 20;
            labelUMMercaderia.Text = "Unidad De Medida *";
            // 
            // textBoxUMMercaderia
            // 
            textBoxUMMercaderia.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBoxUMMercaderia.Location = new Point(174, 57);
            textBoxUMMercaderia.Name = "textBoxUMMercaderia";
            textBoxUMMercaderia.Size = new Size(131, 27);
            textBoxUMMercaderia.TabIndex = 8;
            // 
            // textBoxCantidadMercaderia
            // 
            textBoxCantidadMercaderia.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBoxCantidadMercaderia.Location = new Point(340, 57);
            textBoxCantidadMercaderia.Name = "textBoxCantidadMercaderia";
            textBoxCantidadMercaderia.Size = new Size(127, 27);
            textBoxCantidadMercaderia.TabIndex = 9;
            textBoxCantidadMercaderia.Validating += textBoxCantidadMercaderia_Validating;
            // 
            // groupBoxTransportista
            // 
            groupBoxTransportista.Controls.Add(labelDNITransportista);
            groupBoxTransportista.Controls.Add(labelNombreTransportista);
            groupBoxTransportista.Controls.Add(textBoxDNITransportista);
            groupBoxTransportista.Controls.Add(textBoxNombreTransportista);
            groupBoxTransportista.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxTransportista.Location = new Point(18, 167);
            groupBoxTransportista.Name = "groupBoxTransportista";
            groupBoxTransportista.Size = new Size(970, 129);
            groupBoxTransportista.TabIndex = 3;
            groupBoxTransportista.TabStop = false;
            groupBoxTransportista.Text = "Transportista";
            // 
            // labelDNITransportista
            // 
            labelDNITransportista.AutoSize = true;
            labelDNITransportista.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            labelDNITransportista.Location = new Point(8, 36);
            labelDNITransportista.Name = "labelDNITransportista";
            labelDNITransportista.Size = new Size(40, 15);
            labelDNITransportista.TabIndex = 16;
            labelDNITransportista.Text = "DNI *";
            // 
            // labelNombreTransportista
            // 
            labelNombreTransportista.AutoSize = true;
            labelNombreTransportista.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            labelNombreTransportista.Location = new Point(220, 36);
            labelNombreTransportista.Name = "labelNombreTransportista";
            labelNombreTransportista.Size = new Size(132, 15);
            labelNombreTransportista.TabIndex = 14;
            labelNombreTransportista.Text = "Nombre y apellido *";
            // 
            // textBoxDNITransportista
            // 
            textBoxDNITransportista.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBoxDNITransportista.Location = new Point(7, 59);
            textBoxDNITransportista.Name = "textBoxDNITransportista";
            textBoxDNITransportista.Size = new Size(186, 27);
            textBoxDNITransportista.TabIndex = 4;
            // 
            // textBoxNombreTransportista
            // 
            textBoxNombreTransportista.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBoxNombreTransportista.Location = new Point(220, 59);
            textBoxNombreTransportista.Name = "textBoxNombreTransportista";
            textBoxNombreTransportista.Size = new Size(186, 27);
            textBoxNombreTransportista.TabIndex = 5;
            // 
            // groupBoxMercaderias
            // 
            groupBoxMercaderias.Controls.Add(buttonEliminar);
            groupBoxMercaderias.Controls.Add(buttonAgregar);
            groupBoxMercaderias.Controls.Add(listViewMercaderias);
            groupBoxMercaderias.Controls.Add(textBoxDescripcionMercaderia);
            groupBoxMercaderias.Controls.Add(labelDescripcionMercaderia);
            groupBoxMercaderias.Controls.Add(labelCantidadMercaderia);
            groupBoxMercaderias.Controls.Add(labelUMMercaderia);
            groupBoxMercaderias.Controls.Add(textBoxUMMercaderia);
            groupBoxMercaderias.Controls.Add(textBoxCantidadMercaderia);
            groupBoxMercaderias.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxMercaderias.Location = new Point(18, 259);
            groupBoxMercaderias.Name = "groupBoxMercaderias";
            groupBoxMercaderias.Size = new Size(970, 267);
            groupBoxMercaderias.TabIndex = 6;
            groupBoxMercaderias.TabStop = false;
            groupBoxMercaderias.Text = "Mercaderías";
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.FromArgb(33, 150, 243);
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonEliminar.ForeColor = Color.White;
            buttonEliminar.Location = new Point(597, 57);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(94, 27);
            buttonEliminar.TabIndex = 11;
            buttonEliminar.TabStop = false;
            buttonEliminar.Text = "- Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(33, 150, 243);
            buttonAgregar.FlatAppearance.BorderSize = 0;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAgregar.ForeColor = Color.White;
            buttonAgregar.Location = new Point(498, 57);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(89, 27);
            buttonAgregar.TabIndex = 10;
            buttonAgregar.Text = "+ Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // listViewMercaderias
            // 
            listViewMercaderias.Columns.AddRange(new ColumnHeader[] { columnHeaderDescripcion, columnHeaderUM, columnHeaderCantidadRecibida, columnHeaderCantidadRechazada });
            listViewMercaderias.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            listViewMercaderias.FullRowSelect = true;
            listViewMercaderias.GridLines = true;
            listViewMercaderias.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewMercaderias.Location = new Point(8, 99);
            listViewMercaderias.MultiSelect = false;
            listViewMercaderias.Name = "listViewMercaderias";
            listViewMercaderias.Size = new Size(956, 168);
            listViewMercaderias.TabIndex = 10;
            listViewMercaderias.UseCompatibleStateImageBehavior = false;
            listViewMercaderias.View = View.Details;
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
            // columnHeaderCantidadRecibida
            // 
            columnHeaderCantidadRecibida.Text = "Cantidad Recibida";
            columnHeaderCantidadRecibida.Width = 150;
            // 
            // columnHeaderCantidadRechazada
            // 
            columnHeaderCantidadRechazada.Text = "Cantidad Rechazada";
            columnHeaderCantidadRechazada.Width = 150;
            // 
            // textBoxDescripcionMercaderia
            // 
            textBoxDescripcionMercaderia.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBoxDescripcionMercaderia.Location = new Point(8, 57);
            textBoxDescripcionMercaderia.Name = "textBoxDescripcionMercaderia";
            textBoxDescripcionMercaderia.Size = new Size(130, 27);
            textBoxDescripcionMercaderia.TabIndex = 7;
            textBoxDescripcionMercaderia.Validating += textBoxDescripcionMercaderia_Validating;
            // 
            // labelDescripcionMercaderia
            // 
            labelDescripcionMercaderia.AutoSize = true;
            labelDescripcionMercaderia.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            labelDescripcionMercaderia.Location = new Point(8, 34);
            labelDescripcionMercaderia.Name = "labelDescripcionMercaderia";
            labelDescripcionMercaderia.Size = new Size(90, 15);
            labelDescripcionMercaderia.TabIndex = 19;
            labelDescripcionMercaderia.Text = "Descripción *";
            // 
            // errorProviderCliente
            // 
            errorProviderCliente.ContainerControl = this;
            // 
            // errorProviderNroRemito
            // 
            errorProviderNroRemito.ContainerControl = this;
            // 
            // errorProviderDNITransportista
            // 
            errorProviderDNITransportista.ContainerControl = this;
            // 
            // errorProviderNombreTransportista
            // 
            errorProviderNombreTransportista.ContainerControl = this;
            // 
            // errorProviderDescripcionMercaderia
            // 
            errorProviderDescripcionMercaderia.ContainerControl = this;
            // 
            // errorProviderUMMercaderia
            // 
            errorProviderUMMercaderia.ContainerControl = this;
            // 
            // errorProviderCantidadMercaderia
            // 
            errorProviderCantidadMercaderia.ContainerControl = this;
            // 
            // RecepcionarMercaderiaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1008, 804);
            Controls.Add(groupBoxNotaEspacio);
            Controls.Add(pictureBoxLogo);
            Controls.Add(labelTitulo);
            Controls.Add(groupBoxMercaderias);
            Controls.Add(groupBoxTransportista);
            Controls.Add(groupBoxComprobarEspacio);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RecepcionarMercaderiaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecepcionMercaderiaForm";
            Load += RecepcionarMercaderiaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            groupBoxComprobarEspacio.ResumeLayout(false);
            groupBoxComprobarEspacio.PerformLayout();
            groupBoxNotaEspacio.ResumeLayout(false);
            groupBoxNotaEspacio.PerformLayout();
            groupBoxTransportista.ResumeLayout(false);
            groupBoxTransportista.PerformLayout();
            groupBoxMercaderias.ResumeLayout(false);
            groupBoxMercaderias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNroRemito).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDNITransportista).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNombreTransportista).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDescripcionMercaderia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUMMercaderia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCantidadMercaderia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labelTitulo;
        private GroupBox groupBoxComprobarEspacio;
        private Label labelCliente;
        private Label labelObservaciones;
        private TextBox textBoxCliente;
        private TextBox textBoxObservaciones;
        private Label labelCantidadMercaderia;
        private Label labelUMMercaderia;
        private TextBox textBoxUMMercaderia;
        private TextBox textBoxCantidadMercaderia;
        private GroupBox groupBoxTransportista;
        private Label labelDNITransportista;
        private Label labelNombreTransportista;
        private TextBox textBoxDNITransportista;
        private TextBox textBoxNombreTransportista;
        private GroupBox groupBoxMercaderias;
        private GroupBox groupBox3;
        private Label labelRemito;
        private TextBox textBoxRemito;
        private Button buttonGenerarOrdenYComprobantes;
        private TextBox textBoxDescripcionMercaderia;
        private Label labelDescripcionMercaderia;
        private ListView listViewMercaderias;
        private ColumnHeader columnHeaderDescripcion;
        private ColumnHeader columnHeaderUM;
        private ColumnHeader columnHeaderCantidadRecibida;
        private Button buttonAgregar;
        private ErrorProvider errorProviderCliente;
        private ErrorProvider errorProviderNroRemito;
        private ErrorProvider errorProviderDNITransportista;
        private ErrorProvider errorProviderNombreTransportista;
        private ErrorProvider errorProviderDescripcionMercaderia;
        private ErrorProvider errorProviderUMMercaderia;
        private ErrorProvider errorProviderCantidadMercaderia;
        private Button buttonEliminar;
        private GroupBox groupBoxNotaEspacio;
        private Label label8;
        private RadioButton radioButtonTotal;
        private RadioButton radioButtonParcial;
        private Button buttonGenerarNotaInsuficiente;
        private Button buttonRestablecer;
        private ColumnHeader columnHeaderCantidadRechazada;
        private Label labelCantidadRechazada;
        private TextBox textBoxCantidadRechazada;
        private Button buttonActualizar;
    }
}