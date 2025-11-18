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
            this.comboBox_Login = new System.Windows.Forms.ComboBox();
            this.button_EXIT_LOGIN = new System.Windows.Forms.Button();
            this.pictureBox_Login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // LABEL_CAJEROAPP
            // 
            this.LABEL_CAJEROAPP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LABEL_CAJEROAPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABEL_CAJEROAPP.Font = new System.Drawing.Font("Candara", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CAJEROAPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LABEL_CAJEROAPP.Location = new System.Drawing.Point(25, 9);
            this.LABEL_CAJEROAPP.Name = "LABEL_CAJEROAPP";
            this.LABEL_CAJEROAPP.Size = new System.Drawing.Size(350, 67);
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
            this.BUTTON_lOGIN.Location = new System.Drawing.Point(25, 261);
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
            this.BANNER.Size = new System.Drawing.Size(400, 15);
            this.BANNER.TabIndex = 2;
            // 
            // comboBox_Login
            // 
            this.comboBox_Login.DropDownHeight = 120;
            this.comboBox_Login.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Login.DropDownWidth = 200;
            this.comboBox_Login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Login.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Login.FormattingEnabled = true;
            this.comboBox_Login.IntegralHeight = false;
            this.comboBox_Login.Location = new System.Drawing.Point(100, 200);
            this.comboBox_Login.Name = "comboBox_Login";
            this.comboBox_Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Login.Size = new System.Drawing.Size(209, 32);
            this.comboBox_Login.TabIndex = 6;
            // 
            // button_EXIT_LOGIN
            // 
            this.button_EXIT_LOGIN.BackColor = System.Drawing.Color.Red;
            this.button_EXIT_LOGIN.FlatAppearance.BorderSize = 0;
            this.button_EXIT_LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EXIT_LOGIN.Location = new System.Drawing.Point(375, 0);
            this.button_EXIT_LOGIN.Name = "button_EXIT_LOGIN";
            this.button_EXIT_LOGIN.Size = new System.Drawing.Size(25, 25);
            this.button_EXIT_LOGIN.TabIndex = 7;
            this.button_EXIT_LOGIN.Text = "X";
            this.button_EXIT_LOGIN.UseVisualStyleBackColor = false;
            this.button_EXIT_LOGIN.Click += new System.EventHandler(this.button_EXIT_LOGIN_Click);
            // 
            // pictureBox_Login
            // 
            this.pictureBox_Login.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Login.Image = global::CajeroApp.Properties.Resources.dollars;
            this.pictureBox_Login.Location = new System.Drawing.Point(140, 60);
            this.pictureBox_Login.Name = "pictureBox_Login";
            this.pictureBox_Login.Size = new System.Drawing.Size(120, 120);
            this.pictureBox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Login.TabIndex = 5;
            this.pictureBox_Login.TabStop = false;
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(398, 398);
            this.ControlBox = false;
            this.Controls.Add(this.button_EXIT_LOGIN);
            this.Controls.Add(this.comboBox_Login);
            this.Controls.Add(this.pictureBox_Login);
            this.Controls.Add(this.BANNER);
            this.Controls.Add(this.BUTTON_lOGIN);
            this.Controls.Add(this.LABEL_CAJEROAPP);
            this.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LABEL_CAJEROAPP;
        private System.Windows.Forms.Button BUTTON_lOGIN;
        private System.Windows.Forms.Label BANNER;
        private System.Windows.Forms.PictureBox pictureBox_Login;
        private System.Windows.Forms.ComboBox comboBox_Login;
        private System.Windows.Forms.Button button_EXIT_LOGIN;
    }
}

