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
            this.addAnalysis = new System.Windows.Forms.Button();
            this.addFormImplant = new System.Windows.Forms.Button();
            this.addPlate = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.firmButton = new System.Windows.Forms.Button();
            this.siteButton = new System.Windows.Forms.Button();
            this.analysisButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.missingAnalysisButton = new System.Windows.Forms.Button();
            this.invalidAnalysisButton = new System.Windows.Forms.Button();
            this.projectUsable = new System.Windows.Forms.Button();
            this.RegisterVariousButton = new System.Windows.Forms.Button();
            this.addFormVarious = new System.Windows.Forms.Button();
            this.dataBox = new System.Windows.Forms.RichTextBox();
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.monthButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1225, 24);
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
            this.addSite.Location = new System.Drawing.Point(1082, 291);
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
            this.addFirm.Location = new System.Drawing.Point(1082, 246);
            this.addFirm.Name = "addFirm";
            this.addFirm.Size = new System.Drawing.Size(131, 39);
            this.addFirm.TabIndex = 2;
            this.addFirm.Text = "Aggiungi Impresa";
            this.addFirm.UseVisualStyleBackColor = true;
            this.addFirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addImpresa_MouseClick);
            // 
            // addAnalysis
            // 
            this.addAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addAnalysis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnalysis.Location = new System.Drawing.Point(1082, 336);
            this.addAnalysis.Name = "addAnalysis";
            this.addAnalysis.Size = new System.Drawing.Size(131, 39);
            this.addAnalysis.TabIndex = 7;
            this.addAnalysis.Text = "Aggiungi Analisi";
            this.addAnalysis.UseVisualStyleBackColor = true;
            this.addAnalysis.Click += new System.EventHandler(this.addAnalysis_Click);
            // 
            // addFormImplant
            // 
            this.addFormImplant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFormImplant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addFormImplant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFormImplant.Location = new System.Drawing.Point(1080, 94);
            this.addFormImplant.Name = "addFormImplant";
            this.addFormImplant.Size = new System.Drawing.Size(133, 65);
            this.addFormImplant.TabIndex = 8;
            this.addFormImplant.Text = "Aggiungi Formulario Impianto";
            this.addFormImplant.UseVisualStyleBackColor = true;
            this.addFormImplant.Click += new System.EventHandler(this.addFormImplant_Click);
            // 
            // addPlate
            // 
            this.addPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlate.Location = new System.Drawing.Point(1082, 381);
            this.addPlate.Name = "addPlate";
            this.addPlate.Size = new System.Drawing.Size(131, 39);
            this.addPlate.TabIndex = 9;
            this.addPlate.Text = "Aggiungi Targa";
            this.addPlate.UseVisualStyleBackColor = true;
            this.addPlate.Click += new System.EventHandler(this.addPlate_Click);
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(1080, 666);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(133, 65);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "Stampa";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // firmButton
            // 
            this.firmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firmButton.Location = new System.Drawing.Point(13, 28);
            this.firmButton.Name = "firmButton";
            this.firmButton.Size = new System.Drawing.Size(132, 27);
            this.firmButton.TabIndex = 14;
            this.firmButton.Text = "Imprese";
            this.firmButton.UseVisualStyleBackColor = true;
            this.firmButton.Click += new System.EventHandler(this.firmButton_Click);
            // 
            // siteButton
            // 
            this.siteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteButton.Location = new System.Drawing.Point(13, 61);
            this.siteButton.Name = "siteButton";
            this.siteButton.Size = new System.Drawing.Size(132, 27);
            this.siteButton.TabIndex = 15;
            this.siteButton.Text = "Cantieri";
            this.siteButton.UseVisualStyleBackColor = true;
            this.siteButton.Click += new System.EventHandler(this.siteButton_Click);
            // 
            // analysisButton
            // 
            this.analysisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisButton.Location = new System.Drawing.Point(289, 31);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.Size = new System.Drawing.Size(132, 27);
            this.analysisButton.TabIndex = 16;
            this.analysisButton.Text = "Analisi";
            this.analysisButton.UseVisualStyleBackColor = true;
            this.analysisButton.Click += new System.EventHandler(this.analysisButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(151, 28);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(132, 27);
            this.registerButton.TabIndex = 17;
            this.registerButton.Text = "Registro Impianto";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // missingAnalysisButton
            // 
            this.missingAnalysisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingAnalysisButton.Location = new System.Drawing.Point(427, 31);
            this.missingAnalysisButton.Name = "missingAnalysisButton";
            this.missingAnalysisButton.Size = new System.Drawing.Size(132, 27);
            this.missingAnalysisButton.TabIndex = 18;
            this.missingAnalysisButton.Text = "Analisi Mancanti";
            this.missingAnalysisButton.UseVisualStyleBackColor = true;
            this.missingAnalysisButton.Click += new System.EventHandler(this.missingAnalysisButton_Click);
            // 
            // invalidAnalysisButton
            // 
            this.invalidAnalysisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAnalysisButton.Location = new System.Drawing.Point(289, 61);
            this.invalidAnalysisButton.Name = "invalidAnalysisButton";
            this.invalidAnalysisButton.Size = new System.Drawing.Size(132, 27);
            this.invalidAnalysisButton.TabIndex = 21;
            this.invalidAnalysisButton.Text = "Analisi Scadute";
            this.invalidAnalysisButton.UseVisualStyleBackColor = true;
            this.invalidAnalysisButton.Click += new System.EventHandler(this.invalidAnalysisButton_Click);
            // 
            // projectUsable
            // 
            this.projectUsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectUsable.BackColor = System.Drawing.Color.DarkRed;
            this.projectUsable.Enabled = false;
            this.projectUsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectUsable.Location = new System.Drawing.Point(1137, 31);
            this.projectUsable.Name = "projectUsable";
            this.projectUsable.Size = new System.Drawing.Size(75, 23);
            this.projectUsable.TabIndex = 22;
            this.projectUsable.UseVisualStyleBackColor = false;
            // 
            // RegisterVariousButton
            // 
            this.RegisterVariousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterVariousButton.Location = new System.Drawing.Point(151, 61);
            this.RegisterVariousButton.Name = "RegisterVariousButton";
            this.RegisterVariousButton.Size = new System.Drawing.Size(132, 27);
            this.RegisterVariousButton.TabIndex = 23;
            this.RegisterVariousButton.Text = "Registro Varie";
            this.RegisterVariousButton.UseVisualStyleBackColor = true;
            this.RegisterVariousButton.Click += new System.EventHandler(this.RegisterVariousButton_Click);
            // 
            // addFormVarious
            // 
            this.addFormVarious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFormVarious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addFormVarious.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFormVarious.Location = new System.Drawing.Point(1081, 165);
            this.addFormVarious.Name = "addFormVarious";
            this.addFormVarious.Size = new System.Drawing.Size(133, 65);
            this.addFormVarious.TabIndex = 25;
            this.addFormVarious.Text = "Aggiungi Formulario Varie";
            this.addFormVarious.UseVisualStyleBackColor = true;
            this.addFormVarious.Click += new System.EventHandler(this.addFormVarious_Click);
            // 
            // dataBox
            // 
            this.dataBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBox.Location = new System.Drawing.Point(10, 118);
            this.dataBox.Name = "dataBox";
            this.dataBox.ReadOnly = true;
            this.dataBox.Size = new System.Drawing.Size(1064, 613);
            this.dataBox.TabIndex = 26;
            this.dataBox.Text = "";
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox1.Location = new System.Drawing.Point(13, 94);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(49, 20);
            this.readOnlyTextBox1.TabIndex = 27;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Filtri:";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.table.Location = new System.Drawing.Point(12, 118);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(1062, 610);
            this.table.TabIndex = 28;
            // 
            // monthButton
            // 
            this.monthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthButton.Location = new System.Drawing.Point(427, 61);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(132, 27);
            this.monthButton.TabIndex = 29;
            this.monthButton.Text = "Mesi";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.monthButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1225, 740);
            this.Controls.Add(this.monthButton);
            this.Controls.Add(this.table);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.addFormVarious);
            this.Controls.Add(this.RegisterVariousButton);
            this.Controls.Add(this.projectUsable);
            this.Controls.Add(this.invalidAnalysisButton);
            this.Controls.Add(this.missingAnalysisButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.analysisButton);
            this.Controls.Add(this.siteButton);
            this.Controls.Add(this.firmButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.addPlate);
            this.Controls.Add(this.addFormImplant);
            this.Controls.Add(this.addAnalysis);
            this.Controls.Add(this.addSite);
            this.Controls.Add(this.addFirm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Gestionale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
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
        private System.Windows.Forms.Button addAnalysis;
        private System.Windows.Forms.Button addFormImplant;
        private System.Windows.Forms.Button addPlate;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button firmButton;
        private System.Windows.Forms.Button siteButton;
        private System.Windows.Forms.Button analysisButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button missingAnalysisButton;
        private System.Windows.Forms.Button invalidAnalysisButton;
        private System.Windows.Forms.Button projectUsable;
        private System.Windows.Forms.Button RegisterVariousButton;
        private System.Windows.Forms.Button addFormVarious;
        private System.Windows.Forms.RichTextBox dataBox;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button monthButton;
    }
}

