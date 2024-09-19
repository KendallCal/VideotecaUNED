namespace ClienteTCP
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cliente = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.Label();
            this.lateralConexion = new System.Windows.Forms.Panel();
            this.btnConexion = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.lateralConsultar = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lateralPrestamo = new System.Windows.Forms.Panel();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Black;
            this.panelLateral.Controls.Add(this.panelDatos);
            this.panelLateral.Controls.Add(this.lateralConexion);
            this.panelLateral.Controls.Add(this.btnConexion);
            this.panelLateral.Controls.Add(this.titulo);
            this.panelLateral.Controls.Add(this.lateralConsultar);
            this.panelLateral.Controls.Add(this.btnConsultar);
            this.panelLateral.Controls.Add(this.lateralPrestamo);
            this.panelLateral.Controls.Add(this.btnPrestamo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(223, 600);
            this.panelLateral.TabIndex = 0;
            // 
            // panelDatos
            // 
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.txtCliente);
            this.panelDatos.Controls.Add(this.flowLayoutPanel1);
            this.panelDatos.Controls.Add(this.cliente);
            this.panelDatos.Controls.Add(this.textCliente);
            this.panelDatos.Controls.Add(this.estado);
            this.panelDatos.Controls.Add(this.textEstado);
            this.panelDatos.Location = new System.Drawing.Point(18, 436);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(187, 140);
            this.panelDatos.TabIndex = 23;
            // 
            // txtCliente
            // 
            this.txtCliente.AutoSize = true;
            this.txtCliente.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(13, 42);
            this.txtCliente.MaximumSize = new System.Drawing.Size(160, 14);
            this.txtCliente.MinimumSize = new System.Drawing.Size(160, 14);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(160, 14);
            this.txtCliente.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(155, 1);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cliente.Location = new System.Drawing.Point(20, 42);
            this.cliente.MaximumSize = new System.Drawing.Size(100, 14);
            this.cliente.MinimumSize = new System.Drawing.Size(50, 14);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(50, 14);
            this.cliente.TabIndex = 5;
            // 
            // textCliente
            // 
            this.textCliente.AutoSize = true;
            this.textCliente.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textCliente.Location = new System.Drawing.Point(65, 18);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(55, 18);
            this.textCliente.TabIndex = 4;
            this.textCliente.Text = "Cliente";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.ForeColor = System.Drawing.Color.Red;
            this.estado.Location = new System.Drawing.Point(50, 107);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(84, 14);
            this.estado.TabIndex = 3;
            this.estado.Text = "Desconectado";
            // 
            // textEstado
            // 
            this.textEstado.AutoSize = true;
            this.textEstado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textEstado.Location = new System.Drawing.Point(66, 87);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(53, 18);
            this.textEstado.TabIndex = 2;
            this.textEstado.Text = "Estado";
            // 
            // lateralConexion
            // 
            this.lateralConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lateralConexion.Location = new System.Drawing.Point(0, 121);
            this.lateralConexion.Name = "lateralConexion";
            this.lateralConexion.Size = new System.Drawing.Size(12, 63);
            this.lateralConexion.TabIndex = 21;
            this.lateralConexion.Visible = false;
            // 
            // btnConexion
            // 
            this.btnConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConexion.FlatAppearance.BorderSize = 0;
            this.btnConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConexion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConexion.Image = global::ClienteTCP.Properties.Resources.IconoValidacion;
            this.btnConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConexion.Location = new System.Drawing.Point(12, 121);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConexion.Size = new System.Drawing.Size(192, 63);
            this.btnConexion.TabIndex = 20;
            this.btnConexion.Text = "        Conexion y                         Validación";
            this.btnConexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            this.btnConexion.MouseEnter += new System.EventHandler(this.btnConexion_MouseEnter);
            this.btnConexion.MouseLeave += new System.EventHandler(this.btnConexion_MouseLeave);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.titulo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.titulo.Location = new System.Drawing.Point(37, 45);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(149, 23);
            this.titulo.TabIndex = 19;
            this.titulo.Text = "Videoteca UNED";
            // 
            // lateralConsultar
            // 
            this.lateralConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lateralConsultar.Location = new System.Drawing.Point(0, 323);
            this.lateralConsultar.Name = "lateralConsultar";
            this.lateralConsultar.Size = new System.Drawing.Size(12, 63);
            this.lateralConsultar.TabIndex = 18;
            this.lateralConsultar.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Enabled = false;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Image = global::ClienteTCP.Properties.Resources.IconoConsulta;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(12, 323);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConsultar.Size = new System.Drawing.Size(192, 63);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "        Consultar                           préstamos";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Visible = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            this.btnConsultar.MouseEnter += new System.EventHandler(this.btnConsultar_MouseEnter);
            this.btnConsultar.MouseLeave += new System.EventHandler(this.btnConsultar_MouseLeave);
            // 
            // lateralPrestamo
            // 
            this.lateralPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lateralPrestamo.Location = new System.Drawing.Point(0, 222);
            this.lateralPrestamo.Name = "lateralPrestamo";
            this.lateralPrestamo.Size = new System.Drawing.Size(12, 63);
            this.lateralPrestamo.TabIndex = 16;
            this.lateralPrestamo.Visible = false;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamo.Enabled = false;
            this.btnPrestamo.FlatAppearance.BorderSize = 0;
            this.btnPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrestamo.Image = global::ClienteTCP.Properties.Resources.IconoPelicula;
            this.btnPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamo.Location = new System.Drawing.Point(12, 222);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPrestamo.Size = new System.Drawing.Size(192, 63);
            this.btnPrestamo.TabIndex = 15;
            this.btnPrestamo.Text = "        Préstamo de                      películas";
            this.btnPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Visible = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            this.btnPrestamo.MouseEnter += new System.EventHandler(this.btnPrestamo_MouseEnter);
            this.btnPrestamo.MouseLeave += new System.EventHandler(this.btnPrestamo_MouseLeave);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelSuperior.Controls.Add(this.btnSalir);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(223, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(827, 35);
            this.panelSuperior.TabIndex = 1;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            this.panelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseMove);
            this.panelSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseUp);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(793, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 27);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "X";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(223, 35);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(827, 565);
            this.panelPrincipal.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Videoteca UNED Clientes";
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label btnSalir;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel lateralConexion;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel lateralConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel lateralPrestamo;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Label textEstado;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.Label textCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label txtCliente;
    }
}

