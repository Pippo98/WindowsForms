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
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.addAnalysis = new System.Windows.Forms.Button();
            this.addRegister = new System.Windows.Forms.Button();
            this.addPlate = new System.Windows.Forms.Button();
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
            this.addSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSite.Location = new System.Drawing.Point(875, 82);
            this.addSite.Name = "addSite";
            this.addSite.Size = new System.Drawing.Size(131, 39);
            this.addSite.TabIndex = 4;
            this.addSite.Text = "Aggiungi Cantiere";
            this.addSite.UseVisualStyleBackColor = true;
            this.addSite.Click += new System.EventHandler(this.addSite_Click);
            // 
            // addFirm
            // 
            this.addFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFirm.Location = new System.Drawing.Point(875, 37);
            this.addFirm.Name = "addFirm";
            this.addFirm.Size = new System.Drawing.Size(131, 39);
            this.addFirm.TabIndex = 2;
            this.addFirm.Text = "Aggiungi Impresa";
            this.addFirm.UseVisualStyleBackColor = true;
            this.addFirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addImpresa_MouseClick);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 37);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(857, 517);
            this.textBox.TabIndex = 6;
            this.textBox.Text = "";
            // 
            // addAnalysis
            // 
            this.addAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnalysis.Location = new System.Drawing.Point(875, 127);
            this.addAnalysis.Name = "addAnalysis";
            this.addAnalysis.Size = new System.Drawing.Size(131, 39);
            this.addAnalysis.TabIndex = 7;
            this.addAnalysis.Text = "Aggiungi Analisi";
            this.addAnalysis.UseVisualStyleBackColor = true;
            this.addAnalysis.Click += new System.EventHandler(this.addAnalysis_Click);
            // 
            // addRegister
            // 
            this.addRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRegister.Location = new System.Drawing.Point(875, 489);
            this.addRegister.Name = "addRegister";
            this.addRegister.Size = new System.Drawing.Size(131, 65);
            this.addRegister.TabIndex = 8;
            this.addRegister.Text = "Aggiungi Registro";
            this.addRegister.UseVisualStyleBackColor = true;
            this.addRegister.Click += new System.EventHandler(this.addRegister_Click);
            // 
            // addPlate
            // 
            this.addPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlate.Location = new System.Drawing.Point(875, 172);
            this.addPlate.Name = "addPlate";
            this.addPlate.Size = new System.Drawing.Size(131, 39);
            this.addPlate.TabIndex = 9;
            this.addPlate.Text = "Aggiungi Targa";
            this.addPlate.UseVisualStyleBackColor = true;
            this.addPlate.Click += new System.EventHandler(this.addPlate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1018, 566);
            this.Controls.Add(this.addPlate);
            this.Controls.Add(this.addRegister);
            this.Controls.Add(this.addAnalysis);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.addSite);
            this.Controls.Add(this.addFirm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Gestionale";
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
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button addAnalysis;
        private System.Windows.Forms.Button addRegister;
        private System.Windows.Forms.Button addPlate;
    }
}

