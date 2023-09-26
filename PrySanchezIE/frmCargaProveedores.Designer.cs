namespace PrySanchezIE
{
    partial class frmCargaProveedores
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnNivel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(113, 196);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
            // 
            // btnNivel1
            // 
            this.btnNivel1.Location = new System.Drawing.Point(129, 103);
            this.btnNivel1.Name = "btnNivel1";
            this.btnNivel1.Size = new System.Drawing.Size(75, 23);
            this.btnNivel1.TabIndex = 1;
            this.btnNivel1.Text = "Nivel  1";
            this.btnNivel1.UseVisualStyleBackColor = true;
            // 
            // frmCargaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNivel1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmCargaProveedores";
            this.Text = "Carga Proveedores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnNivel1;
    }
}