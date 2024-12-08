namespace POO_AreaTrapezio
{
    partial class Trapézio
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bmenor = new System.Windows.Forms.TextBox();
            this.txt_bmaior = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_resposta = new System.Windows.Forms.TextBox();
            this.btn_calculo = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular Área de um Trapézio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base menor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Base maior:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Altura:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_bmenor
            // 
            this.txt_bmenor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bmenor.Location = new System.Drawing.Point(84, 45);
            this.txt_bmenor.Name = "txt_bmenor";
            this.txt_bmenor.Size = new System.Drawing.Size(100, 22);
            this.txt_bmenor.TabIndex = 4;
            this.txt_bmenor.TextChanged += new System.EventHandler(this.txt_bmenor_TextChanged);
            // 
            // txt_bmaior
            // 
            this.txt_bmaior.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bmaior.Location = new System.Drawing.Point(84, 94);
            this.txt_bmaior.Name = "txt_bmaior";
            this.txt_bmaior.Size = new System.Drawing.Size(100, 22);
            this.txt_bmaior.TabIndex = 5;
            this.txt_bmaior.TextChanged += new System.EventHandler(this.txt_bmaior_TextChanged);
            // 
            // txt_altura
            // 
            this.txt_altura.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_altura.Location = new System.Drawing.Point(58, 144);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 22);
            this.txt_altura.TabIndex = 6;
            this.txt_altura.TextChanged += new System.EventHandler(this.txt_altura_TextChanged);
            // 
            // txt_resposta
            // 
            this.txt_resposta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resposta.Location = new System.Drawing.Point(111, 192);
            this.txt_resposta.Name = "txt_resposta";
            this.txt_resposta.Size = new System.Drawing.Size(100, 22);
            this.txt_resposta.TabIndex = 7;
            this.txt_resposta.TextChanged += new System.EventHandler(this.txt_resposta_TextChanged);
            // 
            // btn_calculo
            // 
            this.btn_calculo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculo.Location = new System.Drawing.Point(12, 192);
            this.btn_calculo.Name = "btn_calculo";
            this.btn_calculo.Size = new System.Drawing.Size(75, 23);
            this.btn_calculo.TabIndex = 8;
            this.btn_calculo.Text = "Calcular";
            this.btn_calculo.UseVisualStyleBackColor = true;
            this.btn_calculo.Click += new System.EventHandler(this.btn_calculo_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(197, 226);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // Trapézio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_calculo);
            this.Controls.Add(this.txt_resposta);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_bmaior);
            this.Controls.Add(this.txt_bmenor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Trapézio";
            this.Text = "Área do Trapézio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bmenor;
        private System.Windows.Forms.TextBox txt_bmaior;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_resposta;
        private System.Windows.Forms.Button btn_calculo;
        private System.Windows.Forms.Button btn_sair;
    }
}

