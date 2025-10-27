namespace CajeroApp
{
    partial class VentanaPrincipal
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
            this.LABEL_CAJEROAPP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BANNER = new System.Windows.Forms.Label();
            this.label_USUARIO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_nuevaVenta = new System.Windows.Forms.Button();
            this.button_PRODUCTOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LABEL_CAJEROAPP
            // 
            this.LABEL_CAJEROAPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.LABEL_CAJEROAPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABEL_CAJEROAPP.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CAJEROAPP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LABEL_CAJEROAPP.Location = new System.Drawing.Point(12, 0);
            this.LABEL_CAJEROAPP.Name = "LABEL_CAJEROAPP";
            this.LABEL_CAJEROAPP.Size = new System.Drawing.Size(153, 47);
            this.LABEL_CAJEROAPP.TabIndex = 1;
            this.LABEL_CAJEROAPP.Text = "CAJERO APP";
            this.LABEL_CAJEROAPP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::CajeroApp.Properties.Resources.dollars;
            this.pictureBox1.Location = new System.Drawing.Point(159, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BANNER
            // 
            this.BANNER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BANNER.Location = new System.Drawing.Point(-2, 47);
            this.BANNER.Name = "BANNER";
            this.BANNER.Size = new System.Drawing.Size(785, 10);
            this.BANNER.TabIndex = 7;
            // 
            // label_USUARIO
            // 
            this.label_USUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label_USUARIO.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_USUARIO.Location = new System.Drawing.Point(-2, 0);
            this.label_USUARIO.Name = "label_USUARIO";
            this.label_USUARIO.Size = new System.Drawing.Size(785, 47);
            this.label_USUARIO.TabIndex = 8;
            this.label_USUARIO.Text = "BIENVENIDO";
            this.label_USUARIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 347);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_nuevaVenta
            // 
            this.button_nuevaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button_nuevaVenta.FlatAppearance.BorderSize = 0;
            this.button_nuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nuevaVenta.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevaVenta.ForeColor = System.Drawing.Color.White;
            this.button_nuevaVenta.Location = new System.Drawing.Point(10, 109);
            this.button_nuevaVenta.Name = "button_nuevaVenta";
            this.button_nuevaVenta.Size = new System.Drawing.Size(180, 55);
            this.button_nuevaVenta.TabIndex = 10;
            this.button_nuevaVenta.Text = "NUEVA VENTA";
            this.button_nuevaVenta.UseVisualStyleBackColor = false;
            // 
            // button_PRODUCTOS
            // 
            this.button_PRODUCTOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button_PRODUCTOS.FlatAppearance.BorderSize = 0;
            this.button_PRODUCTOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRODUCTOS.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PRODUCTOS.ForeColor = System.Drawing.Color.White;
            this.button_PRODUCTOS.Location = new System.Drawing.Point(12, 203);
            this.button_PRODUCTOS.Name = "button_PRODUCTOS";
            this.button_PRODUCTOS.Size = new System.Drawing.Size(180, 55);
            this.button_PRODUCTOS.TabIndex = 11;
            this.button_PRODUCTOS.Text = "PRODUCTOS";
            this.button_PRODUCTOS.UseVisualStyleBackColor = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.button_PRODUCTOS);
            this.Controls.Add(this.button_nuevaVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BANNER);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LABEL_CAJEROAPP);
            this.Controls.Add(this.label_USUARIO);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LABEL_CAJEROAPP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BANNER;
        private System.Windows.Forms.Label label_USUARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_nuevaVenta;
        private System.Windows.Forms.Button button_PRODUCTOS;
    }
}