namespace WindowsFormsApp1.AddForms
{
    partial class WarningMessage
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
            this.warnTextBox = new System.Web.Management.ReadOnlyTextBox();
            this.SuspendLayout();
            // 
            // warnTextBox
            // 
            this.warnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.warnTextBox.Location = new System.Drawing.Point(39, 26);
            this.warnTextBox.Multiline = true;
            this.warnTextBox.Name = "warnTextBox";
            this.warnTextBox.ReadOnly = true;
            this.warnTextBox.Size = new System.Drawing.Size(334, 60);
            this.warnTextBox.TabIndex = 1;
            this.warnTextBox.TabStop = false;
            // 
            // WarningMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 114);
            this.Controls.Add(this.warnTextBox);
            this.Name = "WarningMessage";
            this.Text = "WarningMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Web.Management.ReadOnlyTextBox warnTextBox;
    }
}