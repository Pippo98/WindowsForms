namespace WindowsFormsApp1.Print
{
    partial class DselectPrint
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
            this.optionsList = new System.Windows.Forms.CheckedListBox();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionsList
            // 
            this.optionsList.CheckOnClick = true;
            this.optionsList.FormattingEnabled = true;
            this.optionsList.Location = new System.Drawing.Point(12, 12);
            this.optionsList.Name = "optionsList";
            this.optionsList.Size = new System.Drawing.Size(245, 349);
            this.optionsList.TabIndex = 0;
            this.optionsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.optionsList_ItemCheck);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(31, 431);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Annulla";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(136, 431);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // DselectPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 549);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.optionsList);
            this.Name = "DselectPrint";
            this.Text = "DselectPrint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox optionsList;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
    }
}