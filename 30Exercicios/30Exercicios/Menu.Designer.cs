namespace _30Exercicios
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btBusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericExercicio = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btSlide12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericExercicio)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBusca
            // 
            this.btBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBusca.Location = new System.Drawing.Point(125, 171);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(326, 23);
            this.btBusca.TabIndex = 0;
            this.btBusca.Text = "Buscar";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(221, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exercícios";
            // 
            // numericExercicio
            // 
            this.numericExercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericExercicio.Location = new System.Drawing.Point(217, 107);
            this.numericExercicio.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericExercicio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericExercicio.Name = "numericExercicio";
            this.numericExercicio.Size = new System.Drawing.Size(120, 26);
            this.numericExercicio.TabIndex = 2;
            this.numericExercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericExercicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btSlide12);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btBusca);
            this.panel3.Controls.Add(this.numericExercicio);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 285);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(291, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exercício Slide 13";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSlide12
            // 
            this.btSlide12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSlide12.Location = new System.Drawing.Point(125, 209);
            this.btSlide12.Name = "btSlide12";
            this.btSlide12.Size = new System.Drawing.Size(160, 23);
            this.btSlide12.TabIndex = 3;
            this.btSlide12.Text = "Exercício Slide 12";
            this.btSlide12.UseVisualStyleBackColor = true;
            this.btSlide12.Click += new System.EventHandler(this.btSlide12_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(585, 309);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.numericExercicio)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericExercicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btSlide12;
        private System.Windows.Forms.Button button1;
    }
}

