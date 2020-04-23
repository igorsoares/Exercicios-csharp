namespace _30Exercicios
{
    partial class Exercicio15
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAlcool = new System.Windows.Forms.RadioButton();
            this.rbGasolina = new System.Windows.Forms.RadioButton();
            this.tbLitros = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.tbPagar = new System.Windows.Forms.TextBox();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posto Ipiranga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de litros : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAlcool);
            this.groupBox1.Controls.Add(this.rbGasolina);
            this.groupBox1.Location = new System.Drawing.Point(55, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rbAlcool
            // 
            this.rbAlcool.AutoSize = true;
            this.rbAlcool.Location = new System.Drawing.Point(88, 29);
            this.rbAlcool.Name = "rbAlcool";
            this.rbAlcool.Size = new System.Drawing.Size(54, 17);
            this.rbAlcool.TabIndex = 5;
            this.rbAlcool.Text = "Álcool";
            this.rbAlcool.UseVisualStyleBackColor = true;
            // 
            // rbGasolina
            // 
            this.rbGasolina.AutoSize = true;
            this.rbGasolina.Checked = true;
            this.rbGasolina.Location = new System.Drawing.Point(16, 29);
            this.rbGasolina.Name = "rbGasolina";
            this.rbGasolina.Size = new System.Drawing.Size(66, 17);
            this.rbGasolina.TabIndex = 4;
            this.rbGasolina.TabStop = true;
            this.rbGasolina.Text = "Gasolina";
            this.rbGasolina.UseVisualStyleBackColor = true;
            // 
            // tbLitros
            // 
            this.tbLitros.Location = new System.Drawing.Point(168, 26);
            this.tbLitros.Name = "tbLitros";
            this.tbLitros.Size = new System.Drawing.Size(80, 20);
            this.tbLitros.TabIndex = 4;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(62, 226);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(182, 23);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // tbPagar
            // 
            this.tbPagar.Location = new System.Drawing.Point(164, 178);
            this.tbPagar.Name = "tbPagar";
            this.tbPagar.ReadOnly = true;
            this.tbPagar.Size = new System.Drawing.Size(80, 20);
            this.tbPagar.TabIndex = 6;
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(164, 149);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.ReadOnly = true;
            this.tbDesconto.Size = new System.Drawing.Size(80, 20);
            this.tbDesconto.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbPagar);
            this.groupBox2.Controls.Add(this.tbLitros);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.tbDesconto);
            this.groupBox2.Controls.Add(this.btCalcular);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 275);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Desconto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preço a pagar:";
            // 
            // Exercicio15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Exercicio15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio15";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAlcool;
        private System.Windows.Forms.RadioButton rbGasolina;
        private System.Windows.Forms.TextBox tbLitros;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox tbPagar;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}