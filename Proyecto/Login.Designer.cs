namespace Proyecto
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.text_contraseña = new MetroFramework.Controls.MetroTextBox();
            this.text_usuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources._11953002_10153246730067479_3720177363912975668_n;
            this.pictureBox1.Location = new System.Drawing.Point(109, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(36, 99);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(391, 187);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroTabPage1.Controls.Add(this.text_contraseña);
            this.metroTabPage1.Controls.Add(this.text_usuario);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.btnAceptar);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(383, 145);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Login";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // text_contraseña
            // 
            // 
            // 
            // 
            this.text_contraseña.CustomButton.Image = null;
            this.text_contraseña.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.text_contraseña.CustomButton.Name = "";
            this.text_contraseña.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_contraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.text_contraseña.CustomButton.TabIndex = 1;
            this.text_contraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_contraseña.CustomButton.UseSelectable = true;
            this.text_contraseña.CustomButton.Visible = false;
            this.text_contraseña.DisplayIcon = true;
            this.text_contraseña.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.text_contraseña.Icon = ((System.Drawing.Image)(resources.GetObject("text_contraseña.Icon")));
            this.text_contraseña.IconRight = true;
            this.text_contraseña.Lines = new string[0];
            this.text_contraseña.Location = new System.Drawing.Point(105, 64);
            this.text_contraseña.MaxLength = 32767;
            this.text_contraseña.Name = "text_contraseña";
            this.text_contraseña.PasswordChar = '●';
            this.text_contraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_contraseña.SelectedText = "";
            this.text_contraseña.SelectionLength = 0;
            this.text_contraseña.SelectionStart = 0;
            this.text_contraseña.ShowClearButton = true;
            this.text_contraseña.Size = new System.Drawing.Size(203, 23);
            this.text_contraseña.TabIndex = 6;
            this.text_contraseña.UseSelectable = true;
            this.text_contraseña.UseSystemPasswordChar = true;
            this.text_contraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_contraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // text_usuario
            // 
            // 
            // 
            // 
            this.text_usuario.CustomButton.Image = null;
            this.text_usuario.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.text_usuario.CustomButton.Name = "";
            this.text_usuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_usuario.CustomButton.TabIndex = 1;
            this.text_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_usuario.CustomButton.UseSelectable = true;
            this.text_usuario.CustomButton.Visible = false;
            this.text_usuario.DisplayIcon = true;
            this.text_usuario.Icon = global::Proyecto.Properties.Resources.add_user;
            this.text_usuario.IconRight = true;
            this.text_usuario.Lines = new string[0];
            this.text_usuario.Location = new System.Drawing.Point(105, 35);
            this.text_usuario.MaxLength = 32767;
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.PasswordChar = '\0';
            this.text_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_usuario.SelectedText = "";
            this.text_usuario.SelectionLength = 0;
            this.text_usuario.SelectionStart = 0;
            this.text_usuario.Size = new System.Drawing.Size(203, 23);
            this.text_usuario.TabIndex = 5;
            this.text_usuario.UseSelectable = true;
            this.text_usuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_usuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Contraseña:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(105, 102);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Apcetar";
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Usuario:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Proyecto.Properties.Resources.sabor;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 355);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Proyecto.Properties.Resources.chickens_kingdom;
            this.BackImagePadding = new System.Windows.Forms.Padding(210, 10, 0, 0);
            this.ClientSize = new System.Drawing.Size(473, 406);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox text_contraseña;
        private MetroFramework.Controls.MetroTextBox text_usuario;

    }
}

