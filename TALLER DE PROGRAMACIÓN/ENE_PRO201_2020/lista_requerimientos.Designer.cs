namespace ENE_PRO201_2020
{
    partial class From_lista_requerimientos
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
            this.comboBox_Trequerimiento = new System.Windows.Forms.ComboBox();
            this.comboBox_prioridad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_pendientes = new System.Windows.Forms.CheckBox();
            this.checkBox_resueltos = new System.Windows.Forms.CheckBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.dataGrid_Mdatos = new System.Windows.Forms.DataGridView();
            this.button_Mresuelto = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Mdatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo requerimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prioridad";
            // 
            // comboBox_Trequerimiento
            // 
            this.comboBox_Trequerimiento.Location = new System.Drawing.Point(134, 28);
            this.comboBox_Trequerimiento.Name = "comboBox_Trequerimiento";
            this.comboBox_Trequerimiento.Size = new System.Drawing.Size(223, 21);
            this.comboBox_Trequerimiento.TabIndex = 13;
            // 
            // comboBox_prioridad
            // 
            this.comboBox_prioridad.FormattingEnabled = true;
            this.comboBox_prioridad.Location = new System.Drawing.Point(134, 66);
            this.comboBox_prioridad.Name = "comboBox_prioridad";
            this.comboBox_prioridad.Size = new System.Drawing.Size(223, 21);
            this.comboBox_prioridad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // checkBox_pendientes
            // 
            this.checkBox_pendientes.AutoSize = true;
            this.checkBox_pendientes.Location = new System.Drawing.Point(6, 19);
            this.checkBox_pendientes.Name = "checkBox_pendientes";
            this.checkBox_pendientes.Size = new System.Drawing.Size(79, 17);
            this.checkBox_pendientes.TabIndex = 6;
            this.checkBox_pendientes.Text = "Pendientes";
            this.checkBox_pendientes.UseVisualStyleBackColor = true;
            // 
            // checkBox_resueltos
            // 
            this.checkBox_resueltos.AutoSize = true;
            this.checkBox_resueltos.Location = new System.Drawing.Point(155, 19);
            this.checkBox_resueltos.Name = "checkBox_resueltos";
            this.checkBox_resueltos.Size = new System.Drawing.Size(73, 17);
            this.checkBox_resueltos.TabIndex = 7;
            this.checkBox_resueltos.Text = "Resueltos";
            this.checkBox_resueltos.UseVisualStyleBackColor = true;
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(375, 104);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(115, 38);
            this.button_buscar.TabIndex = 8;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.Button_buscar_Click);
            // 
            // dataGrid_Mdatos
            // 
            this.dataGrid_Mdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Mdatos.Location = new System.Drawing.Point(18, 157);
            this.dataGrid_Mdatos.Name = "dataGrid_Mdatos";
            this.dataGrid_Mdatos.Size = new System.Drawing.Size(761, 124);
            this.dataGrid_Mdatos.TabIndex = 9;
            // 
            // button_Mresuelto
            // 
            this.button_Mresuelto.Location = new System.Drawing.Point(12, 302);
            this.button_Mresuelto.Name = "button_Mresuelto";
            this.button_Mresuelto.Size = new System.Drawing.Size(185, 41);
            this.button_Mresuelto.TabIndex = 10;
            this.button_Mresuelto.Text = "Marcar como resuelto";
            this.button_Mresuelto.UseVisualStyleBackColor = true;
            this.button_Mresuelto.Click += new System.EventHandler(this.Button_Mresuelto_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(223, 302);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(185, 41);
            this.button_eliminar.TabIndex = 11;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.Button_eliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_pendientes);
            this.groupBox1.Controls.Add(this.checkBox_resueltos);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 41);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // From_lista_requerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 353);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_Mresuelto);
            this.Controls.Add(this.dataGrid_Mdatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_prioridad);
            this.Controls.Add(this.comboBox_Trequerimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "From_lista_requerimientos";
            this.Text = "Lista de Requerimientos";
            this.Load += new System.EventHandler(this.Lista_requerimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Mdatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Trequerimiento;
        private System.Windows.Forms.ComboBox comboBox_prioridad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_pendientes;
        private System.Windows.Forms.CheckBox checkBox_resueltos;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.DataGridView dataGrid_Mdatos;
        private System.Windows.Forms.Button button_Mresuelto;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}