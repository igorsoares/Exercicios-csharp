namespace _30Exercicios
{
    partial class Exercicio10
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
            this.tbDigitado = new System.Windows.Forms.TextBox();
            this.btProcessar = new System.Windows.Forms.Button();
            this.tbDigito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDigitado
            // 
            this.tbDigitado.Location = new System.Drawing.Point(12, 139);
            this.tbDigitado.Name = "tbDigitado";
            this.tbDigitado.ReadOnly = true;
            this.tbDigitado.Size = new System.Drawing.Size(198, 20);
            this.tbDigitado.TabIndex = 44;
            // 
            // btProcessar
            // 
            this.btProcessar.Location = new System.Drawing.Point(12, 180);
            this.btProcessar.Name = "btProcessar";
            this.btProcessar.Size = new System.Drawing.Size(198, 23);
            this.btProcessar.TabIndex = 43;
            this.btProcessar.Text = "Processar";
            this.btProcessar.UseVisualStyleBackColor = true;
            this.btProcessar.Click += new System.EventHandler(this.btProcessar_Click);
            // 
            // tbDigito
            // 
            this.tbDigito.Location = new System.Drawing.Point(12, 101);
            this.tbDigito.Name = "tbDigito";
            this.tbDigito.Size = new System.Drawing.Size(198, 20);
            this.tbDigito.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Qual turno de estudo ? ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Exercício 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "M-Matutino V-Vespertino N-Noturno";
            // 
            // Exercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDigitado);
            this.Controls.Add(this.btProcessar);
            this.Controls.Add(this.tbDigito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDigitado;
        private System.Windows.Forms.Button btProcessar;
        private System.Windows.Forms.TextBox tbDigito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}