namespace _30Exercicios.Slides_12
{
    partial class SalarioTotal
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
            this.labelSal = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "R$";
            // 
            // labelSal
            // 
            this.labelSal.AutoSize = true;
            this.labelSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSal.Location = new System.Drawing.Point(193, 18);
            this.labelSal.Name = "labelSal";
            this.labelSal.Size = new System.Drawing.Size(18, 20);
            this.labelSal.TabIndex = 1;
            this.labelSal.Text = "0";
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.Location = new System.Drawing.Point(13, 42);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(358, 186);
            this.lbResultado.TabIndex = 2;
            // 
            // SalarioTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 241);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.labelSal);
            this.Controls.Add(this.label1);
            this.Name = "SalarioTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalarioTotal";
            this.Load += new System.EventHandler(this.SalarioTotal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSal;
        private System.Windows.Forms.ListBox lbResultado;
    }
}