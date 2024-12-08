namespace projetoOOExemplo2
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
            this.txt_idade1 = new System.Windows.Forms.TextBox();
            this.txt_idade2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_somar = new System.Windows.Forms.RadioButton();
            this.rdb_subtrair = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_CalcularIdade = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade 2:";
            // 
            // txt_idade1
            // 
            this.txt_idade1.Location = new System.Drawing.Point(90, 41);
            this.txt_idade1.Name = "txt_idade1";
            this.txt_idade1.Size = new System.Drawing.Size(100, 20);
            this.txt_idade1.TabIndex = 2;
            // 
            // txt_idade2
            // 
            this.txt_idade2.Location = new System.Drawing.Point(90, 93);
            this.txt_idade2.Name = "txt_idade2";
            this.txt_idade2.Size = new System.Drawing.Size(100, 20);
            this.txt_idade2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_subtrair);
            this.groupBox1.Controls.Add(this.rdb_somar);
            this.groupBox1.Location = new System.Drawing.Point(41, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha a operação";
            // 
            // rdb_somar
            // 
            this.rdb_somar.AutoSize = true;
            this.rdb_somar.Location = new System.Drawing.Point(36, 42);
            this.rdb_somar.Name = "rdb_somar";
            this.rdb_somar.Size = new System.Drawing.Size(89, 17);
            this.rdb_somar.TabIndex = 0;
            this.rdb_somar.TabStop = true;
            this.rdb_somar.Text = "Somar idades";
            this.rdb_somar.UseVisualStyleBackColor = true;
            this.rdb_somar.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdb_subtrair
            // 
            this.rdb_subtrair.AutoSize = true;
            this.rdb_subtrair.Location = new System.Drawing.Point(131, 42);
            this.rdb_subtrair.Name = "rdb_subtrair";
            this.rdb_subtrair.Size = new System.Drawing.Size(98, 17);
            this.rdb_subtrair.TabIndex = 1;
            this.rdb_subtrair.TabStop = true;
            this.rdb_subtrair.Text = "Subtrair  idades";
            this.rdb_subtrair.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado:";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(102, 277);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 7;
            // 
            // btn_CalcularIdade
            // 
            this.btn_CalcularIdade.Location = new System.Drawing.Point(221, 265);
            this.btn_CalcularIdade.Name = "btn_CalcularIdade";
            this.btn_CalcularIdade.Size = new System.Drawing.Size(92, 43);
            this.btn_CalcularIdade.TabIndex = 9;
            this.btn_CalcularIdade.Text = "Calcular Idade";
            this.btn_CalcularIdade.UseVisualStyleBackColor = true;
            this.btn_CalcularIdade.Click += new System.EventHandler(this.btn_CalcularIdade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 353);
            this.Controls.Add(this.btn_CalcularIdade);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_idade2);
            this.Controls.Add(this.txt_idade1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculo Idade";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idade1;
        private System.Windows.Forms.TextBox txt_idade2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_somar;
        private System.Windows.Forms.RadioButton rdb_subtrair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_CalcularIdade;
    }
}

