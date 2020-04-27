namespace _30Exercicios.Slides_12
{
    partial class ListaUsuarios
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
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.cadastrados = new System.Windows.Forms.Label();
            this.lbTodos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(125, 9);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(16, 20);
            this.lbQuantidade.TabIndex = 0;
            this.lbQuantidade.Text = "x";
            // 
            // cadastrados
            // 
            this.cadastrados.AutoSize = true;
            this.cadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrados.Location = new System.Drawing.Point(143, 9);
            this.cadastrados.Name = "cadastrados";
            this.cadastrados.Size = new System.Drawing.Size(97, 20);
            this.cadastrados.TabIndex = 1;
            this.cadastrados.Text = "cadastrados";
            // 
            // lbTodos
            // 
            this.lbTodos.FormattingEnabled = true;
            this.lbTodos.Location = new System.Drawing.Point(13, 42);
            this.lbTodos.Name = "lbTodos";
            this.lbTodos.Size = new System.Drawing.Size(356, 186);
            this.lbTodos.TabIndex = 2;
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 238);
            this.Controls.Add(this.lbTodos);
            this.Controls.Add(this.cadastrados);
            this.Controls.Add(this.lbQuantidade);
            this.Name = "ListaUsuarios";
            this.Text = "ListaUsuarios";
            this.Load += new System.EventHandler(this.ListaUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label cadastrados;
        private System.Windows.Forms.ListBox lbTodos;
    }
}