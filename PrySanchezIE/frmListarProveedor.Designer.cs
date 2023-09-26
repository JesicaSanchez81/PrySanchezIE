namespace PrySanchezIE
{
    partial class frmListarProveedor
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
            this.grilla = new System.Windows.Forms.DataGridView();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtExpendiente = new System.Windows.Forms.TextBox();
            this.txtJuzgado = new System.Windows.Forms.TextBox();
            this.txtJuridiccion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtLiquidador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.grilla.Location = new System.Drawing.Point(12, 225);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(755, 193);
            this.grilla.TabIndex = 1;
            this.grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellContentClick);
            // 
            // btnGrabar
            // 
            this.btnGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnGrabar.Location = new System.Drawing.Point(385, 463);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(49, 44);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(44, 13);
            this.Numero.TabIndex = 3;
            this.Numero.Text = "Nùmero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(31, 103);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(123, 44);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(42, 13);
            this.lblMostrar.TabIndex = 5;
            this.lblMostrar.Text = "Mostrar";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nùmero";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Entidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apertura";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nº Expediente";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Juzgado";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Jurisdicción";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Dirección";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Liquidador responsable";
            this.Column8.Name = "Column8";
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(126, 103);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(100, 20);
            this.txtEntidad.TabIndex = 6;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(223, 103);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(100, 20);
            this.txtApertura.TabIndex = 7;
            // 
            // txtExpendiente
            // 
            this.txtExpendiente.Location = new System.Drawing.Point(319, 103);
            this.txtExpendiente.Name = "txtExpendiente";
            this.txtExpendiente.Size = new System.Drawing.Size(100, 20);
            this.txtExpendiente.TabIndex = 8;
            // 
            // txtJuzgado
            // 
            this.txtJuzgado.Location = new System.Drawing.Point(414, 103);
            this.txtJuzgado.Name = "txtJuzgado";
            this.txtJuzgado.Size = new System.Drawing.Size(100, 20);
            this.txtJuzgado.TabIndex = 9;
            // 
            // txtJuridiccion
            // 
            this.txtJuridiccion.Location = new System.Drawing.Point(508, 103);
            this.txtJuridiccion.Name = "txtJuridiccion";
            this.txtJuridiccion.Size = new System.Drawing.Size(100, 20);
            this.txtJuridiccion.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(604, 103);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtLiquidador
            // 
            this.txtLiquidador.Location = new System.Drawing.Point(688, 103);
            this.txtLiquidador.Name = "txtLiquidador";
            this.txtLiquidador.Size = new System.Drawing.Size(100, 20);
            this.txtLiquidador.TabIndex = 12;
            // 
            // frmListarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 510);
            this.Controls.Add(this.txtLiquidador);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtJuridiccion);
            this.Controls.Add(this.txtJuzgado);
            this.Controls.Add(this.txtExpendiente);
            this.Controls.Add(this.txtApertura);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.grilla);
            this.Name = "frmListarProveedor";
            this.Text = "frmListarProveedor";
            this.Load += new System.EventHandler(this.frmListarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtExpendiente;
        private System.Windows.Forms.TextBox txtJuzgado;
        private System.Windows.Forms.TextBox txtJuridiccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtLiquidador;
    }
}