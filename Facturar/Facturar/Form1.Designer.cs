namespace Facturar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.EntradaProducto1 = new System.Windows.Forms.TextBox();
            this.EntradaProducto2 = new System.Windows.Forms.TextBox();
            this.MuestraSubtotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.EntradaProducto3 = new System.Windows.Forms.TextBox();
            this.LabelProducto1 = new System.Windows.Forms.Label();
            this.LabelProducto2 = new System.Windows.Forms.Label();
            this.LabelProducto3 = new System.Windows.Forms.Label();
            this.MuestraIva = new System.Windows.Forms.TextBox();
            this.MuestraTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EntradaProducto1
            // 
            this.EntradaProducto1.Location = new System.Drawing.Point(135, 22);
            this.EntradaProducto1.Name = "EntradaProducto1";
            this.EntradaProducto1.Size = new System.Drawing.Size(113, 20);
            this.EntradaProducto1.TabIndex = 0;
            // 
            // EntradaProducto2
            // 
            this.EntradaProducto2.Location = new System.Drawing.Point(135, 48);
            this.EntradaProducto2.Name = "EntradaProducto2";
            this.EntradaProducto2.Size = new System.Drawing.Size(113, 20);
            this.EntradaProducto2.TabIndex = 1;
            // 
            // MuestraSubtotal
            // 
            this.MuestraSubtotal.Location = new System.Drawing.Point(135, 114);
            this.MuestraSubtotal.Name = "MuestraSubtotal";
            this.MuestraSubtotal.ReadOnly = true;
            this.MuestraSubtotal.Size = new System.Drawing.Size(113, 20);
            this.MuestraSubtotal.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "FACTURAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "LIMPIAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EntradaProducto3
            // 
            this.EntradaProducto3.Location = new System.Drawing.Point(135, 74);
            this.EntradaProducto3.Name = "EntradaProducto3";
            this.EntradaProducto3.Size = new System.Drawing.Size(113, 20);
            this.EntradaProducto3.TabIndex = 6;
            this.EntradaProducto3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // LabelProducto1
            // 
            this.LabelProducto1.AutoSize = true;
            this.LabelProducto1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LabelProducto1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelProducto1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LabelProducto1.Location = new System.Drawing.Point(34, 22);
            this.LabelProducto1.Name = "LabelProducto1";
            this.LabelProducto1.Size = new System.Drawing.Size(76, 15);
            this.LabelProducto1.TabIndex = 7;
            this.LabelProducto1.Text = "PRODUCTO1";
            this.LabelProducto1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelProducto2
            // 
            this.LabelProducto2.AutoSize = true;
            this.LabelProducto2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LabelProducto2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelProducto2.Location = new System.Drawing.Point(34, 51);
            this.LabelProducto2.Name = "LabelProducto2";
            this.LabelProducto2.Size = new System.Drawing.Size(76, 15);
            this.LabelProducto2.TabIndex = 8;
            this.LabelProducto2.Text = "PRODUCTO2";
            // 
            // LabelProducto3
            // 
            this.LabelProducto3.AutoSize = true;
            this.LabelProducto3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LabelProducto3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelProducto3.Location = new System.Drawing.Point(34, 81);
            this.LabelProducto3.Name = "LabelProducto3";
            this.LabelProducto3.Size = new System.Drawing.Size(76, 15);
            this.LabelProducto3.TabIndex = 9;
            this.LabelProducto3.Text = "PRODUCTO3";
            // 
            // MuestraIva
            // 
            this.MuestraIva.Location = new System.Drawing.Point(135, 140);
            this.MuestraIva.Name = "MuestraIva";
            this.MuestraIva.ReadOnly = true;
            this.MuestraIva.Size = new System.Drawing.Size(113, 20);
            this.MuestraIva.TabIndex = 10;
            // 
            // MuestraTotal
            // 
            this.MuestraTotal.Location = new System.Drawing.Point(135, 166);
            this.MuestraTotal.Name = "MuestraTotal";
            this.MuestraTotal.ReadOnly = true;
            this.MuestraTotal.Size = new System.Drawing.Size(113, 20);
            this.MuestraTotal.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(34, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "SUBTOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(34, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "TOTAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Facturar.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MuestraTotal);
            this.Controls.Add(this.MuestraIva);
            this.Controls.Add(this.LabelProducto3);
            this.Controls.Add(this.LabelProducto2);
            this.Controls.Add(this.LabelProducto1);
            this.Controls.Add(this.EntradaProducto3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MuestraSubtotal);
            this.Controls.Add(this.EntradaProducto2);
            this.Controls.Add(this.EntradaProducto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EntradaProducto1;
        private System.Windows.Forms.TextBox EntradaProducto2;
        private System.Windows.Forms.TextBox MuestraSubtotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox EntradaProducto3;
        private System.Windows.Forms.Label LabelProducto1;
        private System.Windows.Forms.Label LabelProducto2;
        private System.Windows.Forms.Label LabelProducto3;
        private System.Windows.Forms.TextBox MuestraIva;
        private System.Windows.Forms.TextBox MuestraTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}

