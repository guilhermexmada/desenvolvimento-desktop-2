namespace ConversorMedidas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.converterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metrosPésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centímetrosPolegadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
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
            // metrosPésToolStripMenuItem
            // 
            this.metrosPésToolStripMenuItem.Name = "metrosPésToolStripMenuItem";
            this.metrosPésToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.metrosPésToolStripMenuItem.Text = "Metros => Pés";
            this.metrosPésToolStripMenuItem.Click += new System.EventHandler(this.metrosPésToolStripMenuItem_Click);
            // 
            // centímetrosPolegadasToolStripMenuItem
            // 
            this.centímetrosPolegadasToolStripMenuItem.Name = "centímetrosPolegadasToolStripMenuItem";
            this.centímetrosPolegadasToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.centímetrosPolegadasToolStripMenuItem.Text = "Centímetros => Polegadas";
            this.centímetrosPolegadasToolStripMenuItem.Click += new System.EventHandler(this.centímetrosPolegadasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 485);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem converterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metrosPésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centímetrosPolegadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

