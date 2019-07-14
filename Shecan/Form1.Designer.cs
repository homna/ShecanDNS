namespace Shecan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_shecan1 = new System.Windows.Forms.TextBox();
            this.txt_shecan2 = new System.Windows.Forms.TextBox();
            this.txt_globDns1 = new System.Windows.Forms.TextBox();
            this.txt_globDns2 = new System.Windows.Forms.TextBox();
            this.radioBtn_Yes = new System.Windows.Forms.RadioButton();
            this.radioBtn_No = new System.Windows.Forms.RadioButton();
            this.txt_titleDNS1 = new System.Windows.Forms.TextBox();
            this.txt_titleDNS2 = new System.Windows.Forms.TextBox();
            this.txt_titleDNS3 = new System.Windows.Forms.TextBox();
            this.txt_titleDNS4 = new System.Windows.Forms.TextBox();
            this.txt_question = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_shecan1
            // 
            this.txt_shecan1.Location = new System.Drawing.Point(97, 65);
            this.txt_shecan1.Name = "txt_shecan1";
            this.txt_shecan1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_shecan1.Size = new System.Drawing.Size(122, 22);
            this.txt_shecan1.TabIndex = 0;
            this.txt_shecan1.Text = "178.22.122.100";
            // 
            // txt_shecan2
            // 
            this.txt_shecan2.Location = new System.Drawing.Point(97, 93);
            this.txt_shecan2.Name = "txt_shecan2";
            this.txt_shecan2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_shecan2.Size = new System.Drawing.Size(122, 22);
            this.txt_shecan2.TabIndex = 1;
            this.txt_shecan2.Text = "185.51.200.2";
            // 
            // txt_globDns1
            // 
            this.txt_globDns1.Location = new System.Drawing.Point(97, 166);
            this.txt_globDns1.Name = "txt_globDns1";
            this.txt_globDns1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_globDns1.Size = new System.Drawing.Size(122, 22);
            this.txt_globDns1.TabIndex = 2;
            this.txt_globDns1.Text = "8.8.8.8";
            // 
            // txt_globDns2
            // 
            this.txt_globDns2.Location = new System.Drawing.Point(97, 196);
            this.txt_globDns2.Name = "txt_globDns2";
            this.txt_globDns2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_globDns2.Size = new System.Drawing.Size(122, 22);
            this.txt_globDns2.TabIndex = 3;
            this.txt_globDns2.Text = "8.8.4.4";
            // 
            // radioBtn_Yes
            // 
            this.radioBtn_Yes.AutoSize = true;
            this.radioBtn_Yes.Font = new System.Drawing.Font("Zar", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioBtn_Yes.Location = new System.Drawing.Point(12, 72);
            this.radioBtn_Yes.Name = "radioBtn_Yes";
            this.radioBtn_Yes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtn_Yes.Size = new System.Drawing.Size(52, 34);
            this.radioBtn_Yes.TabIndex = 4;
            this.radioBtn_Yes.TabStop = true;
            this.radioBtn_Yes.Text = "بله";
            this.radioBtn_Yes.UseVisualStyleBackColor = true;
            this.radioBtn_Yes.CheckedChanged += new System.EventHandler(this.radioBtn_Yes_CheckedChanged);
            // 
            // radioBtn_No
            // 
            this.radioBtn_No.AutoSize = true;
            this.radioBtn_No.Font = new System.Drawing.Font("Zar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioBtn_No.Location = new System.Drawing.Point(12, 173);
            this.radioBtn_No.Name = "radioBtn_No";
            this.radioBtn_No.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtn_No.Size = new System.Drawing.Size(63, 36);
            this.radioBtn_No.TabIndex = 5;
            this.radioBtn_No.TabStop = true;
            this.radioBtn_No.Text = "خیر";
            this.radioBtn_No.UseVisualStyleBackColor = true;
            this.radioBtn_No.CheckedChanged += new System.EventHandler(this.radioBtn_No_CheckedChanged);
            // 
            // txt_titleDNS1
            // 
            this.txt_titleDNS1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_titleDNS1.Enabled = false;
            this.txt_titleDNS1.Location = new System.Drawing.Point(258, 68);
            this.txt_titleDNS1.Name = "txt_titleDNS1";
            this.txt_titleDNS1.ReadOnly = true;
            this.txt_titleDNS1.Size = new System.Drawing.Size(50, 15);
            this.txt_titleDNS1.TabIndex = 6;
            this.txt_titleDNS1.Text = "DNS 1";
            // 
            // txt_titleDNS2
            // 
            this.txt_titleDNS2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_titleDNS2.Enabled = false;
            this.txt_titleDNS2.Location = new System.Drawing.Point(258, 96);
            this.txt_titleDNS2.Name = "txt_titleDNS2";
            this.txt_titleDNS2.ReadOnly = true;
            this.txt_titleDNS2.Size = new System.Drawing.Size(50, 15);
            this.txt_titleDNS2.TabIndex = 7;
            this.txt_titleDNS2.Text = "DNS 2";
            // 
            // txt_titleDNS3
            // 
            this.txt_titleDNS3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_titleDNS3.Enabled = false;
            this.txt_titleDNS3.Location = new System.Drawing.Point(258, 169);
            this.txt_titleDNS3.Name = "txt_titleDNS3";
            this.txt_titleDNS3.ReadOnly = true;
            this.txt_titleDNS3.Size = new System.Drawing.Size(50, 15);
            this.txt_titleDNS3.TabIndex = 8;
            this.txt_titleDNS3.Text = "DNS 1";
            // 
            // txt_titleDNS4
            // 
            this.txt_titleDNS4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_titleDNS4.Enabled = false;
            this.txt_titleDNS4.Location = new System.Drawing.Point(258, 199);
            this.txt_titleDNS4.Name = "txt_titleDNS4";
            this.txt_titleDNS4.ReadOnly = true;
            this.txt_titleDNS4.Size = new System.Drawing.Size(50, 15);
            this.txt_titleDNS4.TabIndex = 9;
            this.txt_titleDNS4.Text = "DNS 2";
            // 
            // txt_question
            // 
            this.txt_question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_question.Enabled = false;
            this.txt_question.Font = new System.Drawing.Font("Zar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_question.Location = new System.Drawing.Point(12, 12);
            this.txt_question.Name = "txt_question";
            this.txt_question.ReadOnly = true;
            this.txt_question.Size = new System.Drawing.Size(256, 32);
            this.txt_question.TabIndex = 10;
            this.txt_question.Text = "آیا مایل به استفاده از شکن هستید؟";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 258);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.txt_titleDNS4);
            this.Controls.Add(this.txt_titleDNS3);
            this.Controls.Add(this.txt_titleDNS2);
            this.Controls.Add(this.txt_titleDNS1);
            this.Controls.Add(this.radioBtn_No);
            this.Controls.Add(this.radioBtn_Yes);
            this.Controls.Add(this.txt_globDns2);
            this.Controls.Add(this.txt_globDns1);
            this.Controls.Add(this.txt_shecan2);
            this.Controls.Add(this.txt_shecan1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تنظیم DNS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_shecan1;
        private System.Windows.Forms.TextBox txt_shecan2;
        private System.Windows.Forms.TextBox txt_globDns1;
        private System.Windows.Forms.TextBox txt_globDns2;
        private System.Windows.Forms.RadioButton radioBtn_Yes;
        private System.Windows.Forms.RadioButton radioBtn_No;
        private System.Windows.Forms.TextBox txt_titleDNS1;
        private System.Windows.Forms.TextBox txt_titleDNS2;
        private System.Windows.Forms.TextBox txt_titleDNS3;
        private System.Windows.Forms.TextBox txt_titleDNS4;
        private System.Windows.Forms.TextBox txt_question;
    }
}

