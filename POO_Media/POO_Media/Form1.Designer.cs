namespace POO_Media
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
            this.n1 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.btn_calculaMedia = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Location = new System.Drawing.Point(64, 39);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(40, 13);
            this.n1.TabIndex = 0;
            this.n1.Text = "nota 1:";
            this.n1.Click += new System.EventHandler(this.label1_Click);
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Location = new System.Drawing.Point(64, 79);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(40, 13);
            this.n2.TabIndex = 1;
            this.n2.Text = "nota 2:";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(123, 36);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 2;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(123, 76);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_n2.TabIndex = 3;
            // 
            // btn_calculaMedia
            // 
            this.btn_calculaMedia.Location = new System.Drawing.Point(255, 39);
            this.btn_calculaMedia.Name = "btn_calculaMedia";
            this.btn_calculaMedia.Size = new System.Drawing.Size(75, 57);
            this.btn_calculaMedia.TabIndex = 4;
            this.btn_calculaMedia.Text = "Tirar média";
            this.btn_calculaMedia.UseVisualStyleBackColor = true;
            this.btn_calculaMedia.Click += new System.EventHandler(this.btn_calculaMedia_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(438, 58);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_calculaMedia);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Button btn_calculaMedia;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label1;
    }
}

