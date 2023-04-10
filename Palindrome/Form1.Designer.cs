namespace Palindrome
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnPalindrome = new Button();
            SuspendLayout();
            // 
            // BtnPalindrome
            // 
            BtnPalindrome.Location = new Point(89, 53);
            BtnPalindrome.Name = "BtnPalindrome";
            BtnPalindrome.Size = new Size(94, 29);
            BtnPalindrome.TabIndex = 0;
            BtnPalindrome.Text = "Palindrome";
            BtnPalindrome.UseVisualStyleBackColor = true;
            BtnPalindrome.Click += BtnPalindrome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnPalindrome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPalindrome;
    }
}