namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTool = new System.Windows.Forms.ToolStripMenuItem();
            this.newProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addSite = new System.Windows.Forms.Button();
            this.addFirm = new System.Windows.Forms.Button();
            this.registerBox = new System.Windows.Forms.RichTextBox();
            this.addAnalysis = new System.Windows.Forms.Button();
            this.addRegister = new System.Windows.Forms.Button();
            this.addPlate = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.analysisBox = new System.Windows.Forms.RichTextBox();
            this.siteBox = new System.Windows.Forms.RichTextBox();
            this.firmBox = new System.Windows.Forms.RichTextBox();
            this.firmButton = new System.Windows.Forms.Button();
            this.siteButton = new System.Windows.Forms.Button();
            this.analysisButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.missingAnalysisButton = new System.Windows.Forms.Button();
            this.invalidAnalysisBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTool,
            this.newProject});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openTool
            // 
            this.openTool.Name = "openTool";
            this.openTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openTool.Size = new System.Drawing.Size(159, 22);
            this.openTool.Text = "Apri";
            this.openTool.Click += new System.EventHandler(this.openTool_Click);
            // 
            // newProject
            // 
            this.newProject.Name = "newProject";
            this.newProject.Size = new System.Drawing.Size(159, 22);
            this.newProject.Text = "Nuovo Progetto";
            this.newProject.Click += new System.EventHandler(this.newProject_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // addSite
            // 
            this.addSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSite.Location = new System.Drawing.Point(875, 235);
            this.addSite.Name = "addSite";
            this.addSite.Size = new System.Drawing.Size(131, 39);
            this.addSite.TabIndex = 4;
            this.addSite.Text = "Aggiungi Cantiere";
            this.addSite.UseVisualStyleBackColor = true;
            this.addSite.Click += new System.EventHandler(this.addSite_Click);
            // 
            // addFirm
            // 
            this.addFirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFirm.Location = new System.Drawing.Point(875, 190);
            this.addFirm.Name = "addFirm";
            this.addFirm.Size = new System.Drawing.Size(131, 39);
            this.addFirm.TabIndex = 2;
            this.addFirm.Text = "Aggiungi Impresa";
            this.addFirm.UseVisualStyleBackColor = true;
            this.addFirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addImpresa_MouseClick);
            // 
            // registerBox
            // 
            this.registerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBox.Location = new System.Drawing.Point(12, 84);
            this.registerBox.Name = "registerBox";
            this.registerBox.Size = new System.Drawing.Size(857, 473);
            this.registerBox.TabIndex = 6;
            this.registerBox.Text = "";
            // 
            // addAnalysis
            // 
            this.addAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addAnalysis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnalysis.Location = new System.Drawing.Point(875, 280);
            this.addAnalysis.Name = "addAnalysis";
            this.addAnalysis.Size = new System.Drawing.Size(131, 39);
            this.addAnalysis.TabIndex = 7;
            this.addAnalysis.Text = "Aggiungi Analisi";
            this.addAnalysis.UseVisualStyleBackColor = true;
            this.addAnalysis.Click += new System.EventHandler(this.addAnalysis_Click);
            // 
            // addRegister
            // 
            this.addRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRegister.Location = new System.Drawing.Point(875, 84);
            this.addRegister.Name = "addRegister";
            this.addRegister.Size = new System.Drawing.Size(133, 65);
            this.addRegister.TabIndex = 8;
            this.addRegister.Text = "Aggiungi Registro";
            this.addRegister.UseVisualStyleBackColor = true;
            this.addRegister.Click += new System.EventHandler(this.addRegister_Click);
            // 
            // addPlate
            // 
            this.addPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlate.Location = new System.Drawing.Point(875, 325);
            this.addPlate.Name = "addPlate";
            this.addPlate.Size = new System.Drawing.Size(131, 39);
            this.addPlate.TabIndex = 9;
            this.addPlate.Text = "Aggiungi Targa";
            this.addPlate.UseVisualStyleBackColor = true;
            this.addPlate.Click += new System.EventHandler(this.addPlate_Click);
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(873, 492);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(133, 65);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "Stampa";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // analysisBox
            // 
            this.analysisBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.analysisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisBox.Location = new System.Drawing.Point(12, 84);
            this.analysisBox.Name = "analysisBox";
            this.analysisBox.Size = new System.Drawing.Size(857, 470);
            this.analysisBox.TabIndex = 11;
            this.analysisBox.Text = "";
            // 
            // siteBox
            // 
            this.siteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteBox.Location = new System.Drawing.Point(12, 84);
            this.siteBox.Name = "siteBox";
            this.siteBox.Size = new System.Drawing.Size(857, 470);
            this.siteBox.TabIndex = 12;
            this.siteBox.Text = "";
            // 
            // firmBox
            // 
            this.firmBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firmBox.Location = new System.Drawing.Point(12, 84);
            this.firmBox.Name = "firmBox";
            this.firmBox.Size = new System.Drawing.Size(857, 470);
            this.firmBox.TabIndex = 13;
            this.firmBox.Text = "";
            // 
            // firmButton
            // 
            this.firmButton.Location = new System.Drawing.Point(13, 28);
            this.firmButton.Name = "firmButton";
            this.firmButton.Size = new System.Drawing.Size(98, 28);
            this.firmButton.TabIndex = 14;
            this.firmButton.Text = "Imprese";
            this.firmButton.UseVisualStyleBackColor = true;
            this.firmButton.Click += new System.EventHandler(this.firmButton_Click);
            // 
            // siteButton
            // 
            this.siteButton.Location = new System.Drawing.Point(117, 27);
            this.siteButton.Name = "siteButton";
            this.siteButton.Size = new System.Drawing.Size(98, 28);
            this.siteButton.TabIndex = 15;
            this.siteButton.Text = "Cantieri";
            this.siteButton.UseVisualStyleBackColor = true;
            this.siteButton.Click += new System.EventHandler(this.siteButton_Click);
            // 
            // analysisButton
            // 
            this.analysisButton.Location = new System.Drawing.Point(221, 28);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.Size = new System.Drawing.Size(98, 28);
            this.analysisButton.TabIndex = 16;
            this.analysisButton.Text = "Analisi";
            this.analysisButton.UseVisualStyleBackColor = true;
            this.analysisButton.Click += new System.EventHandler(this.analysisButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(325, 28);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(98, 28);
            this.registerButton.TabIndex = 17;
            this.registerButton.Text = "Registro";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // missingAnalysisButton
            // 
            this.missingAnalysisButton.Location = new System.Drawing.Point(429, 28);
            this.missingAnalysisButton.Name = "missingAnalysisButton";
            this.missingAnalysisButton.Size = new System.Drawing.Size(98, 28);
            this.missingAnalysisButton.TabIndex = 18;
            this.missingAnalysisButton.Text = "Analisi Mancanti";
            this.missingAnalysisButton.UseVisualStyleBackColor = true;
            this.missingAnalysisButton.Click += new System.EventHandler(this.missingAnalysisButton_Click);
            // 
            // invalidAnalysisBox
            // 
            this.invalidAnalysisBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invalidAnalysisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAnalysisBox.Location = new System.Drawing.Point(13, 84);
            this.invalidAnalysisBox.Name = "invalidAnalysisBox";
            this.invalidAnalysisBox.Size = new System.Drawing.Size(857, 470);
            this.invalidAnalysisBox.TabIndex = 19;
            this.invalidAnalysisBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1018, 566);
            this.Controls.Add(this.invalidAnalysisBox);
            this.Controls.Add(this.missingAnalysisButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.analysisButton);
            this.Controls.Add(this.siteButton);
            this.Controls.Add(this.firmButton);
            this.Controls.Add(this.firmBox);
            this.Controls.Add(this.siteBox);
            this.Controls.Add(this.analysisBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.addPlate);
            this.Controls.Add(this.addRegister);
            this.Controls.Add(this.addAnalysis);
            this.Controls.Add(this.registerBox);
            this.Controls.Add(this.addSite);
            this.Controls.Add(this.addFirm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Gestionale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTool;
        private System.Windows.Forms.ToolStripMenuItem newProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button addSite;
        private System.Windows.Forms.Button addFirm;
        private System.Windows.Forms.RichTextBox registerBox;
        private System.Windows.Forms.Button addAnalysis;
        private System.Windows.Forms.Button addRegister;
        private System.Windows.Forms.Button addPlate;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.RichTextBox analysisBox;
        private System.Windows.Forms.RichTextBox siteBox;
        private System.Windows.Forms.RichTextBox firmBox;
        private System.Windows.Forms.Button firmButton;
        private System.Windows.Forms.Button siteButton;
        private System.Windows.Forms.Button analysisButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button missingAnalysisButton;
        private System.Windows.Forms.RichTextBox invalidAnalysisBox;
    }
}

