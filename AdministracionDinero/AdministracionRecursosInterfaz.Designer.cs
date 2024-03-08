namespace AdministracionDinero
{
    partial class AdministracionRecursosInterfaz
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
            this.dgvMovmientos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarMovimiento = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovmientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovmientos
            // 
            this.dgvMovmientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovmientos.Location = new System.Drawing.Point(343, 62);
            this.dgvMovmientos.MultiSelect = false;
            this.dgvMovmientos.Name = "dgvMovmientos";
            this.dgvMovmientos.ReadOnly = true;
            this.dgvMovmientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovmientos.Size = new System.Drawing.Size(448, 373);
            this.dgvMovmientos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA MOVIMIENTOS";
            // 
            // btnAgregarMovimiento
            // 
            this.btnAgregarMovimiento.Location = new System.Drawing.Point(32, 78);
            this.btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            this.btnAgregarMovimiento.Size = new System.Drawing.Size(299, 92);
            this.btnAgregarMovimiento.TabIndex = 2;
            this.btnAgregarMovimiento.Text = "AGREGAR MOVIMIENTO";
            this.btnAgregarMovimiento.UseVisualStyleBackColor = true;
            this.btnAgregarMovimiento.Click += new System.EventHandler(this.btnAgregarMovimiento_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 92);
            this.button2.TabIndex = 3;
            this.button2.Text = "MODIFICAR MOVIMIENTO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AdministracionRecursosInterfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarMovimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMovmientos);
            this.Name = "AdministracionRecursosInterfaz";
            this.Text = "AdministracionRecursosInterfaz";
            this.Load += new System.EventHandler(this.AdministracionRecursosInterfaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovmientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovmientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarMovimiento;
        private System.Windows.Forms.Button button2;
    }
}