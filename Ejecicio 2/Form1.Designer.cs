namespace Ejecicio_2
{
    partial class Form1
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
            this.PromedioButton = new System.Windows.Forms.Button();
            this.Pacial1TextBox = new System.Windows.Forms.TextBox();
            this.Pacial2TextBox = new System.Windows.Forms.TextBox();
            this.Pacial3TextBox = new System.Windows.Forms.TextBox();
            this.Pacial4TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PromedioButton
            // 
            this.PromedioButton.Location = new System.Drawing.Point(104, 165);
            this.PromedioButton.Name = "PromedioButton";
            this.PromedioButton.Size = new System.Drawing.Size(75, 23);
            this.PromedioButton.TabIndex = 0;
            this.PromedioButton.Text = "Promedio";
            this.PromedioButton.UseVisualStyleBackColor = true;
            this.PromedioButton.Click += new System.EventHandler(this.PromedioButton_Click);
            // 
            // Pacial1TextBox
            // 
            this.Pacial1TextBox.Location = new System.Drawing.Point(88, 60);
            this.Pacial1TextBox.Name = "Pacial1TextBox";
            this.Pacial1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Pacial1TextBox.TabIndex = 1;
            // 
            // Pacial2TextBox
            // 
            this.Pacial2TextBox.Location = new System.Drawing.Point(88, 86);
            this.Pacial2TextBox.Name = "Pacial2TextBox";
            this.Pacial2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Pacial2TextBox.TabIndex = 2;
            // 
            // Pacial3TextBox
            // 
            this.Pacial3TextBox.Location = new System.Drawing.Point(88, 112);
            this.Pacial3TextBox.Name = "Pacial3TextBox";
            this.Pacial3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Pacial3TextBox.TabIndex = 3;
            // 
            // Pacial4TextBox
            // 
            this.Pacial4TextBox.Location = new System.Drawing.Point(88, 139);
            this.Pacial4TextBox.Name = "Pacial4TextBox";
            this.Pacial4TextBox.Size = new System.Drawing.Size(100, 20);
            this.Pacial4TextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1 Parcial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "2 Parcial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "3 Parcial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "4 Parcial:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pacial4TextBox);
            this.Controls.Add(this.Pacial3TextBox);
            this.Controls.Add(this.Pacial2TextBox);
            this.Controls.Add(this.Pacial1TextBox);
            this.Controls.Add(this.PromedioButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PromedioButton;
        private System.Windows.Forms.TextBox Pacial1TextBox;
        private System.Windows.Forms.TextBox Pacial2TextBox;
        private System.Windows.Forms.TextBox Pacial3TextBox;
        private System.Windows.Forms.TextBox Pacial4TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

