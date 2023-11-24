namespace Aula08_Att1_Calculadora_Forms
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
            this.Numero1Label = new System.Windows.Forms.Label();
            this.Numero2Label = new System.Windows.Forms.Label();
            this.numero1TextBox = new System.Windows.Forms.TextBox();
            this.numero2TextBox = new System.Windows.Forms.TextBox();
            this.SomarButton = new System.Windows.Forms.Button();
            this.SubtrairButton = new System.Windows.Forms.Button();
            this.DividirButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.RespostaLabel = new System.Windows.Forms.Label();
            this.MultiplicarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numero1Label
            // 
            this.Numero1Label.AutoSize = true;
            this.Numero1Label.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero1Label.Location = new System.Drawing.Point(29, 26);
            this.Numero1Label.Name = "Numero1Label";
            this.Numero1Label.Size = new System.Drawing.Size(76, 19);
            this.Numero1Label.TabIndex = 0;
            this.Numero1Label.Text = "Número 1";
            // 
            // Numero2Label
            // 
            this.Numero2Label.AutoSize = true;
            this.Numero2Label.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero2Label.Location = new System.Drawing.Point(28, 67);
            this.Numero2Label.Name = "Numero2Label";
            this.Numero2Label.Size = new System.Drawing.Size(79, 19);
            this.Numero2Label.TabIndex = 1;
            this.Numero2Label.Text = "Número 2";
            // 
            // numero1TextBox
            // 
            this.numero1TextBox.Location = new System.Drawing.Point(115, 25);
            this.numero1TextBox.Name = "numero1TextBox";
            this.numero1TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero1TextBox.TabIndex = 2;
            // 
            // numero2TextBox
            // 
            this.numero2TextBox.Location = new System.Drawing.Point(115, 67);
            this.numero2TextBox.Name = "numero2TextBox";
            this.numero2TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero2TextBox.TabIndex = 3;
            this.numero2TextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SomarButton
            // 
            this.SomarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SomarButton.Location = new System.Drawing.Point(32, 141);
            this.SomarButton.Name = "SomarButton";
            this.SomarButton.Size = new System.Drawing.Size(75, 23);
            this.SomarButton.TabIndex = 4;
            this.SomarButton.Text = "Somar";
            this.SomarButton.UseVisualStyleBackColor = true;
            this.SomarButton.Click += new System.EventHandler(this.SomarButton_Click);
            // 
            // SubtrairButton
            // 
            this.SubtrairButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubtrairButton.Location = new System.Drawing.Point(140, 141);
            this.SubtrairButton.Name = "SubtrairButton";
            this.SubtrairButton.Size = new System.Drawing.Size(75, 23);
            this.SubtrairButton.TabIndex = 5;
            this.SubtrairButton.Text = "Subtrair";
            this.SubtrairButton.UseVisualStyleBackColor = true;
            this.SubtrairButton.Click += new System.EventHandler(this.SubtrairButton_Click);
            // 
            // DividirButton
            // 
            this.DividirButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DividirButton.Location = new System.Drawing.Point(366, 141);
            this.DividirButton.Name = "DividirButton";
            this.DividirButton.Size = new System.Drawing.Size(75, 23);
            this.DividirButton.TabIndex = 7;
            this.DividirButton.Text = "Dividir";
            this.DividirButton.UseVisualStyleBackColor = true;
            this.DividirButton.Click += new System.EventHandler(this.DividirButton_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(32, 207);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 19);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Resposta:";
            // 
            // RespostaLabel
            // 
            this.RespostaLabel.AutoSize = true;
            this.RespostaLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RespostaLabel.Location = new System.Drawing.Point(137, 209);
            this.RespostaLabel.Name = "RespostaLabel";
            this.RespostaLabel.Size = new System.Drawing.Size(16, 17);
            this.RespostaLabel.TabIndex = 9;
            this.RespostaLabel.Text = "0";
            this.RespostaLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MultiplicarButton.Location = new System.Drawing.Point(255, 141);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplicarButton.TabIndex = 10;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            this.MultiplicarButton.Click += new System.EventHandler(this.MultiplicarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 261);
            this.Controls.Add(this.MultiplicarButton);
            this.Controls.Add(this.RespostaLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DividirButton);
            this.Controls.Add(this.SubtrairButton);
            this.Controls.Add(this.SomarButton);
            this.Controls.Add(this.numero2TextBox);
            this.Controls.Add(this.numero1TextBox);
            this.Controls.Add(this.Numero2Label);
            this.Controls.Add(this.Numero1Label);
            this.Name = "Form1";
            this.Text = "Calculadora Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numero1Label;
        private System.Windows.Forms.Label Numero2Label;
        private System.Windows.Forms.TextBox numero1TextBox;
        private System.Windows.Forms.TextBox numero2TextBox;
        private System.Windows.Forms.Button SomarButton;
        private System.Windows.Forms.Button SubtrairButton;
        private System.Windows.Forms.Button DividirButton;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label RespostaLabel;
        private System.Windows.Forms.Button MultiplicarButton;
    }
}

