namespace CapaDePresentacion
{
    partial class registrarPelicula
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
            this.idioma = new System.Windows.Forms.TextBox();
            this.textIdioma = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.TextBox();
            this.textAnio = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.ComboBox();
            this.textCategoria = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.pelicula = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.Label();
            this.dataPeliculas = new System.Windows.Forms.DataGridView();
            this.titulo2 = new System.Windows.Forms.Label();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.AutoSize = true;
            this.textID.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textID.Location = new System.Drawing.Point(68, 53);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(115, 18);
            this.textID.TabIndex = 28;
            this.textID.Text = "ID de la Película";
            this.textID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.Location = new System.Drawing.Point(70, 77);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(150, 26);
            this.id.TabIndex = 0;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idioma
            // 
            this.idioma.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idioma.ForeColor = System.Drawing.Color.Black;
            this.idioma.Location = new System.Drawing.Point(360, 147);
            this.idioma.Name = "idioma";
            this.idioma.Size = new System.Drawing.Size(152, 26);
            this.idioma.TabIndex = 3;
            // 
            // textIdioma
            // 
            this.textIdioma.AutoSize = true;
            this.textIdioma.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdioma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textIdioma.Location = new System.Drawing.Point(357, 123);
            this.textIdioma.Name = "textIdioma";
            this.textIdioma.Size = new System.Drawing.Size(54, 18);
            this.textIdioma.TabIndex = 26;
            this.textIdioma.Text = "Idioma";
            // 
            // anio
            // 
            this.anio.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anio.ForeColor = System.Drawing.Color.Black;
            this.anio.Location = new System.Drawing.Point(360, 77);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(152, 26);
            this.anio.TabIndex = 2;
            // 
            // textAnio
            // 
            this.textAnio.AutoSize = true;
            this.textAnio.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textAnio.Location = new System.Drawing.Point(357, 56);
            this.textAnio.Name = "textAnio";
            this.textAnio.Size = new System.Drawing.Size(141, 18);
            this.textAnio.TabIndex = 24;
            this.textAnio.Text = "Año de lanzamiento";
            // 
            // categoria
            // 
            this.categoria.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.ForeColor = System.Drawing.Color.Black;
            this.categoria.FormattingEnabled = true;
            this.categoria.Location = new System.Drawing.Point(650, 77);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(152, 26);
            this.categoria.TabIndex = 4;
            // 
            // textCategoria
            // 
            this.textCategoria.AutoSize = true;
            this.textCategoria.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textCategoria.Location = new System.Drawing.Point(647, 53);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(73, 18);
            this.textCategoria.TabIndex = 22;
            this.textCategoria.Text = "Categoría";
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
            this.btnRegistrar.Location = new System.Drawing.Point(376, 196);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 35);
            this.btnRegistrar.TabIndex = 5;
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
            this.titulo.Location = new System.Drawing.Point(299, 6);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(274, 23);
            this.titulo.TabIndex = 20;
            this.titulo.Text = "Registrar y Consultar Películas";
            // 
            // pelicula
            // 
            this.pelicula.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pelicula.ForeColor = System.Drawing.Color.Black;
            this.pelicula.Location = new System.Drawing.Point(69, 147);
            this.pelicula.Name = "pelicula";
            this.pelicula.Size = new System.Drawing.Size(152, 26);
            this.pelicula.TabIndex = 1;
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textNombre.Location = new System.Drawing.Point(65, 123);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(155, 18);
            this.textNombre.TabIndex = 18;
            this.textNombre.Text = "Nombre de la Película";
            // 
            // dataPeliculas
            // 
            this.dataPeliculas.AllowUserToAddRows = false;
            this.dataPeliculas.AllowUserToDeleteRows = false;
            this.dataPeliculas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna2,
            this.columna3,
            this.columna4,
            this.columna5,
            this.columna16,
            this.columna7});
            this.dataPeliculas.Location = new System.Drawing.Point(45, 313);
            this.dataPeliculas.Name = "dataPeliculas";
            this.dataPeliculas.ReadOnly = true;
            this.dataPeliculas.RowHeadersVisible = false;
            this.dataPeliculas.Size = new System.Drawing.Size(782, 234);
            this.dataPeliculas.TabIndex = 54;
            // 
            // titulo2
            // 
            this.titulo2.AutoSize = true;
            this.titulo2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.titulo2.Location = new System.Drawing.Point(356, 276);
            this.titulo2.Name = "titulo2";
            this.titulo2.Size = new System.Drawing.Size(160, 23);
            this.titulo2.TabIndex = 55;
            this.titulo2.Text = "Lista de Películas";
            // 
            // columna1
            // 
            this.columna1.Frozen = true;
            this.columna1.HeaderText = "ID";
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            this.columna1.Width = 40;
            // 
            // columna2
            // 
            this.columna2.Frozen = true;
            this.columna2.HeaderText = "Película";
            this.columna2.Name = "columna2";
            this.columna2.ReadOnly = true;
            this.columna2.Width = 170;
            // 
            // columna3
            // 
            this.columna3.Frozen = true;
            this.columna3.HeaderText = "ID Categoría";
            this.columna3.Name = "columna3";
            this.columna3.ReadOnly = true;
            // 
            // columna4
            // 
            this.columna4.Frozen = true;
            this.columna4.HeaderText = "Categoría";
            this.columna4.Name = "columna4";
            this.columna4.ReadOnly = true;
            this.columna4.Width = 118;
            // 
            // columna5
            // 
            this.columna5.Frozen = true;
            this.columna5.HeaderText = "Descripción Categoría";
            this.columna5.Name = "columna5";
            this.columna5.ReadOnly = true;
            this.columna5.Width = 200;
            // 
            // columna16
            // 
            this.columna16.Frozen = true;
            this.columna16.HeaderText = "Año";
            this.columna16.Name = "columna16";
            this.columna16.ReadOnly = true;
            this.columna16.Width = 50;
            // 
            // columna7
            // 
            this.columna7.Frozen = true;
            this.columna7.HeaderText = "Idioma";
            this.columna7.Name = "columna7";
            this.columna7.ReadOnly = true;
            // 
            // registrarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(878, 584);
            this.Controls.Add(this.titulo2);
            this.Controls.Add(this.dataPeliculas);
            this.Controls.Add(this.idioma);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.pelicula);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textIdioma);
            this.Controls.Add(this.textAnio);
            this.Controls.Add(this.textCategoria);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.textNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrarPelicula";
            this.Text = "registrarPelicula";
            this.Load += new System.EventHandler(this.registrarPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textID;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox idioma;
        private System.Windows.Forms.Label textIdioma;
        private System.Windows.Forms.TextBox anio;
        private System.Windows.Forms.Label textAnio;
        private System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.Label textCategoria;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox pelicula;
        private System.Windows.Forms.Label textNombre;
        private System.Windows.Forms.DataGridView dataPeliculas;
        private System.Windows.Forms.Label titulo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna16;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna7;
    }
}