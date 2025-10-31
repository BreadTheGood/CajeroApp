namespace CajeroApp
{
    partial class VentanaLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.LABEL_CAJEROAPP = new System.Windows.Forms.Label();
            this.BUTTON_lOGIN = new System.Windows.Forms.Button();
            this.BANNER = new System.Windows.Forms.Label();
            this.textBox_USUARIO = new System.Windows.Forms.TextBox();
            this.textBox_CONTRASENA = new System.Windows.Forms.TextBox();
            this.button_REGISTRARSE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_REGISTRO = new System.Windows.Forms.Label();
            this.textBox_NOMBREREGISTRO = new System.Windows.Forms.TextBox();
            this.textBox_EMAILREGISTRO = new System.Windows.Forms.TextBox();
            this.textBox_USUARIOREGISTRO = new System.Windows.Forms.TextBox();
            this.textBox_CONTRASENAREGISTRO = new System.Windows.Forms.TextBox();
            this.pictureBox_REGISTRO = new System.Windows.Forms.PictureBox();
            this.button_REGISTRO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_REGISTRO)).BeginInit();
            this.SuspendLayout();
            // 
            // LABEL_CAJEROAPP
            // 
            this.LABEL_CAJEROAPP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LABEL_CAJEROAPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABEL_CAJEROAPP.Font = new System.Drawing.Font("Candara", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CAJEROAPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LABEL_CAJEROAPP.Location = new System.Drawing.Point(225, 9);
            this.LABEL_CAJEROAPP.Name = "LABEL_CAJEROAPP";
            this.LABEL_CAJEROAPP.Size = new System.Drawing.Size(350, 391);
            this.LABEL_CAJEROAPP.TabIndex = 0;
            this.LABEL_CAJEROAPP.Text = "CAJERO APP";
            this.LABEL_CAJEROAPP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BUTTON_lOGIN
            // 
            this.BUTTON_lOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BUTTON_lOGIN.FlatAppearance.BorderSize = 0;
            this.BUTTON_lOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_lOGIN.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_lOGIN.ForeColor = System.Drawing.Color.White;
            this.BUTTON_lOGIN.Location = new System.Drawing.Point(225, 276);
            this.BUTTON_lOGIN.Name = "BUTTON_lOGIN";
            this.BUTTON_lOGIN.Size = new System.Drawing.Size(350, 50);
            this.BUTTON_lOGIN.TabIndex = 1;
            this.BUTTON_lOGIN.Text = "INICIAR SESION";
            this.BUTTON_lOGIN.UseVisualStyleBackColor = false;
            this.BUTTON_lOGIN.Click += new System.EventHandler(this.BUTTON_lOGIN_Click);
            // 
            // BANNER
            // 
            this.BANNER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BANNER.Location = new System.Drawing.Point(0, 385);
            this.BANNER.Name = "BANNER";
            this.BANNER.Size = new System.Drawing.Size(785, 15);
            this.BANNER.TabIndex = 2;
            // 
            // textBox_USUARIO
            // 
            this.textBox_USUARIO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_USUARIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_USUARIO.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_USUARIO.ForeColor = System.Drawing.Color.Silver;
            this.textBox_USUARIO.Location = new System.Drawing.Point(225, 178);
            this.textBox_USUARIO.Multiline = true;
            this.textBox_USUARIO.Name = "textBox_USUARIO";
            this.textBox_USUARIO.Size = new System.Drawing.Size(350, 22);
            this.textBox_USUARIO.TabIndex = 3;
            this.textBox_USUARIO.Text = "USUARIO";
            this.textBox_USUARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_USUARIO.WordWrap = false;
            this.textBox_USUARIO.Enter += new System.EventHandler(this.textBox_USUARIO_Enter);
            this.textBox_USUARIO.Leave += new System.EventHandler(this.textBox_USUARIO_Leave);
            // 
            // textBox_CONTRASENA
            // 
            this.textBox_CONTRASENA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_CONTRASENA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CONTRASENA.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CONTRASENA.ForeColor = System.Drawing.Color.Silver;
            this.textBox_CONTRASENA.Location = new System.Drawing.Point(225, 220);
            this.textBox_CONTRASENA.Name = "textBox_CONTRASENA";
            this.textBox_CONTRASENA.Size = new System.Drawing.Size(350, 21);
            this.textBox_CONTRASENA.TabIndex = 4;
            this.textBox_CONTRASENA.Text = "CONTRASEÑA";
            this.textBox_CONTRASENA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_CONTRASENA.WordWrap = false;
            this.textBox_CONTRASENA.Enter += new System.EventHandler(this.textBox_CONTRASENA_Enter);
            this.textBox_CONTRASENA.Leave += new System.EventHandler(this.textBox_CONTRASENA_Leave);
            // 
            // button_REGISTRARSE
            // 
            this.button_REGISTRARSE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_REGISTRARSE.FlatAppearance.BorderSize = 0;
            this.button_REGISTRARSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_REGISTRARSE.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_REGISTRARSE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button_REGISTRARSE.Location = new System.Drawing.Point(225, 342);
            this.button_REGISTRARSE.Name = "button_REGISTRARSE";
            this.button_REGISTRARSE.Size = new System.Drawing.Size(350, 24);
            this.button_REGISTRARSE.TabIndex = 6;
            this.button_REGISTRARSE.Text = "REGISTRARSE";
            this.button_REGISTRARSE.UseVisualStyleBackColor = false;
            this.button_REGISTRARSE.Click += new System.EventHandler(this.button_REGISTRARSE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CajeroApp.Properties.Resources.dollars;
            this.pictureBox1.Location = new System.Drawing.Point(340, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label_REGISTRO
            // 
            this.label_REGISTRO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label_REGISTRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_REGISTRO.Font = new System.Drawing.Font("Candara", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_REGISTRO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_REGISTRO.Location = new System.Drawing.Point(598, 0);
            this.label_REGISTRO.Name = "label_REGISTRO";
            this.label_REGISTRO.Size = new System.Drawing.Size(350, 400);
            this.label_REGISTRO.TabIndex = 7;
            this.label_REGISTRO.Text = "REGISTRO";
            this.label_REGISTRO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_NOMBREREGISTRO
            // 
            this.textBox_NOMBREREGISTRO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_NOMBREREGISTRO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NOMBREREGISTRO.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NOMBREREGISTRO.ForeColor = System.Drawing.Color.Silver;
            this.textBox_NOMBREREGISTRO.Location = new System.Drawing.Point(608, 150);
            this.textBox_NOMBREREGISTRO.Multiline = true;
            this.textBox_NOMBREREGISTRO.Name = "textBox_NOMBREREGISTRO";
            this.textBox_NOMBREREGISTRO.Size = new System.Drawing.Size(330, 22);
            this.textBox_NOMBREREGISTRO.TabIndex = 8;
            this.textBox_NOMBREREGISTRO.Text = "NOMBRE";
            this.textBox_NOMBREREGISTRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_NOMBREREGISTRO.WordWrap = false;
            this.textBox_NOMBREREGISTRO.Enter += new System.EventHandler(this.textBox_NOMBREREGISTRO_Enter);
            this.textBox_NOMBREREGISTRO.Leave += new System.EventHandler(this.textBox_NOMBREREGISTRO_Leave);
            // 
            // textBox_EMAILREGISTRO
            // 
            this.textBox_EMAILREGISTRO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_EMAILREGISTRO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EMAILREGISTRO.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EMAILREGISTRO.ForeColor = System.Drawing.Color.Silver;
            this.textBox_EMAILREGISTRO.Location = new System.Drawing.Point(608, 190);
            this.textBox_EMAILREGISTRO.Multiline = true;
            this.textBox_EMAILREGISTRO.Name = "textBox_EMAILREGISTRO";
            this.textBox_EMAILREGISTRO.Size = new System.Drawing.Size(330, 22);
            this.textBox_EMAILREGISTRO.TabIndex = 9;
            this.textBox_EMAILREGISTRO.Text = "EMAIL";
            this.textBox_EMAILREGISTRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_EMAILREGISTRO.WordWrap = false;
            this.textBox_EMAILREGISTRO.Enter += new System.EventHandler(this.textBox_EMAILREGISTRO_Enter);
            this.textBox_EMAILREGISTRO.Leave += new System.EventHandler(this.textBox_EMAILREGISTRO_Leave);
            // 
            // textBox_USUARIOREGISTRO
            // 
            this.textBox_USUARIOREGISTRO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_USUARIOREGISTRO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_USUARIOREGISTRO.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_USUARIOREGISTRO.ForeColor = System.Drawing.Color.Silver;
            this.textBox_USUARIOREGISTRO.Location = new System.Drawing.Point(609, 239);
            this.textBox_USUARIOREGISTRO.Multiline = true;
            this.textBox_USUARIOREGISTRO.Name = "textBox_USUARIOREGISTRO";
            this.textBox_USUARIOREGISTRO.Size = new System.Drawing.Size(330, 22);
            this.textBox_USUARIOREGISTRO.TabIndex = 10;
            this.textBox_USUARIOREGISTRO.Text = "USUARIO";
            this.textBox_USUARIOREGISTRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_USUARIOREGISTRO.WordWrap = false;
            this.textBox_USUARIOREGISTRO.Enter += new System.EventHandler(this.textBox_USUARIOREGISTRO_Enter);
            this.textBox_USUARIOREGISTRO.Leave += new System.EventHandler(this.textBox_USUARIOREGISTRO_Leave);
            // 
            // textBox_CONTRASENAREGISTRO
            // 
            this.textBox_CONTRASENAREGISTRO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_CONTRASENAREGISTRO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CONTRASENAREGISTRO.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CONTRASENAREGISTRO.ForeColor = System.Drawing.Color.Silver;
            this.textBox_CONTRASENAREGISTRO.Location = new System.Drawing.Point(609, 286);
            this.textBox_CONTRASENAREGISTRO.Multiline = true;
            this.textBox_CONTRASENAREGISTRO.Name = "textBox_CONTRASENAREGISTRO";
            this.textBox_CONTRASENAREGISTRO.Size = new System.Drawing.Size(330, 22);
            this.textBox_CONTRASENAREGISTRO.TabIndex = 11;
            this.textBox_CONTRASENAREGISTRO.Text = "CONTRASEÑA";
            this.textBox_CONTRASENAREGISTRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_CONTRASENAREGISTRO.WordWrap = false;
            this.textBox_CONTRASENAREGISTRO.Enter += new System.EventHandler(this.textBox_CONTRASENAREGISTRO_Enter);
            this.textBox_CONTRASENAREGISTRO.Leave += new System.EventHandler(this.textBox_CONTRASENAREGISTRO_Leave);
            // 
            // pictureBox_REGISTRO
            // 
            this.pictureBox_REGISTRO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox_REGISTRO.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_REGISTRO.Image")));
            this.pictureBox_REGISTRO.Location = new System.Drawing.Point(728, 55);
            this.pictureBox_REGISTRO.Name = "pictureBox_REGISTRO";
            this.pictureBox_REGISTRO.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_REGISTRO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_REGISTRO.TabIndex = 12;
            this.pictureBox_REGISTRO.TabStop = false;
            // 
            // button_REGISTRO
            // 
            this.button_REGISTRO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_REGISTRO.FlatAppearance.BorderSize = 0;
            this.button_REGISTRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_REGISTRO.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_REGISTRO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button_REGISTRO.Location = new System.Drawing.Point(609, 342);
            this.button_REGISTRO.Name = "button_REGISTRO";
            this.button_REGISTRO.Size = new System.Drawing.Size(330, 24);
            this.button_REGISTRO.TabIndex = 13;
            this.button_REGISTRO.Text = "REGISTRARSE";
            this.button_REGISTRO.UseVisualStyleBackColor = false;
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.button_REGISTRO);
            this.Controls.Add(this.pictureBox_REGISTRO);
            this.Controls.Add(this.textBox_CONTRASENAREGISTRO);
            this.Controls.Add(this.textBox_USUARIOREGISTRO);
            this.Controls.Add(this.textBox_EMAILREGISTRO);
            this.Controls.Add(this.textBox_NOMBREREGISTRO);
            this.Controls.Add(this.label_REGISTRO);
            this.Controls.Add(this.button_REGISTRARSE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_CONTRASENA);
            this.Controls.Add(this.textBox_USUARIO);
            this.Controls.Add(this.BANNER);
            this.Controls.Add(this.BUTTON_lOGIN);
            this.Controls.Add(this.LABEL_CAJEROAPP);
            this.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VentanaLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_REGISTRO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL_CAJEROAPP;
        private System.Windows.Forms.Button BUTTON_lOGIN;
        private System.Windows.Forms.Label BANNER;
        private System.Windows.Forms.TextBox textBox_USUARIO;
        private System.Windows.Forms.TextBox textBox_CONTRASENA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_REGISTRARSE;
        private System.Windows.Forms.Label label_REGISTRO;
        private System.Windows.Forms.TextBox textBox_NOMBREREGISTRO;
        private System.Windows.Forms.TextBox textBox_EMAILREGISTRO;
        private System.Windows.Forms.TextBox textBox_USUARIOREGISTRO;
        private System.Windows.Forms.TextBox textBox_CONTRASENAREGISTRO;
        private System.Windows.Forms.PictureBox pictureBox_REGISTRO;
        private System.Windows.Forms.Button button_REGISTRO;
    }
}

