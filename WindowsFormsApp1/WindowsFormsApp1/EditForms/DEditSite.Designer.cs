namespace Rifiuti.EditForms
{
    partial class DEditSite
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
            this.readOnlyTextBox4 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox2 = new System.Web.Management.ReadOnlyTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.namesComboBox = new System.Windows.Forms.ComboBox();
            this.LocationsComboBox = new System.Windows.Forms.ComboBox();
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readOnlyTextBox4
            // 
            this.readOnlyTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox4.Location = new System.Drawing.Point(228, 152);
            this.readOnlyTextBox4.Multiline = true;
            this.readOnlyTextBox4.Name = "readOnlyTextBox4";
            this.readOnlyTextBox4.ReadOnly = true;
            this.readOnlyTextBox4.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox4.TabIndex = 18;
            this.readOnlyTextBox4.TabStop = false;
            this.readOnlyTextBox4.Text = "Cantiere";
            this.readOnlyTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readOnlyTextBox2
            // 
            this.readOnlyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox2.Location = new System.Drawing.Point(228, 107);
            this.readOnlyTextBox2.Multiline = true;
            this.readOnlyTextBox2.Name = "readOnlyTextBox2";
            this.readOnlyTextBox2.ReadOnly = true;
            this.readOnlyTextBox2.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox2.TabIndex = 17;
            this.readOnlyTextBox2.TabStop = false;
            this.readOnlyTextBox2.Text = "Comune";
            this.readOnlyTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(179, 212);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 22);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Annulla";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // namesComboBox
            // 
            this.namesComboBox.FormattingEnabled = true;
            this.namesComboBox.Location = new System.Drawing.Point(56, 151);
            this.namesComboBox.Name = "namesComboBox";
            this.namesComboBox.Size = new System.Drawing.Size(166, 21);
            this.namesComboBox.TabIndex = 14;
            this.namesComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // LocationsComboBox
            // 
            this.LocationsComboBox.FormattingEnabled = true;
            this.LocationsComboBox.Location = new System.Drawing.Point(56, 107);
            this.LocationsComboBox.Name = "LocationsComboBox";
            this.LocationsComboBox.Size = new System.Drawing.Size(166, 21);
            this.LocationsComboBox.TabIndex = 13;
            this.LocationsComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox1.Location = new System.Drawing.Point(188, 24);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(172, 30);
            this.readOnlyTextBox1.TabIndex = 12;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Modifica Cantiere";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(334, 108);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(168, 20);
            this.LocationTextBox.TabIndex = 19;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(334, 151);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 20;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(228, 258);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(96, 23);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Elimina Elemento";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(300, 212);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 22);
            this.OKButton.TabIndex = 22;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // DEditSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 430);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.readOnlyTextBox4);
            this.Controls.Add(this.readOnlyTextBox2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.namesComboBox);
            this.Controls.Add(this.LocationsComboBox);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Name = "DEditSite";
            this.Text = "DEditSite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox4;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox namesComboBox;
        private System.Windows.Forms.ComboBox LocationsComboBox;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button OKButton;
    }
}