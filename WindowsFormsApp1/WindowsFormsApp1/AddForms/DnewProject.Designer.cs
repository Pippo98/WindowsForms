namespace Rifiuti.AddForms
{
    partial class DnewProject
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
            this.readOnlyTextBox1 = new System.Web.Management.ReadOnlyTextBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.readOnlyTextBox3 = new System.Web.Management.ReadOnlyTextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox1.Location = new System.Drawing.Point(78, 42);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(412, 47);
            this.readOnlyTextBox1.TabIndex = 1;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Aggiungi nuovo progetto";
            this.readOnlyTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(298, 200);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(195, 200);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Annulla";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // readOnlyTextBox3
            // 
            this.readOnlyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox3.Location = new System.Drawing.Point(229, 95);
            this.readOnlyTextBox3.Multiline = true;
            this.readOnlyTextBox3.Name = "readOnlyTextBox3";
            this.readOnlyTextBox3.ReadOnly = true;
            this.readOnlyTextBox3.Size = new System.Drawing.Size(124, 23);
            this.readOnlyTextBox3.TabIndex = 5;
            this.readOnlyTextBox3.TabStop = false;
            this.readOnlyTextBox3.Text = "Nome Progetto";
            this.readOnlyTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(87, 142);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(412, 22);
            this.nameText.TabIndex = 6;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DnewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 262);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.readOnlyTextBox3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Name = "DnewProject";
            this.Text = "newProject";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Windows.Forms.Button cancel;
        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox3;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button ok;
    }
}