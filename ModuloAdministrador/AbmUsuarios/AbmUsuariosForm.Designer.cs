namespace Pampazon.ModuloUsuarios.AbmUsuarios
{
    partial class AbmUsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbmUsuariosForm));
            pictureBoxLogo = new PictureBox();
            buttonEliminar = new Button();
            buttonBuscar = new Button();
            buttonEditar = new Button();
            labelTitulo = new Label();
            textBoxBuscar = new TextBox();
            listViewCliente = new ListView();
            columnHeaderNumero = new ColumnHeader();
            columnHeaderNombre = new ColumnHeader();
            columnHeaderPW = new ColumnHeader();
            columnHeaderRol = new ColumnHeader();
            groupBoxFormulario = new GroupBox();
            labelRol = new Label();
            comboBoxRol = new ComboBox();
            buttonActualizar = new Button();
            labelNumero = new Label();
            textBoxNumero = new TextBox();
            buttonLimpiar = new Button();
            labelNombre = new Label();
            textBoxContrasenia = new TextBox();
            labelContrasenia = new Label();
            textBoxNombre = new TextBox();
            buttonGuardar = new Button();
            errorProviderNumero = new ErrorProvider(components);
            errorProviderNombre = new ErrorProvider(components);
            errorProviderContrasenia = new ErrorProvider(components);
            errorProviderRol = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            groupBoxFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderContrasenia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderRol).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(695, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(300, 60);
            pictureBoxLogo.TabIndex = 15;
            pictureBoxLogo.TabStop = false;
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
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.FromArgb(33, 150, 243);
            buttonBuscar.FlatAppearance.BorderSize = 0;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(255, 49);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(150, 25);
            buttonBuscar.TabIndex = 10;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
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
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            labelTitulo.Location = new Point(20, 12);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(115, 32);
            labelTitulo.TabIndex = 11;
            labelTitulo.Text = "Usuarios";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BackColor = Color.FromArgb(240, 240, 240);
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Font = new Font("Segoe UI", 10F);
            textBoxBuscar.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxBuscar.Location = new Point(20, 49);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = " Nombre. Numero o Rol";
            textBoxBuscar.Size = new Size(229, 25);
            textBoxBuscar.TabIndex = 9;
            textBoxBuscar.UseWaitCursor = true;
            // 
            // listViewCliente
            // 
            listViewCliente.BackColor = Color.White;
            listViewCliente.Columns.AddRange(new ColumnHeader[] { columnHeaderNumero, columnHeaderNombre, columnHeaderPW, columnHeaderRol });
            listViewCliente.Font = new Font("Segoe UI", 10F);
            listViewCliente.ForeColor = Color.FromArgb(64, 64, 64);
            listViewCliente.FullRowSelect = true;
            listViewCliente.GridLines = true;
            listViewCliente.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewCliente.Location = new Point(20, 78);
            listViewCliente.MultiSelect = false;
            listViewCliente.Name = "listViewCliente";
            listViewCliente.Size = new Size(975, 197);
            listViewCliente.TabIndex = 8;
            listViewCliente.UseCompatibleStateImageBehavior = false;
            listViewCliente.View = View.Details;
            // 
            // columnHeaderNumero
            // 
            columnHeaderNumero.Text = "Numero";
            columnHeaderNumero.Width = 80;
            // 
            // columnHeaderNombre
            // 
            columnHeaderNombre.Text = "Nombre";
            columnHeaderNombre.Width = 160;
            // 
            // columnHeaderPW
            // 
            columnHeaderPW.Text = "PW";
            columnHeaderPW.Width = 0;
            // 
            // columnHeaderRol
            // 
            columnHeaderRol.Text = "Rol";
            columnHeaderRol.Width = 200;
            // 
            // groupBoxFormulario
            // 
            groupBoxFormulario.Controls.Add(labelRol);
            groupBoxFormulario.Controls.Add(comboBoxRol);
            groupBoxFormulario.Controls.Add(buttonActualizar);
            groupBoxFormulario.Controls.Add(labelNumero);
            groupBoxFormulario.Controls.Add(textBoxNumero);
            groupBoxFormulario.Controls.Add(buttonLimpiar);
            groupBoxFormulario.Controls.Add(labelNombre);
            groupBoxFormulario.Controls.Add(textBoxContrasenia);
            groupBoxFormulario.Controls.Add(labelContrasenia);
            groupBoxFormulario.Controls.Add(textBoxNombre);
            groupBoxFormulario.Controls.Add(buttonGuardar);
            groupBoxFormulario.Location = new Point(20, 325);
            groupBoxFormulario.Name = "groupBoxFormulario";
            groupBoxFormulario.Size = new Size(975, 159);
            groupBoxFormulario.TabIndex = 14;
            groupBoxFormulario.TabStop = false;
            groupBoxFormulario.Text = "Formulario";
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelRol.Location = new Point(604, 30);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(24, 15);
            labelRol.TabIndex = 20;
            labelRol.Text = "Rol";
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(604, 48);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(160, 23);
            comboBoxRol.TabIndex = 19;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(770, 119);
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
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(870, 119);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(94, 28);
            buttonLimpiar.TabIndex = 16;
            buttonLimpiar.Text = "Restablecer";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelNombre.Location = new Point(178, 30);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 6;
            labelNombre.Text = "Nombre";
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.Location = new Point(390, 48);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.PasswordChar = '*';
            textBoxContrasenia.Size = new Size(186, 23);
            textBoxContrasenia.TabIndex = 9;
            // 
            // labelContrasenia
            // 
            labelContrasenia.AutoSize = true;
            labelContrasenia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelContrasenia.Location = new Point(390, 30);
            labelContrasenia.Name = "labelContrasenia";
            labelContrasenia.Size = new Size(66, 15);
            labelContrasenia.TabIndex = 8;
            labelContrasenia.Text = "Contraseña";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(178, 48);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(186, 23);
            textBoxNombre.TabIndex = 8;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(670, 119);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 28);
            buttonGuardar.TabIndex = 14;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // errorProviderNumero
            // 
            errorProviderNumero.ContainerControl = this;
            // 
            // errorProviderNombre
            // 
            errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderContrasenia
            // 
            errorProviderContrasenia.ContainerControl = this;
            // 
            // errorProviderRol
            // 
            errorProviderRol.ContainerControl = this;
            // 
            // AbmUsuariosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1014, 511);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonEditar);
            Controls.Add(labelTitulo);
            Controls.Add(textBoxBuscar);
            Controls.Add(listViewCliente);
            Controls.Add(groupBoxFormulario);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "AbmUsuariosForm";
            Padding = new Padding(10);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abm Usuarios";
            Load += AbmUsuariosForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            groupBoxFormulario.ResumeLayout(false);
            groupBoxFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderContrasenia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderRol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Button buttonEliminar;
        private Button buttonBuscar;
        private Button buttonEditar;
        private Label labelTitulo;
        private TextBox textBoxBuscar;
        private ListView listViewCliente;
        private ColumnHeader columnHeaderNumero;
        private ColumnHeader columnHeaderNombre;
        private ColumnHeader columnHeaderRol;
        private GroupBox groupBoxFormulario;
        private Button buttonActualizar;
        private Label labelNumero;
        private TextBox textBoxNumero;
        private Button buttonLimpiar;
        private Label labelNombre;
        private TextBox textBoxContrasenia;
        private Label labelContrasenia;
        private TextBox textBoxNombre;
        private Button buttonGuardar;
        private ComboBox comboBoxRol;
        private Label labelRol;
        private ErrorProvider errorProviderNumero;
        private ErrorProvider errorProviderNombre;
        private ErrorProvider errorProviderContrasenia;
        private ErrorProvider errorProviderRol;
        private ColumnHeader columnHeaderPW;
    }
}