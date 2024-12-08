namespace POO_IMC
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.btn_calculo = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_imc = new System.Windows.Forms.Label();
            this.lb_situacao = new System.Windows.Forms.Label();
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Altura;";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IMC =>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Situação: ";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(91, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(147, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(91, 118);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(147, 20);
            this.txt_peso.TabIndex = 8;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(91, 157);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(147, 20);
            this.txt_altura.TabIndex = 9;
            // 
            // btn_calculo
            // 
            this.btn_calculo.Location = new System.Drawing.Point(313, 49);
            this.btn_calculo.Name = "btn_calculo";
            this.btn_calculo.Size = new System.Drawing.Size(88, 28);
            this.btn_calculo.TabIndex = 10;
            this.btn_calculo.Text = "Calcular";
            this.btn_calculo.UseVisualStyleBackColor = true;
            this.btn_calculo.Click += new System.EventHandler(this.btn_calculo_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(313, 94);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(88, 28);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_imc
            // 
            this.lb_imc.AutoSize = true;
            this.lb_imc.Location = new System.Drawing.Point(553, 79);
            this.lb_imc.Name = "lb_imc";
            this.lb_imc.Size = new System.Drawing.Size(16, 13);
            this.lb_imc.TabIndex = 13;
            this.lb_imc.Text = "...";
            // 
            // lb_situacao
            // 
            this.lb_situacao.AutoSize = true;
            this.lb_situacao.Location = new System.Drawing.Point(553, 121);
            this.lb_situacao.Name = "lb_situacao";
            this.lb_situacao.Size = new System.Drawing.Size(16, 13);
            this.lb_situacao.TabIndex = 14;
            this.lb_situacao.Text = "...";
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Items.AddRange(new object[] {
            "masculino",
            "feminino"});
            this.cmb_sexo.Location = new System.Drawing.Point(91, 76);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(147, 21);
            this.cmb_sexo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 433);
            this.Controls.Add(this.cmb_sexo);
            this.Controls.Add(this.lb_situacao);
            this.Controls.Add(this.lb_imc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calculo);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Button btn_calculo;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_imc;
        private System.Windows.Forms.Label lb_situacao;
        private System.Windows.Forms.ComboBox cmb_sexo;
    }
}

