namespace ProjetBI_DataGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_log = new System.Windows.Forms.TextBox();
            this.m_export = new System.Windows.Forms.Button();
            this.m_sizeController = new System.Windows.Forms.TextBox();
            this.m_checkHeader = new System.Windows.Forms.CheckBox();
            this.m_LabelSizeControll = new System.Windows.Forms.Label();
            this.m_optionsTitle = new System.Windows.Forms.Label();
            this.m_Close = new System.Windows.Forms.Button();
            this.m_sql = new System.Windows.Forms.Button();
            this.m_datasCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // m_log
            // 
            this.m_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_log.Enabled = false;
            this.m_log.Location = new System.Drawing.Point(12, 12);
            this.m_log.Multiline = true;
            this.m_log.Name = "m_log";
            this.m_log.ReadOnly = true;
            this.m_log.Size = new System.Drawing.Size(156, 208);
            this.m_log.TabIndex = 2;
            // 
            // m_export
            // 
            this.m_export.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.m_export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.m_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_export.Location = new System.Drawing.Point(12, 227);
            this.m_export.Name = "m_export";
            this.m_export.Size = new System.Drawing.Size(156, 23);
            this.m_export.TabIndex = 3;
            this.m_export.Text = "Export to CSV";
            this.m_export.UseVisualStyleBackColor = false;
            this.m_export.Click += new System.EventHandler(this.exportClick);
            // 
            // m_sizeController
            // 
            this.m_sizeController.HideSelection = false;
            this.m_sizeController.Location = new System.Drawing.Point(174, 48);
            this.m_sizeController.Name = "m_sizeController";
            this.m_sizeController.Size = new System.Drawing.Size(100, 20);
            this.m_sizeController.TabIndex = 4;
            this.m_sizeController.Text = "1";
            // 
            // m_checkHeader
            // 
            this.m_checkHeader.AutoSize = true;
            this.m_checkHeader.Location = new System.Drawing.Point(174, 74);
            this.m_checkHeader.Name = "m_checkHeader";
            this.m_checkHeader.Size = new System.Drawing.Size(91, 17);
            this.m_checkHeader.TabIndex = 5;
            this.m_checkHeader.Text = "With Headers";
            this.m_checkHeader.UseVisualStyleBackColor = true;
            // 
            // m_LabelSizeControll
            // 
            this.m_LabelSizeControll.AutoSize = true;
            this.m_LabelSizeControll.Location = new System.Drawing.Point(174, 32);
            this.m_LabelSizeControll.Name = "m_LabelSizeControll";
            this.m_LabelSizeControll.Size = new System.Drawing.Size(83, 13);
            this.m_LabelSizeControll.TabIndex = 6;
            this.m_LabelSizeControll.Text = "Orders needed :";
            // 
            // m_optionsTitle
            // 
            this.m_optionsTitle.AutoSize = true;
            this.m_optionsTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_optionsTitle.Location = new System.Drawing.Point(188, 9);
            this.m_optionsTitle.Name = "m_optionsTitle";
            this.m_optionsTitle.Size = new System.Drawing.Size(81, 23);
            this.m_optionsTitle.TabIndex = 7;
            this.m_optionsTitle.Text = "Options :";
            // 
            // m_Close
            // 
            this.m_Close.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.m_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.m_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_Close.Location = new System.Drawing.Point(177, 227);
            this.m_Close.Name = "m_Close";
            this.m_Close.Size = new System.Drawing.Size(97, 23);
            this.m_Close.TabIndex = 8;
            this.m_Close.Text = "Exit";
            this.m_Close.UseVisualStyleBackColor = false;
            this.m_Close.Click += new System.EventHandler(this.m_CloseClick);
            // 
            // m_sql
            // 
            this.m_sql.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_sql.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.m_sql.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.m_sql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_sql.Location = new System.Drawing.Point(210, 160);
            this.m_sql.Name = "m_sql";
            this.m_sql.Size = new System.Drawing.Size(47, 25);
            this.m_sql.TabIndex = 9;
            this.m_sql.Text = "Export to CSV";
            this.m_sql.UseVisualStyleBackColor = false;
            this.m_sql.Click += new System.EventHandler(this.m_sql_Click);
            // 
            // m_datasCheck
            // 
            this.m_datasCheck.AutoSize = true;
            this.m_datasCheck.Location = new System.Drawing.Point(174, 97);
            this.m_datasCheck.Name = "m_datasCheck";
            this.m_datasCheck.Size = new System.Drawing.Size(79, 17);
            this.m_datasCheck.TabIndex = 10;
            this.m_datasCheck.Text = "With Datas";
            this.m_datasCheck.UseVisualStyleBackColor = true;
            this.m_datasCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(286, 262);
            this.Controls.Add(this.m_datasCheck);
            this.Controls.Add(this.m_sql);
            this.Controls.Add(this.m_Close);
            this.Controls.Add(this.m_optionsTitle);
            this.Controls.Add(this.m_LabelSizeControll);
            this.Controls.Add(this.m_checkHeader);
            this.Controls.Add(this.m_sizeController);
            this.Controls.Add(this.m_export);
            this.Controls.Add(this.m_log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DataGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox m_log;
        private System.Windows.Forms.Button m_export;
        private System.Windows.Forms.TextBox m_sizeController;
        private System.Windows.Forms.CheckBox m_checkHeader;
        private System.Windows.Forms.Label m_LabelSizeControll;
        private System.Windows.Forms.Label m_optionsTitle;
        private System.Windows.Forms.Button m_Close;
        private System.Windows.Forms.Button m_sql;
        private System.Windows.Forms.CheckBox m_datasCheck;
    }
}

