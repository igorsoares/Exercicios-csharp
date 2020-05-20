namespace _30Exercicios
{
    partial class Exercicio12
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
            this.tbLado1 = new System.Windows.Forms.TextBox();
            this.tbLado2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLado3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCalcula = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(126, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercício 12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado 1 do triângulo";
            // 
            // tbLado1
            // 
            this.tbLado1.Location = new System.Drawing.Point(130, 69);
            this.tbLado1.Name = "tbLado1";
            this.tbLado1.Size = new System.Drawing.Size(100, 20);
            this.tbLado1.TabIndex = 2;
            // 
            // tbLado2
            // 
            this.tbLado2.Location = new System.Drawing.Point(130, 107);
            this.tbLado2.Name = "tbLado2";
            this.tbLado2.Size = new System.Drawing.Size(100, 20);
            this.tbLado2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lado 2 do triângulo";
            // 
            // tbLado3
            // 
            this.tbLado3.Location = new System.Drawing.Point(130, 141);
            this.tbLado3.Name = "tbLado3";
            this.tbLado3.Size = new System.Drawing.Size(100, 20);
            this.tbLado3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lado 3 do triângulo";
            // 
            // btCalcula
            // 
            this.btCalcula.Location = new System.Drawing.Point(64, 212);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(215, 23);
            this.btCalcula.TabIndex = 7;
            this.btCalcula.Text = "Calcular";
            this.btCalcula.UseVisualStyleBackColor = true;
            this.btCalcula.Click += new System.EventHandler(this.btCalcula_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(130, 186);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(100, 20);
            this.tbResultado.TabIndex = 8;
            // 
            // Exercicio12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 247);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btCalcula);
            this.Controls.Add(this.tbLado3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLado2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLado1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLado1;
        private System.Windows.Forms.TextBox tbLado2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLado3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.TextBox tbResultado;
    }
}