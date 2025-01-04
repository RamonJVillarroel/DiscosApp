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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Url de la imagen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "cantidad de canciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de lanzamiento";
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(107, 55);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(100, 20);
            this.txttitulo.TabIndex = 4;
            // 
            // txtCanciones
            // 
            this.txtCanciones.Location = new System.Drawing.Point(152, 94);
            this.txtCanciones.Name = "txtCanciones";
            this.txtCanciones.Size = new System.Drawing.Size(100, 20);
            this.txtCanciones.TabIndex = 5;
            // 
            // txtUrlimagen
            // 
            this.txtUrlimagen.Location = new System.Drawing.Point(120, 129);
            this.txtUrlimagen.Name = "txtUrlimagen";
            this.txtUrlimagen.Size = new System.Drawing.Size(100, 20);
            this.txtUrlimagen.TabIndex = 6;
            // 
            // sendDisco
            // 
            this.sendDisco.Location = new System.Drawing.Point(52, 242);
            this.sendDisco.Name = "sendDisco";
            this.sendDisco.Size = new System.Drawing.Size(75, 23);
            this.sendDisco.TabIndex = 9;
            this.sendDisco.Text = "Enviar Disco";
            this.sendDisco.UseVisualStyleBackColor = true;
            this.sendDisco.Click += new System.EventHandler(this.sendDisco_Click);
            // 
            // CancelarDisco
            // 
            this.CancelarDisco.Location = new System.Drawing.Point(172, 243);
            this.CancelarDisco.Name = "CancelarDisco";
            this.CancelarDisco.Size = new System.Drawing.Size(75, 23);
            this.CancelarDisco.TabIndex = 10;
            this.CancelarDisco.Text = "cancelar";
            this.CancelarDisco.UseVisualStyleBackColor = true;
            this.CancelarDisco.Click += new System.EventHandler(this.CancelarDisco_Click);
            // 
            // AddDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 278);
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
            this.Name = "AddDisco";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AÑADE UN NUEVO DISCO";
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
    }
}