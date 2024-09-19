namespace ClienteTCP
{
    partial class ConsultarPrestamos
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
            this.dataPrestamos = new System.Windows.Forms.DataGridView();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.titulo.Location = new System.Drawing.Point(313, 83);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(201, 23);
            this.titulo.TabIndex = 47;
            this.titulo.Text = "Préstamo de Películas";
            // 
            // dataPrestamos
            // 
            this.dataPrestamos.AllowUserToAddRows = false;
            this.dataPrestamos.AllowUserToDeleteRows = false;
            this.dataPrestamos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna2,
            this.columna3,
            this.columna4,
            this.columna5,
            this.columna6,
            this.columna7,
            this.columna8});
            this.dataPrestamos.Location = new System.Drawing.Point(41, 137);
            this.dataPrestamos.Name = "dataPrestamos";
            this.dataPrestamos.ReadOnly = true;
            this.dataPrestamos.RowHeadersVisible = false;
            this.dataPrestamos.Size = new System.Drawing.Size(745, 349);
            this.dataPrestamos.TabIndex = 55;
            // 
            // columna1
            // 
            this.columna1.HeaderText = "ID Préstamo";
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            this.columna1.Width = 95;
            // 
            // columna2
            // 
            this.columna2.HeaderText = "Fecha Préstamo";
            this.columna2.Name = "columna2";
            this.columna2.ReadOnly = true;
            this.columna2.Width = 120;
            // 
            // columna3
            // 
            this.columna3.HeaderText = "Pendiente Devolución";
            this.columna3.Name = "columna3";
            this.columna3.ReadOnly = true;
            this.columna3.Width = 120;
            // 
            // columna4
            // 
            this.columna4.HeaderText = "ID Película";
            this.columna4.Name = "columna4";
            this.columna4.ReadOnly = true;
            this.columna4.Width = 95;
            // 
            // columna5
            // 
            this.columna5.HeaderText = "Título";
            this.columna5.Name = "columna5";
            this.columna5.ReadOnly = true;
            this.columna5.Width = 200;
            // 
            // columna6
            // 
            this.columna6.HeaderText = "Nombre de la Categoría";
            this.columna6.Name = "columna6";
            this.columna6.ReadOnly = true;
            this.columna6.Width = 150;
            // 
            // columna7
            // 
            this.columna7.HeaderText = "Año de Lanzamiento";
            this.columna7.Name = "columna7";
            this.columna7.ReadOnly = true;
            this.columna7.Width = 120;
            // 
            // columna8
            // 
            this.columna8.HeaderText = "Idioma";
            this.columna8.Name = "columna8";
            this.columna8.ReadOnly = true;
            this.columna8.Width = 120;
            // 
            // ConsultarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(827, 565);
            this.Controls.Add(this.dataPrestamos);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarPrestamos";
            this.Text = "ConsultarPrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.DataGridView dataPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna6;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna7;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna8;
    }
}