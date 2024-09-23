namespace Pampazon.MenuInicio
{
    partial class MenuInicioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicioForm));
            pictureBox1 = new PictureBox();
            labelTitulo = new Label();
            buttonAdmin = new Button();
            groupBox1 = new GroupBox();
            buttonVentas = new Button();
            buttonOperaciones = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(687, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 60);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            labelTitulo.Location = new Point(22, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(185, 32);
            labelTitulo.TabIndex = 16;
            labelTitulo.Text = "Menú de Inicio";
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.FromArgb(33, 150, 243);
            buttonAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAdmin.ForeColor = Color.White;
            buttonAdmin.Location = new Point(145, 114);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(200, 150);
            buttonAdmin.TabIndex = 18;
            buttonAdmin.Text = "Administración de Sistema";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAdmin);
            groupBox1.Controls.Add(buttonVentas);
            groupBox1.Controls.Add(buttonOperaciones);
            groupBox1.Location = new Point(22, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(965, 421);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // buttonVentas
            // 
            buttonVentas.BackColor = Color.FromArgb(33, 150, 243);
            buttonVentas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonVentas.ForeColor = Color.White;
            buttonVentas.Location = new Point(623, 114);
            buttonVentas.Name = "buttonVentas";
            buttonVentas.Size = new Size(200, 150);
            buttonVentas.TabIndex = 20;
            buttonVentas.Text = "Ventas";
            buttonVentas.UseVisualStyleBackColor = false;
            buttonVentas.Click += buttonVentas_Click;
            // 
            // buttonOperaciones
            // 
            buttonOperaciones.BackColor = Color.FromArgb(33, 150, 243);
            buttonOperaciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonOperaciones.ForeColor = Color.White;
            buttonOperaciones.Location = new Point(385, 114);
            buttonOperaciones.Name = "buttonOperaciones";
            buttonOperaciones.Size = new Size(200, 150);
            buttonOperaciones.TabIndex = 19;
            buttonOperaciones.Text = "Operaciones";
            buttonOperaciones.UseVisualStyleBackColor = false;
            // 
            // MenuInicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 511);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Controls.Add(groupBox1);
            Name = "MenuInicioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuInicioForm";
            Load += MenuInicioForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTitulo;
        private Button buttonAdmin;
        private GroupBox groupBox1;
        private Button buttonVentas;
        private Button buttonOperaciones;
    }
}