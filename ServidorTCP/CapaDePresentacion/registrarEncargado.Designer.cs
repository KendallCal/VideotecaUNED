namespace CapaDePresentacion
{
    partial class registrarEncargado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textID = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.ingreso = new System.Windows.Forms.DateTimePicker();
            this.nacimiento = new System.Windows.Forms.DateTimePicker();
            this.textIngreso = new System.Windows.Forms.Label();
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
            this.dataEncargados = new System.Windows.Forms.DataGridView();
            this.titulo2 = new System.Windows.Forms.Label();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataEncargados)).BeginInit();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.AutoSize = true;
            this.textID.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textID.Location = new System.Drawing.Point(31, 61);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(121, 18);
            this.textID.TabIndex = 42;
            this.textID.Text = "ID del Encargado";
            this.textID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(34, 85);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(150, 26);
            this.id.TabIndex = 0;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ingreso
            // 
            this.ingreso.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ingreso.Location = new System.Drawing.Point(470, 151);
            this.ingreso.Name = "ingreso";
            this.ingreso.Size = new System.Drawing.Size(152, 26);
            this.ingreso.TabIndex = 6;
            // 
            // nacimiento
            // 
            this.nacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nacimiento.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nacimiento.Location = new System.Drawing.Point(251, 151);
            this.nacimiento.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.nacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(152, 26);
            this.nacimiento.TabIndex = 5;
            // 
            // textIngreso
            // 
            this.textIngreso.AutoSize = true;
            this.textIngreso.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIngreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textIngreso.Location = new System.Drawing.Point(467, 127);
            this.textIngreso.Name = "textIngreso";
            this.textIngreso.Size = new System.Drawing.Size(122, 18);
            this.textIngreso.TabIndex = 39;
            this.textIngreso.Text = "Fecha de Ingreso";
            // 
            // textNacimiento
            // 
            this.textNacimiento.AutoSize = true;
            this.textNacimiento.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textNacimiento.Location = new System.Drawing.Point(248, 127);
            this.textNacimiento.Name = "textNacimiento";
            this.textNacimiento.Size = new System.Drawing.Size(150, 18);
            this.textNacimiento.TabIndex = 38;
            this.textNacimiento.Text = "Fecha de Nacimiento";
            // 
            // apellido2
            // 
            this.apellido2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido2.Location = new System.Drawing.Point(34, 151);
            this.apellido2.Name = "apellido2";
            this.apellido2.Size = new System.Drawing.Size(152, 26);
            this.apellido2.TabIndex = 4;
            // 
            // textApellido2
            // 
            this.textApellido2.AutoSize = true;
            this.textApellido2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textApellido2.Location = new System.Drawing.Point(31, 127);
            this.textApellido2.Name = "textApellido2";
            this.textApellido2.Size = new System.Drawing.Size(125, 18);
            this.textApellido2.TabIndex = 36;
            this.textApellido2.Text = "Segundo Apellido";
            // 
            // apellido1
            // 
            this.apellido1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido1.Location = new System.Drawing.Point(690, 85);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(152, 26);
            this.apellido1.TabIndex = 3;
            // 
            // textApellido1
            // 
            this.textApellido1.AutoSize = true;
            this.textApellido1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textApellido1.Location = new System.Drawing.Point(687, 61);
            this.textApellido1.Name = "textApellido1";
            this.textApellido1.Size = new System.Drawing.Size(111, 18);
            this.textApellido1.TabIndex = 34;
            this.textApellido1.Text = "Primer Apellido";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(470, 85);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(152, 26);
            this.nombre.TabIndex = 2;
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textNombre.Location = new System.Drawing.Point(467, 61);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(62, 18);
            this.textNombre.TabIndex = 32;
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
            this.btnRegistrar.Location = new System.Drawing.Point(379, 209);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 35);
            this.btnRegistrar.TabIndex = 7;
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
            this.titulo.Location = new System.Drawing.Point(295, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(288, 23);
            this.titulo.TabIndex = 30;
            this.titulo.Text = "Registrar y Consultar Encargado";
            // 
            // identificacion
            // 
            this.identificacion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identificacion.Location = new System.Drawing.Point(251, 85);
            this.identificacion.Name = "identificacion";
            this.identificacion.Size = new System.Drawing.Size(152, 26);
            this.identificacion.TabIndex = 1;
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.AutoSize = true;
            this.textIdentificacion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdentificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textIdentificacion.Location = new System.Drawing.Point(248, 61);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(98, 18);
            this.textIdentificacion.TabIndex = 28;
            this.textIdentificacion.Text = "Identificación";
            // 
            // dataEncargados
            // 
            this.dataEncargados.AllowUserToAddRows = false;
            this.dataEncargados.AllowUserToDeleteRows = false;
            this.dataEncargados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataEncargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEncargados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna2,
            this.columna3,
            this.columna4,
            this.columna5,
            this.columna6,
            this.columna7});
            this.dataEncargados.Location = new System.Drawing.Point(89, 320);
            this.dataEncargados.Name = "dataEncargados";
            this.dataEncargados.ReadOnly = true;
            this.dataEncargados.RowHeadersVisible = false;
            this.dataEncargados.Size = new System.Drawing.Size(700, 235);
            this.dataEncargados.TabIndex = 54;
            // 
            // titulo2
            // 
            this.titulo2.AutoSize = true;
            this.titulo2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.titulo2.Location = new System.Drawing.Point(347, 285);
            this.titulo2.Name = "titulo2";
            this.titulo2.Size = new System.Drawing.Size(184, 23);
            this.titulo2.TabIndex = 55;
            this.titulo2.Text = "Lista de Encargados";
            // 
            // columna1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columna1.DefaultCellStyle = dataGridViewCellStyle1;
            this.columna1.Frozen = true;
            this.columna1.HeaderText = "ID";
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            this.columna1.Width = 50;
            // 
            // columna2
            // 
            this.columna2.Frozen = true;
            this.columna2.HeaderText = "Identificación";
            this.columna2.Name = "columna2";
            this.columna2.ReadOnly = true;
            this.columna2.Width = 95;
            // 
            // columna3
            // 
            this.columna3.Frozen = true;
            this.columna3.HeaderText = "Nombre";
            this.columna3.Name = "columna3";
            this.columna3.ReadOnly = true;
            this.columna3.Width = 130;
            // 
            // columna4
            // 
            this.columna4.Frozen = true;
            this.columna4.HeaderText = "Primer Apellido";
            this.columna4.Name = "columna4";
            this.columna4.ReadOnly = true;
            this.columna4.Width = 110;
            // 
            // columna5
            // 
            this.columna5.HeaderText = "Segundo Apellido";
            this.columna5.Name = "columna5";
            this.columna5.ReadOnly = true;
            this.columna5.Width = 110;
            // 
            // columna6
            // 
            this.columna6.HeaderText = "Fecha de Nacimiento";
            this.columna6.Name = "columna6";
            this.columna6.ReadOnly = true;
            // 
            // columna7
            // 
            this.columna7.HeaderText = "Fecha de Ingreso";
            this.columna7.Name = "columna7";
            this.columna7.ReadOnly = true;
            // 
            // registrarEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(878, 584);
            this.Controls.Add(this.titulo2);
            this.Controls.Add(this.dataEncargados);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.id);
            this.Controls.Add(this.ingreso);
            this.Controls.Add(this.nacimiento);
            this.Controls.Add(this.textIngreso);
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
            this.Name = "registrarEncargado";
            this.Text = "registrarEncargado";
            this.Load += new System.EventHandler(this.registrarEncargado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEncargados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textID;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DateTimePicker ingreso;
        private System.Windows.Forms.DateTimePicker nacimiento;
        private System.Windows.Forms.Label textIngreso;
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
        private System.Windows.Forms.DataGridView dataEncargados;
        private System.Windows.Forms.Label titulo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna6;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna7;
    }
}