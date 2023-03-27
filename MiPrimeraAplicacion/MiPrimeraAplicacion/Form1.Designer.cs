
namespace MiPrimeraAplicacion
{
    partial class frmVentana1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentana1));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEtiqueta1 = new System.Windows.Forms.Label();
            this.txtTexto1 = new System.Windows.Forms.TextBox();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(336, 347);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(144, 66);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiqueta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEtiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEtiqueta1.Location = new System.Drawing.Point(319, 263);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(178, 22);
            this.lblEtiqueta1.TabIndex = 1;
            this.lblEtiqueta1.Text = "Esta es una etiqueta";
            this.lblEtiqueta1.MouseLeave += new System.EventHandler(this.lblEtiqueta1_MouseLeave);
            this.lblEtiqueta1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblEtiqueta1_MouseMove);
            // 
            // txtTexto1
            // 
            this.txtTexto1.BackColor = System.Drawing.SystemColors.Control;
            this.txtTexto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTexto1.Location = new System.Drawing.Point(233, 76);
            this.txtTexto1.MaxLength = 50;
            this.txtTexto1.Name = "txtTexto1";
            this.txtTexto1.Size = new System.Drawing.Size(350, 20);
            this.txtTexto1.TabIndex = 2;
            this.txtTexto1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTexto1_KeyPress);
            // 
            // txtTexto2
            // 
            this.txtTexto2.BackColor = System.Drawing.SystemColors.Control;
            this.txtTexto2.Location = new System.Drawing.Point(233, 139);
            this.txtTexto2.Multiline = true;
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexto2.Size = new System.Drawing.Size(350, 58);
            this.txtTexto2.TabIndex = 3;
            this.txtTexto2.Leave += new System.EventHandler(this.txtTexto2_Leave);
            // 
            // frmVentana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTexto2);
            this.Controls.Add(this.txtTexto1);
            this.Controls.Add(this.lblEtiqueta1);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentana1";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Primera Aplicación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVentana1_FormClosed);
            this.Load += new System.EventHandler(this.frmVentana1_Load);
            this.Click += new System.EventHandler(this.frmVentana1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEtiqueta1;
        private System.Windows.Forms.TextBox txtTexto1;
        private System.Windows.Forms.TextBox txtTexto2;
    }
}

