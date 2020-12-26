namespace Rifiuti.AddForms
{
    partial class DnewAnalysis
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
            this.cerBox = new System.Windows.Forms.ComboBox();
            this.producerBox = new System.Windows.Forms.ComboBox();
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox2 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox3 = new System.Web.Management.ReadOnlyTextBox();
            this.readOnlyTextBox4 = new System.Web.Management.ReadOnlyTextBox();
            this.siteLocationBox = new System.Windows.Forms.ComboBox();
            this.readOnlyTextBox5 = new System.Web.Management.ReadOnlyTextBox();
            this.siteNameBox = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(288, 37);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // cerBox
            // 
            this.cerBox.FormattingEnabled = true;
            this.cerBox.Location = new System.Drawing.Point(288, 77);
            this.cerBox.Name = "cerBox";
            this.cerBox.Size = new System.Drawing.Size(200, 21);
            this.cerBox.TabIndex = 1;
            // 
            // producerBox
            // 
            this.producerBox.FormattingEnabled = true;
            this.producerBox.Location = new System.Drawing.Point(288, 117);
            this.producerBox.Name = "producerBox";
            this.producerBox.Size = new System.Drawing.Size(200, 21);
            this.producerBox.TabIndex = 2;
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Location = new System.Drawing.Point(141, 37);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox1.TabIndex = 3;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Data";
            // 
            // readOnlyTextBox2
            // 
            this.readOnlyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox2.Location = new System.Drawing.Point(141, 77);
            this.readOnlyTextBox2.Multiline = true;
            this.readOnlyTextBox2.Name = "readOnlyTextBox2";
            this.readOnlyTextBox2.ReadOnly = true;
            this.readOnlyTextBox2.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox2.TabIndex = 4;
            this.readOnlyTextBox2.TabStop = false;
            this.readOnlyTextBox2.Text = "CER";
            // 
            // readOnlyTextBox3
            // 
            this.readOnlyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox3.Location = new System.Drawing.Point(141, 120);
            this.readOnlyTextBox3.Multiline = true;
            this.readOnlyTextBox3.Name = "readOnlyTextBox3";
            this.readOnlyTextBox3.ReadOnly = true;
            this.readOnlyTextBox3.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox3.TabIndex = 5;
            this.readOnlyTextBox3.TabStop = false;
            this.readOnlyTextBox3.Text = "Produttore";
            // 
            // readOnlyTextBox4
            // 
            this.readOnlyTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox4.Location = new System.Drawing.Point(141, 163);
            this.readOnlyTextBox4.Multiline = true;
            this.readOnlyTextBox4.Name = "readOnlyTextBox4";
            this.readOnlyTextBox4.ReadOnly = true;
            this.readOnlyTextBox4.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox4.TabIndex = 7;
            this.readOnlyTextBox4.TabStop = false;
            this.readOnlyTextBox4.Text = "Comune";
            // 
            // siteLocationBox
            // 
            this.siteLocationBox.FormattingEnabled = true;
            this.siteLocationBox.Location = new System.Drawing.Point(288, 160);
            this.siteLocationBox.Name = "siteLocationBox";
            this.siteLocationBox.Size = new System.Drawing.Size(200, 21);
            this.siteLocationBox.TabIndex = 6;
            this.siteLocationBox.SelectedValueChanged += new System.EventHandler(this.siteLocationBox_SelectedValueChanged);
            // 
            // readOnlyTextBox5
            // 
            this.readOnlyTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox5.Location = new System.Drawing.Point(141, 204);
            this.readOnlyTextBox5.Multiline = true;
            this.readOnlyTextBox5.Name = "readOnlyTextBox5";
            this.readOnlyTextBox5.ReadOnly = true;
            this.readOnlyTextBox5.Size = new System.Drawing.Size(100, 20);
            this.readOnlyTextBox5.TabIndex = 9;
            this.readOnlyTextBox5.TabStop = false;
            this.readOnlyTextBox5.Text = "Cantiere";
            // 
            // siteNameBox
            // 
            this.siteNameBox.FormattingEnabled = true;
            this.siteNameBox.Location = new System.Drawing.Point(288, 201);
            this.siteNameBox.Name = "siteNameBox";
            this.siteNameBox.Size = new System.Drawing.Size(200, 21);
            this.siteNameBox.TabIndex = 8;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(230, 275);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Annulla";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(351, 275);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 11;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DnewAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 418);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.readOnlyTextBox5);
            this.Controls.Add(this.siteNameBox);
            this.Controls.Add(this.readOnlyTextBox4);
            this.Controls.Add(this.siteLocationBox);
            this.Controls.Add(this.readOnlyTextBox3);
            this.Controls.Add(this.readOnlyTextBox2);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Controls.Add(this.producerBox);
            this.Controls.Add(this.cerBox);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "DnewAnalysis";
            this.Text = "Aggiungi Analisi";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cerBox;
        private System.Windows.Forms.ComboBox producerBox;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox2;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox3;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox4;
        private System.Windows.Forms.ComboBox siteLocationBox;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox5;
        private System.Windows.Forms.ComboBox siteNameBox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}