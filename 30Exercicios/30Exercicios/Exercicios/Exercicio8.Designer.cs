namespace _30Exercicios.Exercicios
{
    partial class Exercicio8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMetros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb18L = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb3L = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantGalao = new System.Windows.Forms.TextBox();
            this.tbQuantLata = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loja tintas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCalcular);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbMetros);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tbMetros
            // 
            this.tbMetros.Location = new System.Drawing.Point(122, 42);
            this.tbMetros.Name = "tbMetros";
            this.tbMetros.Size = new System.Drawing.Size(100, 20);
            this.tbMetros.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tamanho em m²";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbQuantGalao);
            this.groupBox2.Controls.Add(this.tbQuantLata);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb3L);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb18L);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(27, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // tb18L
            // 
            this.tb18L.Location = new System.Drawing.Point(171, 39);
            this.tb18L.Name = "tb18L";
            this.tb18L.ReadOnly = true;
            this.tb18L.Size = new System.Drawing.Size(59, 20);
            this.tb18L.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Latas 18L";
            // 
            // tb3L
            // 
            this.tb3L.Location = new System.Drawing.Point(171, 65);
            this.tb3L.Name = "tb3L";
            this.tb3L.ReadOnly = true;
            this.tb3L.Size = new System.Drawing.Size(59, 20);
            this.tb3L.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Galões 3,5L";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(228, 40);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(67, 23);
            this.btCalcular.TabIndex = 3;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantidade";
            // 
            // tbQuantGalao
            // 
            this.tbQuantGalao.Location = new System.Drawing.Point(100, 65);
            this.tbQuantGalao.Name = "tbQuantGalao";
            this.tbQuantGalao.ReadOnly = true;
            this.tbQuantGalao.Size = new System.Drawing.Size(59, 20);
            this.tbQuantGalao.TabIndex = 11;
            // 
            // tbQuantLata
            // 
            this.tbQuantLata.Location = new System.Drawing.Point(100, 39);
            this.tbQuantLata.Name = "tbQuantLata";
            this.tbQuantLata.ReadOnly = true;
            this.tbQuantLata.Size = new System.Drawing.Size(59, 20);
            this.tbQuantLata.TabIndex = 10;
            // 
            // Exercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 246);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercicio8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMetros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb3L;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb18L;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuantGalao;
        private System.Windows.Forms.TextBox tbQuantLata;
    }
}