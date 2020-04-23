namespace _30Exercicios
{
    partial class Exercicio9
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
            this.tbDigito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btProcessar = new System.Windows.Forms.Button();
            this.tbDigitado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDigito
            // 
            this.tbDigito.Location = new System.Drawing.Point(32, 78);
            this.tbDigito.Name = "tbDigito";
            this.tbDigito.Size = new System.Drawing.Size(198, 20);
            this.tbDigito.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Digite o sexo (F M)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Exercício 9";
            // 
            // btProcessar
            // 
            this.btProcessar.Location = new System.Drawing.Point(69, 157);
            this.btProcessar.Name = "btProcessar";
            this.btProcessar.Size = new System.Drawing.Size(131, 23);
            this.btProcessar.TabIndex = 38;
            this.btProcessar.Text = "Processar";
            this.btProcessar.UseVisualStyleBackColor = true;
            this.btProcessar.Click += new System.EventHandler(this.btProcessar_Click);
            // 
            // tbDigitado
            // 
            this.tbDigitado.Location = new System.Drawing.Point(87, 116);
            this.tbDigitado.Name = "tbDigitado";
            this.tbDigitado.ReadOnly = true;
            this.tbDigitado.Size = new System.Drawing.Size(100, 20);
            this.tbDigitado.TabIndex = 39;
            // 
            // Exercicio9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 192);
            this.Controls.Add(this.tbDigitado);
            this.Controls.Add(this.btProcessar);
            this.Controls.Add(this.tbDigito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio9";
            this.Text = "Exercicio9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDigito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btProcessar;
        private System.Windows.Forms.TextBox tbDigitado;
    }
}