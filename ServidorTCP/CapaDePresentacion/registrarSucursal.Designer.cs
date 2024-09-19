namespace CapaDePresentacion
{
    partial class registrarSucursal
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
            this.textID = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.Label();
            this.activa = new System.Windows.Forms.ComboBox();
            this.textActiva = new System.Windows.Forms.Label();
            this.encargado = new System.Windows.Forms.ComboBox();
            this.textEncargado = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSucursales = new System.Windows.Forms.DataGridView();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.AutoSize = true;
            this.textID.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textID.Location = new System.Drawing.Point(56, 59);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(120, 18);
            this.textID.TabIndex = 38;
            this.textID.Text = "ID de la Sucursal";
            this.textID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(40, 87);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(152, 26);
            this.id.TabIndex = 0;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(687, 87);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(152, 26);
            this.telefono.TabIndex = 2;
            // 
            // textTelefono
            // 
            this.textTelefono.AutoSize = true;
            this.textTelefono.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textTelefono.Location = new System.Drawing.Point(730, 59);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(67, 18);
            this.textTelefono.TabIndex = 36;
            this.textTelefono.Text = "Teléfono";
            // 
            // direccion
            // 
            this.direccion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.Location = new System.Drawing.Point(324, 153);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(231, 40);
            this.direccion.TabIndex = 4;
            // 
            // textDireccion
            // 
            this.textDireccion.AutoSize = true;
            this.textDireccion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textDireccion.Location = new System.Drawing.Point(403, 125);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(72, 18);
            this.textDireccion.TabIndex = 34;
            this.textDireccion.Text = "Dirección";
            // 
            // activa
            // 
            this.activa.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activa.FormattingEnabled = true;
            this.activa.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.activa.Location = new System.Drawing.Point(687, 160);
            this.activa.Name = "activa";
            this.activa.Size = new System.Drawing.Size(152, 26);
            this.activa.TabIndex = 5;
            // 
            // textActiva
            // 
            this.textActiva.AutoSize = true;
            this.textActiva.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textActiva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textActiva.Location = new System.Drawing.Point(738, 132);
            this.textActiva.Name = "textActiva";
            this.textActiva.Size = new System.Drawing.Size(50, 18);
            this.textActiva.TabIndex = 32;
            this.textActiva.Text = "Activa";
            // 
            // encargado
            // 
            this.encargado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encargado.FormattingEnabled = true;
            this.encargado.Location = new System.Drawing.Point(40, 160);
            this.encargado.Name = "encargado";
            this.encargado.Size = new System.Drawing.Size(152, 26);
            this.encargado.TabIndex = 3;
            // 
            // textEncargado
            // 
            this.textEncargado.AutoSize = true;
            this.textEncargado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEncargado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textEncargado.Location = new System.Drawing.Point(77, 132);
            this.textEncargado.Name = "textEncargado";
            this.textEncargado.Size = new System.Drawing.Size(79, 18);
            this.textEncargado.TabIndex = 30;
            this.textEncargado.Text = "Encargado";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(379, 217);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 35);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.MouseEnter += new System.EventHandler(this.btnRegistrar_MouseEnter);
            this.btnRegistrar.MouseLeave += new System.EventHandler(this.btnRegistrar_MouseLeave);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.titulo.Location = new System.Drawing.Point(303, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(272, 23);
            this.titulo.TabIndex = 28;
            this.titulo.Text = "Registrar y Consultar Sucursal";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(324, 87);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(231, 26);
            this.nombre.TabIndex = 1;
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textNombre.Location = new System.Drawing.Point(359, 59);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(160, 18);
            this.textNombre.TabIndex = 26;
            this.textNombre.Text = "Nombre de la Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(349, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Lista de Sucursales";
            // 
            // dataSucursales
            // 
            this.dataSucursales.AllowUserToAddRows = false;
            this.dataSucursales.AllowUserToDeleteRows = false;
            this.dataSucursales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna2,
            this.columna3,
            this.columna4,
            this.columna5,
            this.columna6,
            this.columna7,
            this.columna8,
            this.columna9,
            this.columna11,
            this.columna10,
            this.columna12});
            this.dataSucursales.Location = new System.Drawing.Point(40, 323);
            this.dataSucursales.Name = "dataSucursales";
            this.dataSucursales.ReadOnly = true;
            this.dataSucursales.RowHeadersVisible = false;
            this.dataSucursales.Size = new System.Drawing.Size(799, 224);
            this.dataSucursales.TabIndex = 54;
            // 
            // columna1
            // 
            this.columna1.HeaderText = "ID";
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            this.columna1.Width = 40;
            // 
            // columna2
            // 
            this.columna2.HeaderText = "Sucursal";
            this.columna2.Name = "columna2";
            this.columna2.ReadOnly = true;
            // 
            // columna3
            // 
            this.columna3.HeaderText = "ID Encargado";
            this.columna3.Name = "columna3";
            this.columna3.ReadOnly = true;
            // 
            // columna4
            // 
            this.columna4.HeaderText = "Identificación";
            this.columna4.Name = "columna4";
            this.columna4.ReadOnly = true;
            // 
            // columna5
            // 
            this.columna5.HeaderText = "Encargado";
            this.columna5.Name = "columna5";
            this.columna5.ReadOnly = true;
            // 
            // columna6
            // 
            this.columna6.HeaderText = "Primer Apellido";
            this.columna6.Name = "columna6";
            this.columna6.ReadOnly = true;
            // 
            // columna7
            // 
            this.columna7.HeaderText = "Segundo Apellido";
            this.columna7.Name = "columna7";
            this.columna7.ReadOnly = true;
            // 
            // columna8
            // 
            this.columna8.HeaderText = "Fecha nacimiento";
            this.columna8.Name = "columna8";
            this.columna8.ReadOnly = true;
            // 
            // columna9
            // 
            this.columna9.HeaderText = "Fecha Ingreso";
            this.columna9.Name = "columna9";
            this.columna9.ReadOnly = true;
            // 
            // columna11
            // 
            this.columna11.HeaderText = "Teléfono";
            this.columna11.Name = "columna11";
            this.columna11.ReadOnly = true;
            // 
            // columna10
            // 
            this.columna10.HeaderText = "Dirección";
            this.columna10.Name = "columna10";
            this.columna10.ReadOnly = true;
            this.columna10.Width = 218;
            // 
            // columna12
            // 
            this.columna12.HeaderText = "Activa";
            this.columna12.Name = "columna12";
            this.columna12.ReadOnly = true;
            // 
            // registrarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(878, 584);
            this.Controls.Add(this.dataSucursales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.id);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.activa);
            this.Controls.Add(this.textActiva);
            this.Controls.Add(this.encargado);
            this.Controls.Add(this.textEncargado);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.textNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrarSucursal";
            this.Text = "registrarSucursal";
            this.Load += new System.EventHandler(this.registrarSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textID;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label textTelefono;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label textDireccion;
        private System.Windows.Forms.ComboBox activa;
        private System.Windows.Forms.Label textActiva;
        private System.Windows.Forms.ComboBox encargado;
        private System.Windows.Forms.Label textEncargado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataSucursales;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna6;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna7;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna8;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna9;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna11;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna10;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna12;
    }
}