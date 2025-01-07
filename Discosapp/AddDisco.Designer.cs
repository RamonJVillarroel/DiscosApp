namespace Discosapp
{
    partial class AddDisco
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtCanciones = new System.Windows.Forms.TextBox();
            this.txtUrlimagen = new System.Windows.Forms.TextBox();
            this.sendDisco = new System.Windows.Forms.Button();
            this.CancelarDisco = new System.Windows.Forms.Button();
            this.pboxDisco = new System.Windows.Forms.PictureBox();
            this.cboxGenero = new System.Windows.Forms.ComboBox();
            this.cboxPlataforma = new System.Windows.Forms.ComboBox();
            this.txtGenero = new System.Windows.Forms.Label();
            this.txtPlataforma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Url de la imagen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "cantidad de canciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de lanzamiento";
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(203, 62);
            this.txttitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(132, 22);
            this.txttitulo.TabIndex = 0;
            // 
            // txtCanciones
            // 
            this.txtCanciones.Location = new System.Drawing.Point(203, 116);
            this.txtCanciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtCanciones.Name = "txtCanciones";
            this.txtCanciones.Size = new System.Drawing.Size(132, 22);
            this.txtCanciones.TabIndex = 1;
            // 
            // txtUrlimagen
            // 
            this.txtUrlimagen.Location = new System.Drawing.Point(203, 161);
            this.txtUrlimagen.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrlimagen.Name = "txtUrlimagen";
            this.txtUrlimagen.Size = new System.Drawing.Size(132, 22);
            this.txtUrlimagen.TabIndex = 2;
            this.txtUrlimagen.Leave += new System.EventHandler(this.txtUrlimagen_Leave);
            // 
            // sendDisco
            // 
            this.sendDisco.Location = new System.Drawing.Point(67, 366);
            this.sendDisco.Margin = new System.Windows.Forms.Padding(4);
            this.sendDisco.Name = "sendDisco";
            this.sendDisco.Size = new System.Drawing.Size(100, 28);
            this.sendDisco.TabIndex = 3;
            this.sendDisco.Text = "Enviar Disco";
            this.sendDisco.UseVisualStyleBackColor = true;
            this.sendDisco.Click += new System.EventHandler(this.sendDisco_Click);
            // 
            // CancelarDisco
            // 
            this.CancelarDisco.Location = new System.Drawing.Point(218, 366);
            this.CancelarDisco.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarDisco.Name = "CancelarDisco";
            this.CancelarDisco.Size = new System.Drawing.Size(100, 28);
            this.CancelarDisco.TabIndex = 4;
            this.CancelarDisco.Text = "cancelar";
            this.CancelarDisco.UseVisualStyleBackColor = true;
            this.CancelarDisco.Click += new System.EventHandler(this.CancelarDisco_Click);
            // 
            // pboxDisco
            // 
            this.pboxDisco.Location = new System.Drawing.Point(342, 48);
            this.pboxDisco.Name = "pboxDisco";
            this.pboxDisco.Size = new System.Drawing.Size(203, 181);
            this.pboxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDisco.TabIndex = 11;
            this.pboxDisco.TabStop = false;
            // 
            // cboxGenero
            // 
            this.cboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGenero.FormattingEnabled = true;
            this.cboxGenero.Location = new System.Drawing.Point(203, 210);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.Size = new System.Drawing.Size(133, 24);
            this.cboxGenero.TabIndex = 12;
            // 
            // cboxPlataforma
            // 
            this.cboxPlataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPlataforma.FormattingEnabled = true;
            this.cboxPlataforma.Location = new System.Drawing.Point(203, 255);
            this.cboxPlataforma.Name = "cboxPlataforma";
            this.cboxPlataforma.Size = new System.Drawing.Size(133, 24);
            this.cboxPlataforma.TabIndex = 13;
            // 
            // txtGenero
            // 
            this.txtGenero.AutoSize = true;
            this.txtGenero.Location = new System.Drawing.Point(123, 218);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(52, 16);
            this.txtGenero.TabIndex = 14;
            this.txtGenero.Text = "Genero";
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.AutoSize = true;
            this.txtPlataforma.Location = new System.Drawing.Point(97, 263);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.Size = new System.Drawing.Size(72, 16);
            this.txtPlataforma.TabIndex = 15;
            this.txtPlataforma.Text = "Plataforma";
            // 
            // AddDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 447);
            this.Controls.Add(this.txtPlataforma);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.cboxPlataforma);
            this.Controls.Add(this.cboxGenero);
            this.Controls.Add(this.pboxDisco);
            this.Controls.Add(this.CancelarDisco);
            this.Controls.Add(this.sendDisco);
            this.Controls.Add(this.txtUrlimagen);
            this.Controls.Add(this.txtCanciones);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDisco";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AÑADE UN NUEVO DISCO";
            this.Load += new System.EventHandler(this.AddDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtCanciones;
        private System.Windows.Forms.TextBox txtUrlimagen;
        private System.Windows.Forms.Button sendDisco;
        private System.Windows.Forms.Button CancelarDisco;
        private System.Windows.Forms.PictureBox pboxDisco;
        private System.Windows.Forms.ComboBox cboxGenero;
        private System.Windows.Forms.ComboBox cboxPlataforma;
        private System.Windows.Forms.Label txtGenero;
        private System.Windows.Forms.Label txtPlataforma;
    }
}