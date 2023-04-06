namespace PrimeOrNotRecursion
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
            BtnPrimeOrNot = new Button();
            SuspendLayout();
            // 
            // BtnPrimeOrNot
            // 
            BtnPrimeOrNot.Location = new Point(82, 54);
            BtnPrimeOrNot.Name = "BtnPrimeOrNot";
            BtnPrimeOrNot.Size = new Size(279, 29);
            BtnPrimeOrNot.TabIndex = 0;
            BtnPrimeOrNot.Text = "PrimeNumberOrNot";
            BtnPrimeOrNot.UseVisualStyleBackColor = true;
            BtnPrimeOrNot.Click += BtnPrimeOrNot_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnPrimeOrNot);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPrimeOrNot;
    }
}