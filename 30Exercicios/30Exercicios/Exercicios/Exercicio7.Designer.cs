namespace _30Exercicios
{
    partial class Exercicio7
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
            this.btCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGanhoH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSalarioBruto = new System.Windows.Forms.TextBox();
            this.tbIR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbINSS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSindicato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSalarioL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(7, 309);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(282, 23);
            this.btCalcular.TabIndex = 32;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Exercício 7";
            // 
            // tbNumHora
            // 
            this.tbNumHora.Location = new System.Drawing.Point(139, 99);
            this.tbNumHora.Name = "tbNumHora";
            this.tbNumHora.Size = new System.Drawing.Size(81, 20);
            this.tbNumHora.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Números horas no mês";
            // 
            // tbGanhoH
            // 
            this.tbGanhoH.Location = new System.Drawing.Point(139, 59);
            this.tbGanhoH.Name = "tbGanhoH";
            this.tbGanhoH.Size = new System.Drawing.Size(81, 20);
            this.tbGanhoH.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ganho por hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Salário bruto";
            // 
            // tbSalarioBruto
            // 
            this.tbSalarioBruto.Location = new System.Drawing.Point(127, 13);
            this.tbSalarioBruto.Name = "tbSalarioBruto";
            this.tbSalarioBruto.ReadOnly = true;
            this.tbSalarioBruto.Size = new System.Drawing.Size(81, 20);
            this.tbSalarioBruto.TabIndex = 38;
            // 
            // tbIR
            // 
            this.tbIR.Location = new System.Drawing.Point(127, 47);
            this.tbIR.Name = "tbIR";
            this.tbIR.ReadOnly = true;
            this.tbIR.Size = new System.Drawing.Size(81, 20);
            this.tbIR.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "IR (11%)";
            // 
            // tbINSS
            // 
            this.tbINSS.Location = new System.Drawing.Point(127, 79);
            this.tbINSS.Name = "tbINSS";
            this.tbINSS.ReadOnly = true;
            this.tbINSS.Size = new System.Drawing.Size(81, 20);
            this.tbINSS.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "INSS (8%)";
            // 
            // tbSindicato
            // 
            this.tbSindicato.Location = new System.Drawing.Point(127, 110);
            this.tbSindicato.Name = "tbSindicato";
            this.tbSindicato.ReadOnly = true;
            this.tbSindicato.Size = new System.Drawing.Size(81, 20);
            this.tbSindicato.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Sindicato (5%)";
            // 
            // tbSalarioL
            // 
            this.tbSalarioL.Location = new System.Drawing.Point(127, 141);
            this.tbSalarioL.Name = "tbSalarioL";
            this.tbSalarioL.ReadOnly = true;
            this.tbSalarioL.Size = new System.Drawing.Size(81, 20);
            this.tbSalarioL.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Salário líquido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSalarioL);
            this.groupBox1.Controls.Add(this.tbSalarioBruto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSindicato);
            this.groupBox1.Controls.Add(this.tbIR);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbINSS);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 178);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // Exercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbNumHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGanhoH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGanhoH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSalarioBruto;
        private System.Windows.Forms.TextBox tbIR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbINSS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSindicato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSalarioL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}