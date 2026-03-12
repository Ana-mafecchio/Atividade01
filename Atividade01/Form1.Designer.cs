namespace Atividade01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbResultado = new System.Windows.Forms.Label();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.btnIdade = new System.Windows.Forms.Button();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLetra = new System.Windows.Forms.Button();
            this.btnAprendendo = new System.Windows.Forms.Button();
            this.btnContar10 = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(205, 131);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 0;
            this.lbResultado.Text = "Resultado";
            this.lbResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(208, 95);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(310, 20);
            this.txtCampo.TabIndex = 1;
            // 
            // btnIdade
            // 
            this.btnIdade.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIdade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIdade.Location = new System.Drawing.Point(208, 161);
            this.btnIdade.Name = "btnIdade";
            this.btnIdade.Size = new System.Drawing.Size(152, 73);
            this.btnIdade.TabIndex = 2;
            this.btnIdade.Text = "Calcular Idade";
            this.btnIdade.UseVisualStyleBackColor = false;
            // 
            // btnTabuada
            // 
            this.btnTabuada.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTabuada.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTabuada.Location = new System.Drawing.Point(366, 161);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(152, 73);
            this.btnTabuada.TabIndex = 3;
            this.btnTabuada.Text = "Calcular Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 72);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnLetra
            // 
            this.btnLetra.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLetra.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLetra.Location = new System.Drawing.Point(208, 240);
            this.btnLetra.Name = "btnLetra";
            this.btnLetra.Size = new System.Drawing.Size(152, 72);
            this.btnLetra.TabIndex = 5;
            this.btnLetra.Text = "Verificar Letra";
            this.btnLetra.UseVisualStyleBackColor = false;
            // 
            // btnAprendendo
            // 
            this.btnAprendendo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAprendendo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAprendendo.Location = new System.Drawing.Point(366, 240);
            this.btnAprendendo.Name = "btnAprendendo";
            this.btnAprendendo.Size = new System.Drawing.Size(152, 72);
            this.btnAprendendo.TabIndex = 6;
            this.btnAprendendo.Text = "Estou Aprendendo";
            this.btnAprendendo.UseVisualStyleBackColor = false;
            // 
            // btnContar10
            // 
            this.btnContar10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnContar10.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContar10.Location = new System.Drawing.Point(208, 318);
            this.btnContar10.Name = "btnContar10";
            this.btnContar10.Size = new System.Drawing.Size(152, 72);
            this.btnContar10.TabIndex = 7;
            this.btnContar10.Text = "Contar até 10";
            this.btnContar10.UseVisualStyleBackColor = false;
            this.btnContar10.Click += new System.EventHandler(this.btnContar10_Click_1);
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnJogar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJogar.Location = new System.Drawing.Point(366, 318);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(152, 72);
            this.btnJogar.TabIndex = 8;
            this.btnJogar.Text = "Mini Jogo";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnContar10);
            this.Controls.Add(this.btnAprendendo);
            this.Controls.Add(this.btnLetra);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.btnIdade);
            this.Controls.Add(this.txtCampo);
            this.Controls.Add(this.lbResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Button btnIdade;
        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLetra;
        private System.Windows.Forms.Button btnAprendendo;
        private System.Windows.Forms.Button btnContar10;
        private System.Windows.Forms.Button btnJogar;
    }
}

