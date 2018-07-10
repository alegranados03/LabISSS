namespace Proyecto_isss_seguro
{
    partial class Ingresar_Prueba_BK
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
            this.comboBoxfactorrh = new System.Windows.Forms.ComboBox();
            this.comboBoxgruposanguineo = new System.Windows.Forms.ComboBox();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.textBoxapellidos = new System.Windows.Forms.TextBox();
            this.textBoxnombres = new System.Windows.Forms.TextBox();
            this.textBoxafiliacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxfactorrh
            // 
            this.comboBoxfactorrh.FormattingEnabled = true;
            this.comboBoxfactorrh.Items.AddRange(new object[] {
            "+",
            "-",
            "*"});
            this.comboBoxfactorrh.Location = new System.Drawing.Point(181, 154);
            this.comboBoxfactorrh.Name = "comboBoxfactorrh";
            this.comboBoxfactorrh.Size = new System.Drawing.Size(133, 21);
            this.comboBoxfactorrh.TabIndex = 67;
            // 
            // comboBoxgruposanguineo
            // 
            this.comboBoxgruposanguineo.FormattingEnabled = true;
            this.comboBoxgruposanguineo.Items.AddRange(new object[] {
            "AB",
            "A",
            "B",
            "O",
            "**"});
            this.comboBoxgruposanguineo.Location = new System.Drawing.Point(181, 126);
            this.comboBoxgruposanguineo.Name = "comboBoxgruposanguineo";
            this.comboBoxgruposanguineo.Size = new System.Drawing.Size(133, 21);
            this.comboBoxgruposanguineo.TabIndex = 66;
            // 
            // buttonguardar
            // 
            this.buttonguardar.Location = new System.Drawing.Point(20, 195);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(143, 37);
            this.buttonguardar.TabIndex = 65;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = true;
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.Location = new System.Drawing.Point(194, 195);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(143, 37);
            this.buttoncancelar.TabIndex = 64;
            this.buttoncancelar.Text = "Regresar";
            this.buttoncancelar.UseVisualStyleBackColor = true;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(181, 97);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(133, 20);
            this.textBoxdireccion.TabIndex = 60;
            // 
            // textBoxapellidos
            // 
            this.textBoxapellidos.Location = new System.Drawing.Point(181, 68);
            this.textBoxapellidos.Name = "textBoxapellidos";
            this.textBoxapellidos.Size = new System.Drawing.Size(133, 20);
            this.textBoxapellidos.TabIndex = 59;
            // 
            // textBoxnombres
            // 
            this.textBoxnombres.Location = new System.Drawing.Point(181, 42);
            this.textBoxnombres.Name = "textBoxnombres";
            this.textBoxnombres.Size = new System.Drawing.Size(133, 20);
            this.textBoxnombres.TabIndex = 58;
            // 
            // textBoxafiliacion
            // 
            this.textBoxafiliacion.Location = new System.Drawing.Point(181, 14);
            this.textBoxafiliacion.Name = "textBoxafiliacion";
            this.textBoxafiliacion.Size = new System.Drawing.Size(133, 20);
            this.textBoxafiliacion.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Resultado en CRB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Resultado en Laboratorio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Serie BK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tipo BK+:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Numero BK:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Id de la Prueba:";
            // 
            // Ingresar_Prueba_BK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 244);
            this.Controls.Add(this.comboBoxfactorrh);
            this.Controls.Add(this.comboBoxgruposanguineo);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.textBoxdireccion);
            this.Controls.Add(this.textBoxapellidos);
            this.Controls.Add(this.textBoxnombres);
            this.Controls.Add(this.textBoxafiliacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ingresar_Prueba_BK";
            this.Text = "Ingresar Prueba BK";
            this.Load += new System.EventHandler(this.Ingresar_Prueba_BK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxfactorrh;
        private System.Windows.Forms.ComboBox comboBoxgruposanguineo;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Button buttoncancelar;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.TextBox textBoxapellidos;
        private System.Windows.Forms.TextBox textBoxnombres;
        private System.Windows.Forms.TextBox textBoxafiliacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}