namespace ModernGUI_V3
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblNombreArrendatario = new System.Windows.Forms.Label();
            this.LblApellidoArrendatario = new System.Windows.Forms.Label();
            this.LblNumMiembros = new System.Windows.Forms.Label();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATOS DEL NUEVO ARRENDATARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 22);
            this.textBox3.TabIndex = 4;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(406, 59);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 23);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblNombreArrendatario
            // 
            this.LblNombreArrendatario.AutoSize = true;
            this.LblNombreArrendatario.Location = new System.Drawing.Point(64, 65);
            this.LblNombreArrendatario.Name = "LblNombreArrendatario";
            this.LblNombreArrendatario.Size = new System.Drawing.Size(164, 17);
            this.LblNombreArrendatario.TabIndex = 10;
            this.LblNombreArrendatario.Text = "Nombre del Arrendatario";
            this.LblNombreArrendatario.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblApellidoArrendatario
            // 
            this.LblApellidoArrendatario.AutoSize = true;
            this.LblApellidoArrendatario.Location = new System.Drawing.Point(64, 129);
            this.LblApellidoArrendatario.Name = "LblApellidoArrendatario";
            this.LblApellidoArrendatario.Size = new System.Drawing.Size(164, 17);
            this.LblApellidoArrendatario.TabIndex = 11;
            this.LblApellidoArrendatario.Text = "Apellido del Arrendatario";
            // 
            // LblNumMiembros
            // 
            this.LblNumMiembros.AutoSize = true;
            this.LblNumMiembros.Location = new System.Drawing.Point(64, 205);
            this.LblNumMiembros.Name = "LblNumMiembros";
            this.LblNumMiembros.Size = new System.Drawing.Size(168, 17);
            this.LblNumMiembros.TabIndex = 12;
            this.LblNumMiembros.Text = "N° Miembros de la familia";
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(406, 236);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(92, 23);
            this.BtnAtras.TabIndex = 13;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 341);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.LblNumMiembros);
            this.Controls.Add(this.LblApellidoArrendatario);
            this.Controls.Add(this.LblNombreArrendatario);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblNombreArrendatario;
        private System.Windows.Forms.Label LblApellidoArrendatario;
        private System.Windows.Forms.Label LblNumMiembros;
        private System.Windows.Forms.Button BtnAtras;
    }
}