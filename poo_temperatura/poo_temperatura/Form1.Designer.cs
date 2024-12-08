namespace poo_temperatura
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
            this.txt_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.txt_convert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_cf = new System.Windows.Forms.RadioButton();
            this.rb_fc = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_t
            // 
            this.txt_t.Location = new System.Drawing.Point(128, 83);
            this.txt_t.Name = "txt_t";
            this.txt_t.Size = new System.Drawing.Size(100, 20);
            this.txt_t.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura";
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(143, 158);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "button1";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // txt_convert
            // 
            this.txt_convert.Location = new System.Drawing.Point(128, 122);
            this.txt_convert.Name = "txt_convert";
            this.txt_convert.Size = new System.Drawing.Size(100, 20);
            this.txt_convert.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Conversão";
            // 
            // rb_cf
            // 
            this.rb_cf.AutoSize = true;
            this.rb_cf.Location = new System.Drawing.Point(280, 87);
            this.rb_cf.Name = "rb_cf";
            this.rb_cf.Size = new System.Drawing.Size(123, 17);
            this.rb_cf.TabIndex = 5;
            this.rb_cf.TabStop = true;
            this.rb_cf.Text = "Celsius -> Fahrenheit";
            this.rb_cf.UseVisualStyleBackColor = true;
            // 
            // rb_fc
            // 
            this.rb_fc.AutoSize = true;
            this.rb_fc.Location = new System.Drawing.Point(280, 122);
            this.rb_fc.Name = "rb_fc";
            this.rb_fc.Size = new System.Drawing.Size(126, 17);
            this.rb_fc.TabIndex = 6;
            this.rb_fc.TabStop = true;
            this.rb_fc.Text = "Fahrenheit -> Celsius ";
            this.rb_fc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 312);
            this.Controls.Add(this.rb_fc);
            this.Controls.Add(this.rb_cf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_convert);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_t);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.TextBox txt_convert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_cf;
        private System.Windows.Forms.RadioButton rb_fc;
    }
}

