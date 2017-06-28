namespace ProjetBI_DataGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_generate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_generate
            // 
            this.m_generate.Location = new System.Drawing.Point(12, 226);
            this.m_generate.Name = "m_generate";
            this.m_generate.Size = new System.Drawing.Size(172, 23);
            this.m_generate.TabIndex = 0;
            this.m_generate.Text = "Generate 1 command";
            this.m_generate.UseVisualStyleBackColor = true;
            this.m_generate.Click += new System.EventHandler(this.generateClick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 208);
            this.textBox1.TabIndex = 2;
            // 
            // m_export
            // 
            this.m_export.Enabled = false;
            this.m_export.Location = new System.Drawing.Point(191, 227);
            this.m_export.Name = "m_export";
            this.m_export.Size = new System.Drawing.Size(75, 23);
            this.m_export.TabIndex = 3;
            this.m_export.Text = "Export to CSV";
            this.m_export.UseVisualStyleBackColor = true;
            this.m_export.Click += new System.EventHandler(this.exportClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.m_export);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.m_generate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_generate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button m_export;
    }
}

