namespace Rifiuti.AddForms
{
    partial class DnewPlate
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
            this.firmBox = new System.Windows.Forms.ComboBox();
            this.plateText = new System.Windows.Forms.TextBox();
            this.dimensionBox = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox2 = new System.Web.Management.ReadOnlyTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // firmBox
            // 
            this.firmBox.FormattingEnabled = true;
            this.firmBox.Location = new System.Drawing.Point(208, 41);
            this.firmBox.Name = "firmBox";
            this.firmBox.Size = new System.Drawing.Size(248, 21);
            this.firmBox.TabIndex = 0;
            this.firmBox.SelectedValueChanged += new System.EventHandler(this.firmBox_SelectedValueChanged);
            // 
            // plateText
            // 
            this.plateText.Location = new System.Drawing.Point(208, 111);
            this.plateText.Name = "plateText";
            this.plateText.Size = new System.Drawing.Size(121, 20);
            this.plateText.TabIndex = 1;
            // 
            // dimensionBox
            // 
            this.dimensionBox.FormattingEnabled = true;
            this.dimensionBox.Location = new System.Drawing.Point(335, 111);
            this.dimensionBox.Name = "dimensionBox";
            this.dimensionBox.Size = new System.Drawing.Size(121, 21);
            this.dimensionBox.TabIndex = 2;
            this.dimensionBox.SelectedValueChanged += new System.EventHandler(this.dimensionBox_SelectedValueChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(244, 186);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Annulla";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(348, 186);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Location = new System.Drawing.Point(91, 41);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(98, 21);
            this.readOnlyTextBox1.TabIndex = 5;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Impresa";
            // 
            // readOnlyTextBox2
            // 
            this.readOnlyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox2.Location = new System.Drawing.Point(91, 114);
            this.readOnlyTextBox2.Multiline = true;
            this.readOnlyTextBox2.Name = "readOnlyTextBox2";
            this.readOnlyTextBox2.ReadOnly = true;
            this.readOnlyTextBox2.Size = new System.Drawing.Size(98, 21);
            this.readOnlyTextBox2.TabIndex = 6;
            this.readOnlyTextBox2.TabStop = false;
            this.readOnlyTextBox2.Text = "Targa";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // DnewPlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 272);
            this.Controls.Add(this.readOnlyTextBox2);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.dimensionBox);
            this.Controls.Add(this.plateText);
            this.Controls.Add(this.firmBox);
            this.Name = "DnewPlate";
            this.Text = "DaddPlate";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox firmBox;
        private System.Windows.Forms.TextBox plateText;
        private System.Windows.Forms.ComboBox dimensionBox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}