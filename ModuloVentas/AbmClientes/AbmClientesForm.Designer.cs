namespace Pampazon
{
    partial class AbmClientesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbmClientesForm));
            listViewCliente = new ListView();
            columnHeaderNumero = new ColumnHeader();
            columnHeaderCuit = new ColumnHeader();
            columnHeaderNombre = new ColumnHeader();
            columnHeaderCalleNumero = new ColumnHeader();
            columnHeaderDpto = new ColumnHeader();
            columnHeaderCiudad = new ColumnHeader();
            columnHeaderProvincia = new ColumnHeader();
            columnHeaderCodPostal = new ColumnHeader();
            textBoxBuscar = new TextBox();
            labelTitulo = new Label();
            buttonEditar = new Button();
            groupBoxFormulario = new GroupBox();
            buttonActualizar = new Button();
            labelNumero = new Label();
            textBoxNumero = new TextBox();
            buttonLimpiar = new Button();
            labelCuit = new Label();
            labelNombre = new Label();
            textBoxProvincia = new TextBox();
            labelProvincia = new Label();
            textBoxCodPostal = new TextBox();
            labelCodPostal = new Label();
            textBoxCiudad = new TextBox();
            labelCiudad = new Label();
            textBoxDepto = new TextBox();
            labelDepto = new Label();
            textBoxCuit = new TextBox();
            textBoxCalleNumero = new TextBox();
            labelCalleNumero = new Label();
            textBoxNombre = new TextBox();
            buttonGuardar = new Button();
            buttonBuscar = new Button();
            buttonEliminar = new Button();
            errorProviderCuit = new ErrorProvider(components);
            errorProviderCalleNumero = new ErrorProvider(components);
            errorProviderCiudad = new ErrorProvider(components);
            errorProviderProvincia = new ErrorProvider(components);
            errorProviderCodPostal = new ErrorProvider(components);
            errorProviderNombre = new ErrorProvider(components);
            pictureBoxLogo = new PictureBox();
            errorProviderNumero = new ErrorProvider(components);
            groupBoxFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCuit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCalleNumero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCiudad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProvincia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCodPostal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            SuspendLayout();
            // 
            // listViewCliente
            // 
            listViewCliente.Columns.AddRange(new ColumnHeader[] { columnHeaderNumero, columnHeaderCuit, columnHeaderNombre, columnHeaderCalleNumero, columnHeaderDpto, columnHeaderCiudad, columnHeaderProvincia, columnHeaderCodPostal });
            listViewCliente.FullRowSelect = true;
            listViewCliente.GridLines = true;
            listViewCliente.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewCliente.Location = new Point(12, 75);
            listViewCliente.MultiSelect = false;
            listViewCliente.Name = "listViewCliente";
            listViewCliente.Size = new Size(975, 197);
            listViewCliente.TabIndex = 0;
            listViewCliente.UseCompatibleStateImageBehavior = false;
            listViewCliente.View = View.Details;
            // 
            // columnHeaderNumero
            // 
            columnHeaderNumero.Text = "Numero";
            columnHeaderNumero.Width = 80;
            // 
            // columnHeaderCuit
            // 
            columnHeaderCuit.Text = "CUIT";
            columnHeaderCuit.Width = 100;
            // 
            // columnHeaderNombre
            // 
            columnHeaderNombre.Text = "Nombre";
            columnHeaderNombre.Width = 160;
            // 
            // columnHeaderCalleNumero
            // 
            columnHeaderCalleNumero.Text = "Calle";
            columnHeaderCalleNumero.Width = 160;
            // 
            // columnHeaderDpto
            // 
            columnHeaderDpto.Text = "Dpto";
            columnHeaderDpto.Width = 70;
            // 
            // columnHeaderCiudad
            // 
            columnHeaderCiudad.Text = "Ciudad";
            columnHeaderCiudad.Width = 160;
            // 
            // columnHeaderProvincia
            // 
            columnHeaderProvincia.Text = "Provincia";
            columnHeaderProvincia.Width = 160;
            // 
            // columnHeaderCodPostal
            // 
            columnHeaderCodPostal.Text = "Cod. Postal";
            columnHeaderCodPostal.Width = 80;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BackColor = Color.FromArgb(240, 240, 240);
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Font = new Font("Segoe UI", 10F);
            textBoxBuscar.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxBuscar.Location = new Point(12, 46);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = " Razón Social o CUIT";
            textBoxBuscar.Size = new Size(237, 25);
            textBoxBuscar.TabIndex = 1;
            textBoxBuscar.UseWaitCursor = true;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            labelTitulo.Location = new Point(12, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(105, 32);
            labelTitulo.TabIndex = 11;
            labelTitulo.Text = "Clientes";
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.FromArgb(33, 150, 243);
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(839, 280);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(150, 40);
            buttonEditar.TabIndex = 13;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // groupBoxFormulario
            // 
            groupBoxFormulario.Controls.Add(buttonActualizar);
            groupBoxFormulario.Controls.Add(labelNumero);
            groupBoxFormulario.Controls.Add(textBoxNumero);
            groupBoxFormulario.Controls.Add(buttonLimpiar);
            groupBoxFormulario.Controls.Add(labelCuit);
            groupBoxFormulario.Controls.Add(labelNombre);
            groupBoxFormulario.Controls.Add(textBoxProvincia);
            groupBoxFormulario.Controls.Add(labelProvincia);
            groupBoxFormulario.Controls.Add(textBoxCodPostal);
            groupBoxFormulario.Controls.Add(labelCodPostal);
            groupBoxFormulario.Controls.Add(textBoxCiudad);
            groupBoxFormulario.Controls.Add(labelCiudad);
            groupBoxFormulario.Controls.Add(textBoxDepto);
            groupBoxFormulario.Controls.Add(labelDepto);
            groupBoxFormulario.Controls.Add(textBoxCuit);
            groupBoxFormulario.Controls.Add(textBoxCalleNumero);
            groupBoxFormulario.Controls.Add(labelCalleNumero);
            groupBoxFormulario.Controls.Add(textBoxNombre);
            groupBoxFormulario.Controls.Add(buttonGuardar);
            groupBoxFormulario.Location = new Point(14, 326);
            groupBoxFormulario.Name = "groupBoxFormulario";
            groupBoxFormulario.Size = new Size(975, 241);
            groupBoxFormulario.TabIndex = 4;
            groupBoxFormulario.TabStop = false;
            groupBoxFormulario.Text = "Formulario";
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(776, 207);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(94, 28);
            buttonActualizar.TabIndex = 15;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelNumero.Location = new Point(8, 30);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 18;
            labelNumero.Text = "Numero";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(8, 48);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(148, 23);
            textBoxNumero.TabIndex = 6;
            textBoxNumero.Validating += textBoxNumero_Validating;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(876, 207);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(94, 28);
            buttonLimpiar.TabIndex = 16;
            buttonLimpiar.Text = "Restablecer";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // labelCuit
            // 
            labelCuit.AutoSize = true;
            labelCuit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelCuit.Location = new Point(179, 30);
            labelCuit.Name = "labelCuit";
            labelCuit.Size = new Size(69, 15);
            labelCuit.TabIndex = 8;
            labelCuit.Text = "CUIT / CUIL";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelNombre.Location = new Point(392, 30);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(130, 15);
            labelNombre.TabIndex = 6;
            labelNombre.Text = "Nombre / Razón Social";
            // 
            // textBoxProvincia
            // 
            textBoxProvincia.Location = new Point(566, 113);
            textBoxProvincia.Name = "textBoxProvincia";
            textBoxProvincia.Size = new Size(218, 23);
            textBoxProvincia.TabIndex = 12;
            // 
            // labelProvincia
            // 
            labelProvincia.AutoSize = true;
            labelProvincia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelProvincia.Location = new Point(566, 95);
            labelProvincia.Name = "labelProvincia";
            labelProvincia.Size = new Size(56, 15);
            labelProvincia.TabIndex = 16;
            labelProvincia.Text = "Provincia";
            // 
            // textBoxCodPostal
            // 
            textBoxCodPostal.Location = new Point(808, 113);
            textBoxCodPostal.Name = "textBoxCodPostal";
            textBoxCodPostal.Size = new Size(81, 23);
            textBoxCodPostal.TabIndex = 13;
            // 
            // labelCodPostal
            // 
            labelCodPostal.AutoSize = true;
            labelCodPostal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelCodPostal.Location = new Point(808, 95);
            labelCodPostal.Name = "labelCodPostal";
            labelCodPostal.Size = new Size(80, 15);
            labelCodPostal.TabIndex = 14;
            labelCodPostal.Text = "Código Postal";
            // 
            // textBoxCiudad
            // 
            textBoxCiudad.Location = new Point(320, 113);
            textBoxCiudad.Name = "textBoxCiudad";
            textBoxCiudad.Size = new Size(221, 23);
            textBoxCiudad.TabIndex = 11;
            // 
            // labelCiudad
            // 
            labelCiudad.AutoSize = true;
            labelCiudad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelCiudad.Location = new Point(320, 95);
            labelCiudad.Name = "labelCiudad";
            labelCiudad.Size = new Size(44, 15);
            labelCiudad.TabIndex = 12;
            labelCiudad.Text = "Ciudad";
            // 
            // textBoxDepto
            // 
            textBoxDepto.Location = new Point(221, 113);
            textBoxDepto.Name = "textBoxDepto";
            textBoxDepto.Size = new Size(83, 23);
            textBoxDepto.TabIndex = 10;
            // 
            // labelDepto
            // 
            labelDepto.AutoSize = true;
            labelDepto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelDepto.Location = new Point(220, 95);
            labelDepto.Name = "labelDepto";
            labelDepto.Size = new Size(84, 15);
            labelDepto.TabIndex = 10;
            labelDepto.Text = "Departamento";
            // 
            // textBoxCuit
            // 
            textBoxCuit.Location = new Point(179, 48);
            textBoxCuit.Name = "textBoxCuit";
            textBoxCuit.Size = new Size(186, 23);
            textBoxCuit.TabIndex = 7;
            textBoxCuit.Validating += textBoxCuit_Validating;
            // 
            // textBoxCalleNumero
            // 
            textBoxCalleNumero.Location = new Point(8, 113);
            textBoxCalleNumero.Name = "textBoxCalleNumero";
            textBoxCalleNumero.Size = new Size(186, 23);
            textBoxCalleNumero.TabIndex = 9;
            // 
            // labelCalleNumero
            // 
            labelCalleNumero.AutoSize = true;
            labelCalleNumero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelCalleNumero.Location = new Point(8, 95);
            labelCalleNumero.Name = "labelCalleNumero";
            labelCalleNumero.Size = new Size(86, 15);
            labelCalleNumero.TabIndex = 8;
            labelCalleNumero.Text = "Calle y número";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(392, 48);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(186, 23);
            textBoxNombre.TabIndex = 8;
            textBoxNombre.Validating += textBoxNombre_Validating;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(676, 207);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 28);
            buttonGuardar.TabIndex = 14;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.FromArgb(33, 150, 243);
            buttonBuscar.FlatAppearance.BorderSize = 0;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(255, 46);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(150, 25);
            buttonBuscar.TabIndex = 10;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.FromArgb(33, 150, 243);
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonEliminar.ForeColor = Color.White;
            buttonEliminar.Location = new Point(683, 280);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(150, 40);
            buttonEliminar.TabIndex = 12;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // errorProviderCuit
            // 
            errorProviderCuit.ContainerControl = this;
            // 
            // errorProviderCalleNumero
            // 
            errorProviderCalleNumero.ContainerControl = this;
            // 
            // errorProviderCiudad
            // 
            errorProviderCiudad.ContainerControl = this;
            // 
            // errorProviderProvincia
            // 
            errorProviderProvincia.ContainerControl = this;
            // 
            // errorProviderCodPostal
            // 
            errorProviderCodPostal.ContainerControl = this;
            // 
            // errorProviderNombre
            // 
            errorProviderNombre.ContainerControl = this;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(687, 9);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(300, 60);
            pictureBoxLogo.TabIndex = 7;
            pictureBoxLogo.TabStop = false;
            // 
            // errorProviderNumero
            // 
            errorProviderNumero.ContainerControl = this;
            // 
            // AbmClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1010, 587);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonEditar);
            Controls.Add(labelTitulo);
            Controls.Add(textBoxBuscar);
            Controls.Add(listViewCliente);
            Controls.Add(groupBoxFormulario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AbmClienteForm";
            Padding = new Padding(10);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABM de Clientes";
            Load += AbmClienteForm_Load;
            groupBoxFormulario.ResumeLayout(false);
            groupBoxFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCuit).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCalleNumero).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCiudad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProvincia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCodPostal).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewCliente;
        private TextBox textBoxBuscar;
        private Label labelTitulo;
        private Button buttonEditar;
        private GroupBox groupBoxFormulario;
        private Button buttonGuardar;
        private TextBox textBoxCuit;
        private TextBox textBoxCalleNumero;
        private Label labelCuit;
        private Label labelCalleNumero;
        private TextBox textBoxNombre;
        private Label labelNombre;
        private TextBox textBoxDepto;
        private Label labelDepto;
        private TextBox textBoxProvincia;
        private Label labelProvincia;
        private TextBox textBoxCodPostal;
        private Label labelCodPostal;
        private TextBox textBoxCiudad;
        private Label labelCiudad;
        private Button buttonBuscar;
        private Button buttonEliminar;
        private ColumnHeader columnHeaderNombre;
        private ColumnHeader columnHeaderCuit;
        private ColumnHeader columnHeaderCalleNumero;
        private ColumnHeader columnHeaderDpto;
        private ColumnHeader columnHeaderCiudad;
        private ColumnHeader columnHeaderProvincia;
        private ColumnHeader columnHeaderCodPostal;
        private ErrorProvider errorProviderCuit;
        private ErrorProvider errorProviderCalleNumero;
        private ErrorProvider errorProviderCiudad;
        private ErrorProvider errorProviderProvincia;
        private ErrorProvider errorProviderCodPostal;
        private ErrorProvider errorProviderNombre;
        private PictureBox pictureBoxLogo;
        private Button buttonLimpiar;
        private ColumnHeader columnHeaderNumero;
        private Label labelNumero;
        private TextBox textBoxNumero;
        private ErrorProvider errorProviderNumero;
        private Button buttonActualizar;
    }
}
