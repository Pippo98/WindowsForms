namespace WindowsFormsApp1.AddForms
{
    partial class DnewSite
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
            this.components = new System.ComponentModel.Container();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox2 = new System.Web.Management.ReadOnlyTextBox();
            this.siteCombo = new System.Windows.Forms.ComboBox();
            this.readOnlyTextBox3 = new System.Web.Management.ReadOnlyTextBox();
            this.siteText = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(374, 198);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(95, 28);
            this.ok.TabIndex = 0;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(251, 198);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(95, 28);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Annulla";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(218, 48);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(121, 20);
            this.nameText.TabIndex = 3;
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Location = new System.Drawing.Point(86, 51);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox1.TabIndex = 4;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Nome";
            // 
            // readOnlyTextBox2
            // 
            this.readOnlyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox2.Location = new System.Drawing.Point(86, 96);
            this.readOnlyTextBox2.Multiline = true;
            this.readOnlyTextBox2.Name = "readOnlyTextBox2";
            this.readOnlyTextBox2.ReadOnly = true;
            this.readOnlyTextBox2.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox2.TabIndex = 5;
            this.readOnlyTextBox2.TabStop = false;
            this.readOnlyTextBox2.Text = "Comune";
            // 
            // siteCombo
            // 
            this.siteCombo.FormattingEnabled = true;
            this.siteCombo.Location = new System.Drawing.Point(218, 91);
            this.siteCombo.Name = "siteCombo";
            this.siteCombo.Size = new System.Drawing.Size(121, 21);
            this.siteCombo.TabIndex = 6;
            this.siteCombo.SelectedIndexChanged += new System.EventHandler(this.siteCombo_SelectedIndexChanged);
            // 
            // readOnlyTextBox3
            // 
            this.readOnlyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox3.Location = new System.Drawing.Point(374, 96);
            this.readOnlyTextBox3.Multiline = true;
            this.readOnlyTextBox3.Name = "readOnlyTextBox3";
            this.readOnlyTextBox3.ReadOnly = true;
            this.readOnlyTextBox3.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox3.TabIndex = 7;
            this.readOnlyTextBox3.TabStop = false;
            this.readOnlyTextBox3.Text = "Aggiungi Comune";
            // 
            // siteText
            // 
            this.siteText.Location = new System.Drawing.Point(480, 93);
            this.siteText.Name = "siteText";
            this.siteText.Size = new System.Drawing.Size(121, 20);
            this.siteText.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // DnewSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 311);
            this.Controls.Add(this.siteText);
            this.Controls.Add(this.readOnlyTextBox3);
            this.Controls.Add(this.siteCombo);
            this.Controls.Add(this.readOnlyTextBox2);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Name = "DnewSite";
            this.Text = "Aggiungi Cantiere";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox nameText;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox2;
        private System.Windows.Forms.ComboBox siteCombo;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox3;
        private System.Windows.Forms.TextBox siteText;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}