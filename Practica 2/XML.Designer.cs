namespace Practica_2
{
    partial class XML
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
            this.txtnacimiento = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbldomicilio = new System.Windows.Forms.Label();
            this.lblnacimiento = new System.Windows.Forms.Label();
            this.cmdcrear = new System.Windows.Forms.Button();
            this.sfdguardar = new System.Windows.Forms.SaveFileDialog();
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnacimiento
            // 
            this.txtnacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnacimiento.Location = new System.Drawing.Point(468, 269);
            this.txtnacimiento.Name = "txtnacimiento";
            this.txtnacimiento.Size = new System.Drawing.Size(301, 30);
            this.txtnacimiento.TabIndex = 12;
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttelefono.Location = new System.Drawing.Point(468, 184);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(301, 30);
            this.txttelefono.TabIndex = 11;
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtdomicilio.Location = new System.Drawing.Point(468, 230);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(301, 30);
            this.txtdomicilio.TabIndex = 10;
            // 
            // txtedad
            // 
            this.txtedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtedad.Location = new System.Drawing.Point(468, 144);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(301, 30);
            this.txtedad.TabIndex = 9;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnombre.Location = new System.Drawing.Point(468, 105);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(301, 30);
            this.txtnombre.TabIndex = 8;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblnombre.Location = new System.Drawing.Point(294, 110);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(87, 25);
            this.lblnombre.TabIndex = 13;
            this.lblnombre.Text = "Nombre:";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbledad.Location = new System.Drawing.Point(294, 149);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(64, 25);
            this.lbledad.TabIndex = 14;
            this.lbledad.Text = "Edad:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltelefono.Location = new System.Drawing.Point(294, 189);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(95, 25);
            this.lbltelefono.TabIndex = 15;
            this.lbltelefono.Text = "Telefono:";
            // 
            // lbldomicilio
            // 
            this.lbldomicilio.AutoSize = true;
            this.lbldomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbldomicilio.Location = new System.Drawing.Point(294, 235);
            this.lbldomicilio.Name = "lbldomicilio";
            this.lbldomicilio.Size = new System.Drawing.Size(96, 25);
            this.lbldomicilio.TabIndex = 16;
            this.lbldomicilio.Text = "Domicilio:";
            // 
            // lblnacimiento
            // 
            this.lblnacimiento.AutoSize = true;
            this.lblnacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblnacimiento.Location = new System.Drawing.Point(247, 274);
            this.lblnacimiento.Name = "lblnacimiento";
            this.lblnacimiento.Size = new System.Drawing.Size(197, 25);
            this.lblnacimiento.TabIndex = 17;
            this.lblnacimiento.Text = "Lugar de Nacimiento:";
            // 
            // cmdcrear
            // 
            this.cmdcrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdcrear.Location = new System.Drawing.Point(518, 357);
            this.cmdcrear.Name = "cmdcrear";
            this.cmdcrear.Size = new System.Drawing.Size(183, 61);
            this.cmdcrear.TabIndex = 18;
            this.cmdcrear.Text = "Crear Agenda";
            this.cmdcrear.UseVisualStyleBackColor = true;
            this.cmdcrear.Click += new System.EventHandler(this.cmdcrear_Click);
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Location = new System.Drawing.Point(939, 442);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(113, 47);
            this.cmdcerrar.TabIndex = 19;
            this.cmdcerrar.Text = "Cerrar";
            this.cmdcerrar.UseVisualStyleBackColor = true;
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 515);
            this.Controls.Add(this.cmdcerrar);
            this.Controls.Add(this.cmdcrear);
            this.Controls.Add(this.lblnacimiento);
            this.Controls.Add(this.lbldomicilio);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtnacimiento);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdomicilio);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Name = "XML";
            this.Text = "AGENDA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XML_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnacimiento;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbldomicilio;
        private System.Windows.Forms.Label lblnacimiento;
        private System.Windows.Forms.Button cmdcrear;
        private System.Windows.Forms.SaveFileDialog sfdguardar;
        private System.Windows.Forms.Button cmdcerrar;
    }
}