namespace MiPrimerAplicacin
{
    partial class btn_SN
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
            this.lbl_ingreseAlgo = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ingreseAlgo
            // 
            this.lbl_ingreseAlgo.AutoSize = true;
            this.lbl_ingreseAlgo.Location = new System.Drawing.Point(65, 93);
            this.lbl_ingreseAlgo.Name = "lbl_ingreseAlgo";
            this.lbl_ingreseAlgo.Size = new System.Drawing.Size(64, 13);
            this.lbl_ingreseAlgo.TabIndex = 1;
            this.lbl_ingreseAlgo.Text = "ingrese algo";
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Cyan;
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn.Image = global::MiPrimerAplicacin.Properties.Resources.play;
            this.btn.Location = new System.Drawing.Point(265, 79);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(56, 40);
            this.btn.TabIndex = 0;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_SN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 253);
            this.Controls.Add(this.lbl_ingreseAlgo);
            this.Controls.Add(this.btn);
            this.Name = "btn_SN";
            this.Opacity = 0.4D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioRosa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.btn_SN_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_SN_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbl_ingreseAlgo;
    }
}

