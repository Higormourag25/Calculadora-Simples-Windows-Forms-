namespace Aula01
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioSoma = new System.Windows.Forms.RadioButton();
            this.radioSub = new System.Windows.Forms.RadioButton();
            this.radioDiv = new System.Windows.Forms.RadioButton();
            this.radioMult = new System.Windows.Forms.RadioButton();
            this.textRes = new System.Windows.Forms.TextBox();
            this.buttonFim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // radioSoma
            // 
            this.radioSoma.AutoSize = true;
            this.radioSoma.Location = new System.Drawing.Point(53, 72);
            this.radioSoma.Name = "radioSoma";
            this.radioSoma.Size = new System.Drawing.Size(52, 17);
            this.radioSoma.TabIndex = 2;
            this.radioSoma.TabStop = true;
            this.radioSoma.Text = "Soma";
            this.radioSoma.UseVisualStyleBackColor = true;
            this.radioSoma.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioSub
            // 
            this.radioSub.AutoSize = true;
            this.radioSub.Location = new System.Drawing.Point(53, 95);
            this.radioSub.Name = "radioSub";
            this.radioSub.Size = new System.Drawing.Size(74, 17);
            this.radioSub.TabIndex = 3;
            this.radioSub.TabStop = true;
            this.radioSub.Text = "Subtração";
            this.radioSub.UseVisualStyleBackColor = true;
            this.radioSub.CheckedChanged += new System.EventHandler(this.radioSub_CheckedChanged);
            // 
            // radioDiv
            // 
            this.radioDiv.AutoSize = true;
            this.radioDiv.Location = new System.Drawing.Point(53, 118);
            this.radioDiv.Name = "radioDiv";
            this.radioDiv.Size = new System.Drawing.Size(60, 17);
            this.radioDiv.TabIndex = 4;
            this.radioDiv.TabStop = true;
            this.radioDiv.Text = "Divisão";
            this.radioDiv.UseVisualStyleBackColor = true;
            this.radioDiv.CheckedChanged += new System.EventHandler(this.radioDiv_CheckedChanged);
            // 
            // radioMult
            // 
            this.radioMult.AutoSize = true;
            this.radioMult.Location = new System.Drawing.Point(53, 141);
            this.radioMult.Name = "radioMult";
            this.radioMult.Size = new System.Drawing.Size(87, 17);
            this.radioMult.TabIndex = 5;
            this.radioMult.TabStop = true;
            this.radioMult.Text = "Multiplicação";
            this.radioMult.UseVisualStyleBackColor = true;
            this.radioMult.CheckedChanged += new System.EventHandler(this.radioMult_CheckedChanged);
            // 
            // textRes
            // 
            this.textRes.Location = new System.Drawing.Point(53, 180);
            this.textRes.Name = "textRes";
            this.textRes.Size = new System.Drawing.Size(100, 20);
            this.textRes.TabIndex = 6;
            this.textRes.Tag = "";
            // 
            // buttonFim
            // 
            this.buttonFim.Location = new System.Drawing.Point(159, 179);
            this.buttonFim.Name = "buttonFim";
            this.buttonFim.Size = new System.Drawing.Size(64, 20);
            this.buttonFim.TabIndex = 7;
            this.buttonFim.Text = "Resultado ";
            this.buttonFim.UseVisualStyleBackColor = true;
            this.buttonFim.Click += new System.EventHandler(this.buttonFim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 257);
            this.Controls.Add(this.buttonFim);
            this.Controls.Add(this.textRes);
            this.Controls.Add(this.radioMult);
            this.Controls.Add(this.radioDiv);
            this.Controls.Add(this.radioSub);
            this.Controls.Add(this.radioSoma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Calculadora Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioSoma;
        private System.Windows.Forms.RadioButton radioSub;
        private System.Windows.Forms.RadioButton radioDiv;
        private System.Windows.Forms.RadioButton radioMult;
        private System.Windows.Forms.TextBox textRes;
        private System.Windows.Forms.Button buttonFim;
    }
}

