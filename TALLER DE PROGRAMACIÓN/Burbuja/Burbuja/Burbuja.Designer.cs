namespace Burbuja
{
    partial class Burbuja
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Ordenar = new System.Windows.Forms.Button();
            this.textBox_Numeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Ordenar
            // 
            this.button_Ordenar.Location = new System.Drawing.Point(228, 12);
            this.button_Ordenar.Name = "button_Ordenar";
            this.button_Ordenar.Size = new System.Drawing.Size(106, 190);
            this.button_Ordenar.TabIndex = 0;
            this.button_Ordenar.Text = "Ordenar";
            this.button_Ordenar.UseVisualStyleBackColor = true;
            this.button_Ordenar.UseWaitCursor = true;
            this.button_Ordenar.Click += new System.EventHandler(this.Button_Ordenar_Click);
            // 
            // textBox_Numeros
            // 
            this.textBox_Numeros.BackColor = System.Drawing.Color.White;
            this.textBox_Numeros.Location = new System.Drawing.Point(12, 12);
            this.textBox_Numeros.Multiline = true;
            this.textBox_Numeros.Name = "textBox_Numeros";
            this.textBox_Numeros.Size = new System.Drawing.Size(210, 190);
            this.textBox_Numeros.TabIndex = 1;
            this.textBox_Numeros.UseWaitCursor = true;
            // 
            // Burbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 215);
            this.Controls.Add(this.textBox_Numeros);
            this.Controls.Add(this.button_Ordenar);
            this.Name = "Burbuja";
            this.Text = "Burbuja";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Burbuja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ordenar;
        private System.Windows.Forms.TextBox textBox_Numeros;
    }
}

