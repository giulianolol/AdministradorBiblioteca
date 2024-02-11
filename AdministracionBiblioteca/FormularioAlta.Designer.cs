namespace AdministracionBiblioteca
{
    partial class FormularioAltaLibro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.txbGenero = new System.Windows.Forms.TextBox();
            this.txbAñoPublicado = new System.Windows.Forms.TextBox();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.txbUrlPortada = new System.Windows.Forms.TextBox();
            this.txbUrlAutor = new System.Windows.Forms.TextBox();
            this.btnAgregarAlta = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.pcbLibro = new System.Windows.Forms.PictureBox();
            this.pcbAutor = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(101, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(101, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label3.Location = new System.Drawing.Point(91, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(51, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año Publicado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label5.Location = new System.Drawing.Point(101, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label6.Location = new System.Drawing.Point(34, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Url Foto Portada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label7.Location = new System.Drawing.Point(51, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Url Foto Autor:";
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(150, 33);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(143, 20);
            this.txbTitulo.TabIndex = 7;
            // 
            // txbAutor
            // 
            this.txbAutor.Location = new System.Drawing.Point(150, 78);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(143, 20);
            this.txbAutor.TabIndex = 8;
            // 
            // txbGenero
            // 
            this.txbGenero.Location = new System.Drawing.Point(150, 122);
            this.txbGenero.Name = "txbGenero";
            this.txbGenero.Size = new System.Drawing.Size(143, 20);
            this.txbGenero.TabIndex = 9;
            // 
            // txbAñoPublicado
            // 
            this.txbAñoPublicado.Location = new System.Drawing.Point(150, 167);
            this.txbAñoPublicado.Name = "txbAñoPublicado";
            this.txbAñoPublicado.Size = new System.Drawing.Size(143, 20);
            this.txbAñoPublicado.TabIndex = 10;
            this.txbAñoPublicado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAñoPublicado_KeyPress);
            // 
            // txbStock
            // 
            this.txbStock.Location = new System.Drawing.Point(150, 213);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(143, 20);
            this.txbStock.TabIndex = 11;
            this.txbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbStock_KeyPress);
            // 
            // txbUrlPortada
            // 
            this.txbUrlPortada.Location = new System.Drawing.Point(150, 258);
            this.txbUrlPortada.Name = "txbUrlPortada";
            this.txbUrlPortada.Size = new System.Drawing.Size(143, 20);
            this.txbUrlPortada.TabIndex = 12;
            this.txbUrlPortada.Leave += new System.EventHandler(this.txbUrlPortada_Leave);
            // 
            // txbUrlAutor
            // 
            this.txbUrlAutor.Location = new System.Drawing.Point(150, 303);
            this.txbUrlAutor.Name = "txbUrlAutor";
            this.txbUrlAutor.Size = new System.Drawing.Size(143, 20);
            this.txbUrlAutor.TabIndex = 13;
            this.txbUrlAutor.Leave += new System.EventHandler(this.txbUrlAutor_Leave);
            // 
            // btnAgregarAlta
            // 
            this.btnAgregarAlta.Location = new System.Drawing.Point(94, 381);
            this.btnAgregarAlta.Name = "btnAgregarAlta";
            this.btnAgregarAlta.Size = new System.Drawing.Size(148, 61);
            this.btnAgregarAlta.TabIndex = 14;
            this.btnAgregarAlta.Text = "ACEPTAR";
            this.btnAgregarAlta.UseVisualStyleBackColor = true;
            this.btnAgregarAlta.Click += new System.EventHandler(this.btnAgregarAlta_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(94, 476);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(148, 61);
            this.btnCancelarAlta.TabIndex = 15;
            this.btnCancelarAlta.Text = "CANCELAR";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // pcbLibro
            // 
            this.pcbLibro.Location = new System.Drawing.Point(326, 36);
            this.pcbLibro.Name = "pcbLibro";
            this.pcbLibro.Size = new System.Drawing.Size(254, 283);
            this.pcbLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLibro.TabIndex = 16;
            this.pcbLibro.TabStop = false;
            // 
            // pcbAutor
            // 
            this.pcbAutor.Location = new System.Drawing.Point(327, 354);
            this.pcbAutor.Name = "pcbAutor";
            this.pcbAutor.Size = new System.Drawing.Size(254, 177);
            this.pcbAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAutor.TabIndex = 17;
            this.pcbAutor.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Portada:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(330, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Autor:";
            // 
            // FormularioAltaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(593, 558);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pcbAutor);
            this.Controls.Add(this.pcbLibro);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.btnAgregarAlta);
            this.Controls.Add(this.txbUrlAutor);
            this.Controls.Add(this.txbUrlPortada);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.txbAñoPublicado);
            this.Controls.Add(this.txbGenero);
            this.Controls.Add(this.txbAutor);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioAltaLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Agregar Libro";
            this.Load += new System.EventHandler(this.FormularioAltaLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.TextBox txbAutor;
        private System.Windows.Forms.TextBox txbGenero;
        private System.Windows.Forms.TextBox txbAñoPublicado;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.TextBox txbUrlPortada;
        private System.Windows.Forms.TextBox txbUrlAutor;
        private System.Windows.Forms.Button btnAgregarAlta;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.PictureBox pcbLibro;
        private System.Windows.Forms.PictureBox pcbAutor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}