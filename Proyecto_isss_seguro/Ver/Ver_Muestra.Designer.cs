namespace Proyecto_isss_seguro
{
    partial class Ver_Muestra
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Afiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Establecimiento_Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Establecimiento_Cultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(684, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 33);
            this.button3.TabIndex = 34;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 33);
            this.button2.TabIndex = 33;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMuestra,
            this.N_Afiliacion,
            this.Paciente,
            this.Fecha,
            this.Establecimiento_Referencia,
            this.Establecimiento_Cultivo,
            this.Tipo_Muestra,
            this.Observacion});
            this.dataGridView1.Location = new System.Drawing.Point(24, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 293);
            this.dataGridView1.TabIndex = 32;
            // 
            // IdMuestra
            // 
            this.IdMuestra.HeaderText = "IdMuestra";
            this.IdMuestra.Name = "IdMuestra";
            // 
            // N_Afiliacion
            // 
            this.N_Afiliacion.HeaderText = "Nº de Afiliacion ";
            this.N_Afiliacion.Name = "N_Afiliacion";
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Establecimiento_Referencia
            // 
            this.Establecimiento_Referencia.HeaderText = "Establecimiento de Referencia";
            this.Establecimiento_Referencia.Name = "Establecimiento_Referencia";
            // 
            // Establecimiento_Cultivo
            // 
            this.Establecimiento_Cultivo.HeaderText = "Establecimiento de Cultivo";
            this.Establecimiento_Cultivo.Name = "Establecimiento_Cultivo";
            // 
            // Tipo_Muestra
            // 
            this.Tipo_Muestra.HeaderText = "Tipo de Muestra";
            this.Tipo_Muestra.Name = "Tipo_Muestra";
            // 
            // Observacion
            // 
            this.Observacion.HeaderText = "Observacion de la Muestra";
            this.Observacion.Name = "Observacion";
            this.Observacion.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Busqueda:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // Ver_Muestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 446);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Ver_Muestra";
            this.Text = "Ver Muestra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Afiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Establecimiento_Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Establecimiento_Cultivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
    }
}