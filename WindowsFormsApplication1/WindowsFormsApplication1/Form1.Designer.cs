namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.PhoneTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.AreaCodeBox = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.Location = new System.Drawing.Point(90, 41);
            this.PhoneTxtBox.Mask = "0(000)-000-0000";
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(121, 20);
            this.PhoneTxtBox.TabIndex = 0;
            this.PhoneTxtBox.TextChanged += new System.EventHandler(this.PhoneTxtBox_TextChanged);
            // 
            // CountryBox
            // 
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Location = new System.Drawing.Point(90, 85);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(121, 21);
            this.CountryBox.TabIndex = 1;
            this.CountryBox.SelectedIndexChanged += new System.EventHandler(this.CountryBox_SelectedIndexChanged);
            // 
            // AreaCodeBox
            // 
            this.AreaCodeBox.FormattingEnabled = true;
            this.AreaCodeBox.Location = new System.Drawing.Point(90, 125);
            this.AreaCodeBox.Name = "AreaCodeBox";
            this.AreaCodeBox.Size = new System.Drawing.Size(121, 21);
            this.AreaCodeBox.TabIndex = 2;
            this.AreaCodeBox.SelectedIndexChanged += new System.EventHandler(this.AreaCodeBox_SelectedIndexChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(115, 166);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Show";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.AreaCodeBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.PhoneTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox PhoneTxtBox;
        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.ComboBox AreaCodeBox;
        private System.Windows.Forms.Button submitBtn;
    }
}

