namespace Desafio_Supervisionado_IMC
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
            this.IMC = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.imcresultado = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IMC
            // 
            this.IMC.AutoSize = true;
            this.IMC.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMC.Location = new System.Drawing.Point(88, 28);
            this.IMC.Name = "IMC";
            this.IMC.Size = new System.Drawing.Size(67, 34);
            this.IMC.TabIndex = 0;
            this.IMC.Text = "IMC";
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(26, 80);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(34, 13);
            this.peso.TabIndex = 1;
            this.peso.Text = "Peso:";
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(29, 157);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(37, 13);
            this.altura.TabIndex = 2;
            this.altura.Text = "Altura:";
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(94, 80);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(75, 23);
            this.n1.TabIndex = 3;
            this.n1.UseVisualStyleBackColor = true;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(94, 157);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(75, 23);
            this.n2.TabIndex = 4;
            this.n2.UseVisualStyleBackColor = true;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(29, 218);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(195, 54);
            this.Calcular.TabIndex = 5;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // imcresultado
            // 
            this.imcresultado.AutoSize = true;
            this.imcresultado.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imcresultado.Location = new System.Drawing.Point(32, 325);
            this.imcresultado.Name = "imcresultado";
            this.imcresultado.Size = new System.Drawing.Size(44, 21);
            this.imcresultado.TabIndex = 6;
            this.imcresultado.Text = "IMC:";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(94, 316);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(75, 41);
            this.resultado.TabIndex = 7;
            this.resultado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 487);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.imcresultado);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.IMC);
            this.Name = "Form1";
            this.Text = "Calcular IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IMC;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label imcresultado;
        private System.Windows.Forms.Button resultado;
    }
}

