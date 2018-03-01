namespace Practica_2
{
    partial class Form1
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
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.opfabrir = new System.Windows.Forms.OpenFileDialog();
            this.cmdxml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtimagen
            // 
            this.txtimagen.Location = new System.Drawing.Point(157, 72);
            this.txtimagen.Multiline = true;
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(351, 386);
            this.txtimagen.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "SELECCIONAR!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opfabrir
            // 
            this.opfabrir.FileName = "openFileDialog1";
            // 
            // cmdxml
            // 
            this.cmdxml.Location = new System.Drawing.Point(685, 484);
            this.cmdxml.Name = "cmdxml";
            this.cmdxml.Size = new System.Drawing.Size(143, 57);
            this.cmdxml.TabIndex = 2;
            this.cmdxml.Text = "Crear Agenda";
            this.cmdxml.UseVisualStyleBackColor = true;
            this.cmdxml.Click += new System.EventHandler(this.cmdxml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 553);
            this.Controls.Add(this.cmdxml);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtimagen);
            this.Name = "Form1";
            this.Text = "Archivo BMP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog opfabrir;
        private System.Windows.Forms.Button cmdxml;
    }
}

