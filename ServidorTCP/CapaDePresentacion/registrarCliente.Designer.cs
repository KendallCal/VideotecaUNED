namespace CapaDePresentacion
{
    partial class registrarCliente
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
            this.activo = new System.Windows.Forms.ComboBox();
            this.textActivo = new System.Windows.Forms.Label();
            this.registro = new System.Windows.Forms.DateTimePicker();
            this.nacimiento = new System.Windows.Forms.DateTimePicker();
            this.textRegistro = new System.Windows.Forms.Label();
            this.textNacimiento = new System.Windows.Forms.Label();
            this.apellido2 = new System.Windows.Forms.TextBox();
            this.textApellido2 = new System.Windows.Forms.Label();
            this.apellido1 = new System.Windows.Forms.TextBox();
            this.textApellido1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.identificacion = new System.Windows.Forms.TextBox();
            this.textIdentificacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.AutoSize = true;
            this.textID.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textID.Location = new System.Drawing.Point(29, 67);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(97, 18);
            this.textID.TabIndex = 59;
            this.textID.Text = "ID del Cliente";
            this.textID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(31, 92);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(150, 26);
            this.id.TabIndex = 0;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activo
            // 
            this.activo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activo.FormattingEnabled = true;
            this.activo.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.activo.Location = new System.Drawing.Point(253, 168);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(152, 26);
            this.activo.TabIndex = 5;
            // 
            // textActivo
            // 
            this.textActivo.AutoSize = true;
            this.textActivo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textActivo.Location = new System.Drawing.Point(250, 143);
            this.textActivo.Name = "textActivo";
            this.textActivo.Size = new System.Drawing.Size(51, 18);
            this.textActivo.TabIndex = 57;
            this.textActivo.Text = "Activo";
            // 
            // registro
            // 
            this.registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.registro.Location = new System.Drawing.Point(697, 165);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(152, 26);
            this.registro.TabIndex = 7;
            // 
            // nacimiento
            // 
            this.nacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nacimiento.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nacimiento.Location = new System.Drawing.Point(475, 168);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(152, 26);
            this.nacimiento.TabIndex = 6;
            // 
            // textRegistro
            // 
            this.textRegistro.AutoSize = true;
            this.textRegistro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textRegistro.Location = new System.Drawing.Point(694, 143);
            this.textRegistro.Name = "textRegistro";
            this.textRegistro.Size = new System.Drawing.Size(128, 18);
            this.textRegistro.TabIndex = 54;
            this.textRegistro.Text = "Fecha de Registro";
            // 
            // textNacimiento
            // 
            this.textNacimiento.AutoSize = true;
            this.textNacimiento.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textNacimiento.Location = new System.Drawing.Point(472, 143);
            this.textNacimiento.Name = "textNacimiento";
            this.textNacimiento.Size = new System.Drawing.Size(150, 18);
            this.textNacimiento.TabIndex = 53;
            this.textNacimiento.Text = "Fecha de Nacimiento";
            // 
            // apellido2
            // 
            this.apellido2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido2.Location = new System.Drawing.Point(31, 168);
            this.apellido2.Name = "apellido2";
            this.apellido2.Size = new System.Drawing.Size(152, 26);
            this.apellido2.TabIndex = 4;
            // 
            // textApellido2
            // 
            this.textApellido2.AutoSize = true;
            this.textApellido2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textApellido2.Location = new System.Drawing.Point(28, 143);
            this.textApellido2.Name = "textApellido2";
            this.textApellido2.Size = new System.Drawing.Size(125, 18);
            this.textApellido2.TabIndex = 51;
            this.textApellido2.Text = "Segundo Apellido";
            // 
            // apellido1
            // 
            this.apellido1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido1.Location = new System.Drawing.Point(698, 92);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(152, 26);
            this.apellido1.TabIndex = 3;
            // 
            // textApellido1
            // 
            this.textApellido1.AutoSize = true;
            this.textApellido1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textApellido1.Location = new System.Drawing.Point(695, 67);
            this.textApellido1.Name = "textApellido1";
            this.textApellido1.Size = new System.Drawing.Size(111, 18);
            this.textApellido1.TabIndex = 49;
            this.textApellido1.Text = "Primer Apellido";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(475, 92);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(152, 26);
            this.nombre.TabIndex = 2;
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textNombre.Location = new System.Drawing.Point(472, 67);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(62, 18);
            this.textNombre.TabIndex = 47;
            this.textNombre.Text = "Nombre";
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
            this.btnRegistrar.Location = new System.Drawing.Point(377, 225);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 35);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.titulo.Location = new System.Drawing.Point(305, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(265, 23);
            this.titulo.TabIndex = 45;
            this.titulo.Text = "Registrar y Consultar Clientes";
            // 
            // identificacion
            // 
            this.identificacion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identificacion.Location = new System.Drawing.Point(252, 92);
            this.identificacion.Name = "identificacion";
            this.identificacion.Size = new System.Drawing.Size(152, 26);
            this.identificacion.TabIndex = 1;
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.AutoSize = true;
            this.textIdentificacion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdentificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textIdentificacion.Location = new System.Drawing.Point(250, 67);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(98, 18);
            this.textIdentificacion.TabIndex = 43;
            this.textIdentificacion.Text = "Identificación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(362, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Lista de Clientes";
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna3,
            this.columna2,
            this.columna4,
            this.columna5,
            this.columna6,
            this.columna7,
            this.columna8});
            this.dataClientes.Location = new System.Drawing.Point(66, 327);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.ReadOnly = true;
            this.dataClientes.RowHeadersVisible = false;
            this.dataClientes.Size = new System.Drawing.Size(743, 230);
            this.dataClientes.TabIndex = 62;
            // 
            // columna1
            // 
            this.columna1.HeaderText = "ID";
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            this.columna1.Width = 50;
            // 
            // columna3
            // 
            this.columna3.HeaderText = "Identificación";
            this.columna3.Name = "columna3";
            this.columna3.ReadOnly = true;
            // 
            // columna2
            // 
            this.columna2.HeaderText = "Nombre";
            this.columna2.Name = "columna2";
            this.columna2.ReadOnly = true;
            this.columna2.Width = 125;
            // 
            // columna4
            // 
            this.columna4.HeaderText = "Primer Apellido";
            this.columna4.Name = "columna4";
            this.columna4.ReadOnly = true;
            this.columna4.Width = 85;
            // 
            // columna5
            // 
            this.columna5.HeaderText = "Segundo Apellido";
            this.columna5.Name = "columna5";
            this.columna5.ReadOnly = true;
            this.columna5.Width = 85;
            // 
            // columna6
            // 
            this.columna6.HeaderText = "Fecha de Nacimiento";
            this.columna6.Name = "columna6";
            this.columna6.ReadOnly = true;
            // 
            // columna7
            // 
            this.columna7.HeaderText = "Fecha de Registro";
            this.columna7.Name = "columna7";
            this.columna7.ReadOnly = true;
            // 
            // columna8
            // 
            this.columna8.HeaderText = "Activo";
            this.columna8.Name = "columna8";
            this.columna8.ReadOnly = true;
            // 
            // registrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(878, 584);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.id);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.textActivo);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.nacimiento);
            this.Controls.Add(this.textRegistro);
            this.Controls.Add(this.textNacimiento);
            this.Controls.Add(this.apellido2);
            this.Controls.Add(this.textApellido2);
            this.Controls.Add(this.apellido1);
            this.Controls.Add(this.textApellido1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.identificacion);
            this.Controls.Add(this.textIdentificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrarCliente";
            this.Text = "registrarCliente";
            this.Load += new System.EventHandler(this.registrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textID;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ComboBox activo;
        private System.Windows.Forms.Label textActivo;
        private System.Windows.Forms.DateTimePicker registro;
        private System.Windows.Forms.DateTimePicker nacimiento;
        private System.Windows.Forms.Label textRegistro;
        private System.Windows.Forms.Label textNacimiento;
        private System.Windows.Forms.TextBox apellido2;
        private System.Windows.Forms.Label textApellido2;
        private System.Windows.Forms.TextBox apellido1;
        private System.Windows.Forms.Label textApellido1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label textNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox identificacion;
        private System.Windows.Forms.Label textIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna6;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna7;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna8;
    }
}