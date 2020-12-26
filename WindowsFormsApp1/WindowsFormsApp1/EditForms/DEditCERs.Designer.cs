namespace Rifiuti.EditForms
{
    partial class DEditCERs
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
            this.readOnlyTextBox2 = new System.Web.Management.ReadOnlyTextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.CERTextBox = new System.Windows.Forms.TextBox();
            this.CERComboBox = new System.Windows.Forms.ComboBox();
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.CERList = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.readOnlyTextBox3 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox4 = new System.Web.Management.ReadOnlyTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.NewTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readOnlyTextBox2
            // 
            this.readOnlyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox2.Location = new System.Drawing.Point(387, 233);
            this.readOnlyTextBox2.Multiline = true;
            this.readOnlyTextBox2.Name = "readOnlyTextBox2";
            this.readOnlyTextBox2.ReadOnly = true;
            this.readOnlyTextBox2.Size = new System.Drawing.Size(68, 20);
            this.readOnlyTextBox2.TabIndex = 22;
            this.readOnlyTextBox2.TabStop = false;
            this.readOnlyTextBox2.Text = "CER";
            this.readOnlyTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(485, 355);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 21;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.buttonClicked);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(375, 355);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Annulla";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.buttonClicked);
            // 
            // CERTextBox
            // 
            this.CERTextBox.Location = new System.Drawing.Point(461, 234);
            this.CERTextBox.Name = "CERTextBox";
            this.CERTextBox.Size = new System.Drawing.Size(166, 20);
            this.CERTextBox.TabIndex = 16;
            this.CERTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CERTextBox_KeyPress);
            // 
            // CERComboBox
            // 
            this.CERComboBox.FormattingEnabled = true;
            this.CERComboBox.Location = new System.Drawing.Point(215, 233);
            this.CERComboBox.Name = "CERComboBox";
            this.CERComboBox.Size = new System.Drawing.Size(166, 21);
            this.CERComboBox.TabIndex = 15;
            this.CERComboBox.SelectedIndexChanged += new System.EventHandler(this.CERComboBox_SelectedIndexChanged);
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox1.Location = new System.Drawing.Point(381, 12);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(172, 30);
            this.readOnlyTextBox1.TabIndex = 14;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Modifica CER";
            // 
            // CERList
            // 
            this.CERList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CERList.FormattingEnabled = true;
            this.CERList.ItemHeight = 24;
            this.CERList.Location = new System.Drawing.Point(28, 141);
            this.CERList.Name = "CERList";
            this.CERList.Size = new System.Drawing.Size(166, 172);
            this.CERList.TabIndex = 26;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(633, 233);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 27;
            this.updateButton.Text = "Aggiorna";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.buttonClicked);
            // 
            // readOnlyTextBox3
            // 
            this.readOnlyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox3.Location = new System.Drawing.Point(215, 141);
            this.readOnlyTextBox3.Multiline = true;
            this.readOnlyTextBox3.Name = "readOnlyTextBox3";
            this.readOnlyTextBox3.ReadOnly = true;
            this.readOnlyTextBox3.Size = new System.Drawing.Size(78, 25);
            this.readOnlyTextBox3.TabIndex = 28;
            this.readOnlyTextBox3.TabStop = false;
            this.readOnlyTextBox3.Text = "Aggiungi";
            // 
            // readOnlyTextBox4
            // 
            this.readOnlyTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox4.Location = new System.Drawing.Point(215, 202);
            this.readOnlyTextBox4.Multiline = true;
            this.readOnlyTextBox4.Name = "readOnlyTextBox4";
            this.readOnlyTextBox4.ReadOnly = true;
            this.readOnlyTextBox4.Size = new System.Drawing.Size(78, 25);
            this.readOnlyTextBox4.TabIndex = 29;
            this.readOnlyTextBox4.TabStop = false;
            this.readOnlyTextBox4.Text = "Modifica";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(387, 171);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 31;
            this.addButton.Text = "Aggiungi";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.buttonClicked);
            // 
            // NewTextBox
            // 
            this.NewTextBox.Location = new System.Drawing.Point(215, 172);
            this.NewTextBox.Name = "NewTextBox";
            this.NewTextBox.Size = new System.Drawing.Size(166, 20);
            this.NewTextBox.TabIndex = 30;
            this.NewTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CERTextBox_KeyPress);
            // 
            // DEditCERs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 448);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.NewTextBox);
            this.Controls.Add(this.readOnlyTextBox4);
            this.Controls.Add(this.readOnlyTextBox3);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.CERList);
            this.Controls.Add(this.readOnlyTextBox2);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.CERTextBox);
            this.Controls.Add(this.CERComboBox);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Name = "DEditCERs";
            this.Text = "Modifica CER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox2;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox CERTextBox;
        private System.Windows.Forms.ComboBox CERComboBox;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Windows.Forms.ListBox CERList;
        private System.Windows.Forms.Button updateButton;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox3;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox NewTextBox;
    }
}