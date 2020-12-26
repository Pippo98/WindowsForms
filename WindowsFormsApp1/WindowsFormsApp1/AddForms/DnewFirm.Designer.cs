namespace Rifiuti.AddForms
{
    partial class aggiungiImpresa
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.plateText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.addOK = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox2 = new System.Web.Management.ReadOnlyTextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // plateText
            // 
            this.plateText.Location = new System.Drawing.Point(166, 76);
            this.plateText.Name = "plateText";
            this.plateText.Size = new System.Drawing.Size(136, 20);
            this.plateText.TabIndex = 5;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(166, 32);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(318, 20);
            this.nameText.TabIndex = 7;
            // 
            // addOK
            // 
            this.addOK.Location = new System.Drawing.Point(345, 126);
            this.addOK.Name = "addOK";
            this.addOK.Size = new System.Drawing.Size(87, 29);
            this.addOK.TabIndex = 8;
            this.addOK.Text = "OK";
            this.addOK.UseVisualStyleBackColor = true;
            this.addOK.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(240, 126);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(87, 29);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Annulla";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox1.Location = new System.Drawing.Point(81, 32);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(68, 20);
            this.readOnlyTextBox1.TabIndex = 10;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Nome";
            // 
            // readOnlyTextBox2
            // 
            this.readOnlyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox2.Location = new System.Drawing.Point(81, 76);
            this.readOnlyTextBox2.Multiline = true;
            this.readOnlyTextBox2.Name = "readOnlyTextBox2";
            this.readOnlyTextBox2.ReadOnly = true;
            this.readOnlyTextBox2.Size = new System.Drawing.Size(68, 20);
            this.readOnlyTextBox2.TabIndex = 11;
            this.readOnlyTextBox2.TabStop = false;
            this.readOnlyTextBox2.Text = "Targa";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(345, 75);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(139, 21);
            this.comboBox.TabIndex = 12;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // aggiungiImpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 223);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.readOnlyTextBox2);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addOK);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.plateText);
            this.Name = "aggiungiImpresa";
            this.Text = "Aggiungi Impresa";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox plateText;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button addOK;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox2;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Windows.Forms.ComboBox comboBox;
    }
}