namespace CapaDePresentacion
{
    partial class registrarCategoria
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.TextBox();
            this.textCategoria = new System.Windows.Forms.Label();
            this.dataCategorias = new System.Windows.Forms.DataGridView();
            this.titulo2 = new System.Windows.Forms.Label();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.AutoSize = true;
            this.textID.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textID.Location = new System.Drawing.Point(138, 57);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(127, 18);
            this.textID.TabIndex = 14;
            this.textID.Text = "ID de la Categoría";
            this.textID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.Location = new System.Drawing.Point(141, 85);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(150, 26);
            this.id.TabIndex = 0;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnRegistrar.Location = new System.Drawing.Point(378, 221);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 35);
            this.btnRegistrar.TabIndex = 3;
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
            this.titulo.Location = new System.Drawing.Point(299, 2);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(278, 23);
            this.titulo.TabIndex = 12;
            this.titulo.Text = "Registrar y Consultar Categoría";
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.ForeColor = System.Drawing.Color.Black;
            this.descripcion.Location = new System.Drawing.Point(392, 85);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(358, 95);
            this.descripcion.TabIndex = 2;
            // 
            // textDescripcion
            // 
            this.textDescripcion.AutoSize = true;
            this.textDescripcion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textDescripcion.Location = new System.Drawing.Point(389, 57);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(193, 18);
            this.textDescripcion.TabIndex = 10;
            this.textDescripcion.Text = "Descripción de la Categoría";
            // 
            // categoria
            // 
            this.categoria.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.ForeColor = System.Drawing.Color.Black;
            this.categoria.Location = new System.Drawing.Point(141, 154);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(150, 26);
            this.categoria.TabIndex = 1;
            this.categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCategoria
            // 
            this.textCategoria.AutoSize = true;
            this.textCategoria.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textCategoria.Location = new System.Drawing.Point(138, 127);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(167, 18);
            this.textCategoria.TabIndex = 8;
            this.textCategoria.Text = "Nombre de la Categoría";
            // 
            // dataCategorias
            // 
            this.dataCategorias.AllowUserToAddRows = false;
            this.dataCategorias.AllowUserToDeleteRows = false;
            this.dataCategorias.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna2,
            this.columna3});
            this.dataCategorias.Location = new System.Drawing.Point(130, 342);
            this.dataCategorias.Name = "dataCategorias";
            this.dataCategorias.ReadOnly = true;
            this.dataCategorias.RowHeadersVisible = false;
            this.dataCategorias.Size = new System.Drawing.Size(616, 217);
            this.dataCategorias.TabIndex = 54;
            // 
            // titulo2
            // 
            this.titulo2.AutoSize = true;
            this.titulo2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.titulo2.Location = new System.Drawing.Point(351, 307);
            this.titulo2.Name = "titulo2";
            this.titulo2.Size = new System.Drawing.Size(174, 23);
            this.titulo2.TabIndex = 55;
            this.titulo2.Text = "Lista de Categorias";
            // 
            // columna1
            // 
            this.columna1.Frozen = true;
            this.columna1.HeaderText = "ID";
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            this.columna1.Width = 80;
            // 
            // columna2
            // 
            this.columna2.Frozen = true;
            this.columna2.HeaderText = "Categoría";
            this.columna2.Name = "columna2";
            this.columna2.ReadOnly = true;
            this.columna2.Width = 130;
            // 
            // columna3
            // 
            this.columna3.Frozen = true;
            this.columna3.HeaderText = "Descripción";
            this.columna3.Name = "columna3";
            this.columna3.ReadOnly = true;
            this.columna3.Width = 400;
            // 
            // registrarCategoriaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(878, 584);
            this.Controls.Add(this.titulo2);
            this.Controls.Add(this.dataCategorias);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.id);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.textCategoria);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrarCategoriaPelicula";
            this.Text = "registrarCategoriaPelicula";
            this.Load += new System.EventHandler(this.registrarCategoriaPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textID;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label textDescripcion;
        private System.Windows.Forms.TextBox categoria;
        private System.Windows.Forms.Label textCategoria;
        private System.Windows.Forms.DataGridView dataCategorias;
        private System.Windows.Forms.Label titulo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
    }
}