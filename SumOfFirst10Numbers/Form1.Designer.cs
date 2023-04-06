namespace SumOfFirst10Numbers
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
            BtnSumOf10Numbers = new Button();
            SuspendLayout();
            // 
            // BtnSumOf10Numbers
            // 
            BtnSumOf10Numbers.Location = new Point(150, 80);
            BtnSumOf10Numbers.Name = "BtnSumOf10Numbers";
            BtnSumOf10Numbers.Size = new Size(188, 29);
            BtnSumOf10Numbers.TabIndex = 0;
            BtnSumOf10Numbers.Text = "btnSumOf10Numbers";
            BtnSumOf10Numbers.UseVisualStyleBackColor = true;
            BtnSumOf10Numbers.Click += BtnSumOf10Numbers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSumOf10Numbers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSumOf10Numbers;
    }
}