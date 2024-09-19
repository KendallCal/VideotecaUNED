namespace ClienteTCP
{
    partial class PrestamoPeliculas
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
            this.titulo = new System.Windows.Forms.Label();
            this.sucursal = new System.Windows.Forms.ComboBox();
            this.textSucursal = new System.Windows.Forms.Label();
            this.dataPeliculas = new System.Windows.Forms.DataGridView();
            this.columna0 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textPeliculas = new System.Windows.Forms.Label();
            this.btnRealizarPrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.titulo.Location = new System.Drawing.Point(313, 48);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(201, 23);
            this.titulo.TabIndex = 46;
            this.titulo.Text = "Préstamo de Películas";
            // 
            // sucursal
            // 
            this.sucursal.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucursal.FormattingEnabled = true;
            this.sucursal.Location = new System.Drawing.Point(337, 131);
            this.sucursal.Name = "sucursal";
            this.sucursal.Size = new System.Drawing.Size(152, 26);
            this.sucursal.TabIndex = 52;
            this.sucursal.SelectedIndexChanged += new System.EventHandler(this.sucursal_SelectedIndexChanged);
            // 
            // textSucursal
            // 
            this.textSucursal.AutoSize = true;
            this.textSucursal.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSucursal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textSucursal.Location = new System.Drawing.Point(380, 103);
            this.textSucursal.Name = "textSucursal";
            this.textSucursal.Size = new System.Drawing.Size(66, 18);
            this.textSucursal.TabIndex = 53;
            this.textSucursal.Text = "Sucursal";
            // 
            // dataPeliculas
            // 
            this.dataPeliculas.AllowUserToOrderColumns = true;
            this.dataPeliculas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna0,
            this.columna1,
            this.columna2,
            this.columna3,
            this.columna4,
            this.columna5});
            this.dataPeliculas.Location = new System.Drawing.Point(163, 212);
            this.dataPeliculas.Name = "dataPeliculas";
            this.dataPeliculas.RowHeadersVisible = false;
            this.dataPeliculas.Size = new System.Drawing.Size(500, 217);
            this.dataPeliculas.TabIndex = 54;
           
            // 
            // columna0
            // 
            this.columna0.Frozen = true;
            this.columna0.HeaderText = "Seleccione";
            this.columna0.Name = "columna0";
            this.columna0.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columna0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columna0.Width = 70;
            // 
            // columna1
            // 
            this.columna1.Frozen = true;
            this.columna1.HeaderText = "ID";
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            this.columna1.Width = 50;
            // 
            // columna2
            // 
            this.columna2.Frozen = true;
            this.columna2.HeaderText = "Película";
            this.columna2.Name = "columna2";
            this.columna2.ReadOnly = true;
            this.columna2.Width = 130;
            // 
            // columna3
            // 
            this.columna3.Frozen = true;
            this.columna3.HeaderText = "Categoría";
            this.columna3.Name = "columna3";
            this.columna3.ReadOnly = true;
            // 
            // columna4
            // 
            this.columna4.Frozen = true;
            this.columna4.HeaderText = "Año";
            this.columna4.Name = "columna4";
            this.columna4.ReadOnly = true;
            this.columna4.Width = 50;
            // 
            // columna5
            // 
            this.columna5.Frozen = true;
            this.columna5.HeaderText = "Idioma";
            this.columna5.Name = "columna5";
            this.columna5.ReadOnly = true;
            // 
            // textPeliculas
            // 
            this.textPeliculas.AutoSize = true;
            this.textPeliculas.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPeliculas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textPeliculas.Location = new System.Drawing.Point(379, 185);
            this.textPeliculas.Name = "textPeliculas";
            this.textPeliculas.Size = new System.Drawing.Size(69, 18);
            this.textPeliculas.TabIndex = 55;
            this.textPeliculas.Text = "Películas";
            // 
            // btnRealizarPrestamo
            // 
            this.btnRealizarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnRealizarPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRealizarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRealizarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarPrestamo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPrestamo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRealizarPrestamo.Location = new System.Drawing.Point(320, 478);
            this.btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            this.btnRealizarPrestamo.Size = new System.Drawing.Size(187, 35);
            this.btnRealizarPrestamo.TabIndex = 56;
            this.btnRealizarPrestamo.Text = "Realizar Préstano";
            this.btnRealizarPrestamo.UseVisualStyleBackColor = false;
            this.btnRealizarPrestamo.Click += new System.EventHandler(this.btnRealizarPrestamo_Click);
            this.btnRealizarPrestamo.MouseEnter += new System.EventHandler(this.btnRealizarPrestamo_MouseEnter);
            this.btnRealizarPrestamo.MouseLeave += new System.EventHandler(this.btnRealizarPrestamo_MouseLeave);
            // 
            // PrestamoPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(827, 565);
            this.Controls.Add(this.btnRealizarPrestamo);
            this.Controls.Add(this.dataPeliculas);
            this.Controls.Add(this.textPeliculas);
            this.Controls.Add(this.sucursal);
            this.Controls.Add(this.textSucursal);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrestamoPeliculas";
            this.Text = "PrestamoPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.dataPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ComboBox sucursal;
        private System.Windows.Forms.Label textSucursal;
        private System.Windows.Forms.DataGridView dataPeliculas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columna0;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna5;
        private System.Windows.Forms.Label textPeliculas;
        private System.Windows.Forms.Button btnRealizarPrestamo;
    }
}