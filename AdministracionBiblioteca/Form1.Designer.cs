namespace AdministracionBiblioteca
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
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.pcbLibro = new System.Windows.Forms.PictureBox();
            this.pbxFotoAutor = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnModificarLibro = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(316, 12);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(537, 418);
            this.dgvLibros.TabIndex = 0;
            this.dgvLibros.SelectionChanged += new System.EventHandler(this.dgvLibros_SelectionChanged);
            // 
            // pcbLibro
            // 
            this.pcbLibro.Location = new System.Drawing.Point(23, 12);
            this.pcbLibro.Name = "pcbLibro";
            this.pcbLibro.Size = new System.Drawing.Size(264, 339);
            this.pcbLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLibro.TabIndex = 1;
            this.pcbLibro.TabStop = false;
            // 
            // pbxFotoAutor
            // 
            this.pbxFotoAutor.Location = new System.Drawing.Point(23, 367);
            this.pbxFotoAutor.Name = "pbxFotoAutor";
            this.pbxFotoAutor.Size = new System.Drawing.Size(264, 205);
            this.pbxFotoAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFotoAutor.TabIndex = 2;
            this.pbxFotoAutor.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(359, 451);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "AGREGAR LIBRO";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(359, 522);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(157, 50);
            this.btnEliminarLibro.TabIndex = 4;
            this.btnEliminarLibro.Text = "ELIMINAR LIBRO";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.Location = new System.Drawing.Point(630, 451);
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.Size = new System.Drawing.Size(157, 50);
            this.btnModificarLibro.TabIndex = 5;
            this.btnModificarLibro.Text = "MODIFICAR LIBRO";
            this.btnModificarLibro.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(630, 522);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(157, 50);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "CERRAR APP";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(876, 618);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnModificarLibro);
            this.Controls.Add(this.btnEliminarLibro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxFotoAutor);
            this.Controls.Add(this.pcbLibro);
            this.Controls.Add(this.dgvLibros);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.PictureBox pcbLibro;
        private System.Windows.Forms.PictureBox pbxFotoAutor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnModificarLibro;
        private System.Windows.Forms.Button btnCerrar;
    }
}

