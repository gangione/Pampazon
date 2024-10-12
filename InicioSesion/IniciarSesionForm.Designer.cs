namespace Pampazon.InicioSesion
{
    partial class IniciarSesionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesionForm));
            textBoxContrasenia = new TextBox();
            textBoxUsuario = new TextBox();
            buttonIniciarSesion = new Button();
            pictureBoxLogo = new PictureBox();
            labelUsuario = new Label();
            labelContrasenia = new Label();
            labelTitulo = new Label();
            groupBoxFromulario = new GroupBox();
            errorProviderUsuario = new ErrorProvider(components);
            errorProviderContrasenia = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            groupBoxFromulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderContrasenia).BeginInit();
            SuspendLayout();
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            textBoxContrasenia.Location = new Point(33, 166);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.PasswordChar = '*';
            textBoxContrasenia.Size = new Size(218, 33);
            textBoxContrasenia.TabIndex = 2;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            textBoxUsuario.Location = new Point(123, 194);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(218, 33);
            textBoxUsuario.TabIndex = 1;
            // 
            // buttonIniciarSesion
            // 
            buttonIniciarSesion.BackColor = Color.FromArgb(33, 150, 243);
            buttonIniciarSesion.FlatAppearance.BorderSize = 0;
            buttonIniciarSesion.FlatStyle = FlatStyle.Flat;
            buttonIniciarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonIniciarSesion.ForeColor = Color.White;
            buttonIniciarSesion.Location = new Point(33, 226);
            buttonIniciarSesion.Name = "buttonIniciarSesion";
            buttonIniciarSesion.Size = new Size(218, 40);
            buttonIniciarSesion.TabIndex = 3;
            buttonIniciarSesion.Text = "Iniciar Sesion";
            buttonIniciarSesion.UseVisualStyleBackColor = false;
            buttonIniciarSesion.Click += buttonIniciarSesion_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(90, 55);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(302, 60);
            pictureBoxLogo.TabIndex = 16;
            pictureBoxLogo.TabStop = false;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(33, 45);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(77, 25);
            labelUsuario.TabIndex = 18;
            labelUsuario.Text = "Usuario";
            // 
            // labelContrasenia
            // 
            labelContrasenia.AutoSize = true;
            labelContrasenia.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            labelContrasenia.Location = new Point(33, 138);
            labelContrasenia.Name = "labelContrasenia";
            labelContrasenia.Size = new Size(109, 25);
            labelContrasenia.TabIndex = 17;
            labelContrasenia.Text = "Contraseña";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            labelTitulo.Location = new Point(90, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(302, 32);
            labelTitulo.TabIndex = 19;
            labelTitulo.Text = "Sistema Gestión Integral";
            // 
            // groupBoxFromulario
            // 
            groupBoxFromulario.Controls.Add(buttonIniciarSesion);
            groupBoxFromulario.Controls.Add(labelUsuario);
            groupBoxFromulario.Controls.Add(textBoxContrasenia);
            groupBoxFromulario.Controls.Add(labelContrasenia);
            groupBoxFromulario.Location = new Point(90, 121);
            groupBoxFromulario.Name = "groupBoxFromulario";
            groupBoxFromulario.Size = new Size(302, 284);
            groupBoxFromulario.TabIndex = 20;
            groupBoxFromulario.TabStop = false;
            // 
            // errorProviderUsuario
            // 
            errorProviderUsuario.ContainerControl = this;
            // 
            // errorProviderContrasenia
            // 
            errorProviderContrasenia.ContainerControl = this;
            // 
            // IniciarSesionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 461);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBoxLogo);
            Controls.Add(textBoxUsuario);
            Controls.Add(groupBoxFromulario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "IniciarSesionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            Load += IniciarSesionForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            groupBoxFromulario.ResumeLayout(false);
            groupBoxFromulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderContrasenia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxContrasenia;
        private TextBox textBoxUsuario;
        private Button buttonIniciarSesion;
        private PictureBox pictureBoxLogo;
        private Label labelUsuario;
        private Label labelContrasenia;
        private Label labelTitulo;
        private GroupBox groupBoxFromulario;
        private ErrorProvider errorProviderUsuario;
        private ErrorProvider errorProviderContrasenia;
    }
}