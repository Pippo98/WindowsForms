namespace WindowsFormsApp1.AddForms
{
    partial class DnewRegister
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.producerBox = new System.Windows.Forms.ComboBox();
            this.carrierBox = new System.Windows.Forms.ComboBox();
            this.cerBox = new System.Windows.Forms.ComboBox();
            this.plateBox = new System.Windows.Forms.ComboBox();
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox2 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox3 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox4 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox6 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox7 = new System.Web.Management.ReadOnlyTextBox();
            this.siteLocationBox = new System.Windows.Forms.ComboBox();
            this.readOnlyTextBox8 = new System.Web.Management.ReadOnlyTextBox();
            this.siteNameBox = new System.Windows.Forms.ComboBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.readOnlyTextBox5 = new System.Web.Management.ReadOnlyTextBox();
            this.loadUnloadBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(296, 39);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // producerBox
            // 
            this.producerBox.FormattingEnabled = true;
            this.producerBox.Location = new System.Drawing.Point(296, 83);
            this.producerBox.Name = "producerBox";
            this.producerBox.Size = new System.Drawing.Size(200, 21);
            this.producerBox.TabIndex = 1;
            this.producerBox.SelectedValueChanged += new System.EventHandler(this.producerBox_SelectedValueChanged);
            // 
            // carrierBox
            // 
            this.carrierBox.FormattingEnabled = true;
            this.carrierBox.Location = new System.Drawing.Point(296, 130);
            this.carrierBox.Name = "carrierBox";
            this.carrierBox.Size = new System.Drawing.Size(200, 21);
            this.carrierBox.TabIndex = 2;
            this.carrierBox.SelectedValueChanged += new System.EventHandler(this.carrierBox_SelectedValueChanged);
            // 
            // cerBox
            // 
            this.cerBox.FormattingEnabled = true;
            this.cerBox.Location = new System.Drawing.Point(375, 262);
            this.cerBox.Name = "cerBox";
            this.cerBox.Size = new System.Drawing.Size(121, 21);
            this.cerBox.TabIndex = 4;
            // 
            // plateBox
            // 
            this.plateBox.FormattingEnabled = true;
            this.plateBox.Location = new System.Drawing.Point(375, 176);
            this.plateBox.Name = "plateBox";
            this.plateBox.Size = new System.Drawing.Size(121, 21);
            this.plateBox.TabIndex = 5;
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Location = new System.Drawing.Point(137, 39);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox1.TabIndex = 6;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Data";
            // 
            // readOnlyTextBox2
            // 
            this.readOnlyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox2.Location = new System.Drawing.Point(137, 86);
            this.readOnlyTextBox2.Multiline = true;
            this.readOnlyTextBox2.Name = "readOnlyTextBox2";
            this.readOnlyTextBox2.ReadOnly = true;
            this.readOnlyTextBox2.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox2.TabIndex = 7;
            this.readOnlyTextBox2.TabStop = false;
            this.readOnlyTextBox2.Text = "Produttore";
            // 
            // readOnlyTextBox3
            // 
            this.readOnlyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox3.Location = new System.Drawing.Point(137, 130);
            this.readOnlyTextBox3.Multiline = true;
            this.readOnlyTextBox3.Name = "readOnlyTextBox3";
            this.readOnlyTextBox3.ReadOnly = true;
            this.readOnlyTextBox3.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox3.TabIndex = 8;
            this.readOnlyTextBox3.TabStop = false;
            this.readOnlyTextBox3.Text = "Trasportatore";
            // 
            // readOnlyTextBox4
            // 
            this.readOnlyTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox4.Location = new System.Drawing.Point(137, 176);
            this.readOnlyTextBox4.Multiline = true;
            this.readOnlyTextBox4.Name = "readOnlyTextBox4";
            this.readOnlyTextBox4.ReadOnly = true;
            this.readOnlyTextBox4.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox4.TabIndex = 9;
            this.readOnlyTextBox4.TabStop = false;
            this.readOnlyTextBox4.Text = "Targa";
            // 
            // readOnlyTextBox6
            // 
            this.readOnlyTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox6.Location = new System.Drawing.Point(137, 265);
            this.readOnlyTextBox6.Multiline = true;
            this.readOnlyTextBox6.Name = "readOnlyTextBox6";
            this.readOnlyTextBox6.ReadOnly = true;
            this.readOnlyTextBox6.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox6.TabIndex = 11;
            this.readOnlyTextBox6.TabStop = false;
            this.readOnlyTextBox6.Text = "CER";
            // 
            // readOnlyTextBox7
            // 
            this.readOnlyTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox7.Location = new System.Drawing.Point(137, 305);
            this.readOnlyTextBox7.Multiline = true;
            this.readOnlyTextBox7.Name = "readOnlyTextBox7";
            this.readOnlyTextBox7.ReadOnly = true;
            this.readOnlyTextBox7.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox7.TabIndex = 13;
            this.readOnlyTextBox7.TabStop = false;
            this.readOnlyTextBox7.Text = "Comune";
            // 
            // siteLocationBox
            // 
            this.siteLocationBox.FormattingEnabled = true;
            this.siteLocationBox.Location = new System.Drawing.Point(296, 305);
            this.siteLocationBox.Name = "siteLocationBox";
            this.siteLocationBox.Size = new System.Drawing.Size(200, 21);
            this.siteLocationBox.TabIndex = 12;
            this.siteLocationBox.SelectedIndexChanged += new System.EventHandler(this.siteLocationBox_SelectedIndexChanged);
            // 
            // readOnlyTextBox8
            // 
            this.readOnlyTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox8.Location = new System.Drawing.Point(137, 347);
            this.readOnlyTextBox8.Multiline = true;
            this.readOnlyTextBox8.Name = "readOnlyTextBox8";
            this.readOnlyTextBox8.ReadOnly = true;
            this.readOnlyTextBox8.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox8.TabIndex = 15;
            this.readOnlyTextBox8.TabStop = false;
            this.readOnlyTextBox8.Text = "Cantiere";
            // 
            // siteNameBox
            // 
            this.siteNameBox.FormattingEnabled = true;
            this.siteNameBox.Location = new System.Drawing.Point(296, 347);
            this.siteNameBox.Name = "siteNameBox";
            this.siteNameBox.Size = new System.Drawing.Size(200, 21);
            this.siteNameBox.TabIndex = 14;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(421, 458);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 16;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(296, 458);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 17;
            this.cancel.Text = "Annulla";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // readOnlyTextBox5
            // 
            this.readOnlyTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox5.Location = new System.Drawing.Point(137, 222);
            this.readOnlyTextBox5.Multiline = true;
            this.readOnlyTextBox5.Name = "readOnlyTextBox5";
            this.readOnlyTextBox5.ReadOnly = true;
            this.readOnlyTextBox5.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox5.TabIndex = 10;
            this.readOnlyTextBox5.TabStop = false;
            this.readOnlyTextBox5.Text = "Carico/Scarico";
            // 
            // loadUnloadBox
            // 
            this.loadUnloadBox.FormattingEnabled = true;
            this.loadUnloadBox.Location = new System.Drawing.Point(430, 219);
            this.loadUnloadBox.Name = "loadUnloadBox";
            this.loadUnloadBox.Size = new System.Drawing.Size(66, 21);
            this.loadUnloadBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DnewRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 529);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.readOnlyTextBox8);
            this.Controls.Add(this.siteNameBox);
            this.Controls.Add(this.readOnlyTextBox7);
            this.Controls.Add(this.siteLocationBox);
            this.Controls.Add(this.readOnlyTextBox6);
            this.Controls.Add(this.readOnlyTextBox5);
            this.Controls.Add(this.readOnlyTextBox4);
            this.Controls.Add(this.readOnlyTextBox3);
            this.Controls.Add(this.readOnlyTextBox2);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Controls.Add(this.plateBox);
            this.Controls.Add(this.cerBox);
            this.Controls.Add(this.loadUnloadBox);
            this.Controls.Add(this.carrierBox);
            this.Controls.Add(this.producerBox);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "DnewRegister";
            this.Text = "Nuovo Registro";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox producerBox;
        private System.Windows.Forms.ComboBox carrierBox;
        private System.Windows.Forms.ComboBox cerBox;
        private System.Windows.Forms.ComboBox plateBox;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox2;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox3;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox4;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox6;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox7;
        private System.Windows.Forms.ComboBox siteLocationBox;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox8;
        private System.Windows.Forms.ComboBox siteNameBox;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox5;
        private System.Windows.Forms.ComboBox loadUnloadBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}