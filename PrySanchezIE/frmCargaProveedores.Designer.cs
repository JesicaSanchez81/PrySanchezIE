
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaProveedores));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnNivel1 = new System.Windows.Forms.Button();
            this.btnNivel2 = new System.Windows.Forms.Button();
            this.lblContenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(85, 45);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(226, 252);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnNivel1
            // 
            this.btnNivel1.Location = new System.Drawing.Point(135, 313);
            this.btnNivel1.Name = "btnNivel1";
            this.btnNivel1.Size = new System.Drawing.Size(130, 41);
            this.btnNivel1.TabIndex = 1;
            this.btnNivel1.Text = "Mostrar Carpeta";
            this.btnNivel1.UseVisualStyleBackColor = true;
            this.btnNivel1.Click += new System.EventHandler(this.btnNivel1_Click);
            // 
            // btnNivel2
            // 
            this.btnNivel2.Location = new System.Drawing.Point(504, 313);
            this.btnNivel2.Name = "btnNivel2";
            this.btnNivel2.Size = new System.Drawing.Size(130, 50);
            this.btnNivel2.TabIndex = 2;
            this.btnNivel2.Text = "Mostrar Contenido";
            this.btnNivel2.UseVisualStyleBackColor = true;
            this.btnNivel2.Click += new System.EventHandler(this.btnNivel2_Click);
            // 
            // lblContenido
            // 
            this.lblContenido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblContenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContenido.Location = new System.Drawing.Point(446, 45);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(225, 252);
            this.lblContenido.TabIndex = 3;
            // 
            // frmCargaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.btnNivel2);
            this.Controls.Add(this.btnNivel1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga Proveedores";
            this.Load += new System.EventHandler(this.frmCargaProveedores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnNivel1;
        private System.Windows.Forms.Button btnNivel2;
        private System.Windows.Forms.Label lblContenido;
    }
}