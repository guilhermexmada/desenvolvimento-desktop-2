namespace POO_operacoes
{
    partial class box
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.RadioButton();
            this.btnSub = new System.Windows.Forms.RadioButton();
            this.btnMult = new System.Windows.Forms.RadioButton();
            this.btnDiv = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(94, 30);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 2;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(94, 81);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDiv);
            this.groupBox1.Controls.Add(this.btnMult);
            this.groupBox1.Controls.Add(this.btnSub);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(249, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operador";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(15, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 17);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.TabStop = true;
            this.btnAdd.Text = "Adição";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.AutoSize = true;
            this.btnSub.Location = new System.Drawing.Point(15, 52);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(74, 17);
            this.btnSub.TabIndex = 6;
            this.btnSub.TabStop = true;
            this.btnSub.Text = "Subtração";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.AutoSize = true;
            this.btnMult.Location = new System.Drawing.Point(15, 75);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(87, 17);
            this.btnMult.TabIndex = 7;
            this.btnMult.TabStop = true;
            this.btnMult.Text = "Multiplicação";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.AutoSize = true;
            this.btnDiv.Location = new System.Drawing.Point(15, 98);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(60, 17);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.TabStop = true;
            this.btnDiv.Text = "Divisão";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(497, 30);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 6;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(497, 110);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(100, 55);
            this.btnResultado.TabIndex = 7;
            this.btnResultado.Text = "Calcular";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 340);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "box";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnDiv;
        private System.Windows.Forms.RadioButton btnMult;
        private System.Windows.Forms.RadioButton btnSub;
        private System.Windows.Forms.RadioButton btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnResultado;
    }
}

