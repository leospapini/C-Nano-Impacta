namespace Aula08_Att3_Forms
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
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.valorLabel2 = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.respostaLabel = new System.Windows.Forms.Label();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeLabel.Location = new System.Drawing.Point(74, 55);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(91, 21);
            this.quantidadeLabel.TabIndex = 0;
            this.quantidadeLabel.Text = "Quantidade";
            // 
            // valorLabel2
            // 
            this.valorLabel2.AutoSize = true;
            this.valorLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorLabel2.Location = new System.Drawing.Point(74, 98);
            this.valorLabel2.Name = "valorLabel2";
            this.valorLabel2.Size = new System.Drawing.Size(45, 21);
            this.valorLabel2.TabIndex = 1;
            this.valorLabel2.Text = "Valor";
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(78, 150);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(194, 23);
            this.calcularButton.TabIndex = 2;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // respostaLabel
            // 
            this.respostaLabel.AutoSize = true;
            this.respostaLabel.Location = new System.Drawing.Point(75, 203);
            this.respostaLabel.Name = "respostaLabel";
            this.respostaLabel.Size = new System.Drawing.Size(13, 13);
            this.respostaLabel.TabIndex = 3;
            this.respostaLabel.Text = "0";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Location = new System.Drawing.Point(172, 55);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 4;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(172, 98);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 254);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(this.respostaLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.valorLabel2);
            this.Controls.Add(this.quantidadeLabel);
            this.Name = "Form1";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.Label valorLabel2;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label respostaLabel;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
    }
}

