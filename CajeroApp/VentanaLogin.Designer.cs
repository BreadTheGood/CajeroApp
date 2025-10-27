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
            this.LABEL_CAJEROAPP = new System.Windows.Forms.Label();
            this.BUTTON_lOGIN = new System.Windows.Forms.Button();
            this.BANNER = new System.Windows.Forms.Label();
            this.textBox_USUARIO = new System.Windows.Forms.TextBox();
            this.textBox_CONTRASENA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_CONTRASENA);
            this.Controls.Add(this.textBox_USUARIO);
            this.Controls.Add(this.BANNER);
            this.Controls.Add(this.BUTTON_lOGIN);
            this.Controls.Add(this.LABEL_CAJEROAPP);
            this.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

