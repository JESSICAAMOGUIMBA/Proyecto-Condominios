namespace ModernGUI_V3
{
    partial class Form2
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.LblFechaPago = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblFraccionPagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FACTURAS DEL SERVICIO DE AGUA";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(406, 71);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(111, 33);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtras.Location = new System.Drawing.Point(406, 230);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(111, 33);
            this.BtnAtras.TabIndex = 10;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.UseWaitCursor = true;
            // 
            // LblFechaPago
            // 
            this.LblFechaPago.AutoSize = true;
            this.LblFechaPago.Location = new System.Drawing.Point(13, 59);
            this.LblFechaPago.Name = "LblFechaPago";
            this.LblFechaPago.Size = new System.Drawing.Size(106, 17);
            this.LblFechaPago.TabIndex = 11;
            this.LblFechaPago.Text = "Fecha del pago";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(12, 123);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(155, 17);
            this.LblTotal.TabIndex = 12;
            this.LblTotal.Text = "Valor total de la planilla";
            // 
            // LblFraccionPagar
            // 
            this.LblFraccionPagar.AutoSize = true;
            this.LblFraccionPagar.Location = new System.Drawing.Point(9, 186);
            this.LblFraccionPagar.Name = "LblFraccionPagar";
            this.LblFraccionPagar.Size = new System.Drawing.Size(115, 17);
            this.LblFraccionPagar.TabIndex = 13;
            this.LblFraccionPagar.Text = "Fracción a pagar";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 330);
            this.Controls.Add(this.LblFraccionPagar);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblFechaPago);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Label LblFechaPago;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblFraccionPagar;
    }
}