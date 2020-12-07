namespace Rifiuti.EditForms
{
    partial class DEditFirm
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
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PlateComboBox = new System.Windows.Forms.ComboBox();
            this.PlateTextBox = new System.Windows.Forms.TextBox();
            this.DimensionCombo = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.readOnlyTextBox2 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox4 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox3 = new System.Web.Management.ReadOnlyTextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.readOnlyDimension = new System.Web.Management.ReadOnlyTextBox();
            this.SuspendLayout();
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox1.Location = new System.Drawing.Point(176, 12);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(172, 30);
            this.readOnlyTextBox1.TabIndex = 0;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Modifica Impresa";
            // 
            // NameComboBox
            // 
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(35, 94);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(166, 21);
            this.NameComboBox.TabIndex = 1;
            this.NameComboBox.SelectedIndexChanged += new System.EventHandler(this.NameComboBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(313, 94);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(166, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // PlateComboBox
            // 
            this.PlateComboBox.FormattingEnabled = true;
            this.PlateComboBox.Location = new System.Drawing.Point(80, 138);
            this.PlateComboBox.Name = "PlateComboBox";
            this.PlateComboBox.Size = new System.Drawing.Size(121, 21);
            this.PlateComboBox.TabIndex = 3;
            this.PlateComboBox.SelectedIndexChanged += new System.EventHandler(this.PlateComboBox_SelectedIndexChanged);
            // 
            // PlateTextBox
            // 
            this.PlateTextBox.Location = new System.Drawing.Point(313, 137);
            this.PlateTextBox.Name = "PlateTextBox";
            this.PlateTextBox.Size = new System.Drawing.Size(166, 20);
            this.PlateTextBox.TabIndex = 4;
            // 
            // DimensionCombo
            // 
            this.DimensionCombo.FormattingEnabled = true;
            this.DimensionCombo.Location = new System.Drawing.Point(313, 180);
            this.DimensionCombo.Name = "DimensionCombo";
            this.DimensionCombo.Size = new System.Drawing.Size(121, 21);
            this.DimensionCombo.TabIndex = 5;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(163, 230);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Annulla";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(273, 230);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // readOnlyTextBox2
            // 
            this.readOnlyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox2.Location = new System.Drawing.Point(207, 94);
            this.readOnlyTextBox2.Multiline = true;
            this.readOnlyTextBox2.Name = "readOnlyTextBox2";
            this.readOnlyTextBox2.ReadOnly = true;
            this.readOnlyTextBox2.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox2.TabIndex = 8;
            this.readOnlyTextBox2.TabStop = false;
            this.readOnlyTextBox2.Text = "Nome";
            this.readOnlyTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readOnlyTextBox4
            // 
            this.readOnlyTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox4.Location = new System.Drawing.Point(207, 139);
            this.readOnlyTextBox4.Multiline = true;
            this.readOnlyTextBox4.Name = "readOnlyTextBox4";
            this.readOnlyTextBox4.ReadOnly = true;
            this.readOnlyTextBox4.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox4.TabIndex = 10;
            this.readOnlyTextBox4.TabStop = false;
            this.readOnlyTextBox4.Text = "Targa";
            this.readOnlyTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readOnlyTextBox3
            // 
            this.readOnlyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox3.Location = new System.Drawing.Point(207, 181);
            this.readOnlyTextBox3.Multiline = true;
            this.readOnlyTextBox3.Name = "readOnlyTextBox3";
            this.readOnlyTextBox3.ReadOnly = true;
            this.readOnlyTextBox3.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox3.TabIndex = 11;
            this.readOnlyTextBox3.TabStop = false;
            this.readOnlyTextBox3.Text = "Dimensione";
            this.readOnlyTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(207, 280);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Elimina Elemento";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // readOnlyDimension
            // 
            this.readOnlyDimension.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyDimension.Location = new System.Drawing.Point(101, 181);
            this.readOnlyDimension.Multiline = true;
            this.readOnlyDimension.Name = "readOnlyDimension";
            this.readOnlyDimension.ReadOnly = true;
            this.readOnlyDimension.Size = new System.Drawing.Size(100, 20);
            this.readOnlyDimension.TabIndex = 13;
            this.readOnlyDimension.TabStop = false;
            this.readOnlyDimension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DEditFirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 364);
            this.Controls.Add(this.readOnlyDimension);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.readOnlyTextBox3);
            this.Controls.Add(this.readOnlyTextBox4);
            this.Controls.Add(this.readOnlyTextBox2);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DimensionCombo);
            this.Controls.Add(this.PlateTextBox);
            this.Controls.Add(this.PlateComboBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Name = "DEditFirm";
            this.Text = "DEditFirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox PlateComboBox;
        private System.Windows.Forms.TextBox PlateTextBox;
        private System.Windows.Forms.ComboBox DimensionCombo;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox2;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox4;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Web.Management.ReadOnlyTextBox readOnlyDimension;
    }
}