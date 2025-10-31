namespace CajeroApp
{
    partial class VentanaAdministrador
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
            this.dgv_PRODUCTOS = new System.Windows.Forms.DataGridView();
            this.textBox_CANTIDAD = new System.Windows.Forms.TextBox();
            this.comboBox_PRODUCTOS = new System.Windows.Forms.ComboBox();
            this.textBox_PRECIO = new System.Windows.Forms.TextBox();
            this.button_CALCULAR = new System.Windows.Forms.Button();
            this.button_AGREGAR = new System.Windows.Forms.Button();
            this.textBox_TOTAL = new System.Windows.Forms.TextBox();
            this.label_TOTAL = new System.Windows.Forms.Label();
            this.button_ELIMINAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PRODUCTOS)).BeginInit();
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
            this.BANNER.Size = new System.Drawing.Size(985, 10);
            this.BANNER.TabIndex = 7;
            // 
            // label_USUARIO
            // 
            this.label_USUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label_USUARIO.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_USUARIO.Location = new System.Drawing.Point(-2, 0);
            this.label_USUARIO.Name = "label_USUARIO";
            this.label_USUARIO.Size = new System.Drawing.Size(985, 47);
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
            this.button_nuevaVenta.Click += new System.EventHandler(this.button_nuevaVenta_Click);
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
            // dgv_PRODUCTOS
            // 
            this.dgv_PRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PRODUCTOS.Location = new System.Drawing.Point(198, 57);
            this.dgv_PRODUCTOS.Name = "dgv_PRODUCTOS";
            this.dgv_PRODUCTOS.RowHeadersWidth = 51;
            this.dgv_PRODUCTOS.RowTemplate.Height = 24;
            this.dgv_PRODUCTOS.Size = new System.Drawing.Size(608, 347);
            this.dgv_PRODUCTOS.TabIndex = 12;
            // 
            // textBox_CANTIDAD
            // 
            this.textBox_CANTIDAD.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_CANTIDAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CANTIDAD.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CANTIDAD.ForeColor = System.Drawing.Color.Silver;
            this.textBox_CANTIDAD.Location = new System.Drawing.Point(812, 158);
            this.textBox_CANTIDAD.Multiline = true;
            this.textBox_CANTIDAD.Name = "textBox_CANTIDAD";
            this.textBox_CANTIDAD.Size = new System.Drawing.Size(168, 22);
            this.textBox_CANTIDAD.TabIndex = 14;
            this.textBox_CANTIDAD.Text = "CANTIDAD";
            this.textBox_CANTIDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_CANTIDAD.WordWrap = false;
            // 
            // comboBox_PRODUCTOS
            // 
            this.comboBox_PRODUCTOS.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox_PRODUCTOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PRODUCTOS.Font = new System.Drawing.Font("Candara", 10.2F);
            this.comboBox_PRODUCTOS.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_PRODUCTOS.FormattingEnabled = true;
            this.comboBox_PRODUCTOS.Items.AddRange(new object[] {
            "TIRA DE PAN",
            "MEDIALUNA",
            "FACTURA",
            "PAN LACTAL"});
            this.comboBox_PRODUCTOS.Location = new System.Drawing.Point(816, 74);
            this.comboBox_PRODUCTOS.Name = "comboBox_PRODUCTOS";
            this.comboBox_PRODUCTOS.Size = new System.Drawing.Size(154, 29);
            this.comboBox_PRODUCTOS.TabIndex = 18;
            // 
            // textBox_PRECIO
            // 
            this.textBox_PRECIO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_PRECIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PRECIO.Enabled = false;
            this.textBox_PRECIO.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PRECIO.ForeColor = System.Drawing.Color.Silver;
            this.textBox_PRECIO.Location = new System.Drawing.Point(816, 118);
            this.textBox_PRECIO.Multiline = true;
            this.textBox_PRECIO.Name = "textBox_PRECIO";
            this.textBox_PRECIO.Size = new System.Drawing.Size(154, 22);
            this.textBox_PRECIO.TabIndex = 19;
            this.textBox_PRECIO.Text = "PRECIO";
            this.textBox_PRECIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_PRECIO.WordWrap = false;
            // 
            // button_CALCULAR
            // 
            this.button_CALCULAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button_CALCULAR.FlatAppearance.BorderSize = 0;
            this.button_CALCULAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CALCULAR.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CALCULAR.ForeColor = System.Drawing.Color.White;
            this.button_CALCULAR.Location = new System.Drawing.Point(815, 358);
            this.button_CALCULAR.Name = "button_CALCULAR";
            this.button_CALCULAR.Size = new System.Drawing.Size(155, 33);
            this.button_CALCULAR.TabIndex = 20;
            this.button_CALCULAR.Text = "CALCULAR";
            this.button_CALCULAR.UseVisualStyleBackColor = false;
            // 
            // button_AGREGAR
            // 
            this.button_AGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.button_AGREGAR.FlatAppearance.BorderSize = 0;
            this.button_AGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AGREGAR.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AGREGAR.ForeColor = System.Drawing.Color.White;
            this.button_AGREGAR.Location = new System.Drawing.Point(816, 203);
            this.button_AGREGAR.Name = "button_AGREGAR";
            this.button_AGREGAR.Size = new System.Drawing.Size(155, 30);
            this.button_AGREGAR.TabIndex = 21;
            this.button_AGREGAR.Text = "AGREGAR";
            this.button_AGREGAR.UseVisualStyleBackColor = false;
            // 
            // textBox_TOTAL
            // 
            this.textBox_TOTAL.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_TOTAL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TOTAL.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TOTAL.ForeColor = System.Drawing.Color.Silver;
            this.textBox_TOTAL.Location = new System.Drawing.Point(816, 317);
            this.textBox_TOTAL.Multiline = true;
            this.textBox_TOTAL.Name = "textBox_TOTAL";
            this.textBox_TOTAL.Size = new System.Drawing.Size(155, 22);
            this.textBox_TOTAL.TabIndex = 22;
            this.textBox_TOTAL.Text = "TOTAL";
            this.textBox_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_TOTAL.WordWrap = false;
            // 
            // label_TOTAL
            // 
            this.label_TOTAL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_TOTAL.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TOTAL.ForeColor = System.Drawing.Color.Black;
            this.label_TOTAL.Location = new System.Drawing.Point(813, 298);
            this.label_TOTAL.Name = "label_TOTAL";
            this.label_TOTAL.Size = new System.Drawing.Size(168, 16);
            this.label_TOTAL.TabIndex = 23;
            this.label_TOTAL.Text = "TOTAL :";
            this.label_TOTAL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_ELIMINAR
            // 
            this.button_ELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.button_ELIMINAR.FlatAppearance.BorderSize = 0;
            this.button_ELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ELIMINAR.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ELIMINAR.ForeColor = System.Drawing.Color.White;
            this.button_ELIMINAR.Location = new System.Drawing.Point(815, 248);
            this.button_ELIMINAR.Name = "button_ELIMINAR";
            this.button_ELIMINAR.Size = new System.Drawing.Size(155, 30);
            this.button_ELIMINAR.TabIndex = 24;
            this.button_ELIMINAR.Text = "ELIMINAR";
            this.button_ELIMINAR.UseVisualStyleBackColor = false;
            // 
            // VentanaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(982, 403);
            this.Controls.Add(this.button_ELIMINAR);
            this.Controls.Add(this.label_TOTAL);
            this.Controls.Add(this.textBox_TOTAL);
            this.Controls.Add(this.button_AGREGAR);
            this.Controls.Add(this.button_CALCULAR);
            this.Controls.Add(this.textBox_PRECIO);
            this.Controls.Add(this.comboBox_PRODUCTOS);
            this.Controls.Add(this.textBox_CANTIDAD);
            this.Controls.Add(this.dgv_PRODUCTOS);
            this.Controls.Add(this.button_PRODUCTOS);
            this.Controls.Add(this.button_nuevaVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BANNER);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LABEL_CAJEROAPP);
            this.Controls.Add(this.label_USUARIO);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PRODUCTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL_CAJEROAPP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BANNER;
        private System.Windows.Forms.Label label_USUARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_nuevaVenta;
        private System.Windows.Forms.Button button_PRODUCTOS;
        private System.Windows.Forms.DataGridView dgv_PRODUCTOS;
        private System.Windows.Forms.TextBox textBox_CANTIDAD;
        private System.Windows.Forms.ComboBox comboBox_PRODUCTOS;
        private System.Windows.Forms.TextBox textBox_PRECIO;
        private System.Windows.Forms.Button button_CALCULAR;
        private System.Windows.Forms.Button button_AGREGAR;
        private System.Windows.Forms.TextBox textBox_TOTAL;
        private System.Windows.Forms.Label label_TOTAL;
        private System.Windows.Forms.Button button_ELIMINAR;
    }
}