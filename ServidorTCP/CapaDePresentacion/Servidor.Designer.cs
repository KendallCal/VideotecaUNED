namespace CapaDePresentacion
{
    partial class Servidor
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
            this.contenedorInformacion = new System.Windows.Forms.Panel();
            this.groupInformacion = new System.Windows.Forms.GroupBox();
            this.estado = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.Label();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panelBitacora = new System.Windows.Forms.Panel();
            this.panelConectados = new System.Windows.Forms.Panel();
            this.conectados = new System.Windows.Forms.ListBox();
            this.textBitacora = new System.Windows.Forms.Label();
            this.textConectados = new System.Windows.Forms.Label();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.bitacora = new System.Windows.Forms.TextBox();
            this.contenedorInformacion.SuspendLayout();
            this.groupInformacion.SuspendLayout();
            this.panelBitacora.SuspendLayout();
            this.panelConectados.SuspendLayout();
            this.contenedorDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(1)))));
            this.titulo.Location = new System.Drawing.Point(394, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(83, 23);
            this.titulo.TabIndex = 46;
            this.titulo.Text = "Servidor";
            // 
            // contenedorInformacion
            // 
            this.contenedorInformacion.Controls.Add(this.groupInformacion);
            this.contenedorInformacion.Controls.Add(this.btnDetener);
            this.contenedorInformacion.Controls.Add(this.btnIniciar);
            this.contenedorInformacion.Location = new System.Drawing.Point(144, 48);
            this.contenedorInformacion.Name = "contenedorInformacion";
            this.contenedorInformacion.Size = new System.Drawing.Size(582, 124);
            this.contenedorInformacion.TabIndex = 47;
            // 
            // groupInformacion
            // 
            this.groupInformacion.Controls.Add(this.estado);
            this.groupInformacion.Controls.Add(this.textEstado);
            this.groupInformacion.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInformacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupInformacion.Location = new System.Drawing.Point(15, 10);
            this.groupInformacion.Name = "groupInformacion";
            this.groupInformacion.Size = new System.Drawing.Size(403, 100);
            this.groupInformacion.TabIndex = 11;
            this.groupInformacion.TabStop = false;
            this.groupInformacion.Text = "Información del Servidor";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.ForeColor = System.Drawing.Color.Red;
            this.estado.Location = new System.Drawing.Point(78, 46);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(77, 18);
            this.estado.TabIndex = 1;
            this.estado.Text = "Sin iniciar.";
            // 
            // textEstado
            // 
            this.textEstado.AutoSize = true;
            this.textEstado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.textEstado.Location = new System.Drawing.Point(15, 46);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(57, 18);
            this.textEstado.TabIndex = 0;
            this.textEstado.Text = "Estado:";
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetener.Enabled = false;
            this.btnDetener.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDetener.Location = new System.Drawing.Point(438, 74);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(131, 36);
            this.btnDetener.TabIndex = 10;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            this.btnDetener.MouseEnter += new System.EventHandler(this.btnDetener_MouseEnter);
            this.btnDetener.MouseLeave += new System.EventHandler(this.btnDetener_MouseLeave);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciar.Location = new System.Drawing.Point(438, 19);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(131, 36);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            this.btnIniciar.MouseEnter += new System.EventHandler(this.btnIniciar_MouseEnter);
            this.btnIniciar.MouseLeave += new System.EventHandler(this.btnIniciar_MouseLeave);
            // 
            // panelBitacora
            // 
            this.panelBitacora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBitacora.Controls.Add(this.bitacora);
            this.panelBitacora.Location = new System.Drawing.Point(16, 15);
            this.panelBitacora.Name = "panelBitacora";
            this.panelBitacora.Size = new System.Drawing.Size(334, 369);
            this.panelBitacora.TabIndex = 48;
            // 
            // panelConectados
            // 
            this.panelConectados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConectados.Controls.Add(this.conectados);
            this.panelConectados.Location = new System.Drawing.Point(381, 15);
            this.panelConectados.Name = "panelConectados";
            this.panelConectados.Size = new System.Drawing.Size(334, 369);
            this.panelConectados.TabIndex = 49;
            // 
            // conectados
            // 
            this.conectados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.conectados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conectados.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.conectados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.conectados.FormattingEnabled = true;
            this.conectados.ItemHeight = 15;
            this.conectados.Location = new System.Drawing.Point(14, 23);
            this.conectados.Name = "conectados";
            this.conectados.Size = new System.Drawing.Size(305, 330);
            this.conectados.TabIndex = 2;
            // 
            // textBitacora
            // 
            this.textBitacora.AutoSize = true;
            this.textBitacora.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBitacora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBitacora.Location = new System.Drawing.Point(111, 6);
            this.textBitacora.Name = "textBitacora";
            this.textBitacora.Size = new System.Drawing.Size(142, 18);
            this.textBitacora.TabIndex = 0;
            this.textBitacora.Text = "Bitacora de Eventos";
            // 
            // textConectados
            // 
            this.textConectados.AutoSize = true;
            this.textConectados.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConectados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textConectados.Location = new System.Drawing.Point(474, 6);
            this.textConectados.Name = "textConectados";
            this.textConectados.Size = new System.Drawing.Size(148, 18);
            this.textConectados.TabIndex = 50;
            this.textConectados.Text = "Clientes Conectados";
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.Controls.Add(this.textBitacora);
            this.contenedorDatos.Controls.Add(this.textConectados);
            this.contenedorDatos.Controls.Add(this.panelConectados);
            this.contenedorDatos.Controls.Add(this.panelBitacora);
            this.contenedorDatos.Location = new System.Drawing.Point(67, 188);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(736, 400);
            this.contenedorDatos.TabIndex = 51;
            // 
            // bitacora
            // 
            this.bitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bitacora.Enabled = false;
            this.bitacora.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.bitacora.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.bitacora.Location = new System.Drawing.Point(14, 23);
            this.bitacora.Multiline = true;
            this.bitacora.Name = "bitacora";
            this.bitacora.Size = new System.Drawing.Size(305, 330);
            this.bitacora.TabIndex = 3;
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(878, 584);
            this.Controls.Add(this.contenedorInformacion);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.contenedorDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servidor";
            this.Text = "Servidor";
            this.contenedorInformacion.ResumeLayout(false);
            this.groupInformacion.ResumeLayout(false);
            this.groupInformacion.PerformLayout();
            this.panelBitacora.ResumeLayout(false);
            this.panelBitacora.PerformLayout();
            this.panelConectados.ResumeLayout(false);
            this.contenedorDatos.ResumeLayout(false);
            this.contenedorDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel contenedorInformacion;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox groupInformacion;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label textEstado;
        private System.Windows.Forms.Panel panelBitacora;
        private System.Windows.Forms.Panel panelConectados;
        private System.Windows.Forms.Label textBitacora;
        private System.Windows.Forms.Label textConectados;
        private System.Windows.Forms.Panel contenedorDatos;
        private System.Windows.Forms.ListBox conectados;
        private System.Windows.Forms.TextBox bitacora;
    }
}