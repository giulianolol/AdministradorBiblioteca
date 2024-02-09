namespace AdministracionBiblioteca
{
    partial class Formulario_Eliminar
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
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.btnEliminarBaja = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(12, 363);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(121, 43);
            this.btnCancelarAlta.TabIndex = 16;
            this.btnCancelarAlta.Text = "CANCELAR";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // btnEliminarBaja
            // 
            this.btnEliminarBaja.Location = new System.Drawing.Point(244, 363);
            this.btnEliminarBaja.Name = "btnEliminarBaja";
            this.btnEliminarBaja.Size = new System.Drawing.Size(126, 43);
            this.btnEliminarBaja.TabIndex = 17;
            this.btnEliminarBaja.Text = "ELIMINAR";
            this.btnEliminarBaja.UseVisualStyleBackColor = true;
            this.btnEliminarBaja.Click += new System.EventHandler(this.btnEliminarBaja_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(18, 24);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(352, 303);
            this.dgvLibros.TabIndex = 18;
            // 
            // Formulario_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.btnEliminarBaja);
            this.Controls.Add(this.btnCancelarAlta);
            this.Name = "Formulario_Eliminar";
            this.Text = "Formulario Eliminar Libro";
            this.Load += new System.EventHandler(this.Formulario_Eliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.Button btnEliminarBaja;
        private System.Windows.Forms.DataGridView dgvLibros;
    }
}