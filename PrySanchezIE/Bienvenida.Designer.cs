namespace PrySanchezIE
{
    partial class frmLogo
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
            this.components = new System.ComponentModel.Container();
            this.barraDeCarga = new System.Windows.Forms.ProgressBar();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barraDeCarga
            // 
            this.barraDeCarga.Location = new System.Drawing.Point(214, 415);
            this.barraDeCarga.Name = "barraDeCarga";
            this.barraDeCarga.Size = new System.Drawing.Size(370, 23);
            this.barraDeCarga.TabIndex = 1;
            this.barraDeCarga.Click += new System.EventHandler(this.barraDeCarga_Click);
            // 
            // reloj
            // 
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // frmLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrySanchezIE.Properties.Resources.imagenseguro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barraDeCarga);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestion";
            this.Load += new System.EventHandler(this.frmLogo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar barraDeCarga;
        private System.Windows.Forms.Timer reloj;
    }
}

