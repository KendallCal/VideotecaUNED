namespace CapaDePresentacion
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.contenedorPrincipal = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.lateralServidor = new System.Windows.Forms.Panel();
            this.Servidor = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.lateralPeliculasPorSucursal = new System.Windows.Forms.Panel();
            this.registrarPeliculaSucursal = new System.Windows.Forms.Button();
            this.lateralCliente = new System.Windows.Forms.Panel();
            this.registrarCliente = new System.Windows.Forms.Button();
            this.lateralSucursal = new System.Windows.Forms.Panel();
            this.registrarSucursal = new System.Windows.Forms.Button();
            this.lateralEncargado = new System.Windows.Forms.Panel();
            this.registrarEncargado = new System.Windows.Forms.Button();
            this.lateralPelicula = new System.Windows.Forms.Panel();
            this.registrarPelicula = new System.Windows.Forms.Button();
            this.lateralCategoria = new System.Windows.Forms.Panel();
            this.registrarCategoria = new System.Windows.Forms.Button();
            this.contenedorPrincipal.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedorPrincipal
            // 
            this.contenedorPrincipal.Controls.Add(this.panelPrincipal);
            this.contenedorPrincipal.Controls.Add(this.panelSuperior);
            this.contenedorPrincipal.Controls.Add(this.panelLateral);
            this.contenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.contenedorPrincipal.Name = "contenedorPrincipal";
            this.contenedorPrincipal.Size = new System.Drawing.Size(1100, 616);
            this.contenedorPrincipal.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(223, 35);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(877, 581);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelSuperior.Controls.Add(this.btnSalir);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(223, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(877, 35);
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
            this.btnSalir.Location = new System.Drawing.Point(843, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 27);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "X";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Black;
            this.panelLateral.Controls.Add(this.lateralServidor);
            this.panelLateral.Controls.Add(this.Servidor);
            this.panelLateral.Controls.Add(this.titulo);
            this.panelLateral.Controls.Add(this.lateralPeliculasPorSucursal);
            this.panelLateral.Controls.Add(this.registrarPeliculaSucursal);
            this.panelLateral.Controls.Add(this.lateralCliente);
            this.panelLateral.Controls.Add(this.registrarCliente);
            this.panelLateral.Controls.Add(this.lateralSucursal);
            this.panelLateral.Controls.Add(this.registrarSucursal);
            this.panelLateral.Controls.Add(this.lateralEncargado);
            this.panelLateral.Controls.Add(this.registrarEncargado);
            this.panelLateral.Controls.Add(this.lateralPelicula);
            this.panelLateral.Controls.Add(this.registrarPelicula);
            this.panelLateral.Controls.Add(this.lateralCategoria);
            this.panelLateral.Controls.Add(this.registrarCategoria);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(223, 616);
            this.panelLateral.TabIndex = 0;
            // 
            // lateralServidor
            // 
            this.lateralServidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lateralServidor.Location = new System.Drawing.Point(0, 93);
            this.lateralServidor.Name = "lateralServidor";
            this.lateralServidor.Size = new System.Drawing.Size(12, 45);
            this.lateralServidor.TabIndex = 14;
            this.lateralServidor.Visible = false;
            // 
            // Servidor
            // 
            this.Servidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Servidor.FlatAppearance.BorderSize = 0;
            this.Servidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Servidor.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servidor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Servidor.Image = global::CapaDePresentacion.Properties.Resources.IconoServidor;
            this.Servidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Servidor.Location = new System.Drawing.Point(12, 93);
            this.Servidor.Name = "Servidor";
            this.Servidor.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Servidor.Size = new System.Drawing.Size(192, 45);
            this.Servidor.TabIndex = 13;
            this.Servidor.Text = "        Servidor";
            this.Servidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Servidor.UseVisualStyleBackColor = true;
            this.Servidor.Click += new System.EventHandler(this.Servidor_Click);
            this.Servidor.MouseEnter += new System.EventHandler(this.Servidor_MouseEnter);
            this.Servidor.MouseLeave += new System.EventHandler(this.Servidor_MouseLeave);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titulo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.titulo.Location = new System.Drawing.Point(34, 38);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(149, 23);
            this.titulo.TabIndex = 12;
            this.titulo.Text = "Videoteca UNED";
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            this.titulo.MouseEnter += new System.EventHandler(this.titulo_MouseEnter);
            this.titulo.MouseLeave += new System.EventHandler(this.titulo_MouseLeave);
            // 
            // lateralPeliculasPorSucursal
            // 
            this.lateralPeliculasPorSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lateralPeliculasPorSucursal.Location = new System.Drawing.Point(0, 543);
            this.lateralPeliculasPorSucursal.Name = "lateralPeliculasPorSucursal";
            this.lateralPeliculasPorSucursal.Size = new System.Drawing.Size(12, 45);
            this.lateralPeliculasPorSucursal.TabIndex = 11;
            this.lateralPeliculasPorSucursal.Visible = false;
            // 
            // registrarPeliculaSucursal
            // 
            this.registrarPeliculaSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarPeliculaSucursal.FlatAppearance.BorderSize = 0;
            this.registrarPeliculaSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarPeliculaSucursal.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarPeliculaSucursal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrarPeliculaSucursal.Image = global::CapaDePresentacion.Properties.Resources.iconoPeliculaXSucursal;
            this.registrarPeliculaSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarPeliculaSucursal.Location = new System.Drawing.Point(12, 543);
            this.registrarPeliculaSucursal.Name = "registrarPeliculaSucursal";
            this.registrarPeliculaSucursal.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.registrarPeliculaSucursal.Size = new System.Drawing.Size(192, 45);
            this.registrarPeliculaSucursal.TabIndex = 10;
            this.registrarPeliculaSucursal.Text = "        Películas por                      Sucursal";
            this.registrarPeliculaSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarPeliculaSucursal.UseVisualStyleBackColor = true;
            this.registrarPeliculaSucursal.Click += new System.EventHandler(this.registrarPeliculaSucursal_Click);
            this.registrarPeliculaSucursal.MouseEnter += new System.EventHandler(this.registrarPeliculaSucursal_MouseEnter);
            this.registrarPeliculaSucursal.MouseLeave += new System.EventHandler(this.registrarPeliculaSucursal_MouseLeave);
            // 
            // lateralCliente
            // 
            this.lateralCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lateralCliente.Location = new System.Drawing.Point(0, 468);
            this.lateralCliente.Name = "lateralCliente";
            this.lateralCliente.Size = new System.Drawing.Size(12, 45);
            this.lateralCliente.TabIndex = 9;
            this.lateralCliente.Visible = false;
            // 
            // registrarCliente
            // 
            this.registrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarCliente.FlatAppearance.BorderSize = 0;
            this.registrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarCliente.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrarCliente.Image = global::CapaDePresentacion.Properties.Resources.iconoCliente;
            this.registrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarCliente.Location = new System.Drawing.Point(12, 468);
            this.registrarCliente.Name = "registrarCliente";
            this.registrarCliente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.registrarCliente.Size = new System.Drawing.Size(192, 45);
            this.registrarCliente.TabIndex = 8;
            this.registrarCliente.Text = "        Clientes";
            this.registrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarCliente.UseVisualStyleBackColor = true;
            this.registrarCliente.Click += new System.EventHandler(this.registrarCliente_Click);
            this.registrarCliente.MouseEnter += new System.EventHandler(this.registrarCliente_MouseEnter);
            this.registrarCliente.MouseLeave += new System.EventHandler(this.registrarCliente_MouseLeave);
            // 
            // lateralSucursal
            // 
            this.lateralSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lateralSucursal.Location = new System.Drawing.Point(0, 393);
            this.lateralSucursal.Name = "lateralSucursal";
            this.lateralSucursal.Size = new System.Drawing.Size(12, 45);
            this.lateralSucursal.TabIndex = 7;
            this.lateralSucursal.Visible = false;
            // 
            // registrarSucursal
            // 
            this.registrarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarSucursal.FlatAppearance.BorderSize = 0;
            this.registrarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarSucursal.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarSucursal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrarSucursal.Image = global::CapaDePresentacion.Properties.Resources.iconTienda;
            this.registrarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarSucursal.Location = new System.Drawing.Point(12, 393);
            this.registrarSucursal.Name = "registrarSucursal";
            this.registrarSucursal.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.registrarSucursal.Size = new System.Drawing.Size(192, 45);
            this.registrarSucursal.TabIndex = 6;
            this.registrarSucursal.Text = "        Sucursales";
            this.registrarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarSucursal.UseVisualStyleBackColor = true;
            this.registrarSucursal.Click += new System.EventHandler(this.registrarSucursal_Click);
            this.registrarSucursal.MouseEnter += new System.EventHandler(this.registrarSucursal_MouseEnter);
            this.registrarSucursal.MouseLeave += new System.EventHandler(this.registrarSucursal_MouseLeave);
            // 
            // lateralEncargado
            // 
            this.lateralEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lateralEncargado.Location = new System.Drawing.Point(0, 318);
            this.lateralEncargado.Name = "lateralEncargado";
            this.lateralEncargado.Size = new System.Drawing.Size(12, 45);
            this.lateralEncargado.TabIndex = 5;
            this.lateralEncargado.Visible = false;
            // 
            // registrarEncargado
            // 
            this.registrarEncargado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarEncargado.FlatAppearance.BorderSize = 0;
            this.registrarEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarEncargado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarEncargado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrarEncargado.Image = global::CapaDePresentacion.Properties.Resources.iconEncargado;
            this.registrarEncargado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarEncargado.Location = new System.Drawing.Point(12, 318);
            this.registrarEncargado.Name = "registrarEncargado";
            this.registrarEncargado.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.registrarEncargado.Size = new System.Drawing.Size(192, 45);
            this.registrarEncargado.TabIndex = 4;
            this.registrarEncargado.Text = "        Encargados";
            this.registrarEncargado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarEncargado.UseVisualStyleBackColor = true;
            this.registrarEncargado.Click += new System.EventHandler(this.registrarEncargado_Click);
            this.registrarEncargado.MouseEnter += new System.EventHandler(this.registrarEncargado_MouseEnter);
            this.registrarEncargado.MouseLeave += new System.EventHandler(this.registrarEncargado_MouseLeave);
            // 
            // lateralPelicula
            // 
            this.lateralPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lateralPelicula.Location = new System.Drawing.Point(0, 243);
            this.lateralPelicula.Name = "lateralPelicula";
            this.lateralPelicula.Size = new System.Drawing.Size(12, 45);
            this.lateralPelicula.TabIndex = 3;
            this.lateralPelicula.Visible = false;
            // 
            // registrarPelicula
            // 
            this.registrarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarPelicula.FlatAppearance.BorderSize = 0;
            this.registrarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarPelicula.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarPelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrarPelicula.Image = global::CapaDePresentacion.Properties.Resources.iconPelicula;
            this.registrarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarPelicula.Location = new System.Drawing.Point(12, 243);
            this.registrarPelicula.Name = "registrarPelicula";
            this.registrarPelicula.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.registrarPelicula.Size = new System.Drawing.Size(192, 45);
            this.registrarPelicula.TabIndex = 2;
            this.registrarPelicula.Text = "        Películas";
            this.registrarPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarPelicula.UseVisualStyleBackColor = true;
            this.registrarPelicula.Click += new System.EventHandler(this.registrarPelicula_Click);
            this.registrarPelicula.MouseEnter += new System.EventHandler(this.registrarPelicula_MouseEnter);
            this.registrarPelicula.MouseLeave += new System.EventHandler(this.registrarPelicula_MouseLeave);
            // 
            // lateralCategoria
            // 
            this.lateralCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lateralCategoria.Location = new System.Drawing.Point(0, 168);
            this.lateralCategoria.Name = "lateralCategoria";
            this.lateralCategoria.Size = new System.Drawing.Size(12, 45);
            this.lateralCategoria.TabIndex = 1;
            this.lateralCategoria.Visible = false;
            // 
            // registrarCategoria
            // 
            this.registrarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarCategoria.FlatAppearance.BorderSize = 0;
            this.registrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarCategoria.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrarCategoria.Image = global::CapaDePresentacion.Properties.Resources.iconCategoria;
            this.registrarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarCategoria.Location = new System.Drawing.Point(12, 168);
            this.registrarCategoria.Name = "registrarCategoria";
            this.registrarCategoria.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.registrarCategoria.Size = new System.Drawing.Size(192, 45);
            this.registrarCategoria.TabIndex = 0;
            this.registrarCategoria.Text = "        Categorías";
            this.registrarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarCategoria.UseVisualStyleBackColor = true;
            this.registrarCategoria.Click += new System.EventHandler(this.registrarCategoria_Click);
            this.registrarCategoria.MouseEnter += new System.EventHandler(this.registrarCategoria_MouseEnter);
            this.registrarCategoria.MouseLeave += new System.EventHandler(this.registrarCategoria_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 616);
            this.Controls.Add(this.contenedorPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Videoteca UNED Admin";
            this.contenedorPrincipal.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedorPrincipal;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button registrarCategoria;
        private System.Windows.Forms.Panel lateralCategoria;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel lateralPeliculasPorSucursal;
        private System.Windows.Forms.Button registrarPeliculaSucursal;
        private System.Windows.Forms.Panel lateralCliente;
        private System.Windows.Forms.Button registrarCliente;
        private System.Windows.Forms.Panel lateralSucursal;
        private System.Windows.Forms.Button registrarSucursal;
        private System.Windows.Forms.Panel lateralEncargado;
        private System.Windows.Forms.Button registrarEncargado;
        private System.Windows.Forms.Panel lateralPelicula;
        private System.Windows.Forms.Button registrarPelicula;
        private System.Windows.Forms.Label btnSalir;
        private System.Windows.Forms.Panel lateralServidor;
        private System.Windows.Forms.Button Servidor;
    }
}