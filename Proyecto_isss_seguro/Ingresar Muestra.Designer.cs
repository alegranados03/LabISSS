﻿namespace Proyecto_isss_seguro
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
            this.comboBoxgruposanguineo = new System.Windows.Forms.ComboBox();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.textBoxapellidos = new System.Windows.Forms.TextBox();
            this.textBoxnombres = new System.Windows.Forms.TextBox();
            this.textBoxafiliacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.comboBoxgruposanguineo.Location = new System.Drawing.Point(199, 101);
            this.comboBoxgruposanguineo.Name = "comboBoxgruposanguineo";
            this.comboBoxgruposanguineo.Size = new System.Drawing.Size(263, 21);
            this.comboBoxgruposanguineo.TabIndex = 66;
            // 
            // buttonguardar
            // 
            this.buttonguardar.Location = new System.Drawing.Point(121, 189);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(143, 37);
            this.buttonguardar.TabIndex = 65;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = true;
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.Location = new System.Drawing.Point(295, 189);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(143, 37);
            this.buttoncancelar.TabIndex = 64;
            this.buttoncancelar.Text = "Regresar";
            this.buttoncancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(199, 132);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(263, 20);
            this.textBoxdireccion.TabIndex = 60;
            // 
            // textBoxapellidos
            // 
            this.textBoxapellidos.Location = new System.Drawing.Point(199, 73);
            this.textBoxapellidos.Name = "textBoxapellidos";
            this.textBoxapellidos.Size = new System.Drawing.Size(263, 20);
            this.textBoxapellidos.TabIndex = 59;
            // 
            // textBoxnombres
            // 
            this.textBoxnombres.Location = new System.Drawing.Point(199, 47);
            this.textBoxnombres.Name = "textBoxnombres";
            this.textBoxnombres.Size = new System.Drawing.Size(263, 20);
            this.textBoxnombres.TabIndex = 58;
            // 
            // textBoxafiliacion
            // 
            this.textBoxafiliacion.Location = new System.Drawing.Point(199, 19);
            this.textBoxafiliacion.Name = "textBoxafiliacion";
            this.textBoxafiliacion.Size = new System.Drawing.Size(263, 20);
            this.textBoxafiliacion.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Observacion de la Muestra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tipo de muestra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Establecimiento de Cultivo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Establecimiento de Referencia:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 67;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 68;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 23);
            this.button3.TabIndex = 69;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 282);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxgruposanguineo);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.textBoxdireccion);
            this.Controls.Add(this.textBoxapellidos);
            this.Controls.Add(this.textBoxnombres);
            this.Controls.Add(this.textBoxafiliacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ingresar Muestra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxgruposanguineo;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Button buttoncancelar;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.TextBox textBoxapellidos;
        private System.Windows.Forms.TextBox textBoxnombres;
        private System.Windows.Forms.TextBox textBoxafiliacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}