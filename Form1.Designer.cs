namespace linhas_psicodelicas
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonIr = new System.Windows.Forms.Button();
            this.textBoxIncremento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAngulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLinhas = new System.Windows.Forms.TextBox();
            this.textBoxTamanho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.buttonIr);
            this.panel1.Controls.Add(this.textBoxIncremento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxAngulo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxLinhas);
            this.panel1.Controls.Add(this.textBoxTamanho);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 64);
            this.panel1.TabIndex = 0;
            // 
            // buttonIr
            // 
            this.buttonIr.Location = new System.Drawing.Point(538, 22);
            this.buttonIr.Name = "buttonIr";
            this.buttonIr.Size = new System.Drawing.Size(43, 23);
            this.buttonIr.TabIndex = 6;
            this.buttonIr.Text = "Ir!";
            this.buttonIr.UseVisualStyleBackColor = true;
            this.buttonIr.Click += new System.EventHandler(this.buttonIr_Click);
            // 
            // textBoxIncremento
            // 
            this.textBoxIncremento.Location = new System.Drawing.Point(485, 22);
            this.textBoxIncremento.Name = "textBoxIncremento";
            this.textBoxIncremento.Size = new System.Drawing.Size(47, 20);
            this.textBoxIncremento.TabIndex = 0;
            this.textBoxIncremento.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Incremento:";
            // 
            // textBoxAngulo
            // 
            this.textBoxAngulo.Location = new System.Drawing.Point(343, 22);
            this.textBoxAngulo.Name = "textBoxAngulo";
            this.textBoxAngulo.Size = new System.Drawing.Size(47, 20);
            this.textBoxAngulo.TabIndex = 4;
            this.textBoxAngulo.Text = "74";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ângulo:";
            // 
            // textBoxLinhas
            // 
            this.textBoxLinhas.Location = new System.Drawing.Point(107, 22);
            this.textBoxLinhas.Name = "textBoxLinhas";
            this.textBoxLinhas.Size = new System.Drawing.Size(47, 20);
            this.textBoxLinhas.TabIndex = 5;
            this.textBoxLinhas.Text = "100";
            // 
            // textBoxTamanho
            // 
            this.textBoxTamanho.Location = new System.Drawing.Point(233, 22);
            this.textBoxTamanho.Name = "textBoxTamanho";
            this.textBoxTamanho.Size = new System.Drawing.Size(47, 20);
            this.textBoxTamanho.TabIndex = 3;
            this.textBoxTamanho.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamanho:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº de linhas:";
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 64);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(588, 421);
            this.canvas.TabIndex = 1;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 485);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "linhas psicodelicas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.TextBox textBoxLinhas;
        private System.Windows.Forms.TextBox textBoxAngulo;
        private System.Windows.Forms.TextBox textBoxTamanho;
        private System.Windows.Forms.Button buttonIr;
        private System.Windows.Forms.TextBox textBoxIncremento;
        private System.Windows.Forms.Label label4;
    }
}

