namespace WindowsFormsApp1.AddForms
{
    partial class DopenProject
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
            this.prjList = new System.Windows.Forms.ListView();
            this.newPrjBtn = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox1.Location = new System.Drawing.Point(338, 55);
            this.readOnlyTextBox1.Multiline = true;
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(79, 30);
            this.readOnlyTextBox1.TabIndex = 0;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "Progetti:";
            this.readOnlyTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prjList
            // 
            this.prjList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prjList.HideSelection = false;
            this.prjList.Location = new System.Drawing.Point(12, 91);
            this.prjList.MultiSelect = false;
            this.prjList.Name = "prjList";
            this.prjList.Size = new System.Drawing.Size(730, 217);
            this.prjList.TabIndex = 1;
            this.prjList.UseCompatibleStateImageBehavior = false;
            this.prjList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.prjList_MouseDoubleClick);
            // 
            // newPrjBtn
            // 
            this.newPrjBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPrjBtn.Location = new System.Drawing.Point(321, 12);
            this.newPrjBtn.Name = "newPrjBtn";
            this.newPrjBtn.Size = new System.Drawing.Size(114, 37);
            this.newPrjBtn.TabIndex = 2;
            this.newPrjBtn.Text = "Crea Progetto";
            this.newPrjBtn.UseVisualStyleBackColor = true;
            this.newPrjBtn.Click += new System.EventHandler(this.newPrjBtn_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(411, 314);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 3;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(272, 314);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Annulla";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // DopenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 382);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.newPrjBtn);
            this.Controls.Add(this.prjList);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Name = "DopenProject";
            this.Text = "DopenProject";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Web.Management.ReadOnlyTextBox readOnlyTextBox1;
        private System.Windows.Forms.ListView prjList;
        private System.Windows.Forms.Button newPrjBtn;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}