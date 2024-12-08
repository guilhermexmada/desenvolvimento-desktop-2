namespace ConversorMedidas
{
    partial class MetrosPes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.converterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metrosPésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centímetrosPolegadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_metros = new System.Windows.Forms.TextBox();
            this.txt_pes = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.converterToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(351, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // converterToolStripMenuItem
            // 
            this.converterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metrosPésToolStripMenuItem,
            this.centímetrosPolegadasToolStripMenuItem});
            this.converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            this.converterToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.converterToolStripMenuItem.Text = "Converter";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // metrosPésToolStripMenuItem
            // 
            this.metrosPésToolStripMenuItem.Name = "metrosPésToolStripMenuItem";
            this.metrosPésToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.metrosPésToolStripMenuItem.Text = "Metros => Pés";
            // 
            // centímetrosPolegadasToolStripMenuItem
            // 
            this.centímetrosPolegadasToolStripMenuItem.Name = "centímetrosPolegadasToolStripMenuItem";
            this.centímetrosPolegadasToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.centímetrosPolegadasToolStripMenuItem.Text = "Centímetros => Polegadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor em metros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor em pés";
            // 
            // txt_metros
            // 
            this.txt_metros.Location = new System.Drawing.Point(164, 86);
            this.txt_metros.Name = "txt_metros";
            this.txt_metros.Size = new System.Drawing.Size(100, 20);
            this.txt_metros.TabIndex = 3;
            // 
            // txt_pes
            // 
            this.txt_pes.Location = new System.Drawing.Point(164, 148);
            this.txt_pes.Name = "txt_pes";
            this.txt_pes.Size = new System.Drawing.Size(100, 20);
            this.txt_pes.TabIndex = 4;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(64, 202);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(200, 34);
            this.btn_convert.TabIndex = 5;
            this.btn_convert.Text = "Converter";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // MetrosPes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 305);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_pes);
            this.Controls.Add(this.txt_metros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MetrosPes";
            this.Text = "MetrosPes";
            this.Load += new System.EventHandler(this.MetrosPes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem converterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metrosPésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centímetrosPolegadasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_metros;
        private System.Windows.Forms.TextBox txt_pes;
        private System.Windows.Forms.Button btn_convert;
    }
}