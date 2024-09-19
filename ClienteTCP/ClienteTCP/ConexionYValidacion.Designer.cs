namespace ClienteTCP
{
    partial class ConexionYValidacion
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
            this.contenedorInformacion = new System.Windows.Forms.Panel();
            this.groupInformacion = new System.Windows.Forms.GroupBox();
            this.textIdentificador = new System.Windows.Forms.Label();
            this.identificador = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.textDatos = new System.Windows.Forms.Label();
            this.contedorDatos = new System.Windows.Forms.Panel();
            this.registro = new System.Windows.Forms.Label();
            this.nacimiento = new System.Windows.Forms.Label();
            this.activo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.identificacion = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.textRegistro = new System.Windows.Forms.Label();
            this.textNacimiento = new System.Windows.Forms.Label();
            this.textActivo = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.Label();
            this.textIdentificacion = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.Label();
            this.contenedorInformacion.SuspendLayout();
            this.groupInformacion.SuspendLayout();
            this.contedorDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedorInformacion
            // 
            this.contenedorInformacion.Controls.Add(this.groupInformacion);
            this.contenedorInformacion.Controls.Add(this.btnDesconectar);
            this.contenedorInformacion.Controls.Add(this.btnConectar);
            this.contenedorInformacion.Location = new System.Drawing.Point(122, 63);
            this.contenedorInformacion.Name = "contenedorInformacion";
            this.contenedorInformacion.Size = new System.Drawing.Size(582, 165);
            this.contenedorInformacion.TabIndex = 49;
            // 
            // groupInformacion
            // 
            this.groupInformacion.Controls.Add(this.textIdentificador);
            this.groupInformacion.Controls.Add(this.identificador);
            this.groupInformacion.Controls.Add(this.estado);
            this.groupInformacion.Controls.Add(this.textEstado);
            this.groupInformacion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInformacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupInformacion.Location = new System.Drawing.Point(15, 10);
            this.groupInformacion.Name = "groupInformacion";
            this.groupInformacion.Size = new System.Drawing.Size(403, 137);
            this.groupInformacion.TabIndex = 11;
            this.groupInformacion.TabStop = false;
            this.groupInformacion.Text = "Conexión con el Servidor";
            // 
            // textIdentificador
            // 
            this.textIdentificador.AutoSize = true;
            this.textIdentificador.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdentificador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textIdentificador.Location = new System.Drawing.Point(15, 32);
            this.textIdentificador.Name = "textIdentificador";
            this.textIdentificador.Size = new System.Drawing.Size(91, 18);
            this.textIdentificador.TabIndex = 16;
            this.textIdentificador.Text = "Identificador";
            this.textIdentificador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // identificador
            // 
            this.identificador.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identificador.ForeColor = System.Drawing.Color.Black;
            this.identificador.Location = new System.Drawing.Point(18, 56);
            this.identificador.Name = "identificador";
            this.identificador.Size = new System.Drawing.Size(150, 26);
            this.identificador.TabIndex = 15;
            this.identificador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.ForeColor = System.Drawing.Color.Red;
            this.estado.Location = new System.Drawing.Point(82, 107);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(109, 18);
            this.estado.TabIndex = 1;
            this.estado.Text = "Desconectado.";
            // 
            // textEstado
            // 
            this.textEstado.AutoSize = true;
            this.textEstado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textEstado.Location = new System.Drawing.Point(19, 107);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(57, 18);
            this.textEstado.TabIndex = 0;
            this.textEstado.Text = "Estado:";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnDesconectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDesconectar.Location = new System.Drawing.Point(438, 95);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(131, 36);
            this.btnDesconectar.TabIndex = 10;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            this.btnDesconectar.MouseEnter += new System.EventHandler(this.btnDesconectar_MouseEnter);
            this.btnDesconectar.MouseLeave += new System.EventHandler(this.btnDesconectar_MouseLeave);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConectar.Location = new System.Drawing.Point(438, 31);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(131, 36);
            this.btnConectar.TabIndex = 9;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            this.btnConectar.MouseEnter += new System.EventHandler(this.btnConectar_MouseEnter);
            this.btnConectar.MouseLeave += new System.EventHandler(this.btnConectar_MouseLeave);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.titulo.Location = new System.Drawing.Point(313, 24);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(201, 23);
            this.titulo.TabIndex = 48;
            this.titulo.Text = "Conexión y Validación";
            // 
            // textDatos
            // 
            this.textDatos.AutoSize = true;
            this.textDatos.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.textDatos.Location = new System.Drawing.Point(336, 257);
            this.textDatos.Name = "textDatos";
            this.textDatos.Size = new System.Drawing.Size(154, 23);
            this.textDatos.TabIndex = 50;
            this.textDatos.Text = "Datos del Cliente";
            // 
            // contedorDatos
            // 
            this.contedorDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contedorDatos.Controls.Add(this.registro);
            this.contedorDatos.Controls.Add(this.nacimiento);
            this.contedorDatos.Controls.Add(this.activo);
            this.contedorDatos.Controls.Add(this.nombre);
            this.contedorDatos.Controls.Add(this.identificacion);
            this.contedorDatos.Controls.Add(this.id);
            this.contedorDatos.Controls.Add(this.textRegistro);
            this.contedorDatos.Controls.Add(this.textNacimiento);
            this.contedorDatos.Controls.Add(this.textActivo);
            this.contedorDatos.Controls.Add(this.textNombre);
            this.contedorDatos.Controls.Add(this.textIdentificacion);
            this.contedorDatos.Controls.Add(this.textID);
            this.contedorDatos.Location = new System.Drawing.Point(122, 270);
            this.contedorDatos.Name = "contedorDatos";
            this.contedorDatos.Size = new System.Drawing.Size(582, 274);
            this.contedorDatos.TabIndex = 51;
            // 
            // registro
            // 
            this.registro.AutoSize = true;
            this.registro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registro.Location = new System.Drawing.Point(180, 194);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(0, 18);
            this.registro.TabIndex = 33;
            this.registro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nacimiento
            // 
            this.nacimiento.AutoSize = true;
            this.nacimiento.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nacimiento.Location = new System.Drawing.Point(158, 237);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(0, 18);
            this.nacimiento.TabIndex = 32;
            this.nacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activo.Location = new System.Drawing.Point(81, 151);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(0, 18);
            this.activo.TabIndex = 31;
            this.activo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombre.Location = new System.Drawing.Point(92, 108);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(0, 18);
            this.nombre.TabIndex = 28;
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // identificacion
            // 
            this.identificacion.AutoSize = true;
            this.identificacion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.identificacion.Location = new System.Drawing.Point(128, 65);
            this.identificacion.Name = "identificacion";
            this.identificacion.Size = new System.Drawing.Size(0, 18);
            this.identificacion.TabIndex = 27;
            this.identificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id.Location = new System.Drawing.Point(52, 22);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 18);
            this.id.TabIndex = 25;
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textRegistro
            // 
            this.textRegistro.AutoSize = true;
            this.textRegistro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textRegistro.Location = new System.Drawing.Point(20, 237);
            this.textRegistro.Name = "textRegistro";
            this.textRegistro.Size = new System.Drawing.Size(132, 18);
            this.textRegistro.TabIndex = 24;
            this.textRegistro.Text = "Fecha de Registro:";
            this.textRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNacimiento
            // 
            this.textNacimiento.AutoSize = true;
            this.textNacimiento.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textNacimiento.Location = new System.Drawing.Point(20, 194);
            this.textNacimiento.Name = "textNacimiento";
            this.textNacimiento.Size = new System.Drawing.Size(154, 18);
            this.textNacimiento.TabIndex = 23;
            this.textNacimiento.Text = "Fecha de Nacimiento:";
            this.textNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textActivo
            // 
            this.textActivo.AutoSize = true;
            this.textActivo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textActivo.Location = new System.Drawing.Point(20, 151);
            this.textActivo.Name = "textActivo";
            this.textActivo.Size = new System.Drawing.Size(55, 18);
            this.textActivo.TabIndex = 22;
            this.textActivo.Text = "Activo:";
            this.textActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textNombre.Location = new System.Drawing.Point(20, 108);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(66, 18);
            this.textNombre.TabIndex = 19;
            this.textNombre.Text = "Nombre:";
            this.textNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.AutoSize = true;
            this.textIdentificacion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textIdentificacion.Location = new System.Drawing.Point(20, 65);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(102, 18);
            this.textIdentificacion.TabIndex = 18;
            this.textIdentificacion.Text = "Identificación:";
            this.textIdentificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textID
            // 
            this.textID.AutoSize = true;
            this.textID.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textID.Location = new System.Drawing.Point(20, 22);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(26, 18);
            this.textID.TabIndex = 17;
            this.textID.Text = "ID:";
            this.textID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConexionYValidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(827, 565);
            this.Controls.Add(this.textDatos);
            this.Controls.Add(this.contedorDatos);
            this.Controls.Add(this.contenedorInformacion);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConexionYValidacion";
            this.Text = "ConexionYValidacion";
            this.contenedorInformacion.ResumeLayout(false);
            this.groupInformacion.ResumeLayout(false);
            this.groupInformacion.PerformLayout();
            this.contedorDatos.ResumeLayout(false);
            this.contedorDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contenedorInformacion;
        private System.Windows.Forms.GroupBox groupInformacion;
        private System.Windows.Forms.TextBox identificador;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label textEstado;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label textIdentificador;
        private System.Windows.Forms.Label textDatos;
        private System.Windows.Forms.Panel contedorDatos;
        private System.Windows.Forms.Label textRegistro;
        private System.Windows.Forms.Label textNacimiento;
        private System.Windows.Forms.Label textActivo;
        private System.Windows.Forms.Label textNombre;
        private System.Windows.Forms.Label textIdentificacion;
        private System.Windows.Forms.Label textID;
        private System.Windows.Forms.Label registro;
        private System.Windows.Forms.Label nacimiento;
        private System.Windows.Forms.Label activo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label identificacion;
        private System.Windows.Forms.Label id;
    }
}