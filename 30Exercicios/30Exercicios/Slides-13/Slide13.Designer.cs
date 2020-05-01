namespace _30Exercicios.Slides_13
{
    partial class Slide13
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
            this.tbTitular = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btDeposita = new System.Windows.Forms.Button();
            this.btSaca = new System.Windows.Forms.Button();
            this.btExclui = new System.Windows.Forms.Button();
            this.btHistorico = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizarBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarBancoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titular";
            // 
            // tbTitular
            // 
            this.tbTitular.Location = new System.Drawing.Point(54, 17);
            this.tbTitular.Name = "tbTitular";
            this.tbTitular.Size = new System.Drawing.Size(100, 20);
            this.tbTitular.TabIndex = 1;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(54, 46);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(54, 77);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(54, 109);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.ReadOnly = true;
            this.tbSaldo.Size = new System.Drawing.Size(100, 20);
            this.tbSaldo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldo";
            // 
            // btDeposita
            // 
            this.btDeposita.Location = new System.Drawing.Point(178, 31);
            this.btDeposita.Name = "btDeposita";
            this.btDeposita.Size = new System.Drawing.Size(82, 23);
            this.btDeposita.TabIndex = 8;
            this.btDeposita.Text = "Depositar";
            this.btDeposita.UseVisualStyleBackColor = true;
            this.btDeposita.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSaca
            // 
            this.btSaca.Location = new System.Drawing.Point(178, 60);
            this.btSaca.Name = "btSaca";
            this.btSaca.Size = new System.Drawing.Size(82, 23);
            this.btSaca.TabIndex = 9;
            this.btSaca.Text = "Sacar";
            this.btSaca.UseVisualStyleBackColor = true;
            this.btSaca.Click += new System.EventHandler(this.btSaca_Click);
            // 
            // btExclui
            // 
            this.btExclui.Location = new System.Drawing.Point(178, 89);
            this.btExclui.Name = "btExclui";
            this.btExclui.Size = new System.Drawing.Size(82, 23);
            this.btExclui.TabIndex = 10;
            this.btExclui.Text = "Excluir";
            this.btExclui.UseVisualStyleBackColor = true;
            // 
            // btHistorico
            // 
            this.btHistorico.Location = new System.Drawing.Point(178, 120);
            this.btHistorico.Name = "btHistorico";
            this.btHistorico.Size = new System.Drawing.Size(82, 23);
            this.btHistorico.TabIndex = 11;
            this.btHistorico.Text = "Historico";
            this.btHistorico.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTitular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNumero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSaldo);
            this.groupBox1.Controls.Add(this.tbValor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 142);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarBancoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visualizarBancoToolStripMenuItem
            // 
            this.visualizarBancoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarBancoToolStripMenuItem1});
            this.visualizarBancoToolStripMenuItem.Name = "visualizarBancoToolStripMenuItem";
            this.visualizarBancoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.visualizarBancoToolStripMenuItem.Text = "Visualizar banco";
            // 
            // visualizarBancoToolStripMenuItem1
            // 
            this.visualizarBancoToolStripMenuItem1.Name = "visualizarBancoToolStripMenuItem1";
            this.visualizarBancoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.visualizarBancoToolStripMenuItem1.Text = "Visualizar banco";
            this.visualizarBancoToolStripMenuItem1.Click += new System.EventHandler(this.visualizarBancoToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Slide13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 175);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btHistorico);
            this.Controls.Add(this.btExclui);
            this.Controls.Add(this.btSaca);
            this.Controls.Add(this.btDeposita);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Slide13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.Slide13_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitular;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDeposita;
        private System.Windows.Forms.Button btSaca;
        private System.Windows.Forms.Button btExclui;
        private System.Windows.Forms.Button btHistorico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualizarBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarBancoToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}