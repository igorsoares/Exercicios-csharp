namespace _30Exercicios
{
    partial class Exercicio29
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
            this.tbNota = new System.Windows.Forms.TextBox();
            this.btAdiciona = new System.Windows.Forms.Button();
            this.btLimpa = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            this.btResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leitor de notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a nota (-1 para encerrar)";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(216, 61);
            this.tbNota.Name = "tbNota";
            this.tbNota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbNota.Size = new System.Drawing.Size(86, 20);
            this.tbNota.TabIndex = 2;
            // 
            // btAdiciona
            // 
            this.btAdiciona.Location = new System.Drawing.Point(308, 59);
            this.btAdiciona.Name = "btAdiciona";
            this.btAdiciona.Size = new System.Drawing.Size(75, 23);
            this.btAdiciona.TabIndex = 3;
            this.btAdiciona.Text = "Adicionar";
            this.btAdiciona.UseVisualStyleBackColor = true;
            this.btAdiciona.Click += new System.EventHandler(this.btAdiciona_Click);
            // 
            // btLimpa
            // 
            this.btLimpa.Location = new System.Drawing.Point(112, 267);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(75, 23);
            this.btLimpa.TabIndex = 4;
            this.btLimpa.Text = "Limpar";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.btLimpa_Click);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(13, 87);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(385, 160);
            this.listResult.TabIndex = 5;
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(202, 267);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(75, 23);
            this.btResult.TabIndex = 6;
            this.btResult.Text = "Resultados";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // Exercicio29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 311);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.btAdiciona);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercicio29";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio29";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Button btAdiciona;
        private System.Windows.Forms.Button btLimpa;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Button btResult;
    }
}