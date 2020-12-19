namespace ENE_PRO201_2020
{
    partial class From_registro_requerimiento
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
            this.comboBox_TRequerimiento = new System.Windows.Forms.ComboBox();
            this.comboBox_Asignado = new System.Windows.Forms.ComboBox();
            this.comboBox_Prioridad = new System.Windows.Forms.ComboBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Lcampos = new System.Windows.Forms.Button();
            this.button_Lrequerimientos = new System.Windows.Forms.Button();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_TRequerimiento
            // 
            this.comboBox_TRequerimiento.Location = new System.Drawing.Point(156, 26);
            this.comboBox_TRequerimiento.Name = "comboBox_TRequerimiento";
            this.comboBox_TRequerimiento.Size = new System.Drawing.Size(175, 21);
            this.comboBox_TRequerimiento.TabIndex = 11;
            // 
            // comboBox_Asignado
            // 
            this.comboBox_Asignado.FormattingEnabled = true;
            this.comboBox_Asignado.Location = new System.Drawing.Point(156, 63);
            this.comboBox_Asignado.Name = "comboBox_Asignado";
            this.comboBox_Asignado.Size = new System.Drawing.Size(175, 21);
            this.comboBox_Asignado.TabIndex = 1;
            // 
            // comboBox_Prioridad
            // 
            this.comboBox_Prioridad.FormattingEnabled = true;
            this.comboBox_Prioridad.Location = new System.Drawing.Point(156, 208);
            this.comboBox_Prioridad.Name = "comboBox_Prioridad";
            this.comboBox_Prioridad.Size = new System.Drawing.Size(175, 21);
            this.comboBox_Prioridad.TabIndex = 2;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(18, 252);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(128, 37);
            this.button_Guardar.TabIndex = 3;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.Button_Guardar_Click);
            // 
            // button_Lcampos
            // 
            this.button_Lcampos.Location = new System.Drawing.Point(159, 252);
            this.button_Lcampos.Name = "button_Lcampos";
            this.button_Lcampos.Size = new System.Drawing.Size(128, 37);
            this.button_Lcampos.TabIndex = 4;
            this.button_Lcampos.Text = "Limiar campos";
            this.button_Lcampos.UseVisualStyleBackColor = true;
            this.button_Lcampos.Click += new System.EventHandler(this.Button_Lcampos_Click);
            // 
            // button_Lrequerimientos
            // 
            this.button_Lrequerimientos.Location = new System.Drawing.Point(302, 252);
            this.button_Lrequerimientos.Name = "button_Lrequerimientos";
            this.button_Lrequerimientos.Size = new System.Drawing.Size(128, 37);
            this.button_Lrequerimientos.TabIndex = 5;
            this.button_Lrequerimientos.Text = "Ir a listar requerimientos";
            this.button_Lrequerimientos.UseVisualStyleBackColor = true;
            this.button_Lrequerimientos.Click += new System.EventHandler(this.Button_Lrequerimientos_Click);
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(18, 127);
            this.textBox_Descripcion.Multiline = true;
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(316, 63);
            this.textBox_Descripcion.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo de requerimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Asignado a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prioridad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripción";
            // 
            // From_registro_requerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 312);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Descripcion);
            this.Controls.Add(this.button_Lrequerimientos);
            this.Controls.Add(this.button_Lcampos);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.comboBox_Prioridad);
            this.Controls.Add(this.comboBox_Asignado);
            this.Controls.Add(this.comboBox_TRequerimiento);
            this.Name = "From_registro_requerimiento";
            this.Text = "Registro de requerimientos";
            this.Load += new System.EventHandler(this.From_registro_requerimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_TRequerimiento;
        private System.Windows.Forms.ComboBox comboBox_Asignado;
        private System.Windows.Forms.ComboBox comboBox_Prioridad;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Lcampos;
        private System.Windows.Forms.Button button_Lrequerimientos;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}