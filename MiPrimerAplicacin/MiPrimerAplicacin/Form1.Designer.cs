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
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Cyan;
            this.btn.Image = global::MiPrimerAplicacin.Properties.Resources.pngtree_red_glossy_button_png_image_908890;
            this.btn.Location = new System.Drawing.Point(125, 86);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(237, 107);
            this.btn.TabIndex = 0;
            this.btn.Text = "tocar";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 253);
            this.Controls.Add(this.btn);
            this.Name = "btn_SN";
            this.Opacity = 0.4D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioRosa";
           
            this.Click += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

       
        private System.Windows.Forms.Button btn;
    }
}

