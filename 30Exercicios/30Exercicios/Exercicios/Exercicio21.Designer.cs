namespace _30Exercicios
{
    partial class Exercicio21
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
            this.btPrecos = new System.Windows.Forms.Button();
            this.lbShopp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sr. Manoel Shop";
            // 
            // btPrecos
            // 
            this.btPrecos.Location = new System.Drawing.Point(159, 198);
            this.btPrecos.Name = "btPrecos";
            this.btPrecos.Size = new System.Drawing.Size(137, 23);
            this.btPrecos.TabIndex = 1;
            this.btPrecos.Text = "Tabela de preços";
            this.btPrecos.UseVisualStyleBackColor = true;
            this.btPrecos.Click += new System.EventHandler(this.btPrecos_Click);
            // 
            // lbShopp
            // 
            this.lbShopp.FormattingEnabled = true;
            this.lbShopp.Location = new System.Drawing.Point(12, 38);
            this.lbShopp.Name = "lbShopp";
            this.lbShopp.Size = new System.Drawing.Size(417, 147);
            this.lbShopp.TabIndex = 2;
            // 
            // Exercicio21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 233);
            this.Controls.Add(this.lbShopp);
            this.Controls.Add(this.btPrecos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercicio21";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPrecos;
        private System.Windows.Forms.ListBox lbShopp;
    }
}