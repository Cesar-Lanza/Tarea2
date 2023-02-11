namespace Tarea2
{
    partial class Ejercicio1
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
            this.Calcular = new System.Windows.Forms.Button();
            this.Nota4 = new System.Windows.Forms.TextBox();
            this.Nota3 = new System.Windows.Forms.TextBox();
            this.Nota2 = new System.Windows.Forms.TextBox();
            this.Nota1 = new System.Windows.Forms.TextBox();
            this.Nota4P = new System.Windows.Forms.Label();
            this.Nota3P = new System.Windows.Forms.Label();
            this.Nota2P = new System.Windows.Forms.Label();
            this.Nota1P = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(291, 254);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(159, 59);
            this.Calcular.TabIndex = 29;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Nota4
            // 
            this.Nota4.Location = new System.Drawing.Point(593, 172);
            this.Nota4.Name = "Nota4";
            this.Nota4.Size = new System.Drawing.Size(67, 20);
            this.Nota4.TabIndex = 28;
            // 
            // Nota3
            // 
            this.Nota3.Location = new System.Drawing.Point(413, 172);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(67, 20);
            this.Nota3.TabIndex = 27;
            // 
            // Nota2
            // 
            this.Nota2.Location = new System.Drawing.Point(245, 172);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(67, 20);
            this.Nota2.TabIndex = 26;
            // 
            // Nota1
            // 
            this.Nota1.Location = new System.Drawing.Point(96, 172);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(67, 20);
            this.Nota1.TabIndex = 25;
            // 
            // Nota4P
            // 
            this.Nota4P.AutoSize = true;
            this.Nota4P.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota4P.Location = new System.Drawing.Point(575, 141);
            this.Nota4P.Name = "Nota4P";
            this.Nota4P.Size = new System.Drawing.Size(114, 15);
            this.Nota4P.TabIndex = 24;
            this.Nota4P.Text = "Nota IV Parcial";
            // 
            // Nota3P
            // 
            this.Nota3P.AutoSize = true;
            this.Nota3P.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota3P.Location = new System.Drawing.Point(392, 141);
            this.Nota3P.Name = "Nota3P";
            this.Nota3P.Size = new System.Drawing.Size(114, 15);
            this.Nota3P.TabIndex = 23;
            this.Nota3P.Text = "Nota III Parcial";
            // 
            // Nota2P
            // 
            this.Nota2P.AutoSize = true;
            this.Nota2P.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota2P.Location = new System.Drawing.Point(223, 141);
            this.Nota2P.Name = "Nota2P";
            this.Nota2P.Size = new System.Drawing.Size(110, 15);
            this.Nota2P.TabIndex = 22;
            this.Nota2P.Text = "Nota II Parcial";
            // 
            // Nota1P
            // 
            this.Nota1P.AutoSize = true;
            this.Nota1P.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota1P.Location = new System.Drawing.Point(80, 141);
            this.Nota1P.Name = "Nota1P";
            this.Nota1P.Size = new System.Drawing.Size(106, 15);
            this.Nota1P.TabIndex = 21;
            this.Nota1P.Text = "Nota I Parcial";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Algerian", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(272, 59);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(289, 16);
            this.Nombre.TabIndex = 20;
            this.Nombre.Text = "Promedio Final de un Estudiante";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Nota4);
            this.Controls.Add(this.Nota3);
            this.Controls.Add(this.Nota2);
            this.Controls.Add(this.Nota1);
            this.Controls.Add(this.Nota4P);
            this.Controls.Add(this.Nota3P);
            this.Controls.Add(this.Nota2P);
            this.Controls.Add(this.Nota1P);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox Nota4;
        private System.Windows.Forms.TextBox Nota3;
        private System.Windows.Forms.TextBox Nota2;
        private System.Windows.Forms.TextBox Nota1;
        private System.Windows.Forms.Label Nota4P;
        private System.Windows.Forms.Label Nota3P;
        private System.Windows.Forms.Label Nota2P;
        private System.Windows.Forms.Label Nota1P;
        private System.Windows.Forms.Label Nombre;
    }
}

