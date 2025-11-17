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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_USUARIO = new System.Windows.Forms.Label();
            this.BANNER = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_VENTA = new System.Windows.Forms.Button();
            this.button_PROVEEDORES = new System.Windows.Forms.Button();
            this.dgv_ELEMENTOS = new System.Windows.Forms.DataGridView();
            this.textBox_DATO2 = new System.Windows.Forms.TextBox();
            this.comboBox_PRODUCTOS = new System.Windows.Forms.ComboBox();
            this.textBox_DATO1 = new System.Windows.Forms.TextBox();
            this.button_AGREGAR = new System.Windows.Forms.Button();
            this.textBox_TOTAL = new System.Windows.Forms.TextBox();
            this.label_TOTAL = new System.Windows.Forms.Label();
            this.button_ELIMINAR = new System.Windows.Forms.Button();
            this.button_USUARIO = new System.Windows.Forms.Button();
            this.button_EMPLEADO = new System.Windows.Forms.Button();
            this.button_PRODUCTOS = new System.Windows.Forms.Button();
            this.button_BUSCAR = new System.Windows.Forms.Button();
            this.button_SALIR_VOLVER = new System.Windows.Forms.Button();
            this.textBox_BUSCAR = new System.Windows.Forms.TextBox();
            this.textBox_NOMBRE = new System.Windows.Forms.TextBox();
            this.button_MODIFICAR = new System.Windows.Forms.Button();
            this.ventanaPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ELEMENTOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaPrincipalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_USUARIO
            // 
            this.label_USUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label_USUARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_USUARIO.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_USUARIO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_USUARIO.Location = new System.Drawing.Point(0, 0);
            this.label_USUARIO.Name = "label_USUARIO";
            this.label_USUARIO.Size = new System.Drawing.Size(980, 50);
            this.label_USUARIO.TabIndex = 1;
            this.label_USUARIO.Text = "  USER ";
            this.label_USUARIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BANNER
            // 
            this.BANNER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BANNER.Location = new System.Drawing.Point(-2, 47);
            this.BANNER.Name = "BANNER";
            this.BANNER.Size = new System.Drawing.Size(985, 10);
            this.BANNER.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 442);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_VENTA
            // 
            this.button_VENTA.BackColor = System.Drawing.Color.Gray;
            this.button_VENTA.FlatAppearance.BorderSize = 0;
            this.button_VENTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VENTA.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VENTA.ForeColor = System.Drawing.Color.White;
            this.button_VENTA.Location = new System.Drawing.Point(12, 419);
            this.button_VENTA.Name = "button_VENTA";
            this.button_VENTA.Size = new System.Drawing.Size(180, 55);
            this.button_VENTA.TabIndex = 10;
            this.button_VENTA.Text = "VENTA";
            this.button_VENTA.UseVisualStyleBackColor = false;
            this.button_VENTA.Click += new System.EventHandler(this.button_VENTA_Click);
            // 
            // button_PROVEEDORES
            // 
            this.button_PROVEEDORES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button_PROVEEDORES.FlatAppearance.BorderSize = 0;
            this.button_PROVEEDORES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PROVEEDORES.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PROVEEDORES.ForeColor = System.Drawing.Color.White;
            this.button_PROVEEDORES.Location = new System.Drawing.Point(10, 158);
            this.button_PROVEEDORES.Name = "button_PROVEEDORES";
            this.button_PROVEEDORES.Size = new System.Drawing.Size(180, 55);
            this.button_PROVEEDORES.TabIndex = 11;
            this.button_PROVEEDORES.Text = "PROVEEDORES";
            this.button_PROVEEDORES.UseVisualStyleBackColor = false;
            this.button_PROVEEDORES.Click += new System.EventHandler(this.button_PROVEEDORES_Click);
            // 
            // dgv_ELEMENTOS
            // 
            this.dgv_ELEMENTOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ELEMENTOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ELEMENTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ELEMENTOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ELEMENTOS.Location = new System.Drawing.Point(198, 118);
            this.dgv_ELEMENTOS.Name = "dgv_ELEMENTOS";
            this.dgv_ELEMENTOS.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ELEMENTOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ELEMENTOS.RowHeadersWidth = 51;
            this.dgv_ELEMENTOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ELEMENTOS.RowTemplate.Height = 24;
            this.dgv_ELEMENTOS.Size = new System.Drawing.Size(608, 381);
            this.dgv_ELEMENTOS.TabIndex = 12;
            this.dgv_ELEMENTOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ELEMENTOS_CellClick);
            // 
            // textBox_DATO2
            // 
            this.textBox_DATO2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_DATO2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_DATO2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DATO2.ForeColor = System.Drawing.Color.Silver;
            this.textBox_DATO2.Location = new System.Drawing.Point(812, 158);
            this.textBox_DATO2.Multiline = true;
            this.textBox_DATO2.Name = "textBox_DATO2";
            this.textBox_DATO2.Size = new System.Drawing.Size(168, 22);
            this.textBox_DATO2.TabIndex = 14;
            this.textBox_DATO2.Text = "CANTIDAD";
            this.textBox_DATO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_DATO2.WordWrap = false;
            this.textBox_DATO2.Click += new System.EventHandler(this.textBox_DATO2_Enter);
            this.textBox_DATO2.Enter += new System.EventHandler(this.textBox_DATO2_Enter);
            this.textBox_DATO2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_DATO2_KeyPress);
            this.textBox_DATO2.Leave += new System.EventHandler(this.textBox_DATO2_Leave);
            // 
            // comboBox_PRODUCTOS
            // 
            this.comboBox_PRODUCTOS.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox_PRODUCTOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PRODUCTOS.Font = new System.Drawing.Font("Candara", 10.2F);
            this.comboBox_PRODUCTOS.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_PRODUCTOS.FormattingEnabled = true;
            this.comboBox_PRODUCTOS.Location = new System.Drawing.Point(816, 74);
            this.comboBox_PRODUCTOS.Name = "comboBox_PRODUCTOS";
            this.comboBox_PRODUCTOS.Size = new System.Drawing.Size(154, 29);
            this.comboBox_PRODUCTOS.TabIndex = 18;
            this.comboBox_PRODUCTOS.SelectedIndexChanged += new System.EventHandler(this.comboBox_PRODUCTOS_SelectedIndexChanged);
            // 
            // textBox_DATO1
            // 
            this.textBox_DATO1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_DATO1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_DATO1.Enabled = false;
            this.textBox_DATO1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DATO1.ForeColor = System.Drawing.Color.Silver;
            this.textBox_DATO1.Location = new System.Drawing.Point(816, 118);
            this.textBox_DATO1.Multiline = true;
            this.textBox_DATO1.Name = "textBox_DATO1";
            this.textBox_DATO1.Size = new System.Drawing.Size(154, 22);
            this.textBox_DATO1.TabIndex = 19;
            this.textBox_DATO1.Text = "PRECIO";
            this.textBox_DATO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_DATO1.WordWrap = false;
            this.textBox_DATO1.Click += new System.EventHandler(this.textBox_DATO1_Enter);
            this.textBox_DATO1.Enter += new System.EventHandler(this.textBox_DATO1_Enter);
            this.textBox_DATO1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_DATO1_KeyPress);
            this.textBox_DATO1.Leave += new System.EventHandler(this.textBox_DATO1_Leave);
            // 
            // button_AGREGAR
            // 
            this.button_AGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
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
            this.button_AGREGAR.Click += new System.EventHandler(this.button_AGREGAR_Click);
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
            this.button_ELIMINAR.Click += new System.EventHandler(this.button_ELIMINAR_Click);
            // 
            // button_USUARIO
            // 
            this.button_USUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button_USUARIO.FlatAppearance.BorderSize = 0;
            this.button_USUARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_USUARIO.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_USUARIO.ForeColor = System.Drawing.Color.White;
            this.button_USUARIO.Location = new System.Drawing.Point(10, 236);
            this.button_USUARIO.Name = "button_USUARIO";
            this.button_USUARIO.Size = new System.Drawing.Size(180, 55);
            this.button_USUARIO.TabIndex = 25;
            this.button_USUARIO.Text = "USUARIO";
            this.button_USUARIO.UseVisualStyleBackColor = false;
            this.button_USUARIO.Click += new System.EventHandler(this.button_USUARIO_Click);
            // 
            // button_EMPLEADO
            // 
            this.button_EMPLEADO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button_EMPLEADO.FlatAppearance.BorderSize = 0;
            this.button_EMPLEADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EMPLEADO.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EMPLEADO.ForeColor = System.Drawing.Color.White;
            this.button_EMPLEADO.Location = new System.Drawing.Point(10, 317);
            this.button_EMPLEADO.Name = "button_EMPLEADO";
            this.button_EMPLEADO.Size = new System.Drawing.Size(180, 55);
            this.button_EMPLEADO.TabIndex = 26;
            this.button_EMPLEADO.Text = "EMPLEADO";
            this.button_EMPLEADO.UseVisualStyleBackColor = false;
            this.button_EMPLEADO.Click += new System.EventHandler(this.button_EMPLEADO_Click);
            // 
            // button_PRODUCTOS
            // 
            this.button_PRODUCTOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button_PRODUCTOS.FlatAppearance.BorderSize = 0;
            this.button_PRODUCTOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRODUCTOS.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PRODUCTOS.ForeColor = System.Drawing.Color.White;
            this.button_PRODUCTOS.Location = new System.Drawing.Point(12, 74);
            this.button_PRODUCTOS.Name = "button_PRODUCTOS";
            this.button_PRODUCTOS.Size = new System.Drawing.Size(180, 55);
            this.button_PRODUCTOS.TabIndex = 27;
            this.button_PRODUCTOS.Text = "PRODUCTOS";
            this.button_PRODUCTOS.UseVisualStyleBackColor = false;
            this.button_PRODUCTOS.Click += new System.EventHandler(this.button_PRODUCTOS_Click);
            // 
            // button_BUSCAR
            // 
            this.button_BUSCAR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_BUSCAR.BackgroundImage = global::CajeroApp.Properties.Resources.Lens;
            this.button_BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_BUSCAR.FlatAppearance.BorderSize = 0;
            this.button_BUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BUSCAR.Location = new System.Drawing.Point(763, 74);
            this.button_BUSCAR.Name = "button_BUSCAR";
            this.button_BUSCAR.Size = new System.Drawing.Size(29, 29);
            this.button_BUSCAR.TabIndex = 30;
            this.button_BUSCAR.UseVisualStyleBackColor = false;
            this.button_BUSCAR.Click += new System.EventHandler(this.button_BUSCAR_Click);
            // 
            // button_SALIR_VOLVER
            // 
            this.button_SALIR_VOLVER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.button_SALIR_VOLVER.BackgroundImage = global::CajeroApp.Properties.Resources.LOGOUT;
            this.button_SALIR_VOLVER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SALIR_VOLVER.FlatAppearance.BorderSize = 0;
            this.button_SALIR_VOLVER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SALIR_VOLVER.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SALIR_VOLVER.ForeColor = System.Drawing.Color.Transparent;
            this.button_SALIR_VOLVER.Location = new System.Drawing.Point(935, 10);
            this.button_SALIR_VOLVER.Name = "button_SALIR_VOLVER";
            this.button_SALIR_VOLVER.Size = new System.Drawing.Size(30, 30);
            this.button_SALIR_VOLVER.TabIndex = 2;
            this.button_SALIR_VOLVER.UseVisualStyleBackColor = false;
            this.button_SALIR_VOLVER.Click += new System.EventHandler(this.button_SALIR_VOLVER_Click);
            // 
            // textBox_BUSCAR
            // 
            this.textBox_BUSCAR.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_BUSCAR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_BUSCAR.Enabled = false;
            this.textBox_BUSCAR.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BUSCAR.ForeColor = System.Drawing.Color.Silver;
            this.textBox_BUSCAR.Location = new System.Drawing.Point(217, 74);
            this.textBox_BUSCAR.Name = "textBox_BUSCAR";
            this.textBox_BUSCAR.Size = new System.Drawing.Size(517, 21);
            this.textBox_BUSCAR.TabIndex = 31;
            this.textBox_BUSCAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_BUSCAR.WordWrap = false;
            this.textBox_BUSCAR.Enter += new System.EventHandler(this.textBox_BUSCAR_Enter);
            this.textBox_BUSCAR.Leave += new System.EventHandler(this.textBox_BUSCAR_Leave);
            // 
            // textBox_NOMBRE
            // 
            this.textBox_NOMBRE.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NOMBRE.Enabled = false;
            this.textBox_NOMBRE.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NOMBRE.ForeColor = System.Drawing.Color.Silver;
            this.textBox_NOMBRE.Location = new System.Drawing.Point(815, 77);
            this.textBox_NOMBRE.Multiline = true;
            this.textBox_NOMBRE.Name = "textBox_NOMBRE";
            this.textBox_NOMBRE.Size = new System.Drawing.Size(154, 22);
            this.textBox_NOMBRE.TabIndex = 32;
            this.textBox_NOMBRE.Text = "NOMBRE";
            this.textBox_NOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_NOMBRE.WordWrap = false;
            this.textBox_NOMBRE.Enter += new System.EventHandler(this.textBox_NOMBRE_Enter);
            this.textBox_NOMBRE.Leave += new System.EventHandler(this.textBox_NOMBRE_Leave);
            // 
            // button_MODIFICAR
            // 
            this.button_MODIFICAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.button_MODIFICAR.FlatAppearance.BorderSize = 0;
            this.button_MODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MODIFICAR.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MODIFICAR.ForeColor = System.Drawing.Color.White;
            this.button_MODIFICAR.Location = new System.Drawing.Point(815, 298);
            this.button_MODIFICAR.Name = "button_MODIFICAR";
            this.button_MODIFICAR.Size = new System.Drawing.Size(155, 30);
            this.button_MODIFICAR.TabIndex = 33;
            this.button_MODIFICAR.Text = "MODIFICAR";
            this.button_MODIFICAR.UseVisualStyleBackColor = false;
            this.button_MODIFICAR.Visible = false;
            this.button_MODIFICAR.Click += new System.EventHandler(this.button_MODIFICAR_Click);
            // 
            // ventanaPrincipalBindingSource
            // 
            this.ventanaPrincipalBindingSource.DataSource = typeof(CajeroApp.VentanaPrincipal);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(978, 498);
            this.ControlBox = false;
            this.Controls.Add(this.button_MODIFICAR);
            this.Controls.Add(this.textBox_NOMBRE);
            this.Controls.Add(this.textBox_BUSCAR);
            this.Controls.Add(this.button_BUSCAR);
            this.Controls.Add(this.button_PRODUCTOS);
            this.Controls.Add(this.button_EMPLEADO);
            this.Controls.Add(this.button_USUARIO);
            this.Controls.Add(this.BANNER);
            this.Controls.Add(this.button_SALIR_VOLVER);
            this.Controls.Add(this.button_ELIMINAR);
            this.Controls.Add(this.label_TOTAL);
            this.Controls.Add(this.textBox_TOTAL);
            this.Controls.Add(this.button_AGREGAR);
            this.Controls.Add(this.textBox_DATO1);
            this.Controls.Add(this.comboBox_PRODUCTOS);
            this.Controls.Add(this.textBox_DATO2);
            this.Controls.Add(this.dgv_ELEMENTOS);
            this.Controls.Add(this.button_PROVEEDORES);
            this.Controls.Add(this.button_VENTA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_USUARIO);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ELEMENTOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaPrincipalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_USUARIO;
        private System.Windows.Forms.Label BANNER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_VENTA;
        private System.Windows.Forms.Button button_PROVEEDORES;
        private System.Windows.Forms.DataGridView dgv_ELEMENTOS;
        private System.Windows.Forms.TextBox textBox_DATO2;
        private System.Windows.Forms.TextBox textBox_DATO1;
        private System.Windows.Forms.Button button_AGREGAR;
        private System.Windows.Forms.TextBox textBox_TOTAL;
        private System.Windows.Forms.Label label_TOTAL;
        private System.Windows.Forms.Button button_ELIMINAR;
        private System.Windows.Forms.Button button_SALIR_VOLVER;
        private System.Windows.Forms.Button button_USUARIO;
        private System.Windows.Forms.Button button_EMPLEADO;
        private System.Windows.Forms.Button button_PRODUCTOS;
        private System.Windows.Forms.Button button_BUSCAR;
        private System.Windows.Forms.TextBox textBox_BUSCAR;
        private System.Windows.Forms.BindingSource ventanaPrincipalBindingSource;
        public System.Windows.Forms.ComboBox comboBox_PRODUCTOS;
        private System.Windows.Forms.TextBox textBox_NOMBRE;
        private System.Windows.Forms.Button button_MODIFICAR;
    }
}