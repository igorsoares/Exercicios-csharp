namespace Exercicios
{
    partial class Exercicio20
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
            this.lbFibo = new System.Windows.Forms.ListBox();
            this.btStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFibo
            // 
            this.lbFibo.FormattingEnabled = true;
            this.lbFibo.Location = new System.Drawing.Point(39, 40);
            this.lbFibo.Name = "lbFibo";
            this.lbFibo.Size = new System.Drawing.Size(371, 108);
            this.lbFibo.TabIndex = 5;
            this.lbFibo.SelectedIndexChanged += new System.EventHandler(this.lbFibo_SelectedIndexChanged);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(166, 158);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(116, 23);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Iniciar Fibonacci";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(179, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exercicio 20";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Exercicio20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 195);
            this.Controls.Add(this.lbFibo);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exercicio20";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio20";
            this.Load += new System.EventHandler(this.Exercicio20_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFibo;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label1;
    }
}