namespace ProjetoOrientadoObjetos
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
            this.txtNumeroUm = new System.Windows.Forms.TextBox();
            this.txtNumerodois = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtMostraresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o número um: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o número dois: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumeroUm
            // 
            this.txtNumeroUm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtNumeroUm.Location = new System.Drawing.Point(339, 165);
            this.txtNumeroUm.Name = "txtNumeroUm";
            this.txtNumeroUm.Size = new System.Drawing.Size(101, 20);
            this.txtNumeroUm.TabIndex = 2;
            // 
            // txtNumerodois
            // 
            this.txtNumerodois.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtNumerodois.Location = new System.Drawing.Point(339, 238);
            this.txtNumerodois.Name = "txtNumerodois";
            this.txtNumerodois.Size = new System.Drawing.Size(101, 20);
            this.txtNumerodois.TabIndex = 3;
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSomar.Location = new System.Drawing.Point(339, 284);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(101, 37);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Soma";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtMostraresultado
            // 
            this.txtMostraresultado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMostraresultado.Enabled = false;
            this.txtMostraresultado.Location = new System.Drawing.Point(339, 327);
            this.txtMostraresultado.Name = "txtMostraresultado";
            this.txtMostraresultado.Size = new System.Drawing.Size(101, 20);
            this.txtMostraresultado.TabIndex = 5;
            this.txtMostraresultado.TextChanged += new System.EventHandler(this.txtMostraresultado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::ProjetoOrientadoObjetos.Properties.Resources.mat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 484);
            this.Controls.Add(this.txtMostraresultado);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtNumerodois);
            this.Controls.Add(this.txtNumeroUm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Cálculo Soma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroUm;
        private System.Windows.Forms.TextBox txtNumerodois;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtMostraresultado;
    }
}

