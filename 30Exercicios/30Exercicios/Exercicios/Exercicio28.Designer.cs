namespace _30Exercicios
{
    partial class Exercicio28
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAddNum = new System.Windows.Forms.Button();
            this.tbDigito = new System.Windows.Forms.TextBox();
            this.btProcessa = new System.Windows.Forms.Button();
            this.labelVetor = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAddNum);
            this.groupBox1.Controls.Add(this.tbDigito);
            this.groupBox1.Controls.Add(this.btProcessa);
            this.groupBox1.Controls.Add(this.labelVetor);
            this.groupBox1.Controls.Add(this.tbResult);
            this.groupBox1.Location = new System.Drawing.Point(25, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 160);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btAddNum
            // 
            this.btAddNum.Location = new System.Drawing.Point(83, 114);
            this.btAddNum.Name = "btAddNum";
            this.btAddNum.Size = new System.Drawing.Size(68, 24);
            this.btAddNum.TabIndex = 6;
            this.btAddNum.Text = "Adicionar número";
            this.btAddNum.UseVisualStyleBackColor = true;
            this.btAddNum.Click += new System.EventHandler(this.btAddNum_Click);
            // 
            // tbDigito
            // 
            this.tbDigito.Location = new System.Drawing.Point(149, 27);
            this.tbDigito.Name = "tbDigito";
            this.tbDigito.Size = new System.Drawing.Size(87, 20);
            this.tbDigito.TabIndex = 3;
            // 
            // btProcessa
            // 
            this.btProcessa.Location = new System.Drawing.Point(189, 114);
            this.btProcessa.Name = "btProcessa";
            this.btProcessa.Size = new System.Drawing.Size(94, 24);
            this.btProcessa.TabIndex = 5;
            this.btProcessa.Text = "Ler o quadrado";
            this.btProcessa.UseVisualStyleBackColor = true;
            this.btProcessa.Click += new System.EventHandler(this.btProcessa_Click);
            // 
            // labelVetor
            // 
            this.labelVetor.AutoSize = true;
            this.labelVetor.Location = new System.Drawing.Point(33, 30);
            this.labelVetor.Name = "labelVetor";
            this.labelVetor.Size = new System.Drawing.Size(51, 13);
            this.labelVetor.TabIndex = 2;
            this.labelVetor.Text = "1 número";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(22, 75);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(299, 20);
            this.tbResult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vetor reader";
            // 
            // Exercicio28
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 203);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercicio28";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio28";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAddNum;
        private System.Windows.Forms.TextBox tbDigito;
        private System.Windows.Forms.Button btProcessa;
        private System.Windows.Forms.Label labelVetor;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label1;
    }
}