namespace Rifiuti.EditForms
{
    partial class DEditExtraProcess
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
            this.addButton = new System.Windows.Forms.Button();
            this.readOnlyTextBox4 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox3 = new System.Web.Management.ReadOnlyTextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.ProcessList = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editComboBox = new System.Windows.Forms.ComboBox();
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.newTypeComboBox = new System.Windows.Forms.ComboBox();
            this.editDatePicker = new System.Windows.Forms.DateTimePicker();
            this.editTypeComboBox = new System.Windows.Forms.ComboBox();
            this.kgBox = new System.Windows.Forms.TextBox();
            this.cerCombo = new System.Windows.Forms.ComboBox();
            this.readOnlyTextBox2 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox5 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox6 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox7 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox8 = new System.Web.Management.ReadOnlyTextBox();
            this.editCERCombo = new System.Windows.Forms.ComboBox();
            this.editKgBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(689, 169);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 43;
            this.addButton.Text = "Aggiungi";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.buttonClicked);
            // 
            // readOnlyTextBox4
            // 
            this.readOnlyTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox4.Location = new System.Drawing.Point(271, 249);
            this.readOnlyTextBox4.Multiline = true;
            this.readOnlyTextBox4.Name = "readOnlyTextBox4";
            this.readOnlyTextBox4.ReadOnly = true;
            this.readOnlyTextBox4.Size = new System.Drawing.Size(78, 25);
            this.readOnlyTextBox4.TabIndex = 41;
            this.readOnlyTextBox4.TabStop = false;
            this.readOnlyTextBox4.Text = "Modifica";
            // 
            // readOnlyTextBox3
            // 
            this.readOnlyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox3.Location = new System.Drawing.Point(271, 87);
            this.readOnlyTextBox3.Multiline = true;
            this.readOnlyTextBox3.Name = "readOnlyTextBox3";
            this.readOnlyTextBox3.ReadOnly = true;
            this.readOnlyTextBox3.Size = new System.Drawing.Size(78, 25);
            this.readOnlyTextBox3.TabIndex = 40;
            this.readOnlyTextBox3.TabStop = false;
            this.readOnlyTextBox3.Text = "Aggiungi";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(689, 359);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 39;
            this.updateButton.Text = "Aggiorna";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.buttonClicked);
            // 
            // ProcessList
            // 
            this.ProcessList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.HorizontalScrollbar = true;
            this.ProcessList.ItemHeight = 24;
            this.ProcessList.Location = new System.Drawing.Point(36, 87);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(214, 220);
            this.ProcessList.TabIndex = 38;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(418, 411);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 36;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.buttonClicked);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(308, 411);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Annulla";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.buttonClicked);
            // 
            // editComboBox
            // 
            this.editComboBox.FormattingEnabled = true;
            this.editComboBox.Location = new System.Drawing.Point(271, 280);
            this.editComboBox.Name = "editComboBox";
            this.editComboBox.Size = new System.Drawing.Size(166, 21);
            this.editComboBox.TabIndex = 33;
            this.editComboBox.SelectedIndexChanged += new System.EventHandler(this.comboChanged);
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox1.Location = new System.Drawing.Point(295, 22);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(211, 30);
            this.readOnlyTextBox1.TabIndex = 32;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Modifica lavorazioni";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(271, 119);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(166, 20);
            this.datePicker.TabIndex = 44;
            // 
            // newTypeComboBox
            // 
            this.newTypeComboBox.FormattingEnabled = true;
            this.newTypeComboBox.Location = new System.Drawing.Point(517, 118);
            this.newTypeComboBox.Name = "newTypeComboBox";
            this.newTypeComboBox.Size = new System.Drawing.Size(166, 21);
            this.newTypeComboBox.TabIndex = 45;
            this.newTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboChanged);
            // 
            // editDatePicker
            // 
            this.editDatePicker.Location = new System.Drawing.Point(517, 281);
            this.editDatePicker.Name = "editDatePicker";
            this.editDatePicker.Size = new System.Drawing.Size(166, 20);
            this.editDatePicker.TabIndex = 46;
            // 
            // editTypeComboBox
            // 
            this.editTypeComboBox.FormattingEnabled = true;
            this.editTypeComboBox.Location = new System.Drawing.Point(517, 308);
            this.editTypeComboBox.Name = "editTypeComboBox";
            this.editTypeComboBox.Size = new System.Drawing.Size(166, 21);
            this.editTypeComboBox.TabIndex = 47;
            // 
            // kgBox
            // 
            this.kgBox.Location = new System.Drawing.Point(517, 172);
            this.kgBox.Name = "kgBox";
            this.kgBox.Size = new System.Drawing.Size(166, 20);
            this.kgBox.TabIndex = 48;
            this.kgBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kgBox_KeyPress);
            // 
            // cerCombo
            // 
            this.cerCombo.FormattingEnabled = true;
            this.cerCombo.Location = new System.Drawing.Point(517, 145);
            this.cerCombo.Name = "cerCombo";
            this.cerCombo.Size = new System.Drawing.Size(166, 21);
            this.cerCombo.TabIndex = 49;
            // 
            // readOnlyTextBox2
            // 
            this.readOnlyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox2.Location = new System.Drawing.Point(467, 120);
            this.readOnlyTextBox2.Multiline = true;
            this.readOnlyTextBox2.Name = "readOnlyTextBox2";
            this.readOnlyTextBox2.ReadOnly = true;
            this.readOnlyTextBox2.Size = new System.Drawing.Size(39, 19);
            this.readOnlyTextBox2.TabIndex = 50;
            this.readOnlyTextBox2.TabStop = false;
            this.readOnlyTextBox2.Text = "Tipo";
            // 
            // readOnlyTextBox5
            // 
            this.readOnlyTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox5.Location = new System.Drawing.Point(467, 173);
            this.readOnlyTextBox5.Multiline = true;
            this.readOnlyTextBox5.Name = "readOnlyTextBox5";
            this.readOnlyTextBox5.ReadOnly = true;
            this.readOnlyTextBox5.Size = new System.Drawing.Size(39, 27);
            this.readOnlyTextBox5.TabIndex = 51;
            this.readOnlyTextBox5.TabStop = false;
            this.readOnlyTextBox5.Text = "Kg";
            // 
            // readOnlyTextBox6
            // 
            this.readOnlyTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox6.Location = new System.Drawing.Point(467, 147);
            this.readOnlyTextBox6.Multiline = true;
            this.readOnlyTextBox6.Name = "readOnlyTextBox6";
            this.readOnlyTextBox6.ReadOnly = true;
            this.readOnlyTextBox6.Size = new System.Drawing.Size(39, 19);
            this.readOnlyTextBox6.TabIndex = 52;
            this.readOnlyTextBox6.TabStop = false;
            this.readOnlyTextBox6.Text = "CER";
            // 
            // readOnlyTextBox7
            // 
            this.readOnlyTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox7.Location = new System.Drawing.Point(467, 337);
            this.readOnlyTextBox7.Multiline = true;
            this.readOnlyTextBox7.Name = "readOnlyTextBox7";
            this.readOnlyTextBox7.ReadOnly = true;
            this.readOnlyTextBox7.Size = new System.Drawing.Size(39, 19);
            this.readOnlyTextBox7.TabIndex = 56;
            this.readOnlyTextBox7.TabStop = false;
            this.readOnlyTextBox7.Text = "CER";
            // 
            // readOnlyTextBox8
            // 
            this.readOnlyTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox8.Location = new System.Drawing.Point(467, 363);
            this.readOnlyTextBox8.Multiline = true;
            this.readOnlyTextBox8.Name = "readOnlyTextBox8";
            this.readOnlyTextBox8.ReadOnly = true;
            this.readOnlyTextBox8.Size = new System.Drawing.Size(39, 27);
            this.readOnlyTextBox8.TabIndex = 55;
            this.readOnlyTextBox8.TabStop = false;
            this.readOnlyTextBox8.Text = "Kg";
            // 
            // editCERCombo
            // 
            this.editCERCombo.FormattingEnabled = true;
            this.editCERCombo.Location = new System.Drawing.Point(517, 335);
            this.editCERCombo.Name = "editCERCombo";
            this.editCERCombo.Size = new System.Drawing.Size(166, 21);
            this.editCERCombo.TabIndex = 54;
            // 
            // editKgBox
            // 
            this.editKgBox.Location = new System.Drawing.Point(517, 362);
            this.editKgBox.Name = "editKgBox";
            this.editKgBox.Size = new System.Drawing.Size(166, 20);
            this.editKgBox.TabIndex = 53;
            this.editKgBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kgBox_KeyPress);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(689, 330);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 57;
            this.deleteButton.Text = "ELIMINA";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.buttonClicked);
            // 
            // DEditExtraProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 446);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.readOnlyTextBox7);
            this.Controls.Add(this.readOnlyTextBox8);
            this.Controls.Add(this.editCERCombo);
            this.Controls.Add(this.editKgBox);
            this.Controls.Add(this.readOnlyTextBox6);
            this.Controls.Add(this.readOnlyTextBox5);
            this.Controls.Add(this.readOnlyTextBox2);
            this.Controls.Add(this.cerCombo);
            this.Controls.Add(this.kgBox);
            this.Controls.Add(this.editTypeComboBox);
            this.Controls.Add(this.editDatePicker);
            this.Controls.Add(this.newTypeComboBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.readOnlyTextBox4);
            this.Controls.Add(this.readOnlyTextBox3);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editComboBox);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Name = "DEditExtraProcess";
            this.Text = "DEditExtraProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox4;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ListBox ProcessList;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox editComboBox;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox newTypeComboBox;
        private System.Windows.Forms.DateTimePicker editDatePicker;
        private System.Windows.Forms.ComboBox editTypeComboBox;
        private System.Windows.Forms.TextBox kgBox;
        private System.Windows.Forms.ComboBox cerCombo;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox2;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox5;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox6;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox7;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox8;
        private System.Windows.Forms.ComboBox editCERCombo;
        private System.Windows.Forms.TextBox editKgBox;
        private System.Windows.Forms.Button deleteButton;
    }
}