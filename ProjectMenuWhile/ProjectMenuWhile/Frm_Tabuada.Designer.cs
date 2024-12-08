namespace ProjectMenuWhile
{
    partial class Frm_Tabuada
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
            this.txt_tabuada = new System.Windows.Forms.TextBox();
            this.nud_inicial = new System.Windows.Forms.NumericUpDown();
            this.nud_final = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_inicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_final)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a Tabuada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor inicial:";
            // 
            // txt_tabuada
            // 
            this.txt_tabuada.Location = new System.Drawing.Point(158, 28);
            this.txt_tabuada.Name = "txt_tabuada";
            this.txt_tabuada.Size = new System.Drawing.Size(100, 20);
            this.txt_tabuada.TabIndex = 2;
            // 
            // nud_inicial
            // 
            this.nud_inicial.Location = new System.Drawing.Point(158, 70);
            this.nud_inicial.Name = "nud_inicial";
            this.nud_inicial.Size = new System.Drawing.Size(100, 20);
            this.nud_inicial.TabIndex = 4;
            // 
            // nud_final
            // 
            this.nud_final.Location = new System.Drawing.Point(158, 115);
            this.nud_final.Name = "nud_final";
            this.nud_final.Size = new System.Drawing.Size(100, 20);
            this.nud_final.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor inicial:";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(88, 165);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_resultado.Size = new System.Drawing.Size(272, 158);
            this.txt_resultado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjectMenuWhile.Properties.Resources.imagem1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(282, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 107);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Image = global::ProjectMenuWhile.Properties.Resources.baixo;
            this.btn_calcular.Location = new System.Drawing.Point(148, 342);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(136, 79);
            this.btn_calcular.TabIndex = 9;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Frm_Tabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.nud_final);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_inicial);
            this.Controls.Add(this.txt_tabuada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Tabuada";
            this.Text = "Exercício Tabuada";
            this.Load += new System.EventHandler(this.Frm_Tabuada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_inicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_final)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tabuada;
        private System.Windows.Forms.NumericUpDown nud_inicial;
        private System.Windows.Forms.NumericUpDown nud_final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}