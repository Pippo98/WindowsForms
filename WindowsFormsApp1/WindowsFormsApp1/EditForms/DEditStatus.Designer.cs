namespace Rifiuti.EditForms
{
    partial class DEditStatus
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
            this.CERCombo = new System.Windows.Forms.ComboBox();
            this.readOnlyTextBox2 = new System.Web.Management.ReadOnlyTextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.readOnlyTextBox3 = new System.Web.Management.ReadOnlyTextBox();
            this.StatusValueText = new System.Windows.Forms.TextBox();
            this.statusList = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.SuspendLayout();
            // 
            // CERCombo
            // 
            this.CERCombo.FormattingEnabled = true;
            this.CERCombo.Location = new System.Drawing.Point(173, 82);
            this.CERCombo.Name = "CERCombo";
            this.CERCombo.Size = new System.Drawing.Size(168, 21);
            this.CERCombo.TabIndex = 19;
            this.CERCombo.SelectedIndexChanged += new System.EventHandler(this.CERCombo_SelectedIndexChanged);
            // 
            // readOnlyTextBox2
            // 
            this.readOnlyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox2.Location = new System.Drawing.Point(99, 83);
            this.readOnlyTextBox2.Multiline = true;
            this.readOnlyTextBox2.Name = "readOnlyTextBox2";
            this.readOnlyTextBox2.ReadOnly = true;
            this.readOnlyTextBox2.Size = new System.Drawing.Size(68, 20);
            this.readOnlyTextBox2.TabIndex = 18;
            this.readOnlyTextBox2.TabStop = false;
            this.readOnlyTextBox2.Text = "CER";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(254, 446);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(87, 29);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Annulla";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.buttonClick);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(347, 446);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(87, 29);
            this.OK.TabIndex = 15;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.buttonClick);
            // 
            // readOnlyTextBox3
            // 
            this.readOnlyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox3.Location = new System.Drawing.Point(99, 108);
            this.readOnlyTextBox3.Multiline = true;
            this.readOnlyTextBox3.Name = "readOnlyTextBox3";
            this.readOnlyTextBox3.ReadOnly = true;
            this.readOnlyTextBox3.Size = new System.Drawing.Size(68, 20);
            this.readOnlyTextBox3.TabIndex = 24;
            this.readOnlyTextBox3.TabStop = false;
            this.readOnlyTextBox3.Text = "Stato";
            // 
            // StatusValueText
            // 
            this.StatusValueText.Location = new System.Drawing.Point(173, 109);
            this.StatusValueText.Name = "StatusValueText";
            this.StatusValueText.Size = new System.Drawing.Size(168, 20);
            this.StatusValueText.TabIndex = 21;
            // 
            // statusList
            // 
            this.statusList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusList.FormattingEnabled = true;
            this.statusList.ItemHeight = 25;
            this.statusList.Location = new System.Drawing.Point(99, 135);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(496, 279);
            this.statusList.TabIndex = 25;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(357, 82);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(63, 47);
            this.updateButton.TabIndex = 26;
            this.updateButton.Text = "Aggiorna";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox1.Location = new System.Drawing.Point(261, 22);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(172, 30);
            this.readOnlyTextBox1.TabIndex = 27;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Modifica Riporto";
            // 
            // DEditStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 505);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.statusList);
            this.Controls.Add(this.readOnlyTextBox3);
            this.Controls.Add(this.StatusValueText);
            this.Controls.Add(this.CERCombo);
            this.Controls.Add(this.readOnlyTextBox2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.OK);
            this.Name = "DEditStatus";
            this.Text = "Modifica Riporto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CERCombo;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button OK;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox3;
        private System.Windows.Forms.TextBox StatusValueText;
        private System.Windows.Forms.ListBox statusList;
        private System.Windows.Forms.Button updateButton;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
    }
}